using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Relative
    {

        public int Id { get; }
        public string Name { get; }
        public DateTime DateOfBirth { get; }

        public List<int> ancestors = new List<int>();
        public List<int> descendants = new List<int>();

        public Relative(int id, string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Id = id;
        }



    }
}
