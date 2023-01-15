using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class List<T>
    {
        const int initialListSize = 2;
        T[] baseArray = new T[initialListSize];
        static int arrayEndElement = -1;
        public int Length
        {
            get { return arrayEndElement + 1; }
        }
        public T this[int i]
        {
            get { return baseArray[i]; }
            set { baseArray[i] = value; }
        }

        public T Get(int pos)
        {
            if (baseArray.Length < pos)
            {
                throw new IndexOutOfRangeException();
            }
            else if (pos > arrayEndElement)
            {
                throw new IndexOutOfRangeException();
            }

            return baseArray[pos];
        }

        public void Add(T input)
        {
            arrayEndElement++;

            if (baseArray.Length <= arrayEndElement)
            {
                baseArray = GetIncreasedArray(arrayEndElement);
            }

            baseArray[arrayEndElement] = input;
        }

        public void Insert(T value, int index)
        {
            arrayEndElement++;

            if (index < 0 || index > arrayEndElement)
            {
                throw new IndexOutOfRangeException();
            }
            if (baseArray.Length <= arrayEndElement)
            {
                baseArray = GetIncreasedArray(arrayEndElement);
            }

            /*loop starts at the end element that has value. Before it gets to the index we have to insert new values,
             * loop would shift all values by one index to the end of array.*/
            for (int i = arrayEndElement; i > index; i--)
            {
                baseArray[i] = baseArray[i - 1];
            }
            baseArray[index] = value;

        }
        //have to add all elements from IEnumerable to the list
        public void InsertAll(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (collection.Count() <= (baseArray.Length - arrayEndElement + 1))
            {
                baseArray = GetIncreasedArray(collection.Count());
            }

            foreach (T i in collection)
            {
                baseArray[arrayEndElement++] = i;
            }
        }

        // this method should increase the size of array
        public T[] GetIncreasedArray(int input) //i have to check this argument. there are ways input can be zero.
        {
            T[] array = new T[input * 2];
            baseArray.CopyTo(array, 0);

            return array;
        }

        public void Remove() // have to remove last element
        {
            if (arrayEndElement < 0)
            {
                throw new IndexOutOfRangeException();
            }

            arrayEndElement--;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > arrayEndElement)
            {
                throw new IndexOutOfRangeException();
            }

            arrayEndElement--;

            for (int i = index; i <= arrayEndElement; i++)
            {
                baseArray[i] = baseArray[i + 1];
            }
        }

        public void Clear()
        {
            arrayEndElement = -1;
        }
    }
}
