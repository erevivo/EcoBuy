namespace EcoBuy.Models
{
    public class StoresProductcs
    {
        private int Id { get; set; }

        private int Sid { get; set; }

        private int Pid { get; set; }

        private float Price { get; set; }

        public StoresProductcs(int id, int sid, int pid, float price)
        {
            Id = id;
            Sid = sid;
            Pid = pid;
            Price = price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
