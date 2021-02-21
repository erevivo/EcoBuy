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

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for HeaderUC.xaml
    /// </summary>
    public partial class HeaderUC : UserControl
    {
        public HeaderUC()
        {
            InitializeComponent();
            Wishes();
        }
        public void Wishes()
        {
            DateTime d;
            d = DateTime.Now;
            if (d.Hour >= 7 && d.Hour < 12)
                wish.Content = "בוקר טוב :)";
            else if (d.Hour >= 12 && d.Hour < 15)
                wish.Content = "צהריים טובים :)";
            else if (d.Hour >= 15 && d.Hour < 18)
                wish.Content = "אחר הצהריים טובים :)";
            else if (d.Hour >= 18 && d.Hour < 21)
                wish.Content = "ערב טוב :)";
            else if (d.Hour >= 21 && d.Hour <= 23)
                wish.Content = "לילה טוב :)";
            else if (d.Hour >= 0 && d.Hour <= 6)
                wish.Content = "לילה טוב :)";

        }
    }
}
