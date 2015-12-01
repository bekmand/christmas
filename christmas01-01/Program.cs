using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = 0;
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Christmas01-01.txt");

            foreach(char input in text)
            {
                if (input == '(')floor++; 
                else if (input == ')')floor--;
                Console.WriteLine(floor);
            }
            Console.WriteLine("Correct floor is: " + floor);

            Console.ReadLine();

            int basement = 0;
            int count = 0;

            string text2 = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Christmas01-01.txt");

            foreach (char input2 in text2)
            {
                if(basement == -1)
                {
                    Console.WriteLine("Santa Entered the basement at position: " + count);
                    Console.ReadLine();
                }
                else if (input2 == '(')basement++;
                else if (input2 == ')')basement--;

                count++;

                Console.WriteLine(basement);
            }



            Console.ReadLine();
        }
    }
}
