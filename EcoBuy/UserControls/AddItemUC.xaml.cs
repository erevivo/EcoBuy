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
using EcoBuy.BE;
using EcoBuy.ViewModels;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for AddItemUC.xaml
    /// </summary>
    public partial class AddItemUC : UserControl
    {
        string temp1="";
        string temp2 = "";
        public AddItemUC()
        {
            InitializeComponent();
            this.DataContext = new AddItemUCVM(this);
            
        }
        private void IcecreamDropZone_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ((AddItemUC)this.DataContext).temp1 = files[0];
        }

        private void StoreDropZone_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ((AddItemUC)this.DataContext).temp2 = files[0];
        }
        private void UserControlBG_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
