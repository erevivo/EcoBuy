using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EcoBuy.ViewModels
{
    public class SearchEngineUCVM : ViewModelBase
    {
        public string SearchText { get; set; }

        public ICommand SearchCommand { get; set; }

        public SearchEngineUCVM()
        {
            SearchCommand = new RelayCommand(() => Search());
        }

        private void Search()
        {
            
        }
    }
}
