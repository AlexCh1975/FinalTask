/*
    Задача: Написать программу, которая из имеющегося массива строк формирует 
    новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
    массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
    массивами.

    Примеры:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
*/

//Console.Clear();

Console.Write("Введите размер массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");

string[] stringArray = CreateStringArray(lengthArray); 
string[] newStringArray = SortStringArray(stringArray);

PrintArray(stringArray);
PrintArray(newStringArray, "Red");

string[] CreateStringArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int GetLengthArray(string[] array)
{
    int length = 0;
    int lengthString = 3;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > lengthString) continue;
        else length++;
    }
    return length;
}

string[] SortStringArray(string[] array)
{
    int lengthString = 3;
    int lengthArray = GetLengthArray(array);
    string[] newArray = new string[lengthArray];
    int index = 0;
    
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length > lengthString) continue;
        else newArray[index] = array[j];
        index++;
    }
    return newArray;
}

void PrintArray(string[] array, string colorName = "Green")
{
    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
    Console.Write("[ ");
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"'{array[i]}' ");
        else Console.Write($"'{array[i]}', ");
    }
    
    Console.WriteLine("]");
    Console.ResetColor();
}