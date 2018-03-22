using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> myList = new List<object>();

            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");

            foreach(var entry in myList)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
            int sum = 0;
            foreach (var entry in myList)
            {
                if(entry is int) {
                    int en = (int)entry;
                    sum += en;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
