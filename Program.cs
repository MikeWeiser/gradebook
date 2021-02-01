using System;

namespace GradeBook
{
    class Program
    {   
        //blah blah
        static void Main(string[] args)
        {
            //string concatentation:
            //Console.WriteLine("Hello" + args[0] + "!");

            //string interpolation:
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
