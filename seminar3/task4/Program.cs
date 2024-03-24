// Задание 4*. Совместная работа
// [если позволит тайминг]
// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите трехзначное число");
int nunber = Convert.ToInt32(Console.ReadLine());

int[] result = new int[3];

for (int i = 0; i < result.Length; i++)
{
    result[i] = nunber % 10;
    nunber /= 10;
}

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i] + "  ");
}