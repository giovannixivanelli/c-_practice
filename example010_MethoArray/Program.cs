int[] array = {21,24,53,14,81, 25,36,57,81};

int n = array.Length; // присваем n значение количества индексов в массиве
int find = 81;

int index = 0; // счетчик, чтоб можно было перебрать все индексы в массиве, начиная с 0

while (index < n)
    {
        if(array[index] == find)
            {
                Console.WriteLine(index);
                break; // прерывает цикл
            }
        index ++;

    }