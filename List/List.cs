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
        int arrayEndElement = -1;

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

        // this method should increase the size of array
        public T[] GetIncreasedArray(int input) //i have to check this argument. there are ways input can be zero.
        {
            T[] array = new T[input * 2];
            baseArray.CopyTo(array, 0);

            return array;
        }
    }
}
