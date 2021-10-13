using EcoBuy.ViewModels.UserControls;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for AllPurchases.xaml
    /// </summary>
    public partial class AllPurchases : UserControl
    {
        public AllPurchases()
        {
            InitializeComponent();
            this.DataContext = new AllPurchaseUCVM();
        }
    }
}
