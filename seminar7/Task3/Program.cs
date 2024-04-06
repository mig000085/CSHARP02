
// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d*/

void PrintConsonan2(string str)
{
    if (str.Length == 0) return;
    string vowels = "aouyie";
    if (char.IsAsciiLetter(str[0]) == true && !vowels.Contains(char.ToLower(str[0])))
    {
        Console.Write(str[0] + " ");
    }

    PrintConsonan2(str.Substring(1));

}






void PrintConsonan(string str, int count)
{
    if (count == str.Length) return;
    string vowels = "aouyie";
    if (char.IsAsciiLetter(str[count]) == true && !vowels.Contains(char.ToLower(str[count])))
    {
        Console.Write(str[count] + " ");
    }

    PrintConsonan(str, count + 1);

}
Console.WriteLine("Ввидите строку Латинскими буквами: ");
string userInput = Console.ReadLine();

PrintConsonan(userInput);
PrintConsonan2(userInput);
