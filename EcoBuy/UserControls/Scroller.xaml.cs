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
using System.Windows.Threading;

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

