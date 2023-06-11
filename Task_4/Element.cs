using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public struct Element
    {
        public string NameUA { get; set; }
        public string NameRU { get; set; }
        public string NameEN { get; set; }

        public Element(string translUA, string translRU, string translEN)
        {
            NameUA = translUA;
            NameRU = translRU;
            NameEN = translEN;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"{NameUA} - {NameRU} - {NameEN}");
        }
    }
}
