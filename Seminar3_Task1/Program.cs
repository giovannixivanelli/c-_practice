// int[] array = {1,3,4,19,3};

// int n = array.Length;
// int find = 5;

// int index = 0;

// while (index < n)
//     {
//         if(array[index] == find)
//             {
//                 Console.WriteLine("Да");
//             }
//             index++;
//             else 
//                 {
//                     Console.WriteLine("Нет");
//                 }
//     }
/*

Вывести все четные числа в промежутке от 

1) Через невозвращаемую функцию
*/

// void testFunc(int first )
//     {
//         if(first % 2 == 0)
//             {
//                 Console.Write(first+" ");
//             }
//     }
// Console.WriteLine("Enter the first number");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber > secondNumber)
//     {
//         int temp = firstNumber;
//         firstNumber = secondNumber;
//         secondNumber = temp;
//     }

// while(secondNumber >= firstNumber)
//     {
//         testFunc(firstNumber);
//         firstNumber++;
        
//     }

// 1) Через возвращаемую функцию
// int testFunc(int first ) // Создаем функцию с тем типом, с которым хотим вернуть результат
//     {
//         if(first % 2 == 0) // если число честное
//             {
//                 return first; // то возвращает число
             
//             }
//         else
//             {
//                 return 0; // если у нас число нечетное, то возвращает 0, чтобы войти в условие first % 2 == 0;

//             }
//     }
// Console.WriteLine("Enter the first number"); // команда вывода текста "Enter the first number"
// int firstNumber = Convert.ToInt32(Console.ReadLine()); //команда для ввода и преобразования натурального числа
// Console.WriteLine("Enter the second number");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber > secondNumber) // если наше первое число больше второго, нам нужно поменять их местами, чтобы промежуток цифр был от малого до большого
//     {
//         int temp = firstNumber;
//         firstNumber = secondNumber;
//         secondNumber = temp;
//     }

// while(secondNumber >= firstNumber)
//     {
//         int result = testFunc(firstNumber);
//         if(result != 0)
//             {
//             Console.Write(firstNumber+" ");

//             }
//         firstNumber++;
        
//     }


/*

Задачи из семинара

1. Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.

*/


// Напишите программу, 
// которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// void NunFunc(int first){
//     int sum = 0;
//     for(int i=1;i<=first;i++){
//         sum+=i;
//     }
//     Console.WriteLine(sum);

// }

// Console.WriteLine("enter numb");
// int num = Convert.ToInt32(Console.ReadLine());
// NunFunc(num);

// void NumFunc(int number)
//     {
//         int count = 0;
//         int sum = 0;
//         if(number > 1)
//             {
//             while(count < number)
//                 {
//                     sum = sum + (sum + 1);
//                     count++;
//                 }
//             Console.WriteLine(sum);
//             }

//     }

// Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());
// NumFunc(number);

/*
    2. Напиши сумму цифр введенного числа
*/

// void NumFunc(int num)
//     {  
//              int count = 0;
//              while(num>0)
//                 {
//                     num /= 10;
//                     count++;
//                 }
//             Console.WriteLine($"Sum of digits is {count}");
//             }
//     Console.WriteLine("Enter the number");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num == 0)
//         {
//             Console.WriteLine("1");
//         }
//     NumFunc(num);

/*
Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.


*/

// void sqrtFunc (int num)
//     {
//         int count = 1;
//         int sqr = 1;
//         while(count <= num)
//             {
//                 sqr = count * count;
//                 Console.Write($"{sqr},");
//                 count++;
//             }
            
//     }
// Console.WriteLine("Enter the number");
// int num = Convert.ToInt32(Console.ReadLine());
// sqrtFunc(num);



/*
Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

// void sqrtFunc (int num)
//     {
//         int count = 1;
//         int mult = 1;
//         while(count <= num)
//             {
//                 mult *= count;
//                 count++;
//             }
//         Console.Write(mult);            
//     }

// Console.WriteLine("Enter the number");
// int num = Convert.ToInt32(Console.ReadLine());
// sqrtFunc(num);