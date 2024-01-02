namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager{
    public static string conString = @"server=192.168.10.150; port=3306; user=dac56; password=welcome; database=dac56";

    public static List<Product> GetAllProducts(){
       List<Product> list=new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString ="server=192.168.10.150;port=3306;user=dac56;password=welcome;database=dac56";
        string query ="select * from products";
        MySqlCommand command = new MySqlCommand(query, connection);
        try{
            connection.Open();
            MySqlDataReader reader=command.ExecuteReader();
            
            while(reader.Read()){
            Product product=new Product();
            int id=int.Parse(reader["productid"].ToString());
            string title=reader["title"].ToString();
            string description=reader["description"].ToString();
            product.Id=id;
            product.Title=title;
            product.Description=description;
            list.Add(product);
            }
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
       
       
      
        return list;
    }
        


    }
