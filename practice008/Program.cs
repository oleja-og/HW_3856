// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int EnterNumbers(string numberName)
{
    Console.Write($" Enter number {numberName} ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(0, 10);
        }
    }
    return matrix;
}


int[,] SortMassivRows(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int n = 0; n < matrix.GetLength(1) - 1; n++)
            {

                if (matrix[i, n] < matrix[i, n + 1])
                {
                    int temp = matrix[i, n + 1];
                    matrix[i, n + 1] = matrix[i, n];
                    matrix[i, n] = temp;
                }
            }

        }

    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

void Tusk54()
{
    int rows = EnterNumbers("Enter rows :");
    int columns = EnterNumbers("Enter columns :");
    int[,] matrix = GetMatrix(rows, columns);
    PrintMatrix(matrix);
    Console.WriteLine();
    SortMassivRows(matrix);
    PrintMatrix(matrix);
}

// Tusk54();


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[] SummRows(int[,] matrix)
{
    int result = 0;
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            result += matrix[i, l];
        }
        array[i] = result;
        result = 0;
    }
    return array;
}


void SearchMin(int[] array)
{
    int minValue = array[0];
    int minRows = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (minValue >= array[i])
        {
            minValue = array[i];
            minRows = i + 1;
        }

    }
    Console.WriteLine($"минимальное значение {minValue} в {minRows} строке )");
}


void Tusk56()
{
    int rows = EnterNumbers("Enter rows :");
    int columns = EnterNumbers("Enter columns :");
    int[,] matrix = GetMatrix(rows, columns);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[] array = SummRows(matrix);
    Console.WriteLine();
    Console.WriteLine(string.Join(" ", array));
    SearchMin(array);


}

// Tusk56();


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] MassivMatix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            for (int l = 0; l < matrix1.GetLength(1); l++)
            {
                result[i, k] += matrix1[i, l] * matrix2[l, k];

            }
        }
    }
    return result;
}

void Tusk58()
{
    int rows1 = EnterNumbers("Enter rows :");
    int columns1 = EnterNumbers("Enter columns :");
    int[,] matrix1 = GetMatrix(rows1, columns1);
    PrintMatrix(matrix1);
    Console.WriteLine();
    int rows2 = EnterNumbers("Enter rows :");
    int columns2 = EnterNumbers("Enter columns :");
    int[,] matrix2 = GetMatrix(rows1, columns1);
    PrintMatrix(matrix2);
    Console.WriteLine();
    PrintMatrix(MassivMatix(matrix1, matrix2));


}

// Tusk58();


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] GetMatrix3d(int x, int y, int z)
{
    int[] array = new int[x*y*z];
    int number;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 20);
        number = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 20);
                    j = 0;
                    number = array[i];
                }
                number = array[i];
            }
        }
    }

    int[,,] matrix = new int[x, y, z];
    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for (int l = 0; l < y; l++)
        {
            for (int j = 0; j < z; j++)
            {
                matrix[i, l, j] = array[count];
                count++;
            }
        }
    }
    return matrix;
}


void PrintMatrix3d(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write(matrix[i, l, j] + $"({i},{l},{j}) ");
            }
            Console.ReadLine();
        }
        
    }
}

void Tusk60()
{
    int x = EnterNumbers("Enter x :");
    int y = EnterNumbers("Enter y :");
    int z = EnterNumbers("Enter z :");
    int[,,] matrix1 = GetMatrix3d(x, y, z);
    PrintMatrix3d(matrix1);
    Console.WriteLine();
    



}

Tusk60();