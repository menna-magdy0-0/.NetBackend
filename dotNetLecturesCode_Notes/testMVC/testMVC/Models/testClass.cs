namespace testMVC.Models
{
    interface ISort//contract
    {
        
        void Sort(int[] arr);
    }


    class BubbleSort:ISort
    {
        public void Sort(int[] arr)
        {
            //arr sort using bubble sort
        }
    }
    class SelectionSort : ISort
    {
        public void Sort(int[] arr)
        {
            //arr sort using selection sort
        }
    }

    class Stack //Hign level class depend on low level class BubbleSort
                //depend on the class BubbleSort
    {           //open for extend and modification 
        int[] arr;
        ISort SortObj;
        public Stack(ISort _sortObj)
        {
            //SortObj = new BubbleSort();
            SortObj = _sortObj;//dependency injection
            //to make the user choose the sort type
            //BubbleSort or SelectionSort
            //to make initialization in the constructor
        }
        void SortStack()//ISort _sort)
        {
            SortObj.Sort(arr);
        }
    }

    public class testClass
    {
        public void Method1()
        {
            Stack s1 = new Stack(new BubbleSort());
            Stack s2 = new Stack(new SelectionSort());
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
