using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_App
{
    class TestDemo
    {
        static int i = 0, j = 0;
        static FileStream fs = new FileStream("demo.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
        public static void  Writer()
        {
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter The Message");
            string s = Console.ReadLine();
            byte[] bytes = Encoding.Default.GetBytes(s);
            fs.Write(bytes,0,bytes.Length);
            j = i;
            i = i + s.Length;
            fs.Position = i;
            Reader();

        }
        public static void Reader()
        {
            FileStream file = new FileStream("demo.txt", FileMode.Open,FileAccess.ReadWrite,FileShare.ReadWrite);
            StreamReader sr = new StreamReader(file);
            string s = sr.ReadLine();
            Console.WriteLine("reading..");
            string hi = s.Substring(j);
            Console.WriteLine(hi);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
          S:Writer();
            Reader();
            goto S;
        }
     }
}
