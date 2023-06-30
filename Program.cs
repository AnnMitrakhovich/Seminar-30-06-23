// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// double[,] Create2DArray(int rows, int cols)
// {
//     return new double[rows, cols];
// }
// void Fill2DArray(double[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = Math.Round(rnd.Next(min, max + 1) * 0.1, 1);
// }
// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minN = InputNum("Введите минимальное значение в диапазоне чисел массива: ");
// int maxN = InputNum("Введите максимальное значение в диапазоне чисел массива: ");
// double[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minN, maxN);
// Print2DArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
void FindAverage(int[,] array)
{
    double average = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa += array[i, j];
        }
        average = Math.Round(summa / array.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца равно {average}.");
    }
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minN = InputNum("Введите минимальное значение в диапазоне чисел массива: ");
int maxN = InputNum("Введите максимальное значение в диапазоне чисел массива: ");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minN, maxN);
Print2DArray(myArray);
FindAverage(myArray);

// РАБОТА НА УРОКЕ
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// int InputNum(string message)
// {
// 	Console.Write(message);
// 	return int.Parse(Console.ReadLine()!);
// }
// void FillArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
// 	for (int i = 0; i < array.GetLength(0); i++)
// 		for (int j = 0; j < array.GetLength(1); j++)
// 			array[i, j] = rnd.Next(min, max + 1);
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 			System.Console.Write($"{array[i, j]}\t");
// 			System.Console.WriteLine();
// 	}
// }
// int ChangeArray(int [,] array)
// {
//     int sum = 0;
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
//         if (i==j) sum = sum + array[i,j];
//     }
//     return sum;
// } 
// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int maxValue = InputNum ("ВВедите максимум диапазона");
// int minValue = InputNum ("ВВедите минимум диапазона");
// int [,] myArray = new int[rows,columns];
// FillArray(myArray,minValue,maxValue);
// PrintArray(myArray);
// Console.WriteLine("");
// int result = ChangeArray(myArray);
// Console.WriteLine(result);

// int SumDiag(int[,] array)
// {
//     int sum = 0;
//     int temp = array.GetLength(1);
//     if (array.GetLength(0) < array.GetLength(1))
//         temp = array.GetLength(0);
//     for (int i = 0; i < temp; i++)
//     {
//         sum += array[i, i];
//     }
//     return sum;
// }


// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// int InputNum(string message)
// {
// 	Console.Write(message);
// 	return int.Parse(Console.ReadLine()!);
// }
// void FillArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
// 	for (int i = 0; i < array.GetLength(0); i++)
// 		for (int j = 0; j < array.GetLength(1); j++)
// 			array[i, j] = rnd.Next(min, max + 1);
// }
// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 			System.Console.Write($"{array[i, j]}\t");
// 			System.Console.WriteLine();
// 	}
// }
// void ChangeArray(int [,] array)
// {
// 	for (int i = 2; i < array.GetLength(0); i=i+2)
// 	{
// 		for (int j = 2; j < array.GetLength(1); j=j+2)
//         array[i,j] = array[i,j]*array[i,j];
//     }
// } 
// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int maxValue = InputNum ("ВВедите максимум диапазона");
// int minValue = InputNum ("ВВедите минимум диапазона");
// int [,] myArray = new int[rows,columns];
// FillArray(myArray,minValue,maxValue);
// PrintArray(myArray);
// Console.WriteLine("");
// ChangeArray(myArray);
// PrintArray(myArray);

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// int InputNum(string message)
// {
// 	Console.Write(message);
// 	return int.Parse(Console.ReadLine()!);
// }

// void FillArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 		for (int j = 0; j < array.GetLength(1); j++)
// 			array[i, j] = i + j;
// }

// void PrintArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 			System.Console.Write($"{array[i, j]}\t");
// 			System.Console.WriteLine();
// 	}
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int[,] myArray = new int[rows, columns];
// FillArray(myArray);
// PrintArray(myArray);

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }
// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }
// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");
// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// 
// escape-последовательности
// int a = 1;
// int b = 2;
// Console.WriteLine($"{a} + {b}\nИтого {a + b}\n");
// Console.WriteLine("!");