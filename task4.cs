using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uzunlug:");
            int uzunluq = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("en:");
            int en = Convert.ToInt32(Console.ReadLine());
            int perimetr = (uzunluq + en) * 2;
            Console.WriteLine("perimetr=" +perimetr);
            int sahe = uzunluq * en;
            Console.WriteLine("sahe="+sahe);
        }
    }
}
