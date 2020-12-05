using System;

namespace DataGenerator.Data.Models
{
    public class ProductModel
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductAdjective { get; set; }
        public string ProductDescription { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Category { get; set; }

    }
}
