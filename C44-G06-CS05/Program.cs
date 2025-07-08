using System.ComponentModel;
using System.Drawing;

namespace C44_G06_CS05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - .Write a program that prints an identity matrix using for loop, in other
            //words takes a value n from the user and shows the identity table of size n * 
            //n.

            Console.Write("Enter the size of the identity matrix (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nIdentity matrix of size {n}x{n}: ");
            for (int i = 0; i < n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }

            //2 - Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = new int[]
            {
                1, 7, 8, 4, 2, 5
            };
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine($"\nThe Sum of all elements in the array: {sum}");

            //3 - Write a program in C# Sharp to merge two arrays of the same size sorted in
            //ascending order.
            int[] arr1 = new int[] { 1, 3, 5, 7 };
            int[] arr2 = new int[] { 2, 4, 6, 8 };
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                mergedArray[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                mergedArray[arr1.Length + i] = arr2[i];
            }
            Array.Sort(mergedArray);
            Console.WriteLine("\nMerged and sorted array: ");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }

            //4 - Write a program in C# Sharp to find maximum and minimum element in an
            //array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };

            int[] numbers = new int[] { 2, 4, 2, 6, 6, 1, 8, 9, 10, 30, 76, 59, 58 };
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine($"\nMaximum element in the array: {max}");
            Console.WriteLine($"Minimum element in the array: {min}");

            //5 - Write a program in C# Sharp to find the second largest element in an
            //array.
            int[] arr3 = new int[] { 12, 35, 1, 10, 34,36, 1 };
            int first = arr3[0];
            int second = arr3[0];
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] > first)
                {
                    second = first;
                    first = arr3[i];
                }
                else if (arr3[i] > second && arr3[i] != first)
                {
                    second = arr3[i];
                }
            }
            Console.WriteLine($"\nThe Second largest element in the array: { second} ");

        }
    }
}
