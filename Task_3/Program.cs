using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            #region
            Relative James = new Relative("James Smith", DateTime.Parse("27/11/1989"));
            Relative Emma = new Relative("Emma Johnson", DateTime.Parse("27/11/2003"));
            Relative William = new Relative("William Brown", DateTime.Parse("27/11/2004"));
            Relative Olivia = new Relative("Olivia Davis", DateTime.Parse("27/11/2013"));

            James.AddChildren(Emma);
            James.AddChildren(William);
            Emma.AddChildren(Olivia);

            Relative Benjamin = new Relative("Benjamin Taylor", DateTime.Parse("27/11/1978"));
            Relative Sophia = new Relative("Sophia Miller", DateTime.Parse("27/11/2004"));
            Relative Henry = new Relative("Henry Anderson", DateTime.Parse("27/11/2001"));
            Relative Ava = new Relative("Ava Wilson", DateTime.Parse("27/11/2014"));

            Benjamin.AddChildren(Sophia);
            Benjamin.AddChildren(Henry);
            Sophia.AddChildren(Ava);

            Relative Ethan = new Relative("Ethan Adams", DateTime.Parse("27/11/1923"));
            Relative Isabella = new Relative("Isabella Brooks", DateTime.Parse("27/11/2004"));
            Relative Matthew = new Relative("Matthew Clark", DateTime.Parse("27/11/2008"));
            Relative Amelia = new Relative("Amelia Evans", DateTime.Parse("27/11/2009"));
            Relative Daniel = new Relative("Daniel Garcia", DateTime.Parse("27/11/2004"));
            Relative Harper = new Relative("Harper Hall", DateTime.Parse("27/11/2004"));
            Relative Joseph = new Relative("Joseph Hernandez", DateTime.Parse("27/11/2006"));
            Relative Mia = new Relative("Mia Jackson", DateTime.Parse("27/11/2003"));

            Ethan.AddChildren(Isabella);
            Ethan.AddChildren(Matthew);
            Ethan.AddChildren(Amelia);

            Isabella.AddChildren(Daniel);
            Daniel.AddChildren(Harper);
            Joseph.AddChildren(Mia);

            #endregion

            #region

            FamilyTree relatives = new FamilyTree();
            relatives.Add(James);
            relatives.Add(Benjamin);
            relatives.Add(Ethan);

            //relatives.Add(Emma);
            //relatives.Add(William);
            //relatives.Add(Olivia);
            //relatives.Add(Sophia);
            //relatives.Add(Henry);
            //relatives.Add(Ava);
            //relatives.Add(Ethan);
            //relatives.Add(Isabella);
            //relatives.Add(Matthew);
            //relatives.Add(Amelia);
            //relatives.Add(Daniel);
            //relatives.Add(Harper);
            //relatives.Add(Joseph);
            //relatives.Add(Mia);

            #endregion

            Console.WriteLine("1 - вывести всіх родичів; 2 - Вивести родичів людіни; 3 - пошук за роком народження;");
            Console.Write("Меню: ");
            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    {
                        //вивести вих родичів!
                        foreach (var item in relatives)
                        {
                            item.PrintFamilyTree();
                            Console.WriteLine();
                        }
                        break;
                    }
                case "2":
                    {
                        //вивести родичів конкретної людини
                        Console.Write("Імя когог шукати: ");
                        string name = Console.ReadLine();
                        relatives[name].PrintFamilyTree();
                        break;
                    }
                case "3":
                    {
                        Console.Write("За яким роком шукати: ");
                        string yearskrin = Console.ReadLine();

                        // пошук по дати народження
                        DateTime skrinDate = DateTime.Parse($"1/1/{yearskrin}");
                        var res = relatives.SearchYearOfBirth(skrinDate);

                        Console.WriteLine("За цим роком народження:");
                        foreach (Relative item in res)
                        {
                            Console.WriteLine(" -" + item.Name);
                        }
                        break;
                    }
            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}
