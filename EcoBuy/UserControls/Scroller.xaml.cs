using System.Windows;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    public partial class Scroller : UserControl
    {
        public Scroller()
        {
            InitializeComponent();
        }
        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            myScroll.LineUp();
            myScroll.LineUp();
        }
    }
}

