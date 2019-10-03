using System;
using System.Linq;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            int maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);
                //Console.WriteLine("Please enter array element number " + (i + 1));
                //array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element number " + (i + 1));
                Console.Write(array[i] + "\n");
            }
            array[2] *= 10;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("element number " + (i + 1));
                Console.Write(array[i] + "\n");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine("Max value is: " + maxValue);

        }
    }
}
