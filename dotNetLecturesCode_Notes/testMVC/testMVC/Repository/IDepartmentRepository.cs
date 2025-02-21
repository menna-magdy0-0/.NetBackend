using testMVC.Models;

namespace testMVC.Repository
{
    public interface IDepartmentRepository
    {
        public string Id { get; set; }//for testing the uniqueness of object identity

        public void Add(Department obj);

        public void Update(Department obj);

        public void Delete(int id);

        public Department GetById(int id);

        public List<Department> GetAll();

        public void Save();
    }
}
