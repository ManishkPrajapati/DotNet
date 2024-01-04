using BOL;
using DAL;
namespace BLL;

public class EmployeeManager
{
  public bool Validate(string email, string password)
  {
    bool status = EDManager.Check(email, password);
    Console.WriteLine(status);
    return status;
  }

  public Employee FindEmployee(string firstname, string password)
  {
    return EDManager.GetEmp(firstname, password);
  }

  public bool ChangeEmployee(int id, string firstname, string email, string password)
  {
    return EDManager.UpdateEmp(id, firstname, email, password);
  }

}