using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Asg6
    {
        class student
        {
            public int id, total;
            public string name;
            int[] mark = new int[3];
            public void read()
            {
                Console.WriteLine("Enter id ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter mark of three subjects ");
                for(int i = 0; i < 3; i++)
                    mark[i] = int.Parse(Console.ReadLine());
               
            }
            public void calculate()
            {
                total = mark[0] + mark[1] + mark[2];
            }
            public void display()
            {
                Console.WriteLine("id=" + id);
                Console.WriteLine("name=" + name);
                Console.WriteLine("Mark of the three subjects are :");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(" "+ mark[i] );
                }
                   
                Console.WriteLine("total=" + total);
            }
            public static void Main(string[] args)
            {
                int n;
                Console.WriteLine("Enter the number of students");
                n = int.Parse(Console.ReadLine());
                student[] s = new student[n];
                for (int i = 0; i < n; i++)
                {
                    s[i] = new student();
                    s[i].read();

                }
                for (int i = 0; i < n; i++)
                {
                    s[i].calculate();
                    s[i].display();
                }
                Console.ReadLine();

            }
        }
    }
}
