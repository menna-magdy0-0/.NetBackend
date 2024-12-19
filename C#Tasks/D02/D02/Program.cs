namespace D02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            Console.WriteLine("Enter the string to convert it to int:");
            string input = Console.ReadLine();
            int result;
            if (int.TryParse(input, out result))
            {
                Console.WriteLine($"Conversion done successfuly and the integer value is {result}");
            }
            else
            {
                Console.WriteLine($"Conversion failed as The input contains non-numeric characters.");
            }
            //2-Write C# program that Extract a substring from a given string.
            string stringInput = Console.ReadLine();
            string[] outputString = stringInput.Split(" ");
            foreach (string str in outputString)
            {
                Console.WriteLine(str);
            }
            //3-Write C# program that take two string variables and print them as one variable
            Console.WriteLine("enter the 1st text");
            string text1 = Console.ReadLine();
            Console.WriteLine("enter the 2nd text");
            string text2 = Console.ReadLine();
            string res = string.Format(text1 + " " + text2);
            Console.WriteLine(res);
            //4. Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            //Assign the result in avariable then display the result.Note :
            //a. that below 10 degrees is "Just Cold"
            //b. above 30 degrees is "Just Hot"
            //c. anything else is "Just Good"
            Console.WriteLine("enter the tempreture:");
            int temp=int.Parse(Console.ReadLine());
            string state = (temp < 10) ? "Just Cold." : (temp > 30) ? "Just Hot." : "Just Good.";
            Console.WriteLine(state);
        }
    }
}
