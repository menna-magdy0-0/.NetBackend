using System;

namespace errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y ;
            Boolean b=int.TryParse(Console.ReadLine(),out y);
            if(b==true)
            {
                Console.WriteLine(y);

            }
            else
            {
                Console.WriteLine("parsing error");
            }
            StreamReader sr=null;
            try
            {
                sr = new StreamReader("D:\\Downloads\\c# code wave\\test.txt");
                string str = sr.ReadToEnd();
                Console.WriteLine(str);
            }
            catch (FileNotFoundException ex1)
            {
                Console.WriteLine("File Not Founnd");
            }
            catch (DirectoryNotFoundException ex2)
            {
                Console.WriteLine("directory not found");
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }

            }

        }
        static void Main1(string[] args)
        {
            //syntax errors -> the easiest errors 
            //types 
            //semicolumns 
            //names 
            //logical error -> 
            //trace code 
            //runtime error -> application crash
            //exception in clr to describe the error using an object 
            //try
            //{

            //    int x = 10;
            //    int y;
            //    Console.WriteLine("plz enter value of y");
            //    y = int.Parse(Console.ReadLine());//line1
            //    int r;
            //    r = x / y;//line2
            //    Console.WriteLine(r);
            //}
            //catch (Exception e1) 
            //{
            //    Console.WriteLine(e1.Message);
            //    Console.WriteLine();
            //    Console.WriteLine(e1.StackTrace);

            //    //plz enter value of y
            //    //6500000000000
            //    //Value was either too large or too small for an Int32.

            //    //at System.Number.ThrowOverflowException[TInteger]()
            //    //at System.Int32.Parse(String s)
            //    //at errors.Program.Main(String[] args) in D:\C#Projects\lec8\errors\Program.cs:line 21
            //    //end of program

            //    //plz enter value of y
            //    //0
            //    //Attempted to divide by zero.

            //    //at errors.Program.Main(String[] args) in D:\C#Projects\lec8\errors\Program.cs:line 25
            //    //end of program

            //}
            //Console.WriteLine("end of program");
            int x = 10;
            short y;
            Console.WriteLine("plz enter value y");
            try
            {

                int[] arr = { 5, 6, 7 };
                Console.WriteLine(arr[1]);
                y=short.Parse(Console.ReadLine());
                int r;
                r = x / y;
                Console.WriteLine(r);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("plz enter a valid index");

                //Console.WriteLine(ex.GetType);
                //Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
                //plz enter value y
                //Index was outside the bounds of the array.

                //at errors.Program.Main(String[] args) in D:\C#Projects\lec8\errors\Program.cs:line 58



            }
            catch(FormatException e2)
            {
                Console.WriteLine("please enter a valid index");
            }
            finally
            {
                Console.WriteLine("end of program");

            }
            //catch(Exception e3)
            //{
            //    Console.WriteLine("exception occured");
            //}
        }
            
        
    }
}
