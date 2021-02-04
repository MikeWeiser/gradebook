using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {   
        //blah blah
        static void Main(string[] args)
        {
            var book = new Book("Mike's Grade Book");  // invokes a constructor method
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            
            
            List<double> grades = new List<double>() {12.7, 10.3, 6.11, 4.1}; 
            grades.Add(56.1);

            var result = 0.0;
            foreach(var number in grades) // 'number' variable has to be typed correctly
            {
                result += number;
            }

            result /= grades.Count;
            System.Console.WriteLine($"The average grade is {result:N1}");



        }
    }
}
