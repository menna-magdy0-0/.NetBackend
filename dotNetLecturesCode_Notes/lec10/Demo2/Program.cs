namespace Demo2
{
    //step 0 Delegate DT Declaration
    //new class (new Delegate) , Specify Function Signature 
    public delegate int StringFunDelDT(string S);
    public delegate bool CompFunDelDT(int L, int R);
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Delegate Declaration 
            StringFunDelDT fptr;
            //2. pointer to function (Delegate object) Initialization 
            fptr = new StringFunDelDT(StringFunctions.GetLength);
            //3. using pointer to function ,call(invoke) function 
            int R=fptr.Invoke("ABCabc"); 
            Console.WriteLine(R);
            fptr = new StringFunDelDT(StringFunctions.GetUpChar);
            R = fptr.Invoke("ABCabc");
            Console.WriteLine(R);
            //fptr = new StringFunDelDT(StringFunctions.GetFullName);
            //compiler enforce delegate signature 
            //function not static , define object then object name.function name 
            StringFunctions SObj=new StringFunctions() { Ch='z'};
            //object methods
            fptr = new StringFunDelDT(SObj.GetCharNum);
            R = fptr("Abczyfz");
            //fptr.Invoke("Abczyf");
            Console.WriteLine(R);
        }
    }
    class StringFunctions
    {
        public static int GetLength(string str) { return str?.Length ?? -1; }
        public char Ch { get; set; }
        public int GetCharNum(string str)
        {
            int Counter = 0;
            for (int i = 0; i < str?.Length; i++)
            {
                if (str[i] == this.Ch) Counter++;
            }
            return Counter;
        }
        public int GetFullName(string FName, string LName) { return FName.Length + LName.Length; }
        public static int GetUpChar(string str)
        {
            int Counter = 0;
            for (int i = 0; i < str?.Length; i++)
            {
                if (Char.IsUpper(str[i])) Counter++;
            }
            return Counter;
        }
    }
}
