// Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("\nПеревёрнутый массив:");
        PrintArray(array);
    }

    // Метод для переворачивания массива
    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            // Обмен значениями
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            // Переход к следующим элементам
            start++;
            end--;
        }
    }

    // Метод для печати массива
    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}