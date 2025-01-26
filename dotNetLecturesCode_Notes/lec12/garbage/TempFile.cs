using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage
{
    internal class TempFile
    {
        //public  MyProperty { get; set; }
        string fileName;
        FileStream stream;
        byte[] data;
        public TempFile()
        {
            fileName = $"D:\\C#Projects\\1\\tempdata{DateTime.Now.ToLongTimeString().Replace(":",string.Empty)}.dat";
            stream=new FileStream(fileName,FileMode.Create);
            data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            stream.Write(data, 0, data.Length);
            stream.Close();


        }
        public void Dispose()
        {
            Console.WriteLine("dispose");
            File.Delete(fileName);
            GC.SuppressFinalize(this); 
        }
        public void DoSomeThing()
        {
            Console.WriteLine("do something");
        }
        ~TempFile()
        {
            Console.WriteLine("destractor");
            File.Delete(fileName);
        }
    }
}
