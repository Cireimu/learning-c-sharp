using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        // explicit constructor method, needs to have same name as class
        // public means code outside this class can have access to this method
        // public can be used with methods and fields like our grades field
        // private means that code can only be used within the same class
        public Book(string name)
        {
            grades = new List<double>();
            // this is a implicit variable to point to 
            // the current object being operated on
            this.name = name;
        }
        // instance member of class book, means that any Book object created has access to all the methods
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                // if (number > highGrade)
                // {
                //     highGrade = number;
                // }
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;
            //                     formating string, number with three places after the .
            //                                             ||
            Console.WriteLine($"The Lowest grade is {lowGrade}");
            Console.WriteLine($"The Lowest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N3}");
        }
        List<double> grades;
        private string name;
    }
}