using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> myList = new MyList<string>();
            myList.Add("Metin");
            Console.WriteLine("Length of mylist: " + myList.Length);
            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
            myList.Add("Kuzey");
            Console.WriteLine("Length of mylist: " + myList.Length);
            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }

            MyList<int> mylist1 = new MyList<int>();
            mylist1.Add(15);
            mylist1.Add(25);
            Console.WriteLine("Length of mylist1: " + mylist1.Length);
            foreach (var item in mylist1.Items)
            {
                Console.WriteLine(item);
            }
            mylist1.Add(45);
            mylist1.Add(56);
            Console.WriteLine("Length of mylist1: " + mylist1.Length);
            foreach (var item in mylist1.Items)
            {
                Console.WriteLine(item);
            }





        }
    }
}

