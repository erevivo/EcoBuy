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
    /// <summary>
    /// Interaction logic for Footer.xaml
    /// </summary>
    public partial class Footer : UserControl
    {
        public Footer()
        {
            InitializeComponent();
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = TimeSpan.FromSeconds(4);
            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if ((feedList.SelectedIndex + 1) < feedList.Items.Count)
                feedList.SelectedIndex = feedList.SelectedIndex + 1;
            else
                feedList.SelectedIndex = 0;
            feedList.ScrollIntoView(feedList.SelectedItem);
        }

        public class Temp
        {
            public string Message { get; set; }
        }
    }
}
