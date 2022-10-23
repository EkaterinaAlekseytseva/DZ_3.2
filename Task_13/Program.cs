//Напишите программу, которая выводит третью цифру заданного (целого) числа или сообщает (на консоле), что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int anyNumber = int.Parse(Console.ReadLine()!);

string anyNumberText = Convert.ToString(anyNumber);

if (anyNumberText.Length > 2)
{
    Console.WriteLine("третья цифра " + anyNumberText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
