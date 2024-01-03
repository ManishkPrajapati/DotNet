using DAL;
using BOL;
namespace BLL;

public class ProductManager
{
  public List<Products> GetAllProducts()
  {
    List<Products> elist = DBManager.GetAllProd();
    return elist;
  }

  public bool AddProduct(int id, string name, int price)
  {
    return DBManager.SaveProduct(id, name, price);
  }
  public Products GetProducts(int id)
  {
    return DBManager.FindProduct(id);
  }

  public bool EditProduct(int id, string name, int price)
  {
    return DBManager.UpdateProduct(id, name, price);
  }

}
