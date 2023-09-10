using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(100);
            myList.Add(1000);
            myList.Add(10000);
            Console.WriteLine(myList.Count);
        }
    }


    class MyList<T>
    {

        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }


        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_tempArray.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count { get { return _array.Length; } }

    }
}
