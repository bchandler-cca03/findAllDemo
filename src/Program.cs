using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            lst.Add(20);
            lst.Add(30);
            lst.Add(300);
            lst.Add(400);
            lst.Add(9);
            lst.Add(19);
            lst.Add(789);
            lst.Add(45);
            lst.Add(125);
            lst.Add(99);

            foreach (var r in lst)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
