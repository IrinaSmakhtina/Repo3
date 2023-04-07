using System;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте массив из 3 строк");
            string[] array = new string[3];
            array[0] = Console.ReadLine();
            array[1] = Console.ReadLine();
            array[2] = Console.ReadLine();
            int size = CountStrings(array);
            if (size > 0)
            {
                string[] resultArray = new string[size];
                CopyStrings(array, resultArray);
                Console.WriteLine("Сформированный массив строк,длина которых меньше, либо равна 3 символа");
                PrintArray(resultArray);
            }
            else
            {
                Console.WriteLine("В заданном массиве нет строк, которые меньше, либо равны 3 символа");
            }
        }
        static int CountStrings(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    count++;
                }
            }
            return count;
        }
        static void CopyStrings(string[] array1, string[] array2)
        {
            int j = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <= 3)
                {
                    array2[j] = array1[i];
                    j++;
                }
            }
        }
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
