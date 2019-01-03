using System;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> question1 = new List<int>() { 4, 8, 11, 45, 62 };
            List<int> results = new List<int>();

            Console.WriteLine("Please enter a number to divide each of the list items by:");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            foreach (int number in question1)
            {
                if (question1.Contains(number))
                {
                    Console.WriteLine(number / numberOne);
                }
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please do not divide by zero");
            return;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        finally
        {
            Console.WriteLine("Program will now end. GoodBye!");
            Console.ReadLine();
        }
 
        Console.ReadLine();
    }
}

