using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie_bąbelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsList newClass = new StudentsList(10);
            StudentsList bubblesorted = new StudentsList();
            StudentsList quicksorted = new StudentsList();

            foreach (Student s in newClass.Students)
            {
                Console.WriteLine(s.Age);
                bubblesorted.Students.Add(s);
                quicksorted.Students.Add(s);
            }


            Console.WriteLine(".");


            BubbleSorting aaa = new BubbleSorting(ref bubblesorted);
            foreach (Student s in bubblesorted.Students)
            {
                Console.WriteLine(s.Age);
            }

            QuickSort bbb = new QuickSort(ref quicksorted);

            
            Console.WriteLine(".");

            foreach (Student s in bubblesorted.Students)
            {
                Console.WriteLine(s.Age);
            }






            Console.ReadKey();
        }
    }
}
