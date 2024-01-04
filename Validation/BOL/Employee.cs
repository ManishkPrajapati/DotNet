namespace BOL;

public class Employee
{
  public Employee(int id, string firstname, string email, string password)
  {
    this.id = id;
    this.firstname = firstname;
    this.email = email;
    this.password = password;
  }

  public int id { get; set; }
  public string firstname { get; set; }
  public string email { get; set; }
  public string password { get; set; }

}