﻿int Max(int arg1, int arg2, int arg3) 
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    } 

int[] array = {1, 2, 3, 41, 5, 66, 7, 8, 9}; // указываем массив
// array[0] = 12; // в скобке пишем индекс массива, к которому обращаемся

// Console.WriteLine(array[0]);

    int maxNum = Max(
        Max(array[0], array[1], array[2]),
        Max(array[3], array[4], array[5]),
        Max(array[6], array[7], array[8])
    );   

    Console.WriteLine(maxNum);

