namespace TryLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Named Object
            //var std1 = new Student { Id = 1, Name ="sara"};
            //cw(std1);//NameSpace.ClassName
            ////named object => object has reference name
            //var arr=new int[] { 1, 2, 3 };
            #endregion

            #region Collection
            //base for all collections is 
            //1. IEnumerable
            //2. ICollection
            //List<int> list = new List<int>();
            //Dictionary<int , string> dict = new Dictionary<int , string>();

            //IEnumerable<int> nums=new List<int>();
            //ICollection<int> collection =new List<int>();
            //IEnumerable<KeyValuePair<int,string>> collection2=new Dictionary<int , string>(); 
            #endregion

            #region Anonymous Object
            //List<Student> students = new List<Student>()
            //{
            //    new Student {Id=1, Name="mohamed" },
            //    new Student{Id=2,Name="khaled"}
            //};
            //new Student();//unreachable object in heap

            #endregion


            #region Anonymous Function
            //(int x, int y) => { return x + y; };
            //Delegates
            //Predicate<Student> predicate1 = std =>
            //{
            //    int y;
            //    return std != null;
            //};//take only one input parameter generic and return boolean 
            //Action action = () => Console.WriteLine("hello");
            //Action<int, int> action2 = (q, w) => Console.WriteLine("test");
            //Action<int> action3 = r => Console.WriteLine("menna");
            //Action<Student> predicate2 = std =>
            //{
            //};
            ////take from 0 to 16 input parameters generics and return void 
            ////multi casting applicable with action not applicable with predicate
            //Func<int> func1 = () => 22;
            //Func<int, int, bool> fun2 = (x, y) => true;
            ////take from 0 to 16 parameter generics and return type is generic 
            #endregion


            #region Anonymous Types
            //var s1 = new { Id=1,Name="Menna",Age=22,Salary=123M};
            ////anonymous type is a read only object in memory 
            ////created with specification you declared 
            ////Console.WriteLine(s1.GetType());
            //Console.WriteLine(s1);
            //Console.WriteLine(s1.Name);
            ////s1.Name = "Ramy";//error as it readonly
            //var s2 = new { Id=1,Name="Menna",Age=22,Salary=123M};
            ////s1 = s2;
            ////s1 will deleted by garbage collector
            //var s3 = new { FirstName = "Menna", SecondName = "Magdy" };
            //Console.WriteLine(s3);
            #endregion

            #region Before Linq
            //List<int> list = new List<int>(){1, 27, 8, 9,  12 , 13 , 14 , 15 , 3, 4, 5, 6,10, 11,7,5,0,1,3};
            //List<int> filteredNums=new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    filteredNums.Add(list[i]);
            //}
            #endregion

            #region Linq Declaration
            //features added on collections 
            //40 additional(extentions) methods
            //List<int> list = new List<int>();

            #endregion

            #region Extenstion Methods
            //int x = 1234;
            //int y = Int32Extension.Mirror(x);//mirror
            ////Console.WriteLine(y);
            //int z = x.Mirror();
            ////to make this shape applicable ===> make function as extension method over int 
            //Console.WriteLine(z);

            //string str = "Sara";
            //Console.WriteLine(str.Welcome());

            #endregion

            #region Repository
            var Employees = Repository.GetEmployee();
            var Departments=Repository.GetDepartments();
            #endregion
            #region Linq Methods
            //var filteredEmps = Enumerable.Min(Employees, e => e.Age);
            //filteredEmps=Employees.Min(emp=>emp.Age);
            //Console.WriteLine(filteredEmps);
            #endregion

            #region Linq Query Expression
            //like qui join in sql   select from where 
            //select * from employees 
            //linq query expression must enclosed by select 
            //linq query expression is limited for linq => support 12 methods from 40
            //item -> range 
            ////Employees -> Collection 
            //var q1 = from item in Employees
            //         select item;
            //var q2=from item in Employees
            //       where item.Age>25
            //       select item;
            //var q3=from item in Employees
            //       where item.DeptId==1 && item.Name.ToLower().Contains("m")
            //       select item;
            //var q4=from item in Employees
            //       where item.DeptId==1
            //       orderby item.Name ascending
            //       select item;
            //foreach (var item in q4)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region [fluent API] function expression linq lambda expression => function chaining => most used 
            ////select all employees
            //var q1=Employees.ToList();
            //var q2=Employees.Where(q=>q.DeptId==1);
            ////var q3 = Enumerable.Where(Employees, q => q.DeptId == 1);
            ////chaining
            //var q3 = Employees.Where(e => e.Age > 23).Where(q => q.Age % 2 != 0);
            //var q4 = Employees.Where(w => w.DeptId == 1).OrderBy(ww => ww.Name);
            //var q5 = Employees.OrderBy(emp => emp.Name).Where(e => e.DeptId == 2);
            //var q6=Employees.Where(s=>s.Salary>5000).OrderBy(s => s.Name).ThenBy(f=>f.Age);
            //foreach (var item in q6)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Single object => First , FirstOrDefault,Last,LastOrDefault,Single,SingleOrDefault,ElementAt  Find=>EF
            //var q1=Employees.First();
            //var q2 = Employees.First(e => e.Name.ToLower().Contains("r"));
            ////var q3=Employees.First(ww=>ww.DeptId == 7);
            ////First (condition) if condition doesn't match any element => runtime error 
            ////FirstOrDefault (condition) if condition doesn't match any element => return default value null and no runtime error fired 
            //var q3 = Employees.FirstOrDefault();
            //var q4 =Employees.FirstOrDefault(ww => ww.DeptId == 7);
            //var q5 = Employees.FirstOrDefault(m => m.Age > 25);
            //var q6=Employees.Last();
            //var q7 = Employees.Last(e => e.Name.ToLower().Contains("n"));
            ////var q8=Employees.Last(ww=> ww.DeptId == 66);//runtime error 
            //var q9 = Employees.LastOrDefault();
            ////var q10 = Employees.Single();
            ////single() => match more than one element => runtime error sequence contains more than element
            //var q11 = Employees.Single(ww=> ww.Age==25);
            ////var q12 = Employees.Single(m => m.DeptId == 66);
            ////single() => match more than no element => runtime error sequence no match element
            ////var q13=Employees.SingleOrDefault();
            ////singleOrDefault() => match more than one element => runtime error sequence contains more than element
            //var q14 = Employees.SingleOrDefault(ww => ww.Id==6);
            //var q15 = Employees.SingleOrDefault(ww =>ww.DeptId == 66);
            ////no rutime error => returns null
            //var q16=Employees.ElementAt(5);
            //Console.WriteLine(q16);
            #endregion

            #region Deffered Execution vs Immediate Execution
            //singleObject first , last , single are immediate execution
            //all linq query except singleObject first , last , single are differed execution
            //execution will be differed untill you iterate on this query 
            //var q1 =Employees.Where(e => e.DeptId==1);
            //Employees.Add(new Employee { Id = 1, Name = "QQQQ", Age = 22, Salary = 2222, DeptId = 1 });
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);//execution will happen here
            //}
            //to make the execution to be immediate execution 
            //cast query to any collection 
            //var q2 = Employees.Where(e => e.DeptId == 1).ToList(); //execution will happen here
            //Employees.Add(new Employee { Id = 1, Name = "zzzzz", Age = 23, Salary = 4222, DeptId = 1 });
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Select first 3
            //var q1 = Employees.Take(33);
            //var q2 = Employees.Skip(3).Take(3);
            //var q3=Employees.TakeLast(3);
            //var q4 = Employees.TakeWhile(m=>m.Name.Length<=5);
            //var q5 = Employees.SkipWhile(m => m.Name.Length <= 5);
            //foreach (var item in q5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List of Integers  All, Any , Distinct
            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 3, 3, 3, 4, 4, 4, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6 };
            //Console.WriteLine(Nums.All(ww=>ww%2==0));//any like or , all like and 
            //var q1=Nums.Distinct();//nums unique
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Employee Distinct
            //List<Employee>tmp= new List<Employee>
            //{
            //    new Employee{Id=1,Name="Menna",Age=22, Salary=1234,DeptId=1},
            //    new Employee{Id=2,Name="Omar",Age=23, Salary=5234,DeptId=2},
            //    new Employee{Id=3,Name="Khaled",Age=24, Salary=6234,DeptId=3},
            //    new Employee{Id=4,Name="Sara",Age=25, Salary=2234,DeptId=3},
            //    new Employee{Id=1,Name="Menna",Age=22, Salary=1234,DeptId=1},
            //    new Employee{Id=10,Name="Yossef",Age=28, Salary=9234,DeptId=1 },
            //    new Employee{Id=4,Name="Sara",Age=25, Salary=2234,DeptId=3},
            //    new Employee{Id=5,Name="Menna",Age=21, Salary=1234,DeptId=3},
            //    new Employee{Id=6,Name="Hani",Age=26, Salary=4234,DeptId=1},
            //    new Employee{Id=7,Name="Farah",Age=27, Salary=6234,DeptId=1},
            //    new Employee{Id=8,Name="Nada",Age=23, Salary=7234,DeptId=2},
            //    new Employee{Id=8,Name="Menna",Age=23, Salary=7234,DeptId=2},
            //    new Employee{Id=9,Name="Israa",Age=27, Salary=8234,DeptId=2},
            //    new Employee{Id=1,Name="Menna",Age=22, Salary=1234,DeptId=1},
            //};
            //var q1 = tmp.Distinct(new EmployeeCompare());
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Projection => Select
            //var q1 = Employees.Where(e => e.DeptId == 2).Select(ww => ww.Name);
            //var q2=from item in Employees
            //       where item.DeptId == 2
            //       select item.Name;
            //var q3=Employees
            //    .Where(ww=>ww.DeptId==1)
            //    .Select(emp=> new Employee { Id = emp.Id, Name = emp.Name });
            //var q4 = Employees
            //    .Where(ww => ww.DeptId == 1)
            //    .Select(i=>new {SSN=i.Id,FullName=i.Name});
            //var q5= Employees
            //    .Where(ww => ww.Age >23)
            //    .OrderBy(i => i.Name)
            //    .Select(emp => new { emp.Name, emp.Salary });
            //var q6= Employees
            //    .Select(emp => new {SSN=emp.Id,FullName=emp.Name})
            //    .Where (ww=>ww.SSN>5)
            //    .OrderBy(ww => ww.FullName);
            ////var q7= Employees
            //foreach (var item in q6)
            //{
            //    Console.WriteLine(item);
            //}
            ////var q1 = Employees.Select(e => new { e.Id, e.Name });
            #endregion

            #region Join
            //var q1 = Employees.Select(ww => new { ww.Id, ww.Name, ww.DeptId });
            //var q2=from emp in Employees
            //       join dept in Departments
            //       on emp.DeptId equals dept.DeptId
            //       select new {emp.Name , dept.DeptName };

            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region GroupBy
            //var q1 = from emp in Employees
            //         group emp by emp.DeptId;
            //var q2 = from emp in Employees
            //         join dept in Departments
            //         on emp.DeptId equals dept.DeptId
            //         group emp by dept.DeptName;

            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            #endregion

            #region Min Max Average
            //var q1=Employees.Min(ww => ww.Salary);
            //var q2=Employees.Max(ww => ww.Salary);
            //var q3=Employees.Average(ww => ww.Salary);

            //Console.WriteLine(q1);
            //Console.WriteLine(q2);
            //Console.WriteLine(q3);

            //var q4=Employees.Where(ww=>ww.Salary>(Employees.Average(e=>e.Salary)));
            //var q5=Employees.Where(ww=>ww.Salary>q3);

            //foreach (var item in q5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Insert Update Delete
            //insert
            //Employees.Add(new Employee { Id = 11, Name = "Draft" });
            //update
            //catch to update 
            //var emp = Employees.SingleOrDefault(ww => ww.Id==11);
            //emp.Name = "Ahmed";
            //emp.Salary = 9999;
            //emp.DeptId = 1;

            //Delete
            //catch to delete 
            //var delemp = Employees.FirstOrDefault(ww => ww.Id == 1);
            //Employees.Remove(delemp);
            //linq to objects
            //Employees.RemoveAll(ww => ww.DeptId == 1);
            //foreach (var item in Employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region OfType
            //List<User> Users = new List<User>()
            //{
            //    new Male{Id=1,Name="Khaled"},
            //    new Male{Id=2,Name="Omar"},
            //    new Female{Id=3,Name="Sara"},
            //    new Female{Id=4,Name="Menna"}
            //};
            //var q1 = Users.OfType<Female>();
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Set Operators Except , Concat , Union
            //List<int> Nums1= Enumerable.Range(0,50).ToList();
            //List<int> Nums2= Enumerable.Range(40,60).ToList();
            //var q1=Nums1.Concat(Nums2).ToList();
            //var q2=Nums1.Union(Nums2).ToList();
            //var q3 = Nums1.Except(Nums2).ToList();
            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Zip Operator
            //var nums = new List<int> { 1, 2, 3, 4 };
            //var names = new List<string> { "Menna", "Khaled", "Sara", "Omar" };
            //var q1 = nums.Zip(names, (num, name) => new { num, name });
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Join v02 fluent syntax 
            //Employees.Join(Departments, w => w.DeptId, d => d.DeptId, (e, d) => new { e.Name, d.DeptName });
            #endregion

            #region Indexed where , indexed select
            //var q1=Employees.Select((emp,index)=> new {index,emp.Name });
            //var q2=Employees.Where((emp, index) => emp.DeptId==1 && index<5);
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


        }
    }
}
