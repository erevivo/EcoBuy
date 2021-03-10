﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EcoBuy.ViewModels;
namespace EcoBuy.Commands
{
    public class AddImageCommand : ICommand
    {
        #region Fileds
        public event EventHandler CanExecuteChanged;
        public AddItemUCVM CurrVM { get; set; }
        #endregion
        public AddImageCommand(AddItemUCVM VM)
        {
            CurrVM = VM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string ImageUrl;
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            var result = fileDialog.ShowDialog();
            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    var file = fileDialog.FileName;
                    ImageUrl = file;
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    ImageUrl = null;
                    break;
            }
            CurrVM.ImageUrl = ImageUrl;
        }
    }
}
