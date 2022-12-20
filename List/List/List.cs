using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class List<T>
    {
        const int initialListSize = 2;
        T[] baseArray = new T[initialListSize];
        static int arrayEndElement = -1;
        public int Length 
        {
            get { return arrayEndElement + 1; } 
        } 

        public T Get(int pos)
        {
            if (baseArray.Length < pos)
            {
                throw new IndexOutOfRangeException();
            }
            else if (baseArray[pos] == null)
            {
                throw new ArgumentNullException();
            }
            else if (pos > arrayEndElement)
            {
                throw new IndexOutOfRangeException();
            }

            return baseArray[pos];
        }

        public void Insert(T input)
        {
            arrayEndElement++;

            if (baseArray.Length > arrayEndElement)
            {
                baseArray[arrayEndElement] = input;
            }
            //if array is full it shoud be increased an then add a new member to the end
            else
            {
                baseArray = GetIncreasedArray(arrayEndElement);
                baseArray[arrayEndElement] = input;
            }
        }

        public void Insert(T value, int index)
        {
            arrayEndElement++;

            if (baseArray.Length > arrayEndElement && index >= 0 && index <= arrayEndElement)
            {
                /*loop starts at the end element that has value. Before it gets to the index we have to insert new values,
                             * loop would shift all values by one index to the end of array.*/
                for (int i = arrayEndElement; i > index; i--)
                {
                    baseArray[i] = baseArray[i - 1];
                }
                baseArray[index] = value;
            }
            else if (index < 0 || index > arrayEndElement)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                baseArray = GetIncreasedArray(arrayEndElement);

                for (int i = arrayEndElement; i > index; i--)
                {
                    baseArray[i] = baseArray[i - 1];
                }
                baseArray[index] = value;
            }
        }
        //have to add all elements from IEnumerable to the list
        public void InsertAll(IEnumerable<T> collection)
        {
            if (collection.Count() > (baseArray.Length - arrayEndElement + 1))
            {
                foreach (T i in collection)
                {
                    baseArray[arrayEndElement++] = i;
                }
            }
            else if (collection == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                baseArray = GetIncreasedArray(collection.Count());

                foreach (T i in collection)
                {
                    baseArray[arrayEndElement++] = i;
                }
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
            arrayEndElement--;
        }

        public void RemoveAt(int index)
        {
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
