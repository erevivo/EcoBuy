using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.Models
{
    public class CategoriesExpenses : INotifyPropertyChanged
    {
        // Event Handler
        public event PropertyChangedEventHandler PropertyChanged;

        #region Private Fields
        private List<double> _electricity;
        private List<double> _fashion;
        private List<double> _health;
        private List<double> _food;
        #endregion

        #region Properties
        public List<double> Electricity
        {
            get => _electricity;
            set
            {
                _electricity = value;
                OnPropertyChanged("Electricity");
            }
        }
        public List<double> Fashion
        {
            get => _fashion;
            set
            {
                _fashion = value;
                OnPropertyChanged("Fashion");
            }
        }
        public List<double> Food
        {
            get => _food;
            set
            {
                _food = value;
                OnPropertyChanged("Food");
            }
        }
        public List<double> Health
        {
            get => _health;
            set
            {
                _health = value;
                OnPropertyChanged("Health");
            }
        }
        #endregion

        #region Constructors
        public CategoriesExpenses()
        {
        }

        public CategoriesExpenses(CategoriesExpenses other)
        {
            Electricity = other.Electricity;
            Fashion = other.Fashion;
            Food = other.Food;
            Health = other.Health;
        }
        #endregion

        // Event
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
