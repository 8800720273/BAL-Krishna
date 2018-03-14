using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo
{
    class Logger12
    {

        private static readonly log4net.ILog log
       = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Enter()
        {
            Console.WriteLine("Enter Reqiured Details");
        }
        public static void CheckName()
        {
            Console.Write("UserName : ");
            string s1 = Console.ReadLine();
            if (s1.Length <= 1)
            {
                throw new CapitalLetter("Name should be greater than one digit");
            }
        }
        public static void CheckAge()
        {
        M: Console.Write("Age : ");
            int i;
            string s = Console.ReadLine();
            if (int.TryParse(s, out i)) { }
            else { Console.WriteLine("Worng Entery Please Try Again"); goto M; }
            if (i < 21)
            {
                log.Info("Age should be more than 21");
                throw new CapitalLetter("Age should be greater than 21");
            }
        }
        public static void Addhar()
        {
        J: Console.Write("AddharCardNo:");
            long k;
            string s = Console.ReadLine();
            if (long.TryParse(s, out k)) { }
            else { Console.WriteLine("AddharCard Number Should be in Numeric Form"); goto J; }

            if (s.Length < 12 || 12 < s.Length)
            {
                throw new CapitalLetter("AddharNo should be of 12 Digit");
            }
        }
        public static void passWord1()
        {
            Console.WriteLine("Enter Your New PassWord : ");
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            int f = 0;
            foreach (var item in ch)
            {
                if (item == '@')
                {
                    f = 1;
                    break;
                }
            }

            if (ch.Length < 8)
            {
                log.Info("please provide length 8 to password");
                throw new CapitalLetter("Please provide minimium 8 length password");
            }
            else if (f == 0)
                throw new CapitalLetter("Please provide Atlest one @ ");



        }
        public static void Main(string[] args)
        {
            Enter();
        I: try
            {
                CheckName();
            }
            catch (CapitalLetter e)
            {
                log.Error(e.Message);
                goto I;
            }
        L: try
            {
                CheckAge();
            }
            catch (CapitalLetter e)
            {
                log.Error(e.Message);
                goto L;
            }
        K: try
            {
                Addhar();
            }
            catch (CapitalLetter e)
            {
                log.Error(e.Message);
                goto K;
            }
        M: try
            {
                passWord1();
            }
            catch (CapitalLetter e)
            {
                log.Error(e.Message);
                goto M;
            }
            Console.WriteLine("filled");
            Console.WriteLine("Press Any Key to Exit...");
            Console.ReadKey();
        }
    }
}
