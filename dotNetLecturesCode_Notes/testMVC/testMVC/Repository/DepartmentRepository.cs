using testMVC.Models;

namespace testMVC.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public string Id { get; set; }//for testing the uniqueness of object identity

        ITIContext context;
        public DepartmentRepository(ITIContext _context)
        {
            context = _context; //new ITIContext();
            Id=Guid.NewGuid().ToString();
        }
        //CRUD
        public void Add(Department obj) 
        { 
            context.Add(obj);
        }
        public void Update(Department obj) 
        { 
            context.Update(obj);
        }
        public void Delete(int id) 
        {
            Department Dept = GetById(id);
            context.Remove(Dept);
        }
        public Department GetById(int id) 
        { 
            return context.Departments.FirstOrDefault(x => x.Id == id);
        }
        public List<Department> GetAll() 
        {
            return context.Departments.ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
