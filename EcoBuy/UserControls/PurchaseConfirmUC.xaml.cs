using EcoBuy.ViewModels;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for PurchaseConfirmUC.xaml
    /// </summary>
    public partial class PurchaseConfirmUC : UserControl
    {
        public PurchaseConfirmUC()
        {
            InitializeComponent();
            this.DataContext = new PurchaseConfirmUCVM();
        }
    }
}
