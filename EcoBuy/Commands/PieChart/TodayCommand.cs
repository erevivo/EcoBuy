using EcoBuy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EcoBuy.Commands.PieChart
{

    public class TodayCommand : ICommand
    {
        #region Fileds
        public event EventHandler CanExecuteChanged;
        public PieChartUCVM CurrVM { get; set; }
        #endregion
        public TodayCommand(PieChartUCVM VM)
        {
            CurrVM = VM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
          
        }
    }
}
