﻿using EcoBuy.ViewModels.UserControls;
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
    /// Interaction logic for AllPurchases.xaml
    /// </summary>
    public partial class AllPurchases : UserControl
    {
        public AllPurchases()
        {
            InitializeComponent();
            this.DataContext = new AllPurchaseUCVM();
        }
    }
}
