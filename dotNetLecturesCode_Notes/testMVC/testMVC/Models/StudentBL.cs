namespace testMVC.Models
{
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Ahmed", ImageURL="1.jpg"});
            students.Add(new Student() { Id = 2, Name = "Menna", ImageURL="2.png"});
            students.Add(new Student() { Id = 3, Name = "Sara", ImageURL="2.png"});
            students.Add(new Student() { Id = 4, Name = "Khaled", ImageURL="1.jpg"});
            students.Add(new Student() { Id = 5, Name = "Nada", ImageURL="2.png"});
        }
        public List<Student>GetAll()
        {
            return students;
        }
        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
