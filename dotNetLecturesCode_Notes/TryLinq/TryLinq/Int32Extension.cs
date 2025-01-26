using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLinq
{
    internal static class Int32Extension
    {
        //function as extension function 
        //function in static class 
        //function is static function 
        //this keyword in input parameter 
        public static int Mirror(this int  value)
        {
            var tmp=value.ToString().ToCharArray();
            Array.Reverse(tmp);
            int m = int.Parse(tmp);
            return m;
        }
        //public static int Mirror(int value)
        //{
        //    var tmp = value.ToString().ToCharArray();
        //    Array.Reverse(tmp);
        //    int m = int.Parse(tmp);
        //    return m;
        //}
        public static string Welcome(this string text)
        {
            return $"welcome {text}";
        }
    }
}
