//Примеры создания массивов в C#

// int [] array = new int [4]; выделяется память на 4 элемента, заполнен нулями.
// int [] array = new int [4] { 5, 6, 7, 8 }; заполнен указанными элементами.
// int [] array = new int [] { 5, 6, 7, 8 }; заполнен указанными элементами.
// int[] array = { 5, 6, 7, 8 };



int[] array = { 5, 6, 7, 8 };

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(i + " : " + array[i]);
}
Console.WriteLine();

foreach (var item in array)
{
    Console.WriteLine(item);
}
Console.WriteLine();