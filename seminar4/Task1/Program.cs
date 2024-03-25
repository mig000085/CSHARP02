// Задание 1. Совместная работа
// Семинар 4. Функции
// 20 мин
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// Console.WriteLine("hello!");
// string str = "2024";
// int num = Convent.ToInt32("str");

int[] CreateArrRnaInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max)
 
    


    return array;
}