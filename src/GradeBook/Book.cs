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
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                case 'F':
                    AddGrade(50);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            while (index < grades.Count)
            {

                if (grades[index] == 42.1)
                {
                    //  stops the loop early, then jumps to line 56
                    // break;

                    // takes us to the next itteration of the loop
                    // continue;

                    // using a identifier word you can make the loop jump to a certain place
                    // goto done;
                }
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                index += 1;
            }

            // for(var index = 0; index < grades.Count; index += 1)
            // {
            // 
            // }
            result.Average /= grades.Count;

            return result;
        }
        public List<double> grades;

        // It is convention that when you have a public member, it's name is uppercase
        public string Name;
    }
}