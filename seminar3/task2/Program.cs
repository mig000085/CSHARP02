﻿/*Задание 2. Работа в сессионных залах
Семинар 3. Массивы
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]
*/

int[] arr = new int[10] { 1, -5, 6, 5, 4, 8, 9, -3, 5, 10 };
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * -1;
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i] + " ");
}

