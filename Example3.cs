using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExaple
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<int> list = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter a Number{i + 1}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);
            }
            Console.WriteLine("List of Enter Numbers: ");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            // list end
            //Dictionary

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Number1");
            dic.Add(2, "Number2");
            dic.Add(3, "Number3");
            dic.Add(4, "Number4");

            for (int i = 0; i < dic.Count; i++)
            {
                KeyValuePair<int, string> pair = dic.ElementAt(i);
                Console.WriteLine($"Key:{pair.Key} Value:{pair.Value}");
            }
            // Dictionary ends
            //List Example
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.WriteLine("Priting even numbers: ");
            foreach (int num in even)
            {
                Console.Write($"{num},");
            }
            Console.WriteLine();
            Console.WriteLine("Priting odd numbers:");
            foreach (int num in odd)
            {
                Console.Write($"{num},");
            }
            Console.ReadLine();
        }
    }
}