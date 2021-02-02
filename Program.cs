using System;

namespace GradeBook
{
    class Program
    {   
        //blah blah
        static void Main(string[] args)
        {

            double x = 34.1;
            double y = 77.9;

            double result = x + y;

            Console.WriteLine(result);
       
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
