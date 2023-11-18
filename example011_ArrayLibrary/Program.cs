void FillArray(int[] collection )
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
            {
                collection[index] = new Random().Next(1,10);
                index ++;
            }
    }

void PrintArray(int[] coll)
    {
        int count = coll.Length;
        int position = 0;
        while (position < count)
            {
                Console.WriteLine(coll[position]);
                position ++;
            }
    }

int IndexOf(int[] collection, int find)
    {
        int count = collection.Length;
        int index = 0;
        int position = -1; // если элемента нет в указанном для вывода массиве, то указываем так по умолчанию
        // -1 означает, что элемент не найден
        while(index < count)
            {
                if(collection[index] == find)
                    {
                        position = index; 
                        break;
                    }
                index++;
            }
        return position;
    }
int[] array = new int[10];
//создаем новый массив из 10 элементов 
// по умолчанию они заполняются нулями
// чтобы этого избежать, пишет код из первой строчки
FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

