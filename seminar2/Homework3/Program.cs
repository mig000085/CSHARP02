/*Задача 3: Напишите программу, которая принимает 
на вход целое число из отрезка [10, 99] и показывает 
наибольшую цифру числа.
Например:
40 => 4
96 => 9
72 => 7*/


int number = 78;
int firstdigit = number / 10;
int lastdigit = number % 10;

if (number < 10 || number > 99)
{
    Console.WriteLine("Число вне заданного отрезка");
}
else
{
    if (firstdigit > lastdigit)
    {
        Console.WriteLine(firstdigit);
    }
    else
    {
        Console.WriteLine(lastdigit);
    }
}



