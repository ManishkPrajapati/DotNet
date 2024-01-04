using BOL;
using MySql.Data.MySqlClient;
namespace DAL;

public class EDManager
{

  public static string conString = @"server=localhost;port=3306;user=root;password=Sword@353730;database=user1";

  public static bool Check(string email, string password)
  {
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    try
    {
      string query = "select * from employee where email = @email and password = @pass";
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@email", email);
      cmd.Parameters.AddWithValue("@pass", password);
      MySqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        string? fn = reader["email"].ToString();
        string? ps = reader["password"].ToString();
        if (fn.Equals(email) && ps.Equals(password))
        {
          return true;
        }
      }
    }
    catch (Exception ee)
    {
      Console.WriteLine(ee.Message);
    }
    finally
    {
      conn.Close();
    }
    return false;
  }


  public static Employee GetEmp(string firstname, string password)
  {
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    try
    {
      string query = "select * from employee where firstname = @fname and password = @pass";
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@fname", firstname);
      cmd.Parameters.AddWithValue("@pass", password);
      MySqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        int id = int.Parse(reader["id"].ToString());
        string? fn = reader["firstname"].ToString();
        string? em = reader["email"].ToString();
        string? ps = reader["password"].ToString();
        Employee e = new Employee(id, fn, em, ps);
        return e;
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

  public static bool UpdateEmp(int id, string firstname, string email, string password)
  {
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    try
    {
      string query = "update employee set firstname=@fname, email=@email, password=@pass where id=@id";
      conn.Open();
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@id", id);
      cmd.Parameters.AddWithValue("@fname", firstname);
      cmd.Parameters.AddWithValue("@email", email);
      cmd.Parameters.AddWithValue("@pass", password);
      int n = cmd.ExecuteNonQuery();
      if (n > 0)
      {
        return true;
      }
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


  public static List<Products> GetAllProd()
  {
    List<Products> plist = new List<Products>();
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    try
    {
      string query = "select * from products order by id";
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


  public static bool RemoveProduct(int Id)
  {
    MySqlConnection conn = new MySqlConnection();
    conn.ConnectionString = conString;
    string query = "delete from products where id = @Id";
    try
    {
      MySqlCommand cmd = new MySqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@Id", Id);
      conn.Open();
      int n = cmd.ExecuteNonQuery();
      if (n > 0)
      {
        return true;
      }
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