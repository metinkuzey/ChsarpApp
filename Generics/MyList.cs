using System;
namespace Generics
{
    // WE CREATED OWN LIST CLASS
    public class MyList<T>
    {

        T[] items;
        // we want to use new key word for our list, we should create our list class constructor
        public MyList()
        {
            items = new T[0];
        }

        // We use T definition for use any data type. For exmp. int, bool, string ....
        public void Add(T item)
        {
            T[] tempArray = items;// we hold our exist array's member in temp array.
                                  // We create tem array without new key word.
                                  // Because we don't want to lose temp array reference address.
                                  // If we lose this address, we lose our exist list members.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}

