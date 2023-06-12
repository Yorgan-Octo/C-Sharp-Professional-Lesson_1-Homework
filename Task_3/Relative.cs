using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Relative
    {
        public string Name { get; }
        public DateTime DateOfBirth { get; }
        public List<Relative> сhildren = new List<Relative>();
        public Relative(string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }

        public void AddChildren(Relative chil)
        {
            сhildren.Add(chil);
        }
        public void PrintFamilyTree(string iner = "- ")
        {
            Console.WriteLine($"{iner}{Name} {DateOfBirth.Year}р");
            foreach (var child in сhildren)
            {
                child.PrintFamilyTree("    " + iner);
            }
        }

        public void SearchYear(DateTime year, ref List<Relative> res)
        {

            if (DateOfBirth.Year == year.Year)
            {
                res.Add(this);
            }

            foreach (var item in сhildren)
            {
                if (item.DateOfBirth.Year == year.Year)
                {
                    //res.Add(item);
                    item.SearchYear(year, ref res);
                }
            }

        }

    }
}
