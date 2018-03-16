using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace TestClass
{/// <summary>
/// Class 
/// </summary>
    public class Class1
    {
        delegate void Test(string name);
        static void Main(string[] args)
        { 
            Test t = new Test(Show);
            t("Message");

        }
        static  void Show(String name)
        {
            Console.WriteLine("Hello"+name);
        }
    }
}
