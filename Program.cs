using System;

namespace GradeBook
{
    class Program
    {   
        //blah blah
        static void Main(string[] args)
        {

            //double[] numbers;  // just declaring
            // double[] numbers = new double[3];  // provide explicit size of array
            var numbers = new double[3];  // with implicit typing
            // double x;
            // x = x + 3.1; // this and above line with cause an error

            numbers[0] = 12.7; // unassigned local variable
            numbers[1] = 22.9;
            numbers[2] = 33.5;

            var result = numbers[0] + numbers[1] + numbers[2];
            System.Console.WriteLine(result);

            

       
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
