using System;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Insert(1);
            list.Insert(4);

            Console.WriteLine(list.Get(1));
        }
    }

    public class List<T>
    {
        T[] baseArray = new T[2];
        int arrayEndElement = -1;

        public T Get (int pos)
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

        public void Insert (T input)
        {
            arrayEndElement++;

            if (baseArray.Length > arrayEndElement)
            {
                baseArray[arrayEndElement] = input;
            }
            //if array is full it shoud be increased an then add a new member to the end
            else
            {
                IncreaseSize(arrayEndElement);
                baseArray[arrayEndElement] = input;
            }
        }
        
        // this method should increase the size of array
        public T[] IncreaseSize (int input)
        {
            return new T[input*2];
        }
    }
}
