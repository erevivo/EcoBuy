using EcoBuy.Models;
using LiveCharts;

namespace EcoBuy.UserControls
{
    public class ExpensesGraphDataModel
    {
        public ExpensesGraphDataModel(CategoriesExpenses dataModel)
        {
            this.ElectricityDataSeries = new ChartValues<double>(dataModel.Electricity);
            this.FashionDataSeries = new ChartValues<double>(dataModel.Fashion);
            this.FoodDataSeries = new ChartValues<double>(dataModel.Food);
            this.HealthDataSeries = new ChartValues<double>(dataModel.Health);
        }

        public ChartValues<double> ElectricityDataSeries { get; set; }
        public ChartValues<double> FashionDataSeries { get; set; }
        public ChartValues<double> FoodDataSeries { get; set; }
        public ChartValues<double> HealthDataSeries { get; set; }
    }
}

