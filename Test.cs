using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo
{
        abstract class M1
        {
            public int add(int a, int b)
            {
                return (a + b);
            }
        }
        class M2 : M1
        {
            public int mul(int a, int b)
            {
                return a * b;
            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                M2 ob = new M2();
            //int result = ob.add(10, 20);
            int result = ob.mul(10, 40);
                Console.WriteLine("the result is {0}", result);
                Console.ReadLine();
            }
        }
 }
