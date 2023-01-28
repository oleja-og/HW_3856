// Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Enter numbers : ");
string strnumber1 = Console.ReadLine();
string strnumber2 = Console.ReadLine();
int number1 = Convert.ToInt32(strnumber1);
int number2 = Convert.ToInt32(strnumber2);

if (number1>number2) Console.WriteLine($"MAX = {number1} MIN = {number2}");

else 
Console.WriteLine($"MAX = {number2} MIN = {number1}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();

Console.WriteLine("Enter numbers : ");
string strnumb1 = Console.ReadLine();
string strnumb2 = Console.ReadLine();
string strnumb3 = Console.ReadLine();
int numb1 = Convert.ToInt32(strnumb1);
int numb2 = Convert.ToInt32(strnumb2);
int numb3 = Convert.ToInt32(strnumb3);
int max = numb1;

if (max<numb2) max=numb2;
if (max<numb3) max=numb3;

Console.WriteLine($"MAX = {max}");


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.WriteLine("Enter numbers : ");
string strnum = Console.ReadLine();
int num = Convert.ToInt32(strnum);

if (num%2==0) Console.WriteLine($"{num} четное");
else
Console.WriteLine($"{num} нечетное");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Enter number N : ");
string strnum1 = Console.ReadLine();
int num1= Convert.ToInt32(strnum1);
int count = 1;
Console.WriteLine("Numbers from 1 to N :");
while (count<=num1)
{
if (count%2==0) Console.Write($"{count}, ");
count+=1;
}
Console.WriteLine();

