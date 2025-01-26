namespace lec10
{
    //define new data type of type delegate 
    public delegate int opdel(int x, int y);
    //func -> return data from any type and take up to 16 parameter,
    // Action-> return void
    //predicate-> return boolean and take only one parameter 
    internal class Program
    {


        public static int Add(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "ahmed","mohamed","ali"};
            //opdel o1 = new opdel(Add);
            opdel o2 = Add;
            //anonymous function
            //opdel o3 = (x, y) => {  return x + y; };
            opdel o3 = (x, y) =>  x + y; ;
            o3 += Add;
            //invocation list 
            Console.WriteLine(o3?.Invoke(12, 30));
            //Console.WriteLine(o3(4,5));
            
        }
    }
}
