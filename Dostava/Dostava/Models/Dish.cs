namespace Dostava.Models
{
    public class Dish
    {
        public Guid Id { get; set; } 
        public int Price { get; set; }
        public string DishName { get; set; }
        public string DishPicture { get; set; }
    }
}
