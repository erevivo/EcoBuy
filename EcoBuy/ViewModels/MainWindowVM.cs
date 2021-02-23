using EcoBuy.Models;

namespace EcoBuy.ViewModels
{
    public class MainWindowVM : ViewModelBase
    {
        public PieChartUCVM PieChartVM { get; set; }

        public MainWindowVM()
        {
            PieChartVM = new PieChartUCVM();
        }
    }
}
