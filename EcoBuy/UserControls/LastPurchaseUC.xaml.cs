using EcoBuy.ViewModels;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for LastPurchaseUI.xaml
    /// </summary>
    public partial class LastPurchaseUC : UserControl
    {
        public LastPurchaseUC()
        {
            InitializeComponent();
            this.DataContext = new LastPurchaseUCVM();
        }
    }
}
