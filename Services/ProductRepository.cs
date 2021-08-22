using System.Collections.Generic;
using DiSample.Models;

namespace DiSample.Services
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return new List<Product>(){
                new Product{Id=1,Name="Apple Iphone 12pro max",Price=999.9m},
                new Product{Id=1,Name="Apple Iphone 12",Price=900.99m},
                new Product{Id=1,Name="Xiaumi Mi 11",Price=300.00m},
                new Product{Id=1,Name="Macbook M1",Price=1999.9m}

        };
        }
    }
}