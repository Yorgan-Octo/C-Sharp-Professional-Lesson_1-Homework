using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class DictionaryCollection : ICollection
    {
        private Element[] elements = new Element[0];

        public string this[int index]
        {
            get
            {
                return $"{elements[index].NameUA} - {elements[index].NameRU} - {elements[index].NameEN}";
            }
        }
        public int Count { get { return elements.Length; } }
        public void Add(string translUA, string translRU, string translEN)
        {
            Array.Resize(ref elements, elements.Length + 1);
            elements[elements.Length - 1] = new Element(translUA, translRU, translEN);
        }
        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(elements[i], j);
                j++;
            }
        }
        public bool IsSynchronized { get { return true; } }
        public object SyncRoot { get { return this; } }
        public string TranslationRU(string elemnt)
        {
            foreach (Element item in elements)
            {
                if (item.NameUA == elemnt)
                    return item.NameRU;
            }
            return null;
        }
        public string TranslationEN(string elemnt)
        {
            foreach (Element item in elements)
            {
                if (item.NameUA == elemnt)
                    return item.NameEN;
            }
            return null;
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)elements).GetEnumerator();
        }
    }
}
