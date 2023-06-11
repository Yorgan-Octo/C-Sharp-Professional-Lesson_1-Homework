using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class FamilyTree : IList
    {

        Relative[] relatives = new Relative[0];

        public int Count { get { return relatives.Length; } }


        public object this[int index]
        {
            get { return relatives[index]; }
            set { relatives[index] = value as Relative; }
        }

        public int Add(object obj)
        {
            if (obj is Relative)
            {
                Relative newEle = (Relative)obj;

                Array.Resize(ref relatives, relatives.Length + 1);
                relatives[relatives.Length - 1] = newEle;
                return relatives.Length -1;
            }

            return -1;
        }
        public void Clear()
        {
            relatives = new Relative[0];
        }
        public bool Contains(object value)
        {
            if (value is Relative)
            {
                Relative ele = (Relative)value;

                foreach (var item in relatives)
                {
                    if (item.Name == ele.Name)
                        return true;

                }
            }
            return false;
        }
        public int IndexOf(object value)
        {
            if (value is Relative)
            {
                Relative relative = (Relative)value;

                for (int i = 0; i < Count; i++)
                    if (relatives[i].Name == relative.Name)
                        return i;
            }
            return -1;
        }
        public void Insert(int index, object value)
        {
            Relative rel = value as Relative;

            if ((index >= 0) && (index < Count))
            {
                relatives[index] = rel;
            }
        }



        public void CopyTo(Array array, int arrayIndex)
        {

        }

        //
        // Сводка:
        //     Удаляет первое вхождение указанного объекта из коллекции System.Collections.IList.
        //
        // Параметры:
        //   value:
        //     Объект, который необходимо удалить из коллекции System.Collections.IList.
        //
        // Исключения:
        //   T:System.NotSupportedException:
        //     Объект System.Collections.IList доступен только для чтения. или - System.Collections.IList
        //     имеет фиксированный размер.
        public void Remove(object value)
        {

        }

        //
        // Сводка:
        //     Удаляет элемент System.Collections.IList, расположенный по указанному индексу.
        //
        // Параметры:
        //   index:
        //     Отсчитываемый от нуля индекс удаляемого элемента.
        //
        // Исключения:
        //   T:System.ArgumentOutOfRangeException:
        //     index не является допустимым индексом в System.Collections.IList.
        //
        //   T:System.NotSupportedException:
        //     Объект System.Collections.IList доступен только для чтения. или - System.Collections.IList
        //     имеет фиксированный размер.
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
        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in relatives)
            {
                yield return item;
            }
        }

    }
}
