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

        }
    }
}
