using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie_bąbelkowe
{
    class Student
    {
        
        public int Age { get; }
        public Student(int age)
        {
            Age = age;
        }
            

        
    }

    class StudentsList
    {
        Random ab;
        public List<Student> Students = new List<Student>();

        public StudentsList(int a)
        {
            for(int i= 0;i<a;i++)
            {
                ab = new Random(i); 
                Students.Add(new Student(ab.Next(15,30)));
            }
        }
        public StudentsList()
        {

        }
        
    }
}
