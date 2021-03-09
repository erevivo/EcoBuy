
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EcoBuy.Models
{
    public class CategoriesCount : INotifyPropertyChanged
    {
        // Event Handler
        public event PropertyChangedEventHandler PropertyChanged;

        #region Private Fields
        private int _electricity;
        private int _fashion;
        private int _food;
        private int _health;
        #endregion

        #region Properties
        public int Electricity
        {
            get => _electricity;
            set
            {
                _electricity = value;
                OnPropertyChanged("Electricity");
            }
        }
        public int Fashion
        {
            get => _fashion;
            set
            {
                _fashion = value;
                OnPropertyChanged("Fashion");
            }
        }
        public int Food
        {
            get => _food;
            set
            {
                _food = value;
                OnPropertyChanged("Food");
            }
        }
        public int Health
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
        public CategoriesCount()
        {
        }

        public CategoriesCount(CategoriesCount other)
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
