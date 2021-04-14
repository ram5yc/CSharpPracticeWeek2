using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //04/14/2021//
            //Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
            string php = "PHP Tutorial";
            Console.WriteLine(php.Substring(1,2).Equals("HP") ? php.Remove(1,2) : php);



            //Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH".
            string ph = "PHP";
            //Console.WriteLine(ph.Substring(1,3).Equals("PHP") ? ph.Replace("PH") :ph);
            //Console.WriteLine(ph.Remove(3).Equals("PHP") ? ph.Replace("p", "h") :ph);
            Console.WriteLine(ph.Remove(2));



            //Write a C# program to find the largest and lowest values from three integer values. 
            int one, two, three;
            Console.WriteLine("Enter three numbers to find the lowest and highest: ");
            one = Convert.ToInt32(Console.ReadLine());
            two = Convert.ToInt32(Console.ReadLine());
            three = Convert.ToInt32(Console.ReadLine());

            //if (one < two && one < three)
            //{
            //    return
            //}
            Console.WriteLine("Largest: " + Math.Max(one, Math.Max(two,three)));
            Console.WriteLine("Smallest: " + Math.Min(one, Math.Min(two,three)));
        }
    }
}
