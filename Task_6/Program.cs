using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] inte = { 1, 2, 3, 4, 5 };

            var res = Cvadra(inte);

            foreach (var item in res)
            {
                Console.Write(item + ", ");
            }

            Console.ReadKey();
        }

        public static IEnumerable Cvadra(int[] args)
        {
            var ser = args.Where(x => x % 2 != 0).Select(x => x * x);

            foreach (var item in ser)
            {
                yield return item;
            }

            //або так:
            //foreach (int number in numbers)
            //{
            //    if (number % 2 != 0)
            //    {
            //        yield return number * number;
            //    }
            //}
        }


    }
}
