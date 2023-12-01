/*
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 

Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


*/

while(true)
    {
        Console.WriteLine("Введите число");
        string input = Console.ReadLine();
        if(input == "q")
            {
                break;
            }
        int number;
        if(int.TryParse(input, out number))
            {
                int sum = 0;
                while(number > 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                if(sum % 2 == 0)
                    {
                        Console.Write("ВАУ");
                        break;  
                    }
                else
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
                    }
            }
    }

/*

Задача 2: Задайте массив заполненный случайными трёхзначными числами. 

Напишите программу, которая покажет количество чётных чисел в массиве.


*/

int [] numbers = new int[10];

int evNumbers = 0;

Console.WriteLine("Наш массив: ");
for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
        Console.Write(numbers[i] + " ");
        
        if(numbers[i] % 2 == 0)
            {
                evNumbers++;
            }
    }
Console.WriteLine();
Console.Write($"Количество четных числе в массиве: {evNumbers}");

/*

Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

*/

int[] newArray = new int [10];
Console.WriteLine("Оригинальный массив: ");
for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(1, 100);
        Console.Write(newArray[i] + " ");
    }
Console.WriteLine("Реверс массива: ");
for (int i = 0; i < newArray.Length / 2; i++)
{
    int temp = newArray[i];
    newArray[i] = newArray[newArray.Length - i - 1];
    newArray[newArray.Length - i - 1] = temp;
}
Console.Write(newArray);

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Исходный массив:");
PrintArray(numbers);
ReverseArray(numbers);
Console.WriteLine("Перевернутый массив:");
PrintArray(numbers);

void ReverseArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
    }

void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }


