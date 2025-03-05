using testMVC.Models;

namespace testMVC.Repository
{
    public interface IEmployeeRepository
    {
        public void Add(Employee obj);

        public void Update(Employee obj);

        public void Delete(int id);

        public Employee GetById(int id);

        public List<Employee> GetAll();

        public void Save();

        public List<Employee> GetByDeptId(int id);
    }
}
