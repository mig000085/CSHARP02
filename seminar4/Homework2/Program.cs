//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве


using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем размер массива
        int arraySize = 10; // Например, 10 элементов

        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем массив для хранения случайных трехзначных чисел
        int[] numbers = new int[arraySize];

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = random.Next(100, 1000); // Генерируем случайное трехзначное число
        }

        // Подсчитываем количество чётных чисел в массиве
        int evenCount = CountEvenNumbers(numbers);

        // Выводим результат
        Console.WriteLine("Массив случайных трехзначных чисел:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }

    // Метод для подсчета количества чётных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}