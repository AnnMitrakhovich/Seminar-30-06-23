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