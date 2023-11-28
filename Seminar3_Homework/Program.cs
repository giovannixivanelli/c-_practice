// /*

// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 

// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// */

// int [] CreateArray(int max, int min, int size)
//     {
//         int [] array = new int [size];
//         for(int i = 0; i < size; i++)
//             {
//                 array[i] = new Random().Next(min, max+1);
//             }
//         return array; 
//     }

// void ShowNumbers (int[] array) 
//     {
//         for(int i = 0; i < array.Length; i++) 
//             {
//                 if(array[i] >= 20 && array[i] <= 90)
//                     {
//                     Console.Write(array[i] + " ");
//                     }
//             }
//     }


// Console.WriteLine("Enter the array's size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the array's min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the array's max");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] array = CreateArray(max, min, size);
// ShowNumbers(array);

// /*

// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// */

// int [] CreateArray(int max, int min, int size)
//     {
//         int [] array = new int [10];
//         for(int i = 0; i < size; i++)
//             {
//                 array[i] = new Random().Next(min, max+1);
//             }
//         return array; 
//     }

// void ShowArray(int [] array){
    
//     for(int i = 0; i<array.Length;i++){
//         Console.Write(array[i] +" ");
//     }
//     Console.WriteLine();
// }

// void ShowNumbers (int[] array) 
//     {
//         int count = 0;
//         for(int i = 0; i < array.Length; i++) 
//             {
//                 if(array[i] % 2 == 0)
//                     {
//                         count +=1;
//                     }
//             }
//         Console.WriteLine($"Количество четных чисел: {count}");
//     }


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимамльное число массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] array = CreateArray(max, min, size);
// ShowArray(array);
// ShowNumbers(array);