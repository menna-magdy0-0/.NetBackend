using EFDBCreationStrategies;

//most commonly used startegy [Migrate]
//migration will be done in versions 



//make EF dochanges in DB without drop database or trancate data
//EF will create a new table or column or delete a column
///
///Miguration CLI
///1- Enable-Migrations   => must in legacy ef6   ===> EF Core obselete 
///2- Add-migration InitialCreate 
///3- update-database -verbose  ==> affect in database
///



namespace EFDBCreationStrategies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIContext db = new ITIContext();
            db.Employees.Add(new Employee { Name = "Ahmed" });
            db.SaveChanges();
        }
    }
}
