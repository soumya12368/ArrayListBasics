using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ListBasic_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            ArrayList StudentGrades = new ArrayList
            {
                85,92,78,95,88
            };
            Console.WriteLine("Grades present in List is:" + StudentGrades.Count);
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sum of all grades in studentGrades:");
            foreach (int i in StudentGrades)
            {
                sum += (int)i;
            }
            Console.WriteLine($"The sum of the grades in studentgrades is {sum}");
            Console.WriteLine("updates students grade after adding new data");
            StudentGrades.Add(90);
            foreach (int i in StudentGrades)
            {
                Console.Write(i);
            }
            Console.WriteLine("Removal of the contents in studentGrades");
            StudentGrades.RemoveAt(2);
            Console.WriteLine("updates students grade after Removing data");
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Updating the studentgrades list:");
            StudentGrades.Insert(3, 96);
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
