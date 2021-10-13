using EcoBuy.ViewModels;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for ShopRecoUI.xaml
    /// </summary>
    public partial class ShopRecoUC : UserControl
    {
        public ShopRecoUC()
        {
            InitializeComponent();
            this.DataContext = new ShopRecoUCVM();
        }
    }
}
