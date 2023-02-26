// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
int numbersRows = SetNumber("Rows");
int numbersColumns = SetNumber("Columns");
int numbersMaxValue = SetNumber("MaxValue");
int numbersMinValue = SetNumber("MinValue");

var matr= GetMasiv(numbersRows,numbersColumns,numbersMaxValue,numbersMinValue);
Print(matr);
System.Console.WriteLine();
SortDescending(matr);
Print(matr);

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    var num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMasiv (int rows, int columns, int max, int min)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
       for (int l = 0; l <  columns; l++)
       {
            matrix[i,l] = new Random().Next(min, max +1);
       }   
    }
    return matrix;
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            System.Console.Write(matr[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

void SortDescending(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            for (int k = 0; k < matr.GetLength(1)-1; k++)
            {
                if (matr[i,k] < matr [i,k+1])
                {
                    int temp = matr [i,k+1];
                    matr [i,k+1] = matr[i,k];
                    matr[i,k] = temp;
                }
            }
        }
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
int numberRows = SetNumber("Rows");
int numberColumns = SetNumber("Columns");
int numberMaxValue = SetNumber("MaxValue");
int numberMinValue = SetNumber("MinValue");

var matrix= GetMasiv(numberRows,numberColumns,numberMaxValue,numberMinValue);
Print(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"{MinValueRows(matrix)+1} строка");

int MinValueRows(int [,] matr)
{
    int row = 0;
    int? minSum = null;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum=0;
        for (int l = 0; l < matr.GetLength(1); l++)
        {
            sum = sum + matr[i,l];
        }
        if (minSum == null) 
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
int num1Rows = SetNumber("Rows matrix");
int num1Columns = SetNumber("Columns matrix");
int num1MaxValue = SetNumber("MaxValue matrix");
int num1MinValue = SetNumber("MinValue matrix");

var matrix1= GetMasiv(num1Rows,num1Columns,num1MaxValue,num1MinValue);

var matrix2= GetMasiv(num1Rows,num1Columns,num1MaxValue,num1MinValue);

Print(matrix1);
System.Console.WriteLine();
Print(matrix2);
System.Console.WriteLine();
Print(MatrixProduct(matrix1,matrix2));

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)  
{
    int[,] resultProduct = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
                resultProduct[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }
    }
    return resultProduct;
}


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
int numX = SetNumber("X matrix value");
int numY = SetNumber("Y matrix value");
int numZ = SetNumber("Z matrix value");

var matrix3D= GetMasiv3D(numX,numY,numZ);
PrintMasiv3D(matrix3D);

int [,,] GetMasiv3D(int X, int Y, int Z)
{
    int[,,] matrix = new int[X, Y, Z];
    int[] array = new int[90];
    SortArray(array);
    ShuffleArray(array);


    for (int i = 0; i < X * Y * Z;)
    {
        for (int x = 0; x < X; x++)
        {
            for (int y = 0; y < Y; y++)
            {
                for (int z = 0; z < Z; z++)
                {
                    matrix[x, y, z] = array[i];
                    i++;
                }

            }
        }
    }
    return matrix;    

}

void SortArray(int[] Numbers)  
{
    int length = Numbers.Length;

    for (int i = 0; i < length; i++)
    {
        Numbers[i] = i + 10;
    }
    return;
}

int[] ShuffleArray(int[] array) 
{
    Random rand = new Random();

    for (int i = array.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);

        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}

void PrintMasiv3D(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                System.Console.Write($"{matrix[x, y, z]} ({x}, {y}, {z}) ");
            }
            System.Console.WriteLine();
        }
    }
}
