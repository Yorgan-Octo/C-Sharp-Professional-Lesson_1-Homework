using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public struct Months
    {
        public int Id { get; }
        public string Name { get; }
        public int AmountOfDays { get; }
        public Months(int id, string name, int amountOfDays)
        {
            Id = id;
            Name = name;
            AmountOfDays = amountOfDays;
        }   
        public void WriteInfo()
        {

            Console.WriteLine(new String('-',30));
            Console.WriteLine($" {Id} - {Name} - {AmountOfDays} дн; ");
            Console.WriteLine(new String('-', 30));

        }

    }
}
