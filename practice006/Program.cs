// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

string[] EnterNumbers()
{
    Console.WriteLine(" Enter numbers : ");
    string array = Console.ReadLine();
    string[] numbers = array.Split(" ");
   
    return numbers;
}


int Possitive(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.Parse(array[i])>0) count++;
        else count=count;
    }
    return count;
}


void task1()
{
    string[] number = EnterNumbers();
    Console.WriteLine(string.Join(",",number));
   int count = Possitive(number);
   Console.WriteLine($"count = {count}");
}

task1();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Enternumber()
{
    Console.WriteLine(" Enter number : ");
    double number = double.Parse(Console.ReadLine());
    return number;
}


void task2()
{
    double numberB1 = Enternumber();
    double numberK1 = Enternumber();
    double numberB2 = Enternumber();
    double numberK2 = Enternumber();
    
    Console.WriteLine($"numberB1 = {numberB1}, numberk1 = {numberK1}, numberB2 = {numberB2}, numberK2 = {numberK2}");

    double resultx = methodX(numberB1, numberK1, numberB2, numberK2);
     Console.WriteLine($"{resultx}");
    double resulty = methodY(numberB1, numberK1, numberB2, numberK2);
     Console.WriteLine($"{resulty}");
}

double methodX(double numberB1, double numberK1, double numberB2, double numberK2)
{
   double resultx = Math.Abs((numberB1 - numberB2))/(numberK1 - numberK2);   
   return resultx;
}


double methodY(double numberB1, double numberK1, double numberB2, double numberK2)
{
   double resultx = methodX(numberB1, numberK1, numberB2, numberK2);
   double resulty = numberK2*resultx+ numberB2;
   return resulty;
}




task2();



// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

int Enternumber()
{
    Console.WriteLine(" Enter number : ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Fibonacci(int n)
{
   if (n == 0 || n == 1) return n;
   
   return Fibonacci(n - 1) + Fibonacci(n - 2);

}

int[] EnterFibonacci(int n)
{
   int[] result= new int[n];
   for (int i = 0; i < n; i++)
   {
      result[i] = Fibonacci(i);
   }
   return result;
}


void tusk3()
{
   int n = Enternumber();
   int[] array = EnterFibonacci(n);
   Console.WriteLine(string.Join(" ",array));
   
}

tusk3();