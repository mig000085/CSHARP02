// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
//[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

char[] chars = { 'a', 'b,' 'c', 'd' };
string strResuit = string.Empty;

for (int i = 0; i < chars.Length; i++)
{
    strResuit += chars[i]; // c#
    //strResuit = strResuit + chars[i]; jaua
}
Console.whileLine(strResuit);
