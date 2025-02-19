namespace testMVC.Models
{
    public class testClass
    {
        public void Method1()
        {
            Console.WriteLine("1");
            Method2();
            Console.WriteLine("3");
        }
        public void Method2()
        {
            Console.WriteLine("2");
        }
        int viewData;
        public int ViewData {
            set { viewData = value;}
            get { return viewData; }
        }
        public dynamic ViewBag
        {
            set { ViewData= value; }
            get { return ViewData; }
        }
        public int Add(int x , int y)
        {
            dynamic xx = 5;
            dynamic yy = "ahmed";
            dynamic obj = new Student();
            
            return x + y;
        }
        public void display()
        {
            int a = 10;
            int b = 20;
            Add(a, b);
        }
    }
}
