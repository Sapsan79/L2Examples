//Создать массив, заполнить случайными цмфрами и вывести номер позиции нужного числа

void FillArray(int[] collection) //voud не возращает результат (без return) FillArray - имя, collection -имя аргумента
{
    int length = collection.Length; //Получение длины массива
    int index = 0; //Позиция индекса по умолчанию = 0
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //Заполнение массива случайными числами
        //index = index + 1;
        index++;
    }
}

void PrintArrey(int[] col) //метод void, который будет печатать
{
    int count = col.Length; // Количество элементов массива
    int position = 0; //Позиция индекса по умолчанию = 0
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //collection-аргумент, find-какой-то элемент
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    find = 5;//искомое значение
     //Для того, чтобы не было занулёвки в ответе при отсутсвии нужного чисмла
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив из 10 элементов
FillArray(array);
PrintArrey(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
