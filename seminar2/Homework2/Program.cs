﻿/*Задача 2: Напишите программу, которая принимает 
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка.

Например
2, 3 => 1
-5, 3 => 2
-3, -2 => 3
4, -2 => 4*/

int x = 2;
int y = -3;

if (x > 0 && y > 0)
{
    System.Console.WriteLine("1");
}
else
{

}
if (x < 0 && y < 0)
{
    System.Console.WriteLine("3");
}
else
{

}
if (x < 0 && y > 0)
{
    System.Console.WriteLine("2");
}
else
{

}
if (x > 0 && y < 0)
{
    System.Console.WriteLine("4");
}
else
{

}