using System.IO;
using System.Xml.Serialization;
using log4net;
using log4net.Config;

namespace Serialization_App
{
    [XmlRoot("Person12")]
  public class Person12
    {

        private static ILog log
     = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string ApplicantName;
        private string SSNNo;
        private string CitizenShip1;
        public string ApplicaName1
        {
            get
            {
                return ApplicantName;
            }
            set
            {
                ApplicantName = value;
            }
        }
        [XmlElement("SSNNo")]
        public string SSno
        {
            get
            {
                return SSNNo;
            }
            set
            {
                SSNNo = value;
            }
        }
        [XmlElement("Citizen")]
        public string CitizenShip
        {
            get
            {
                return CitizenShip1;
            }
            set
            {
                CitizenShip1 = value;
            }
        }
    }
    class ElementType
    {
        public static void Write()
        {
            BasicConfigurator.Configure();
            Person12 per = new Person12() { ApplicaName1 = "John kethi", SSno = "UTGDY65577", CitizenShip = "UnitedState" };
            Person12 per1 = new Person12() { ApplicaName1 = "Angelina Marry", SSno = "USIDTY466565", CitizenShip = "GERMANY" };
            Person12 per2 = new Person12() { ApplicaName1 = "Nitesh Bansal", SSno = "UUYLK78876678", CitizenShip = "BARMUDA" };
            Person12 per3 = new Person12() { ApplicaName1 = "Bal Krishna", SSno = "USASSNOC76865", CitizenShip = "U.s.A" };
            Person12[] per12 = new Person12[] {per,per1,per2,per3 };
            FileStream fs = new FileStream("Citezen1.xml",FileMode.Create,FileAccess.Write,FileShare.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Person12[]));
            xs.Serialize(fs, per12);
            fs.Close();
        }
        public static void Read()
        {
            Person12 per = new Person12();
            FileStream fs = new FileStream("Citezen1.Xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Person12[]));
            Person12[] cus = (Person12[])xs.Deserialize(fs);
            foreach(var cus1 in cus)
            {
                System.Console.WriteLine("ApplicatName :  "+cus1.ApplicaName1);
                System.Console.WriteLine("Snno         :  "+cus1.SSno);
                System.Console.WriteLine("CitizenShip  :  "+cus1.CitizenShip);
                System.Console.WriteLine("==================================");
                System.Console.WriteLine();


            }

            fs.Close();
        }
        static void Main(string[] args)
        {
            Write();
            Read();
            System.Console.ReadKey();
        }
    }
}
