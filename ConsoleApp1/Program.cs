using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating of an array
            //int[] array1 = { 1, 55, 99, 15, 10, -30, 87 };
            int[] array0 = Niz.CreateArray();
            // task 1:
            // Write a Function  for calculating the mean value of those elements of an array of integers that are divisible by 5.
            Console.WriteLine("\nTask 1\n");
            Console.WriteLine("Mean value of elements divisible by 5 = {0:0.##}", Niz.CalculateMeanDivisible(array0));

            // task 2:
            // Write a method  for finding the smallest and largest values of an array of integers.
            Console.WriteLine("\nTask 2\n");
            Console.WriteLine("The smallest element of the array: {0}", Niz.FindSmallestElement(array0));

            // task 3
            // Write a method for sorting an array in ascending order.
            Console.WriteLine("\nTask 3\n");
            int[] sortedArray = Niz.SortArrayAscending(array0);
            Console.WriteLine("Sorted array:");
            Niz.PrintArray(sortedArray);

            // task 4:
            // Write a method to combine two arrays into a third. All three arrays must be in ascending order
            Console.WriteLine("\nTask 4\n");
            Console.WriteLine("Create the first array - ");
            int[] array1 = Niz.CreateArray();
            Console.WriteLine("Create the second array - ");
            int[] array2 = Niz.CreateArray();

            Console.WriteLine("\nSorting arrays:");
            array1 = Niz.SortArrayAscending(array1);
            array2 = Niz.SortArrayAscending(array2);
            Console.WriteLine("Array1 after sorting:");
            Niz.PrintArray(array1);
            Console.WriteLine("Array2 after sorting:");
            Niz.PrintArray(array2);

            Console.WriteLine("\nCombining arrays:");
            int[] array3 = Niz.CombineArrays(array1, array2);
            Niz.PrintArray(array3);

            Console.WriteLine("\nCombinedArray after sorting:");
            array3 = Niz.SortArrayAscending(array3);
            Niz.PrintArray(array3);

            // task 4:
            // Switch-case
            Console.WriteLine("\nTask 5\n");
            var defaultColor = Console.BackgroundColor;
            string answer;
            do
            {
                Console.WriteLine("Choose a color for background or exit:");
                Console.WriteLine("\tBlack");
                Console.WriteLine("\tRed");
                Console.WriteLine("\tGreen");
                Console.WriteLine("\tBlue");
                Console.WriteLine("\tDark");
                Console.WriteLine("\tExit");
                answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "black":
                    case "dark":
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("Check");
                            break;
                        }
                    case "red":
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Check");
                            break;
                        }
                    case "green":
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Check");
                            break;
                        }
                    case "blue":
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Check");
                            break;
                        }
                    case "exit":
                        {
                            Console.BackgroundColor = defaultColor;
                            Console.WriteLine("Exiting...");
                            break;
                        }
                    default:
                        {
                            Console.BackgroundColor = defaultColor;
                            Console.WriteLine("Sorry, not implemented =(");
                            break;
                        }
                }    
            }
            while (answer != "exit");

            Console.ReadLine();
        }
    }
}
