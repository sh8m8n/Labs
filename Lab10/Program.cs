using System;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            School school = new School(50000000);
            school.Reward(school.FindMinMaxEmployee());

            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalSeconds) ;

            Console.ReadKey();

        }
    }
}

//卩仨弓丫人乙丅闩丅辷 丅仨匚丅口乃:

//匚丅卩丫片丅丫卩辷:
//50,3126772
//50,6796259
//49,8709012

//片人闩匚匚辷:
//70,9564118
//71,2653774
//71,5295894