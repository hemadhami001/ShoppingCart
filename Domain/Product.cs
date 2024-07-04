
namespace Domain
{
    public class Product
    {
     public int Id { get; set; } 
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        private int categoryId;

        public int GetCategoryId()
        {
            return categoryId;
        }

        public void SetCategoryId(int value)
        {
            categoryId = value;
        }

        public DateTime CreatedDate { get; set; }  
        public ICollection<CartItem> CartItems { get; set;}
        public ICollection<OderItem> OrderItems { get; set;}
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
