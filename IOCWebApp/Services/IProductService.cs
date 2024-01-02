using IOCWebApp.Models;
using System.Collections.Generic;

namespace IOCWebApp.Services;

public interface IProductService
{
    List<Product> GetProducts();
    Product GetProductById(int id);
    bool Insert(Product product);
    bool Update(Product product);
    bool Delete(int id);

}