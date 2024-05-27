﻿
namespace Domain
{
    public class Product
    {
     public int Id { get; set; } 
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime created_at { get; set; }         
    }
}
