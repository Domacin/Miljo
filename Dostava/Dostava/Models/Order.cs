namespace Dostava.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public int OrderPrice { get; set; }
        public string ?Comment { get; set; }
        public string AddressToDeliverTo { get; set; }
        public string UserWhoOrdered { get; set; }


    }
}
