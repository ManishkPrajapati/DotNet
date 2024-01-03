using BOL;
using MySql.Data.MySqlClient;
namespace DAL;



public class DBManager
{

  public static string conString = @"server=localhost;port=3306;user=root;password=Sword@353730;database=user1";

  public static List<Products> GetAllProd()
  {
    List<Products> plist = new List<Products>();
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    try
    {
      string query = "select * from products";
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(query, conn);
      MySqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        int id = int.Parse(reader["id"].ToString());
        string name = reader["name"].ToString();
        int price = int.Parse(reader["price"].ToString());
        Products prod = new Products(id, name, price);
        plist.Add(prod);
      }
      reader.Close();

    }
    catch (Exception ee)
    {
      Console.WriteLine(ee.Message);
    }
    finally
    {
      conn.Close();
    }
    return plist;
  }


  public static bool SaveProduct(int Id, string Name, int Price)
  {
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    string query = "insert into products values(@Id,@Name,@Price)";
    try
    {
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@Id", Id);
      cmd.Parameters.AddWithValue("@Name", Name);
      cmd.Parameters.AddWithValue("@Price", Price);
      conn.Open();
      int n = cmd.ExecuteNonQuery();
      if (n > 0)
      {
        return true;
      }
      return false;
    }
    catch (Exception e)
    {
      throw e;
    }
    finally
    {
      conn.Close();
    }
    return false;
  }


  public static Products FindProduct(int id)
  {
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    try
    {
      string query = "select * from products where id = @id";
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@id", id);
      MySqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        int Id = int.Parse(reader["id"].ToString());
        string name = reader["name"].ToString();
        int price = int.Parse(reader["price"].ToString());
        Products prod = new Products(Id, name, price);
        return prod;
      }
      reader.Close();

    }
    catch (Exception ee)
    {
      Console.WriteLine(ee.Message);
    }
    finally
    {
      conn.Close();
    }
    return null;
  }

  public static bool UpdateProduct(int Id, string Name, int Price)
  {
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    string query = "update products set name = @Name, price=@Price where id = @Id";
    try
    {
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@Id", Id);
      cmd.Parameters.AddWithValue("@Name", Name);
      cmd.Parameters.AddWithValue("@Price", Price);
      conn.Open();
      int n = cmd.ExecuteNonQuery();
      if (n > 0)
      {
        return true;
      }
      return false;
    }
    catch (Exception e)
    {
      throw e;
    }
    finally
    {
      conn.Close();
    }
    return false;
  }


}