namespace lec12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            User u1 = new User() { Id = 1 ,Name="Khaled"};
            User u2 = new User() { Id = 2 ,Name="Amir"};
            User u3 = new User() { Id = 3 ,Name="Ahmed"};
            User u4 = new User() { Id = 4 ,Name="Farah"};
            Group g1 = new Group() { Name = "ITI" };
            Group g2 = new Group() { Name = "fci" };

            g1.AddMember(u1);
            g1.AddMember(u2);
            g1.AddMember(u3);
            g1.AddMember(u4);
            g1.RemoveMember(u4);

            g2.AddMember(u3);
            Post p1=new Post() { Title="xyz",Description="hamada",Creator=u1};
            g1.AddPost(p1);
            Post p2=new Post() { Title="hamada",Description="hamada",Creator=u1};
            g1.AddPost(p2);
        }
    }
}
