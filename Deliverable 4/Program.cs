/*
  Author: Joshua Yo
  Date: 2/8/2023
  Comments: This C# Console application code demonstrate the use 
            of arrays after getting input from users 
*/

using System;

namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the size of the array
            int n = 25;

            // Initialize an array of size n to store the Fibonacci numbers
            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            // Generate the Fibonacci sequence
            for (int i = 2; i < n; i++)
            {
                // The current number is the sum of the two previous numbers
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }

            // Display the Fibonacci sequence
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
        }
    }
}