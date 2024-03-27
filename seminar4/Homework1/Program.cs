//Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


using System;

class Program
{


    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечётная.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }

    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        foreach (char digit in number.ToString())
        {
            sum += int.Parse(digit.ToString());
        }
        return sum % 2 == 0;
    }
}    