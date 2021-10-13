namespace EcoBuy.Models
{
    public class Store
    {
        private Store store;

        public int Id { get; set; }

        public int StoreId { get; set; }

        public string Name { get; set; }

        public Store(int id, int storeId, string name)
        {
            Id = id;
            StoreId = storeId;
            Name = name;
        }

        public Store()
        {
        }

        public Store(Store store)
        {
            this.store = store;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
