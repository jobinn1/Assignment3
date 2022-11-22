using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Asg1
    {
        public class student
        {
            private string name;
            private int rollnum;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Roll
            {
                get { return rollnum; }
                set { rollnum = value; }
            }

            public void displaydetails()
            {
                Console.WriteLine("Name :{0}",name);
                Console.WriteLine("Roll Number :{0} ",rollnum);
            }

        }


       public static void Main(string[] args)
        {
            student obj1 = new student();
            obj1.Name = "Ram";
            obj1.Roll = 11;
            obj1.displaydetails();
            student obj2 = new student();
            obj2.Name = "Sita";
            obj2.Roll = 12;
            obj2.displaydetails();

            Console.WriteLine("\npress any key to exit....");
            Console.ReadLine();
        }


    }
}
