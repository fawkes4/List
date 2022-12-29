using System;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            
            list.Remove();

        }
    }

    //public class List<T>
    //{
    //    const int initialListSize = 2;
    //    T[] baseArray = new T[initialListSize];
    //    int arrayEndElement = -1;

    //    public T Get (int pos)
    //    {
    //        if (baseArray.Length < pos)
    //        {
    //            throw new IndexOutOfRangeException();
    //        }
    //        else if (baseArray[pos] == null)
    //        {
    //            throw new ArgumentNullException();
    //        }

    //        return baseArray[pos];
    //    }

    //    public void Insert (T input)
    //    {
    //        arrayEndElement++;

    //        if (baseArray.Length > arrayEndElement)
    //        {
    //            baseArray[arrayEndElement] = input;
    //        }
    //        //if array is full it shoud be increased an then add a new member to the end
    //        else
    //        {
    //            baseArray = GetIncreasedArray(arrayEndElement);
    //            baseArray[arrayEndElement] = input;
    //        }
    //    }
        
    //    // this method should increase the size of array
    //    public T[] GetIncreasedArray (int input)
    //    {
    //        T[] array = new T[input*2];
    //        baseArray.CopyTo(array, 0);

    //        return array;
    //    }
    //}
}
