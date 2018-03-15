using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using log4net;
using log4net.Config;

namespace Serialization_App
{
    [Serializable]
    class Person1
    {

        public string userName;
        [NonSerialized]
        public string securityNumber;
        public int age;
    }
    class SimpleSerialization1
    {
        private static ILog log
       = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Write()
        {
            Person1 pe = new Person1() { userName = "Nitesh", securityNumber = "123Bansal", age = 23 };
            Stream fs =  new FileStream("bal.txt",FileMode.Create,FileAccess.Write,FileShare.None);
            IFormatter f = new BinaryFormatter();
            f.Serialize(fs, pe);
            fs.Close();
        }
        public static void Read()
        {
            BasicConfigurator.Configure();
            Person1 ps = new Person1();
            BinaryFormatter bf = new BinaryFormatter();
            Stream fs = new FileStream("bal.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            Person1 pe = (Person1)bf.Deserialize(fs);
            fs.Close();
            log.Info("Username  :  " + ps.userName);
            log.Info("SecurityInformation  :  "+ps.securityNumber);
            log.Info("age   :   " + ps.age);
            Console.WriteLine("Go to Logger ...............Loding");
        }


            static void Main(string[] args)
            {
            Write();
            Read();
            Console.ReadKey();
            }
        }
}
