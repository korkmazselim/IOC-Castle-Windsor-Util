using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Sale
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public Guest Guest { get; set; }
        public decimal SaleTotalAmount { get; set; }
        public SaleType SaleType { get; set; }
    }
    public class Guest
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public string GuestAddress { get; set; }
    }
    public class Product
    { 
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductUnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public enum SaleType 
    {
        Web = 1,
        Cash = 2
    }
}
