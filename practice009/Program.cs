// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



void PrintNumber(int i)
{
    Console.Write(i +" ");
    if(i>1)
    {
        PrintNumber(i-1);
    }
    
}


int EnterNumbers(string numberName)
{
    Console.Write($" Enter number {numberName} :");
    int number = int.Parse(Console.ReadLine());
    return number;
}


void Task64()
{
    int number = EnterNumbers("N");
    PrintNumber(number);
    Console.WriteLine();
}

// Task64();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SummNumbers(int[] array, int i=0)
{
    if (i >= array.Length)
    {
        return 0;
    }
    return array[i]+SummNumbers(array, i+1);
}


int[] EnterArray(int number1, int number2)
{
    int[] array = new int[(number2 - number1)+1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (number1)+i;
    }
    return array;
}



void Task66()
{
    int number1 = EnterNumbers("M");
    int number2 = EnterNumbers("N");
    int[] array = EnterArray(number1, number2);
    Console.WriteLine(string.Join(",", array));
    int summ = SummNumbers(array);
    Console.WriteLine($"Сумма всех элементво = {summ}");
}


// Task66();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// m = 0     n+1
// m>0, n=0  A(m-1,1)
// m>0, n>0  A(m-1,A(m,n-1)
double Akkerman(double m, double n)
{
    if (m == 0) return n+1;
    else if (m>0 && n==0) return Akkerman(m-1,1);
    else if (m>0&& n>0) return Akkerman(m-1,Akkerman(m,n-1));

    return 0;
}

void Task68()
{
    double number1 = Math.Abs(EnterNumbers("M"));
    double number2 = Math.Abs(EnterNumbers("N"));
    // int[] array = EnterArray(number1, number2);
    // Console.WriteLine(string.Join(",", array));
    // int summ = SummNumbers(array);
    Console.WriteLine($"{number1} {number2}");
    double result = Akkerman(number1,number2);
    Console.WriteLine(result);
}


Task68();