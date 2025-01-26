using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class PhoneBook
    {
        string[] names = { "ahmed", "mohamed", "ali" };
        string[] numbers = { "1111", "3333", "4444" };
        public string this[string str]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == str)
                    {
                        return numbers[i];
                    }
                }
                throw new Exception();
            }
        }
        public string this[int i]
        {
            get
            {
                if (i < numbers.Length)
                    return numbers[i];
                throw new Exception();
            }
        }
        public string this[int i, string str]
        {
            get
            {
                if (i < numbers.Length)
                    return numbers[i];
                throw new Exception();
            }

            //public PhoneBook() 
            //{
            //    names = new string[10];
            //    numbers = new string[20];
            //}

        }
    }
}
