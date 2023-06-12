using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class FamilyTree : IList<Relative>
    {

        Relative[] relatives = new Relative[0];

        public int Count { get { return relatives.Length; } }


        public Relative this[int index]
        {
            get { return relatives[index]; }
            set { relatives[index] = value; }
        }
        public Relative this[string name]
        {
            get 
            {
                foreach (var item in relatives)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }

                return null;
            }
            
        }



        public void Add(Relative obj)
        {
            Array.Resize(ref relatives, relatives.Length + 1);
            relatives[relatives.Length - 1] = obj;
        }
        public void Clear()
        {
            relatives = new Relative[0];
        }
        public bool Contains(Relative value)
        {
            foreach (var item in relatives)
            {
                if (item.Name == value.Name)
                    return true;
            }

            return false;
        }
        public int IndexOf(Relative value)
        {
            for (int i = 0; i < Count; i++)
                if (relatives[i].Name == value.Name)
                    return i;

            return -1;
        }
        public void Insert(int index, Relative value)
        {
            if ((index >= 0) && (index < Count))
                relatives[index] = value;
        }



        public void CopyTo(Relative[] array, int arrayIndex)
        {

        }
        // Сводка:
        //     Удаляет первое вхождение указанного объекта из коллекции System.Collections.IList.
        public bool Remove(Relative value)
        {
            return false;
        }
        // Сводка:
        //     Удаляет элемент System.Collections.IList, расположенный по указанному индексу.
        public void RemoveAt(int index)
        {

        }




        public bool IsFixedSize
        {
            get { return false; }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public bool IsSynchronized
        {
            get { return false; }
        }
        public object SyncRoot
        {
            get { return null; }
        }




        public IEnumerable SearchYearOfBirth(DateTime year)
        {
            List<Relative> res = new List<Relative>();
            foreach (var item in relatives)
            {
                item.SearchYear(year, ref res);
            }


            return res;
        }




        public IEnumerator<Relative> GetEnumerator()
        {
            return ((IEnumerable<Relative>)relatives).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<Relative>).GetEnumerator();
        }


    }
}
