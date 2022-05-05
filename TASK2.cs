using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int point = Int32.Parse(input);
            Console.WriteLine("POINT="+point);
         

            {
                if (point >= 91 && point <= 100)
                {
                    Console.WriteLine("A");
                }
                else if (point >= 81 && point <= 90)
                {
                    Console.WriteLine("B");
                   
                }
                else if (point >= 71 && point <= 80)
                {

                    Console.WriteLine("C");
                }
                else if (point >= 61 && point <= 70)
                {
                    Console.WriteLine("D");
                }
                else if (point >= 51 && point <= 60)
                {
                    Console.WriteLine("E");
                }
                else if (point < 51)
                {
                    Console.WriteLine("KESR");
                }

                
            }
          

        }
    }
}