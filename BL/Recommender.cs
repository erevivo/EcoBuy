using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BL
{
    public class Recommender
    {
        private static string FileName = "PurchasedProducts.txt";
        private static string BaseDataSetRelativePath = @"C:\Users\Evyatar\Documents\GitHub\EcoBuy\BL\Data";
        private static string TrainingDataRelativePath = $"{BaseDataSetRelativePath}\\" + FileName;
        private static string TrainingDataLocation = GetAbsolutePath(TrainingDataRelativePath);

        private static string BaseModelRelativePath = @"..\..\..\Model";
        private static string ModelRelativePath = $"{BaseModelRelativePath}/model.zip";
        private static string ModelPath = GetAbsolutePath(ModelRelativePath);

        //return top n products comptiable with productid

        public static IEnumerable<(int, float)> GetTopNPredictions(uint productId, int n)
        {
            //STEP 1: Create MLContext to be shared across the model creation workflow objects 
            MLContext mlContext = new MLContext();

            //STEP 2: Read the trained data using TextLoader by defining the schema for reading the product co-purchase dataset
            var traindata = mlContext.Data.LoadFromTextFile(path: TrainingDataLocation,
                                                      columns: new[]
                                                                {
                                                                    new TextLoader.Column("Label", DataKind.Single, 0),
                                                                    new TextLoader.Column(name:nameof(ProductEntry.ProductID), dataKind:DataKind.UInt32, source: new [] { new TextLoader.Range(0) }, keyCount: new KeyCount(262111)),
                                                                    new TextLoader.Column(name:nameof(ProductEntry.CoPurchaseProductID), dataKind:DataKind.UInt32, source: new [] { new TextLoader.Range(1) }, keyCount: new KeyCount(262111))
                                                                },
                                                      hasHeader: true,
                                                      separatorChar: '\t');

            //STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
            //        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer. 
            MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
            options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
            options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
            options.LabelColumnName = "Label";
            options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
            options.Alpha = 0.01;
            options.Lambda = 0.025;
            // For better results use the following parameters
            //options.K = 100;
            //options.C = 0.00001;

            //Step 4: Call the MatrixFactorization trainer by passing options.
            var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

            //STEP 5: Train the model fitting to the DataSet
            ITransformer model = est.Fit(traindata);

            //STEP 6: Create prediction engine and predict the top "n" combined products for product "productId"
            //        The higher the score the higher the probability for this particular productID being co-purchased 
            var predictionengine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
            var topN = (from m in Enumerable.Range(1, 262111)
                        let p = predictionengine.Predict(
                           new ProductEntry()
                           {
                               ProductID = productId,
                               CoPurchaseProductID = (uint)m
                           })
                        orderby p.Score descending
                        select (ProductID: m, Score: p.Score)).Take(n);

            return topN;
        }

        static double GetPredictionScore(uint productId, uint coPurchaseProductID)
        {
            //STEP 1: Create MLContext to be shared across the model creation workflow objects 
            MLContext mlContext = new MLContext();

            //STEP 2: Read the trained data using TextLoader by defining the schema for reading the product co-purchase dataset
            var traindata = mlContext.Data.LoadFromTextFile(path: TrainingDataLocation,
                                                      columns: new[]
                                                                {
                                                                    new TextLoader.Column("Label", DataKind.Single, 0),
                                                                    new TextLoader.Column(name:nameof(ProductEntry.ProductID), dataKind:DataKind.UInt32, source: new [] { new TextLoader.Range(0) }, keyCount: new KeyCount(262111)),
                                                                    new TextLoader.Column(name:nameof(ProductEntry.CoPurchaseProductID), dataKind:DataKind.UInt32, source: new [] { new TextLoader.Range(1) }, keyCount: new KeyCount(262111))
                                                                },
                                                      hasHeader: true,
                                                      separatorChar: '\t');

            //STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
            //        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer. 
            MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
            options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
            options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
            options.LabelColumnName = "Label";
            options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
            options.Alpha = 0.01;
            options.Lambda = 0.025;
            // For better results use the following parameters
            //options.K = 100;
            //options.C = 0.00001;

            //Step 4: Call the MatrixFactorization trainer by passing options.
            var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

            //STEP 5: Train the model fitting to the DataSet
            ITransformer model = est.Fit(traindata);

            //STEP 6: Create prediction engine and predict the score for Product "productId" being co-purchased with Product "coPurchaseProductID".
            //        The higher the score the higher the probability for this particular productID being co-purchased 
            var predictionengine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
            var prediction = predictionengine.Predict(
                new ProductEntry()
                {
                    ProductID = productId,
                    CoPurchaseProductID = coPurchaseProductID
                });

            return Math.Round(prediction.Score, 2);
        }

        public static string GetAbsolutePath(string relativeDatasetPath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Recommender).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativeDatasetPath);

            return fullPath;
        }

        public class Copurchase_prediction
        {
            public float Score { get; set; }
        }

        public class ProductEntry
        {
            [KeyType(count: 262111)]
            public uint ProductID { get; set; }

            [KeyType(count: 262111)]
            public uint CoPurchaseProductID { get; set; }
        }

        public class Prediction
        {
            public uint CoPurchaseProductID { get; set; }
            public float Score { get; set; }
        }
    }
}
