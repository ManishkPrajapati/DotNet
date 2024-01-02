namespace DAL;
using BOL;

public interface IDBManager
{
    public List<Department> GetAll();
    public Department GetById(int id);

    public void Insert(Department dept);
    public void Update(Department dept);
    public void Delete(int id);
}