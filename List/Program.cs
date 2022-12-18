using System;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Insert(1,0);
            list.Insert(4, 1);
            list.Insert(5, 2);
            list.Insert(6);
            list.Insert(7);
            list.Insert(8);

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Get(2));
            Console.WriteLine(list.Get(3));
            Console.WriteLine(list.Get(4));
            Console.WriteLine(list.Get(5));
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
