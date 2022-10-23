//Напишите программу, которая принимает на вход трёхзначное (целое) число и на выходе (в териминале) показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

int GetDigit(int number)
{
    int firstDigit = number / 10;
    int secontDigit = number / 10;
    int GetDigit = secontDigit % 10;
    return GetDigit;
}

Console.WriteLine(GetDigit(number));
