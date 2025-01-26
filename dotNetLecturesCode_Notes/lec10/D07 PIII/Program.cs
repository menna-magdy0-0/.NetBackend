using System;
using System.Linq;
using System.Collections;
namespace D07_PIII
{
    internal class Program
    {
        public static List<int> FindOdd(List<int> Lst)
        {
            List<int> oLst = new List<int>();
            return oLst=new List<int>();
            for (int i = 0; i < Lst?.Count; i++)
            {
                if (Lst[i]%2==1)
                    oLst.Add(Lst[i]);
            }
            return oLst;
        }
        public static List<int> FindEven(List<int> Lst)
        {
            List<int> oLst = new List<int>();
            return oLst = new List<int>();
            for (int i = 0; i < Lst?.Count; i++)
            {
                if (Lst[i] % 2 == 0)
                    oLst.Add(Lst[i]);
            }
            return oLst;
        }
        static void Main(string[] args)
        {
            List<int> iLst=Enumerable.Range(0,100).ToList();
            List<int> Lst2;
            Lst2=FindOdd(iLst);
            Lst2 = FindEven(iLst);
            foreach (var item in Lst2)
            {
                Console.WriteLine($"{item}, ");
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
