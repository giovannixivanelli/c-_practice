/*

Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

*/

// int [,] Create2dArray(int row, int col, int min, int max){
//     int [,] array = new int [row,col];
//     for (int i =0; i<row; i++){
//         for(int j = 0; j<col;j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбиков: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] created2dArray = Create2dArray(row,col,min,max);

// Console.WriteLine("Получился такой массив: ");
// Show2dArray(created2dArray);
//  Console.WriteLine();

// Console.WriteLine("Укажите номер строки элемента: ");
// int findRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Укажите номер столбика элемента: ");
// int findCol= Convert.ToInt32(Console.ReadLine());

// if (findRow >= 0 && findRow < created2dArray.GetLength(0) && findCol >= 0 && findCol < created2dArray.GetLength(1))
//     {
//             int element = created2dArray[findRow, findCol]; 
//             Console.WriteLine($"Значение элемента массива: {element}");
//     }
// else
//     {
//             Console.WriteLine("Указанный элемент массива не существует.");
//     }

/*

Задача 2: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

*/

// int [,] Create2dArray(int row, int col, int min, int max){
//     int [,] array = new int [row,col];
//     for (int i =0; i<row; i++){
//         for(int j = 0; j<col;j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбиков: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] created2dArray = Create2dArray(row,col,min,max);

// Console.WriteLine("Получился такой массив: ");
// Show2dArray(created2dArray);
// Console.WriteLine();

// int newRow = created2dArray.GetLength(0);
// int newCol = created2dArray.GetLength(1);

//         for (int j = 0; j < newCol; j++)
//         {
//             int temp = created2dArray[0, j];
//             created2dArray[0, j] = created2dArray[newRow - 1, j];
//             created2dArray[newRow - 1, j] = temp;
//         }
// Console.WriteLine("Массив после замены местами первой и последней строки:");
//         for (int i = 0; i < created2dArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < created2dArray.GetLength(1); j++)
//             {
//                 Console.Write(created2dArray[i, j] + " ");
//             }
//             Console.WriteLine();
//         }