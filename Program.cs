using System;

namespace dotnet_FindMax
{


    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size of array:");// Do dai cua mang 
                size = int.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }

            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);
        }
    }
}
//The shotert way using MAX() OR Linq liabry

/* using System.Linq;
Console.WriteLine("Enter the number of elements in the array:");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Enter the elements of the array:");

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int max = arr.Max();// using Max () instead.

Console.WriteLine($"The maximum value in the array is {max}.");
*/
