﻿using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(Grade(grade));
        }
        static string Grade(double grade) {
            string result = null;
            if (grade>=2.00 && grade<3)
            {
                result = "Fail";
            }
            else if (grade>=3&&grade<3.50)
            {
                result = "Poor";
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                result = "Good";
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                result = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6)
            {
                result = "Excellent";
            }
            return result;
        }
    }
}
