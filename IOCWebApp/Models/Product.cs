namespace IOCWebApp.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Title { get; set; }
    public string Picture { get; set; }
    public string Description { get; set; }

    public int UnitPrice { get; set; }
    public bool Available { get; set; }
    public int CategotyId { get; set; }
    public int UnitInStock { get; set; }
}