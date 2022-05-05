using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.WriteLine("baslangic eded=");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("son eded=");
            number2 = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            {
                while(number1<=number2)
                {
                    sum = sum + number1;
                    number1++;

                }
            }
            Console.WriteLine(sum);
           
           
        }
    }
}