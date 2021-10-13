using EcoBuy.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for AddItemUC.xaml
    /// </summary>
    public partial class AddItemUC : UserControl
    {
        public AddItemUC()
        {
            InitializeComponent();
            this.DataContext = new AddItemUCVM(this);

        }
        private void UserControlBG_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
