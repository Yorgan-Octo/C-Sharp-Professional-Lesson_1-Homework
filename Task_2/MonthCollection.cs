using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class MonthCollection : ICollection //так як колекція не змінюется я вирішив що ICollection буде краще
    {
        Months[] months = new Months[12]
        {
            new Months(1, "Январь", 31),
            new Months(2, "Февраль", 29),
            new Months(3, "Март", 31),
            new Months(4, "Апрель", 30),
            new Months(5, "Май", 31),
            new Months(6, "Июнь", 30),
            new Months(7, "Июль", 31),
            new Months(8, "Август", 31),
            new Months(9, "Сентябрь", 30),
            new Months(10, "Октябрь", 31),
            new Months(11, "Ноябрь", 30),
            new Months(12, "Декабрь", 31)
        };
        public int Count => months.Length;
        public string this[int index]
        {
            get
            {
                if (index > 0 && index <= 12)
                    return months[index - 1].Name;
                else
                    return $"Ми не на марсі у нас немае {index} мічяця";
            }
        }
        public void CopyTo(Array array, int index)
        {
            var arr = array as object[];

            if (arr == null || index < 0)
                throw new ArgumentException("Expecting array to be object[]");

            for (int i = 0; i < array.Length; i++)
            {
                arr[index++] = months[i];
            }
        }
        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { return this; } }
        public IEnumerable SearchDaysInMonth(int day)
        {
            foreach (Months item in months)
            {
                if (day > 0 && item.AmountOfDays == day)
                {
                    yield return item;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return months.GetEnumerator();
        }
    }
}
