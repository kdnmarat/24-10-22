using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Niz
    {
        public static int GetNumberFromConsole()
        {
            int result;
            string entry = Console.ReadLine();
            while (!int.TryParse(entry, out result))
            {
                Console.Write("Please type a numeric value: ");
                entry = Console.ReadLine();
            };
            return result;
        }

        public static int[] CreateArray()
        {
            Console.WriteLine("Please specify the array length:");
            int length = GetNumberFromConsole();
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = GetNumberFromConsole();
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine("Printing all elements of the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element {i + 1}: {array[i],5}");
            }
        }

        public static float CalculateMeanDivisible(int[] array)
        {
            int sum = 0;
            int numberOfDivisibleElements = 0;
            foreach (int num in array)
            {
                if (num%5 == 0)
                {
                    numberOfDivisibleElements++;
                    sum = sum + num;
                }
            }
            float result = (float)sum / (float)numberOfDivisibleElements;
            return result;
        }

        public static int[] SortArrayAscending(int[] array)
        {
            int temp;
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static int FindSmallestElement(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int[] CombineArrays(int[] array1, int[] array2)
        {
            int totalLength = array1.Length + array2.Length;
            int[] resultArray = new int[totalLength];
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                resultArray[array1.Length+i] = array2[i];
            }
            return resultArray;
        }
    }
}
