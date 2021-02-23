using EcoBuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.ViewModels
{
    public class PieChartUCVM : ViewModelBase
    {
        public CategoiesCount CategoriesCount { get; set; }

        public PieChartUCVM()
        {
            Test();
        }

        private void Test()
        {
            CategoriesCount = new CategoiesCount() { Electricity = 10, Fashion = 5, Food = 5, Health = 20 };
        }
    }
}
