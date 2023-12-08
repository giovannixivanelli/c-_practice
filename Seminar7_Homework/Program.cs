// /*

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// */


void FillWitNumbers(int m, int n)
    {
        if (m <= n)
        {               
            Console.Write(m + " ");
            FillWitNumbers(m + 1, n);
        }
    }
Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");

FillWitNumbers(m, n);


/*

Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

*/
int AckFunction (int m, int n)
    {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0) return AckFunction(m - 1, 1);
        else if (m > 0 && n > 0) return AckFunction(m - 1, AckFunction(m, n - 1));
        else return -1; 
    }

Console.WriteLine("Введите значение для m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение для n:");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckFunction (m, n);

Console.WriteLine($"Функция Аккермана для чисел {m} и {n} равна {result}");

/*

Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

*/

int[] FillArray(int size)
    {
        int[] array = new int[size];
        Random random = new Random();
        
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100);
        }
        
        return array;
    }
    
void ShowArray(int[] array, int index = 0)
    {
        if (index < array.Length)
        {
            Console.Write(array[index] + " ");
            ShowArray(array, index + 1);
        }
    }

void ShowReversedArray(int[] array, int index)
    {
        if (index >= 0)
            {
                Console.Write(array[index] + " ");
                ShowReversedArray(array, index - 1);
            }
    }

int[] newArray = FillArray(10);
Console.WriteLine("Массив:");
ShowArray(newArray);
Console.WriteLine();
Console.WriteLine("Перевернутый массив: ");
ShowReversedArray(newArray, newArray.Length - 1);