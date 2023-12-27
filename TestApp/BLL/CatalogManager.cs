namespace BLL;
using BOL;
// using DAL;
using DAL.Connected;


public class CatalogManager{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts = DBManager.GetAllProducts();
        return allProducts;
    }
}