using DAL;
using BOL;
namespace BLL;

public class ProductManager
{
  public List<Products> GetAllProducts()
  {
    List<Products> elist = EDManager.GetAllProd();
    return elist;
  }

  public bool AddProduct(int id, string name, int price)
  {
    return EDManager.SaveProduct(id, name, price);
  }
  public Products GetProducts(int id)
  {
    return EDManager.FindProduct(id);
  }

  public bool EditProduct(int id, string name, int price)
  {
    return EDManager.UpdateProduct(id, name, price);
  }

  public bool DeleteProducts(int id)
  {
    return EDManager.RemoveProduct(id);
  }

}
