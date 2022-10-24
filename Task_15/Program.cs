//Напишите программу, которая принимает на вход (целую) цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число, обозначающее день недели");
int day = int.Parse(Console.ReadLine()!);

if (day > 0 && day < 8)
{
    if (multiplicity(day))
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
else
{
    Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}

bool multiplicity(int day)
{
    return day == 7 || day == 6;
}



