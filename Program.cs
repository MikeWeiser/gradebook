using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {   
        //blah blah
        static void Main(string[] args)
        {
            
            // dont forget system namespace for a dynamic List, also requires 1 Type Argument
            List<double> grades = new List<double>() {12.7, 10.3, 6.11, 4.1}; 
            grades.Add(56.1);

            var result = 0.0;
            // var average = 0.0;
            
            foreach(var number in grades) // 'number' variable has to be typed correctly
            {
                result += number;
            }

            result /= grades.Count;

            System.Console.WriteLine($"The average grade is {result:N1}");

       
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello dude");
            }

        }
    }
}
