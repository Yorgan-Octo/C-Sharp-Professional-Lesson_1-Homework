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
            FamilyTree familyTree = new FamilyTree();

            familyTree.Add(new Relative(1, "Monika Brondo", DateTime.Now));
            familyTree["Monika Brondo"].descendants.Add(3);
            familyTree["Monika Brondo"].descendants.Add(4);

            familyTree.Add(new Relative(2, "Dmitr Brondo", DateTime.Now));
            familyTree["Dmitr Brondo"].descendants.Add(3);
            familyTree["Dmitr Brondo"].descendants.Add(4);

            familyTree.Add(new Relative(3, "Amin Brondo", DateTime.Now));
            familyTree["Amin Brondo"].ancestors.Add(1);
            familyTree["Amin Brondo"].ancestors.Add(2);

            familyTree.Add(new Relative(4, "Asim Brondo", DateTime.Now));
            familyTree["Asim Brondo"].ancestors.Add(1);
            familyTree["Asim Brondo"].ancestors.Add(2);

            foreach (var item in familyTree)
            {


                if (item.descendants.Count != 0)
                {
                Console.WriteLine(item.Name);


                    foreach (var item1 in item.descendants)
                    {

                        foreach (var item2 in familyTree)
                        {
                            if (item1 == item2.Id)
                            {
                                Console.WriteLine("    " + item2.Name);
                            }
                        }

                    }
                }

            }
            Console.ReadKey();
        }
    }
}
