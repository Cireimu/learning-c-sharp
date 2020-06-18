using System;
using System.Collections.Generic;

// Global namespace, DANGEROUS
namespace GradeBook
{
    // most developers only allow for one class per file
    // class Book
    // {

    // }
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ethan's Grade Book");
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);
            var done = false;

            while (!done)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    done = true;
                    continue;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                // this will catch anything that's run here
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

            }


            var stats = book.GetStatistics();
            //                     formating string, number with three places after the .
            //                                             ||
            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The Lowest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N3}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            // var in c# is implicit
            // cannot convert data types

            // var x = 34.1;
            // var y = 10.3;
            // var result = x + y;
            //   initializes a new array  size of array
            // double[]   ||         ||
            // var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };  //initialization method do not require specififed array size
            // when using a list in c# you have to describe what you're going to store in it
            // Lists are more dynamic than arrays
            // var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            // grades.Add(56.1);
            // count is a property, not a method
            // Instead use array initialization syntax
            // BAD SYNTAX DO NOT DO THIS IN C#
            // numbers[0] = 12.7;
            // numbers[1] = 29.0;
            // numbers[2] = 39.1;
            // numbers[3] = 41.1;
            // Console.WriteLine can take any number of parameters of any type, 
            // then prints it into the console
            // System.Console.WriteLine() is the same as below
            // System.Console.WriteLine(result);
            // Console.WriteLine(result);
        }
    }
}
