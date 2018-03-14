using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo
{
    class Program
    {
        int a;
        int b;
        public  int Add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program c =  new Program();
            int c1 = c.Add(10,20);
            Console.WriteLine(c1);
            Console.ReadKey();
        }
    }
}
