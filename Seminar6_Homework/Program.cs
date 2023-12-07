/*

Задача 1: Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.

*/

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбиков");
int columns = Convert.ToInt32(Console.ReadLine()); 

char[,] array = new char[rows, columns]; 

Random random = new Random();

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            {
                array[i, j] = Convert.ToChar(random.Next(65, 91));
            }
    }

        // создаем строку из символов массива
        string str = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                str += array[i, j];
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);

        Console.WriteLine("Строка из символов массива:");
        Console.WriteLine(str);


static void PrintArray(char[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

/*

Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на строчные.

*/

string GetCharsToLower(string str)
    {
        str = str.ToLower();
        return str;
    }

Console.WriteLine("Введите словосочетание:");
string str = Convert.ToString(Console.ReadLine());
string res = GetCharsToLower(str);
Console.WriteLine(res);


/*
Задача 3: Задайте произвольную строку. 
Выясните, является ли она палиндромом.
*/ 
string FilterString(string str){
    string res = str.ToLower();
    string count = "";
    foreach(char elem in res){
        if(elem != ' '){
            count+=elem;
        }
    }
    return count;
}

string IsPalindrome(string str){
    for(int i = 0; i<str.Length/2; i++){
        if(str[i] != str[str.Length-i-1]){
            return("Это не палиндром");
        }
    }
    return("Это палиндром");
}


string str = "TeNert";
string res = FilterString(str);
Console.WriteLine(IsPalindrome(res));