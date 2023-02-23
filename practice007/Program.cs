// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int EnterNumbers(string numberName)
{
    Console.Write($" Enter number {numberName} :");
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows,columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i,l] = Math.Round(new Random().Next(min,max+1)+new Random().NextDouble(),1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i,l] + " ");
        }
        Console.WriteLine();
    }
}



void Task47()
{
    int rowCount = EnterNumbers("Rows");
    int columnsCount= EnterNumbers("Columns");
    int minValue = EnterNumbers("Min value");
    int maxValue = EnterNumbers("Max value");
    double[,] matrix = GetMatrix(rowCount, columnsCount, minValue, maxValue);
    PrintMatrix(matrix);
    

    // Console.WriteLine($"{m}  {n} {min} {max}");
}

Task47();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetMatrix1(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i,l] = new Random().Next(min,max+1);
        }
    }
    return matrix;
}

void ShowNumber(int[,] matrix)
{
    int value = EnterNumbers("check Value");
    int count =0;
    foreach (int i in matrix)
    {
        if(value == i)
        {
            count++;
            break;
        }
    }
    if (count>0) Console.WriteLine($"Число {value} есть в массиве ");
    else Console.WriteLine($"Числа {value} нет в массиве ");

   
}



void Task50()
{
    int rowCount = EnterNumbers("Rows");
    int columnsCount= EnterNumbers("Columns");
    int minValue = EnterNumbers("Min value");
    int maxValue = EnterNumbers("Max value");
    int[,] matrix1 = GetMatrix1(rowCount, columnsCount, minValue, maxValue);
    PrintMatrix(matrix1);
    ShowNumber(matrix1);
    

    
}

Task50();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int EnterNumbers(string numberName)
{
    Console.Write($" Enter number {numberName} :");
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows,columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i,l] = new Random().Next(0,10);
        }
    }
    return matrix;
}

double[] GetMiddleColumn(double[,] matrix)
{
    double result = 0;
    double[] array = new double[matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            result+= matrix[l,i];
        }
        array[i] = Math.Round(result/matrix.GetLength(0),1);
        result=0;
    }
    return array;
}





void Task50()
{
    int rowCount = EnterNumbers("Rows");
    int columnsCount= EnterNumbers("Columns");
    // int minValue = EnterNumbers("Min value");
    // int maxValue = EnterNumbers("Max value");
    double[,] matrix = GetMatrix(rowCount, columnsCount);
    PrintMatrix(matrix);
    Console.WriteLine();
    double[] array = GetMiddleColumn(matrix);
    Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ",array)}.");    
}

Task50();


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
