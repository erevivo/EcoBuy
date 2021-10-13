using System;
using System.Windows.Controls;

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
