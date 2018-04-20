using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie_bąbelkowe
{
    class BubbleSorting
    {
        public BubbleSorting(ref StudentsList ts)
        {
            Sort(ref ts);
        }

        void Sort(ref StudentsList students)
        {

            int s;
            int n = 0;
            
            while(true)
            {
                s = 0;
                n++;
                for (int i = students.Students.Count; i > 1; i--)
                {
                    if (checkIfSmaller(students.Students[i - 1], students.Students[i - 2]))
                    {
                        s++;
                        Student a, b;
                        a = students.Students[i - 1];
                        b = students.Students[i - 2];

                        students.Students[i - 1] = b;
                        students.Students[i - 2] = a;
                    }
                    
                }
                if (s == 0)
                    break;
            }
            
        }

        bool checkIfSmaller(Student A,Student B)
        {
            if (A.Age < B.Age)
                return true;
            
            else
                return false;
        }
    }
}
