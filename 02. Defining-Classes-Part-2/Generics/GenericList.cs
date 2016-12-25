using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericList<T> where T : IComparable
    {
        const int DefaultCapacity = 4;

        private T[] elementsList;
        private int elementsCount;

        public GenericList(int capacity)
        {
            elementsList = new T[capacity];
            elementsCount = 0;
        }

        public GenericList() : this(DefaultCapacity) { }

        public int ElementsCount
        {
            get
            {
                return elementsCount;
            }
        }

        public void Add(T element)
        {
            Insert(elementsCount, element);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= elementsCount)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
            }

            for (int i = index; i < elementsCount; i++)
            {
                elementsList[i] = elementsList[i + 1];
            }

            elementsList[elementsCount - 1] = default(T);
            elementsCount--;
        }

        // access element
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= elementsCount)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
                }

                return elementsList[index];
            }

            set
            {
                if (index < 0 || index >= elementsCount)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
                }

                elementsList[index] = value;
            }
        }

        // insert element
        public void Insert(int index, T element)
        {
            if (index < 0 || index > elementsCount)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
            }

            T[] extendedList = elementsList;
            if (elementsCount + 1 == elementsList.Length)
            {
                // create list of double size
                extendedList = new T[elementsList.Length * 2];
            }

            Array.Copy(elementsList, extendedList, index);
            elementsCount++;
            Array.Copy(elementsList, index, extendedList, index + 1, elementsCount - index - 1);
            extendedList[index] = element;
            elementsList = extendedList;
        }

        // find element by value
        public int IndexOf(T element)
        {
            for (int i = 0; i < elementsList.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(element, elementsList[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            elementsList = new T[DefaultCapacity];
            elementsCount = 0;
        }

        public bool Contains(T element)
        {
            int index = IndexOf(element);
            bool found = index != -1;
            return found;
        }

        public T Max()
        {
            T max = elementsList[0];
            for (int i = 1; i < elementsCount; i++)
            {
                if (elementsList[i].CompareTo(max) > 0)
                {
                    max = elementsList[i];
                }
            }

            return max;
        }

        public T Min()
        {
            T min = elementsList[0];
            for (int i = 1; i < elementsCount; i++)
            {
                if (elementsList[i].CompareTo(min) < 0)
                {
                    min = elementsList[i];
                }
            }

            return min;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in elementsList)
            {
                sb.AppendLine(element != null ? element.ToString() : "empty");
            }

            return sb.ToString();
        }
    }
}
