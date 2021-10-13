using EcoBuy.UserControls;
using EcoBuy.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace EcoBuy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
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
        private void ConfirmProductClick(object sender, RoutedEventArgs e)
        {
            MainUIGrid.Children.Clear();
            MainUIGrid.Height = 864;
            MainUIGrid.Width = 1920;
            var uc = new PurchaseConfirmUC();
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
