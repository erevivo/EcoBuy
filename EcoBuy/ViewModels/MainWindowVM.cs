namespace EcoBuy.ViewModels
{
    public class MainWindowVM : ViewModelBase
    {
        public ViewModelBase PieChartVM { get; set; }
        public ViewModelBase ExpensesGraphVM { get; set; }
        public ViewModelBase LastPurchaseVM { get; set; }
        public ViewModelBase SearchEngineVM { get; set; }

        public MainWindowVM()
        {
            PieChartVM = new PieChartUCVM();
            SearchEngineVM = new SearchEngineUCVM();
            LastPurchaseVM = new LastPurchaseUCVM();
            ExpensesGraphVM = new ExpensesGraphUCVM();
        }
    }
}
