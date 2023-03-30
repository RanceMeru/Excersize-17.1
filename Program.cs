using System;

namespace Excersize_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //17
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the movie rating");
            //The whole thing need to be true or none of it is true 
            //&& will take precedence will come first in the arguement/ condition
            char rating = char.Parse(Console.ReadLine());
            if (age <= 12 || age >= 55 && rating == 'G')
            {
                Console.WriteLine("Discount applies");
            }
            else
            {//example input 15 and G then this code will execute because age>=55 && rating == 'G'are grouped first
                Console.WriteLine(" The Discount does not apply here bucko");
            }
        }
    }
}
