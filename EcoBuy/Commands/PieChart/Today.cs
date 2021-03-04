using EcoBuy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EcoBuy.Commands.PieChart
{

    public class Today : ICommand
    {
        #region Fileds
        public event EventHandler CanExecuteChanged;
        public PieChartUCVM CurrVM { get; set; }
        #endregion
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
