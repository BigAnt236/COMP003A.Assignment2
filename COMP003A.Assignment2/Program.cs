/*
 * Author: Anthony Alvarez
 * Course: COMP-003A
 * Purpose: Week 2 Assignment
 */


namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            string firstName = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string inputeAge = Console.ReadLine();
            
            int yearBorn = 2024 - Convert.ToInt32(inputeAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
        }
    }
}
