// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("enter number from 100 to 999: ");
string strnumb = Console.ReadLine();
int numb = int.Parse(strnumb);

int result = numb%100/10;

Console.WriteLine($"second number = {result}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("enter number : ");
string strnumber = Console.ReadLine();
int numb1 = int.Parse(strnumber);
int numb2 = strnumber.Length;

int count = 1;
// int i = Convert.ToInt32(Math.Pow(10, numb2-count));
int result1;

// int result = numb1%Convert.ToInt32(Math.Pow(10, numb2-count));
// int result1 = result%Convert.ToInt32(Math.Pow(10, numb2-(count+1)));
// int result2 = result1/Convert.ToInt32(Math.Pow(10, numb2-(count+2)));
// Console.WriteLine(result2);

while (count!=3)
{
    result1 = numb1%Convert.ToInt32(Math.Pow(10, numb2-count));
    numb1 = result1;
    count++;
}

Console.WriteLine(numb1/Convert.ToInt32(Math.Pow(10, numb2-count)));


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("enter number from 1 to 7: ");
string strnumber1 = Console.ReadLine();
int number = int.Parse(strnumber1);


if (number == 6 || number ==7) Console.WriteLine("Weekend!!!");

else if (number <1 || number >7) Console.WriteLine("incorrect input");

else Console.WriteLine("It's not the weekend");
