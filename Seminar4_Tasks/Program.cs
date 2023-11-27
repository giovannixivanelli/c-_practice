// Есть ли число в массиве/ да или нет

// int[] createArray(int min, int max, int size) // размер массива в int size так как у нас статический массив
//     {
    
//         int [] array = new int [size]; //

//         for(int i = 0; i < size; i++) // цикл для заполнения
//             {
//                 array[i] = new Random().Next(min, max+1); // +1 чтоб до выбранного числа включительон
//             }
//         return array;
//     }; 

// void showArray(int [] array) // функция для вывода массива
//     {
//         for(int i = 0; i < array.Length; i++)
//             {
//                 Console.Write(array[i +" "]);
//             }
//         Console.WriteLine(); // перевод строки
//     }

// bool findDigit(int[] array, int digit)
//     {

//         for(int i = 0; i < array.Length; i++)
//             {
//                 if(array[i] = digit)
//                     {
//                         return true;
//                     }
//             }
//         return false;
//     }

// Console.WriteLine("Enter array's size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter array's min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter array's max");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a digit");
// int digit = Convert.ToInt32(Console.ReadLine());

// int[] array = createArray(min, max, size);

// showArray(array);
// bool result = findDigit(array, digit);
// if(result == true)
//     {
//         Console.WriteLine("Да");
//     }
// else
//     {
//         Console.WriteLine("Нет");
//     }

int [] CreateArray(int min, int max, int size){

    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array; 
}

void ShowArray(int [] array){
    
    for(int i = 0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

bool FindDigit(int [] array, int digit){
    //bool flag = false;
    for(int i = 0; i<array.Length; i++){
        if(array[i] == digit){
           return true; 
        }
    }
    return false;
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter search digit");
int digit = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
bool res = FindDigit(array, digit);
if(res == true){
    Console.WriteLine("ДА");
}
else{
    Console.WriteLine("Нет");
}