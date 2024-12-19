using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D03
{
    //6.Design a real-world scenario using enums. For example, create an enum called OrderStatus with values like:
    //Pending
    //Processing
    //Shipped
    //Delivered
    //-Write a class to simulate the change of an order’s status and print the current status at each step.
    enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered
    }

    class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }


        public Order(int orderId)
        {
            OrderId = orderId;
            Status = OrderStatus.Pending;
        }

        public void UpdateStatus()
        {
            switch (Status)
            {
                case OrderStatus.Pending:
                    Status = OrderStatus.Processing;
                    break;
                case OrderStatus.Processing:
                    Status = OrderStatus.Shipped;
                    break;
                case OrderStatus.Shipped:
                    Status = OrderStatus.Delivered;
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("The order has already been delivered.");
                    break;
            }
        }
        public void PrintStatus()
        {
            Console.WriteLine($"Order {OrderId} is currently: {Status}");
        }
    }
    //5.Create an enum called TrafficLight with the following values Red Yellow Green
    enum TrafficLight
    {
        Red, Yellow, Green
    }
    internal class Program
    {
        //1.Explain the difference between passing(Value type parameters) by value
        //and by reference then write a suitable c# example
        //passing value by value meanings that taking copy from data and making changes to copies not the addresses
        //passing value by reference meanings that taking and making changes to original addresses

        //passing value by value 
        static void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        //passing value by reference
        static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        //3.Create a function named "IsPrime", which receives an integer number and
        //retuns true if it is prime, or false if it is not
        static bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;

        }
        //4.Create a function named MinMaxArray, to return the minimum and maximum
        //values stored in an array, using reference parameter
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) { min = arr[i]; }
                if (arr[i] > max) { max = arr[i]; }

            }
        }
        static void Main(string[] args)
        {
            //1.Explain the difference between passing(Value type parameters) by value
            //and by reference then write a suitable c# example
            int val1 = 10;
            int val2 = 20;
            Console.WriteLine($"before swapping: value1={val1} , value2={val2}");
            swap(val1, val2);
            Console.WriteLine($"after swapping using passing value by value : value1 ={val1} , value2 ={val2}");
            swap(ref val1, ref val2);
            Console.WriteLine($"after swapping using passing value by reference : value1 ={val1} , value2 ={val2}");
            //3.Create a function named "IsPrime", which receives an integer number and
            //retuns true if it is prime, or false if it is not
            Console.WriteLine("enter the number you need to check: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Is this number is prime ? {IsPrime(num)}");
            //4.Create a function named MinMaxArray, to return the minimum and maximum
            //values stored in an array, using reference parameter
            int[] arrayTest = { 10, 40, 60, 2, 9, 5, 90, 1 };
            int min = arrayTest[0], max = arrayTest[0];
            MinMaxArray(arrayTest, ref min, ref max);
            Console.WriteLine($"Minimum number in the array is :{min}");
            Console.WriteLine($"Maximum number in the array is :{max}");
            //5.demonstrates the use of the TrafficLight enum
            TrafficLight currentLight = TrafficLight.Red;
            Console.WriteLine($"Current traffic light: {currentLight}");
            //6.Design a real - world scenario using enums.For example, create an enum called OrderStatus with values like:
            //Pending
            //Processing
            //Shipped
            //Delivered
            //-Write a class to simulate the change of an order’s status and print the current status at each step.
            Order order = new Order(1000);
            order.PrintStatus();

            order.UpdateStatus();
            order.PrintStatus();

            order.UpdateStatus();
            order.PrintStatus();

            order.UpdateStatus();
            order.PrintStatus();

            order.UpdateStatus();



        }
    }
}
