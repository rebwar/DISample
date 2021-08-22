using System.Collections.Generic;
using DiSample.Models;

namespace DiSample.Services
{
    public interface IProductRepository
    {
         List<Product>GetProducts();
    }
}