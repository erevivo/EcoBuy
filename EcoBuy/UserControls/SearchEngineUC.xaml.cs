using EcoBuy.ViewModels;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for SearchEngineUI.xaml
    /// </summary>
    public partial class SearchEngineUI : UserControl
    {
        public SearchEngineUI()
        {
            InitializeComponent();
            this.DataContext = new SearchEngineUCVM();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
