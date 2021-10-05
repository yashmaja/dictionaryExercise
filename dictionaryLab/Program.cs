using System;
//using System.Collections;
using System.Collections.Generic;

namespace dictionaryLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();
            grades.Add("Yash", 80);
            grades.Add("Jillian", 95);
            grades.Add("Emma", 83);
            grades.Add("Ben", 93);
            grades.Add("Carole", 86);
            grades.Add("Mark", 68);
            grades.Add("Scott", 45);
            grades.Add("Dan", 75);
            grades.Add("Sunidhi", 99);
            grades.Add("Eko", 50);

            foreach(KeyValuePair<string, int> kvp in grades)
            {
                if (kvp.Value > 60)
                {
                    Console.WriteLine($"{kvp.Key} has {kvp.Value}% in the class and is passing");
                }
                else
                {
                    Console.WriteLine($"{kvp.Key} has {kvp.Value}% in the class and is failing.");
                }
            }
        }
    }
}
