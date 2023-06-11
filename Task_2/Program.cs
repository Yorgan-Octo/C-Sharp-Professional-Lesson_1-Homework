using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {

            MonthCollection monthCollection = new MonthCollection();

            //вивод всії місяців
            //foreach (Months item in monthCollection)
            //{
            //    item.WriteInfo();
            //}

            var res = monthCollection.SearchDaysInMonth(31);
            Console.WriteLine("Місяці в яких 31 день");
            foreach (Months item in res)
            {
                item.WriteInfo();
            }


            Console.WriteLine();


            res = monthCollection.SearchDaysInMonth(30);

            Console.WriteLine("Місяці в яких 30 день");
            foreach (Months item in res)
            {
                item.WriteInfo();
            }


            Console.WriteLine();


            res = monthCollection.SearchDaysInMonth(29);

            Console.WriteLine("Місяці в яких 29 денів");
            foreach (Months item in res)
            {
                item.WriteInfo();
            }



            Console.ReadLine();

        }
    }
}
