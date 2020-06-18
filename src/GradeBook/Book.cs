using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        // explicit constructor method, needs to have same name as class
        // public means code outside this class can have access to this method
        // public can be used with methods and fields like our grades field
        // private means that code can only be used within the same class
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        // instance member of class book, means that any Book object created has access to all the methods
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
        public List<double> grades;

        // It is convention that when you have a public member, it's name is uppercase
        public string Name;
    }
}