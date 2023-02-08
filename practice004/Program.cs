// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int NumberPow(int number1, int number2=1)
{
    int result = number1;
    for( int i=1; i<number2; i++)
    {
       result = result*number1;
    }   
    return result;
}



Console.WriteLine("Enter number :");
string strnumber1 = Console.ReadLine();
int number1 = int.Parse(strnumber1);

Console.WriteLine("Enter number :");
string strnumber2 = Console.ReadLine();
int number2 = int.Parse(strnumber2);

Console.WriteLine($"{number1}**{number2} = {NumberPow(number1,number2)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int NumberSum(int numb)
{
    numb = Math.Abs(numb);
    string strnumb = numb.ToString();
    int sumnumb=0;
    for(int i = 0; i < strnumb.Length; i++)
    {
        sumnumb +=  numb%10;
        numb = numb/10;
    }
    return sumnumb;
}

Console.WriteLine("Enter number :");
string strnumb = Console.ReadLine();
int numb = int.Parse(strnumb);


Console.WriteLine($"Summa numbers = {NumberSum(numb)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void NumberRandom(int[] myArray)
{
    
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(0,10);
    }
}


void NumberPrint(int[] myArray)
{
    Console.WriteLine("[{0}]", string.Join(", ", myArray));   
}

Console.WriteLine("Enter number :");
string strnumb1 = Console.ReadLine();
int numb1 = int.Parse(strnumb1);
int [] myArray = new int[numb1];
NumberRandom(myArray);
NumberPrint(myArray);