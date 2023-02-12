// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] MassiveLength()
{
    int[] array = new int[new Random().Next(3,10)];
    return array;
}

int[] MassiveFilling(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100,1000);
    }
    return myArray;
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) 
        {
            count++;
        }
        else count=count;
    }
    return count;
}

void PrintPositive(int count)
{
    Console.WriteLine(count);

}

void Main()
{
    int[] array = MassiveLength();    // Создает пустой массив рандомной величины от 3 до 10
    Console.WriteLine(string.Join(",",array));
    int[] myarray= MassiveFilling(array); // Заполняет массив трехзначными числами
    Console.WriteLine(string.Join(",",myarray));
    int count = PositiveNumbers(myarray); // Находит количество положительных чисел
    PrintPositive(count);                 // выводит на экран количество положительных
}

Main();


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] MassiveLength()
{
    int[] array = new int[new Random().Next(0,10)];
    return array;
}

int[] MassiveFilling(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-10,11);
    }
    return myArray;
}


int MassiveSumm(int[] myArray)
{
    int result = 0;
    for (int i = 1; i < myArray.Length; i+=2)
    {
        result += myArray[i];
    }
    return result;
}


void PrintSumm(int result)
{
    Console.WriteLine(result);

}

void Main()
{
    int[] array = MassiveLength();    // Создает пустой массив рандомной величины от 3 до 10
    Console.WriteLine(string.Join(",",array));
    int[] myarray= MassiveFilling(array); // Заполняет массив трехзначными числами
    Console.WriteLine(string.Join(",",myarray));
    int result = MassiveSumm(myarray); // Находит количество положительных чисел
    PrintSumm(result);                 // выводит на экран количество положительных
}


Main();


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] MassiveLength()
{
    double[] array = new double[new Random().Next(2,10)];
    return array;
}

double [] MassiveFilling(double[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        int random = new Random().Next(-1000,1000);
        double myRandom = Convert.ToDouble(random)/10.0;

        myArray[i] = myRandom;
    
    }
    return myArray;
}


double MassivMax(double[] myArray)
{
    double max = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        
        if (max<= myArray[i])
        {
            max = myArray[i];
        }
    }
    return max;
}


double MassivMin(double[] myArray)
{
    double min = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        
        if (min >= myArray[i])
        {
            min = myArray[i];
        }
    }
    return min;
}


double MassivDiff(double max, double min)
{
    double result = max-min;
    return result;
}


void PrintSumm(double result)
{
    Console.WriteLine(result);

}

void Main()
{
    double[] array = MassiveLength();
    Console.WriteLine(string.Join(", ", array));
    double[] myArray = MassiveFilling(array);
    Console.WriteLine(string.Join(", ", myArray));
    double max = MassivMax(myArray);
    Console.WriteLine($"максимальное = {max}");
    double min = MassivMin(myArray);
    Console.WriteLine($"минимальное = {min}");
    double diff = MassivDiff(max,min);
    PrintSumm(diff);

}

Main();