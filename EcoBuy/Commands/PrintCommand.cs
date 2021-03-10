using EcoBuy.PrintDataGrid;
using EcoBuy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace EcoBuy.Commands
{
    public class PrintCommand : ICommand
    {
        #region Properties
        public event EventHandler CanExecuteChanged;
        public PrintDG Printer { get; set; }
        public LastPurchaseUCVM CurrVM;
        #endregion
        public PrintCommand(LastPurchaseUCVM VM)
        {
            CurrVM = VM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Printer = new PrintDG();
            Printer.printDG(CurrVM.DataGridPurchasedList, "הקניה האחרונה שלך");
        }
    }
}
