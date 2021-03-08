
namespace EcoBuy.Models
{
    public class CategoriesCount
    {
        public int Electricity { get; set; }
        public int Fashion { get; set; }
        public int Food { get; set; }
        public int Health { get; set; }

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
    }
}
