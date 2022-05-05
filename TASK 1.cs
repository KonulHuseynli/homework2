using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 28;
            if(a%3==0 && a%7==0)
            {
                a++;
                Console.WriteLine("eded 3 e ve 7 e bolunur");

            }
            else
            {
                Console.WriteLine("bolunmur");
            }
        }
    }
}
