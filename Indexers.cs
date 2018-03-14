using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Student11
    {
        public string Name;
        public string FatherName;
        public int Age;
        public string PostalAdress;
        public string sex;
        public int PhoneNumber;
        public string HigerEducation;
        public Student11(string x, string y, int z, string a, string b, int c, string d)
        {
            this.Name = x;
            this.FatherName = y;
            this.Age = z;
            this.PostalAdress = a;
            this.sex = b;
            this.PhoneNumber = c;
            this.HigerEducation = d;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Name;
                else if (index == 1)
                    return FatherName;
                else if (index == 2)
                    return Age;
                else if (index == 3)
                    return PostalAdress;
                else if (index == 4)
                    return sex;
                else if (index == 5)
                    return PhoneNumber;
                else if (index == 6)
                    return HigerEducation;
                return null;
            }
            set
            {
                if (index == 0)
                    Name = (string)value;
                else if (index == 1)
                    FatherName = (string)value;
                else if (index == 2)
                    Age = Convert.ToInt32(value);
                //Age = (int)value;
                else if (index == 3)
                    PostalAdress = (string)value;
                else if (index == 4)
                    sex = (string)value;
                else if (index == 5)
                    PhoneNumber = (int)value;
                else if (index == 6)
                    HigerEducation = (string)value;
            }
        }
        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "NAME")
                {
                    return Name;
                }
                else if (name.ToUpper() == "FATHERNAME")
                {
                    return FatherName;
                }
                else if (name.ToUpper() == "AGE")
                    return Age;
                else if (name.ToUpper() == "POSTALADDRESS")
                    return PostalAdress;
                else if (name.ToUpper() == "SEX")
                    return sex;
                else if (name.ToUpper() == "PHONENUMBER")
                    return PhoneNumber;
                else if (name.ToUpper() == "HIGHEREDUCATION")
                    return HigerEducation;
                return null;
            }
            set
            {
                if (name.ToUpper() == "NAME")
                    Name = (string)value;
                else if (name.ToUpper() == "FATHERNAME")
                    FatherName = (string)value;
                else if (name.ToUpper() == "AGE")
                    Age = (int)value;
                else if (name.ToUpper() == "POSTALADDRESS")
                    PostalAdress = (string)value;
                else if (name.ToUpper() == "SEX")
                    sex = (string)value;
                else if (name.ToUpper() == "PHONENUMBER")
                    PhoneNumber = (int)value;
                else if (name.ToUpper() == "HIGHEREDUCATION")
                    HigerEducation = (string)value;
            }
        }



    }
    class indexers
    {
        public static void Enter(LinkedList<Student11> list)
        {
            Console.WriteLine("Please Enter the Details");
            Console.Write("CandateName : ");
            string Name = Console.ReadLine();
            Console.Write("FatherName : ");
            string FName = Console.ReadLine();
            int age;
        z: Console.Write("Age : ");
            if (int.TryParse(Console.ReadLine(), out age)) { }
            else { Console.Write("Enter Your Age Again"); goto z; }
            Console.Write("Postal Address : ");
            string PAddress = Console.ReadLine();
            Console.Write("sex : ");
            string sex = Console.ReadLine();
            int phone;
        j: Console.Write("Phone Number : ");
            if (int.TryParse(Console.ReadLine(), out phone)) { }
            else { Console.WriteLine("Enter NumberFormate"); goto j; }
            Console.Write("HigherEducation : ");
            string s = Console.ReadLine();
            Student11 st = new Student11(Name, FName, age, PAddress, sex, phone, s);
            if (list.Count == 0)
                list.AddFirst(st);
            int i = 0;
            foreach (var item in list)
            {
                if (st.Name.Equals(item.Name) && st.PhoneNumber == item.PhoneNumber)
                {
                    i = 1;
                    break;
                }

            }
        Q: Console.WriteLine("Which field you want to update Enter");
            Console.WriteLine("Name              : Press 0");
            Console.WriteLine("FatherName        : Press 1");
            Console.WriteLine("Age               : Press 2");
            Console.WriteLine("PostalAdress      : Press 3");
            Console.WriteLine("sex               : Press 4");
            Console.WriteLine("PhoneNumber       : Press 5");
            Console.WriteLine("HigherEducation   : Press 6");
            Console.WriteLine("No Update         : Press 7");
            int q;
            if (int.TryParse(Console.ReadLine(), out q)) { }
            else { Console.WriteLine("Please Provide Correct Input"); goto Q; }
            if (q == 7)
            {
                goto SS;
            }
            Console.WriteLine("Enter the value To Update : ");
            string s11 = Console.ReadLine();
            if (q == 2 || q == 5)
            {
                st[Convert.ToString(q)] = s11;
                //st[q.ToString()] = s11;
            }
            st[q] = s11;
            //Console.WriteLine("Enter the Field Name To Which You Want To Update");
            // string str =Console.ReadLine();
            //Console.WriteLine("Enter the Updated Value");
            // string str1 =Console.ReadLine();
            //st[str] = str1;
           SS:
            if (i == 0)
                list.AddLast(st);



        }

        static void Display(LinkedList<Student11> list)
        {
            Console.WriteLine("Your Entered Details ");
            foreach (var item in list)
            {
                Console.WriteLine("CanidateName    : " + item.Name);
                Console.WriteLine("FatherName      : "  + item.FatherName);
                Console.WriteLine("Age             : " + item.Age);
                Console.WriteLine("Postal Adress   : " + item.PostalAdress);
                Console.WriteLine("Sex             : " + item.sex);
                Console.WriteLine("Phone Number    : " + item.PhoneNumber);
                Console.WriteLine("HigherEducation : " + item.HigerEducation);
                Console.WriteLine("=========================================");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            LinkedList<Student11> list = new LinkedList<Student11>();
        L: Enter(list);

        G: Console.WriteLine("If you want add More student Details PRESS 1 To EXIT PRESS 0 ");
            int i;
            if (int.TryParse(Console.ReadLine(), out i)) { }
            else { Console.WriteLine("Enter Valid Value Please"); goto G; }
            if (i == 1)
            {
                goto L;
            }
            Display(list);


            Console.ReadKey();
        }
    }
}
