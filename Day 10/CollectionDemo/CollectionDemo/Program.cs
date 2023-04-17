using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            Console.WriteLine("\n\n***List***");
            foreach (object i in primeNumbers)
            {
                Console.WriteLine(i);
            }


            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine("\n\n***Stack***");
            foreach (object i in s1)
            {
                Console.WriteLine(i);
            }

            Queue q1 = new Queue();
            q1.Enqueue(1);

            ArrayList arrayList = new ArrayList();
            //Console.WriteLine(arrayList.Capacity);
            arrayList.Add(125);
            arrayList.Add(231);
            arrayList.Add(176);
            arrayList.Add(198);
            arrayList.Add(239);
            arrayList.Add(187);
            arrayList.Add(true);
            arrayList.Add(new Emp());
            //Console.WriteLine(arrayList.Capacity);
            Console.WriteLine("\n\n***ArrayList***");
            foreach (object i in arrayList)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n\n***SortedList***");
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }
    class Emp
    {

    }
}
