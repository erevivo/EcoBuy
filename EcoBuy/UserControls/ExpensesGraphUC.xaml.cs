using EcoBuy.Models;
using EcoBuy.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace EcoBuy.UserControls
{
    /// <summary>
    /// Interaction logic for ExpensesGraphUC.xaml
    /// </summary>
    public partial class ExpensesGraphUC : UserControl
    {
        #region DependencyProperties
        public static readonly DependencyProperty ElectricityProperty = DependencyProperty.Register(
                                                            "Electricity",
                                                            typeof(CategoriesExpenses),
                                                            typeof(ExpensesGraphUC),
                                                            new PropertyMetadata(default(CategoriesExpenses)));
        #endregion
        #region Properties
        public CategoriesExpenses CategoriesExpenses
        {
            get => (CategoriesExpenses)GetValue(ElectricityProperty);
            set => SetValue(ElectricityProperty, value);
        }
        #endregion
        public ExpensesGraphUC()
        {
            InitializeComponent();
            this.DataContext = new ExpensesGraphUCVM();
        }
    }
}