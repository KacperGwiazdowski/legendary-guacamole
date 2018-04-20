using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie_bąbelkowe
{
    class QuickSort
    {
        StudentsList sorted = new StudentsList();


        public QuickSort(ref StudentsList ts)
        {
            Sort(ts,0,ts.Students.Count);
           
        }

        void Sort( StudentsList studentsList, int left, int right)
        {

                var pivot = studentsList.Students[(left + right) / 2];
            

             StudentsList lesserThanPivot = new StudentsList();

             StudentsList biggerThanPivot = new StudentsList();

            for (int i = 0; i < studentsList.Students.Count; i++)// pętla która wypełnia obie tablice w stosunku do pivota
            {

                if ((left + right) / 2 == i)
                    continue;

                if (studentsList.Students[i].Age < pivot.Age)
                {
                    lesserThanPivot.Students.Add(studentsList.Students[i]);
                }
                else
                {
                    biggerThanPivot.Students.Add(studentsList.Students[i]);
                }
            }
            

            if (lesserThanPivot.Students.Count == 1) //warunek do tablicy elementów mniejszych od pivota
            {
                sorted.Students.Add(lesserThanPivot.Students[0]);//jeżeli w talbicy jest jeden element to dodaj do posortowanych
                sorted.Students.Add(studentsList.Students[(left + right) / 2]);//a potem dodaj samego pivota
            }
            else if (lesserThanPivot.Students.Count > 1)//jeżeli elementów w tablicy mniejszych od pivota jest więcej 
            {
                Sort(lesserThanPivot, 0, lesserThanPivot.Students.Count);//to sortuj je dalej
                biggerThanPivot.Students.Add(pivot);// a pivota wrzuć do tablicy większych żeby brał udział w dalszym sortowaniu
            }
            else if (lesserThanPivot.Students.Count == 0)//jeżeli nie ma elemntów mniejszych od pivota to dodaj samego pivota
                sorted.Students.Add(studentsList.Students[(left + right) / 2]);


            if (biggerThanPivot.Students.Count > 1)//jeżeli elementów większych od pivota jest więcej niż jeden
            {
                Sort(biggerThanPivot, 0, biggerThanPivot.Students.Count);// to je posortuj

            }

            else if (biggerThanPivot.Students.Count == 1)// jak jest jeden 
            {
                sorted.Students.Add(biggerThanPivot.Students[0]);// to dodaj go do listy
                
            }



       








        }
    }

}           

        






