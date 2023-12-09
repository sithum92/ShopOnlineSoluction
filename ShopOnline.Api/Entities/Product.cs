﻿namespace ShopOnline.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public String Name  { get; set; }
        public String  Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
    }
}
