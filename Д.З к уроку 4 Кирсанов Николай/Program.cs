﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.З_к_уроку_4_Кирсанов_Николай_задание_1                                           //    1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
{                                                                                 //      значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать 
    class Program                                                                // программу, позволяющую найти и вывести количество пар элементов массива, в которых
    {

        static int GetNumberOfPairs(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }

        static void Main(string[] args)
        {
            const int arrayLength = 20;
            int[] myArray = new int[arrayLength];
            Random random = new Random();
            int result;

            Console.WriteLine("Вас приветствует программа подсчёта пар элементов, в которых хотя бы одно число делится на 3.");
            Console.Write("\nВ следующем массиве [ ");
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = random.Next(-10000, 10001);
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine("\b\b ]\n");

            result = GetNumberOfPairs(myArray, arrayLength);

            Console.WriteLine($"Количество пар: {result}");

            Console.ReadKey();
        }






    }
}
