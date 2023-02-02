// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Введите 5ти значное число : ");
string number = Console.ReadLine();
int num = int.Parse(number);
int num1 = num/10000;
int num5 = num%10;
int num2 = num/1000%10;
int num4 = num/10%10;

if (num1==num5 && num2==num4) Console.WriteLine($"{num} - палиндромом");
else Console.WriteLine($"{num} - не является палиндромом");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Enter number X:");
double numX = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Y:");
double numY = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number z:");
double numZ = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number X:");
double num1X = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Y:");
double num1Y = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number Z:");
double num1Z = double.Parse(Console.ReadLine());


double result = Math.Sqrt(Math.Pow((num1X - numX),2) + Math.Pow((num1Y - numY),2)+Math.Pow((num1Z - numZ),2));

Console.WriteLine(Math.Round(result, 2));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.WriteLine("Enter number X:");
int numb = int.Parse(Console.ReadLine());
int count = 1;
while (count <= numb)
{
    Console.WriteLine($"{count} в степени 3 = {Math.Pow(count,3)} ");
    count+=1;
}