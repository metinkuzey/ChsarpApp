using System;

namespace ChsarpTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 50;
            Console.WriteLine(number1); // numbeer1 = 20 because int variables hold the value

            int[] numbers1 = new int[] {10,20,30,40};
            int[] numbers2 = new int[] {90,80,70,60};
            numbers1 = numbers2;
            numbers2[3] = 127;
            Console.WriteLine(numbers1[3]);
            // result is 127, because array types variable hold the reference address
            // of value, so if there is a process of two array equalization, both arrays have the same address
            // and if we change second array any member value, in the same index of first array memmber value take the same value.

            /*
             
             int, double, bool ..... primitive value type

             BUT !!!!

            Arrays, Classes, Abstract Class, Interface .... reference type

            So if a variable is reference type,
            you should that this variable does not hold value,
            it holds reference address.
 
             
             */

        }
    }
}
