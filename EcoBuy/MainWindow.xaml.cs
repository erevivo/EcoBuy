using BE;
using EcoBuy.ExtensionMethods;
using EcoBuy.UserControls;
using PL.ConnectToGoogleDrive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EcoBuy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UIElementCollection _children;

        //private GoogleDriveApi downloadQr;
        public MainWindow()
        {
            InitializeComponent();
            //downloadQr = new GoogleDriveApi();
            //downloadQr.Connect();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddProductClick(object sender, RoutedEventArgs e)
        {
            MainUIGrid.Children.Clear();
            MainUIGrid.Height = 864;
            MainUIGrid.Width = 1920;
            var uc = new AddItemUC();
            uc.Height = 864;
            uc.Width = 1920;
            Grid.SetRowSpan(uc, 2);
            Grid.SetColumnSpan(uc, 3);
            MainUIGrid.Children.Add(uc);
        }
        private void MainClick(object sender, RoutedEventArgs e)
        {
            MainUIGrid.Children.Clear();
            MainUIGrid.Children.Add(PieChartUC);
            MainUIGrid.Children.Add(SearchEngineUC);
            MainUIGrid.Children.Add(LastPurchaseUC);
            MainUIGrid.Children.Add(ShopRecoUI);
            MainUIGrid.Children.Add(ExpensesGraphUC);


        }
    }
}
