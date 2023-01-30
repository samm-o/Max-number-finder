using System;
using System.Linq;

namespace Max_number_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a series of integers seperated by a comma: ");
            var input = Console.ReadLine();
            var numbers = input.Split(",");                    //Splits string input to string array
            int[] ints = numbers.Select(int.Parse).ToArray();   //Converts string array to int array
            int biggest = ints[0];                              //Stores first number into biggest

            for (int i = 1; i < ints.Length; i++)
            {
                if(ints[i] > biggest)                           //If 'i' index value in ints is bigger than "biggest"
                {
                    biggest = ints[i];                          //"biggest" becomes bigger number until largest number is reached
                }
            }
            Console.WriteLine(biggest);                         //Print "biggest"

        }
    }
}

