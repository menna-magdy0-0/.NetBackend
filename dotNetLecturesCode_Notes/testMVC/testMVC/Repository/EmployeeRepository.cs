using testMVC.Models;

namespace testMVC.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        ITIContext context;
        public EmployeeRepository(ITIContext _context)
        {
            context = _context;//new ITIContext();
        }
        //CRUD
        public void Add(Employee obj)
        {
            context.Add(obj);
        }
        public void Update(Employee obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Employee Emp = GetById(id);
            context.Remove(Emp);
        }
        public Employee GetById(int id)
        {
            return context.Employees.FirstOrDefault(x => x.Id == id);
        }
        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
