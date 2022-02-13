using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] gpa = { 3.42, 3.12, 3.11, 3.54, 3.57, 3.61, };

            Console.WriteLine("Array of GPA");
            for (int i = 0; i < gpa.Length; i++)
            {
                Console.WriteLine($"{i+1} element of array contains {gpa[i]} GPA");
            }

            List<string> names = new List<string>()
            {
                "Ahmed", "Ali" ,"Musa","Rameez",
                "Rizwan","Hamza","Saad","Aslam"
            };
            List<string> colors = new List<string>()
            {
                "Blue", "Black" ,"White","Cyan",
                "Red"
            };

            Console.WriteLine("\n\nList of Names");
            foreach (var item1 in names)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("\n\nList of Colors");
            foreach (var item2 in colors)
            {
                Console.WriteLine(item2);
            }
        }
    }
}

/*
 * Question :
1. Create an array of your GPAs (double)
2. Use for loop to print
3. Create a list of strings with names (Sibling) use method 1 to add values
4. 
Create a list of strings with colors use method 2 to add values
5. User for each loop to print List of Names and Colors */