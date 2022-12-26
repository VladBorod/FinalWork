// Добро пожаловать в код программы по отсеву элементов массива, превышающих три знака!

Console.Clear();
// Исходящий массив данных.

string[] arr =  {"hello", "2", "world", 
                    ":-)", "1234", "1567", "-2",
                    "computer science", "Russia",
                    "Denmark", "Kazan", "123", "-=-",
                    "Rapido", "num", "arr", "Elden",
                    "Whicher", "Mass", "Tor", "5%5",
                    "Vitality", "High eay to hell",
                    "Kill fish", "Best boxer", "Cool look",
                    "333", "222", "do", "what", "gap",
                    "Clown", "it", "this", "is", "all"};

// Метод вывода заданного массива.
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
// Метод выбора элементов размером до трех знаков.
string[] SerchingLessThreeSymbolsElements(string[] array)
{
    string[] elementsSearch = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            elementsSearch[count] = array[i];
            count++;
        }
    }
    return elementsSearch;
}
// Метод вывода элементов подходящих заданному условию.
void PrintArraySearching(string[] searchingArray)
{
    for (int i = 0; i < searchingArray.Length; i++)
    {
        Console.Write(searchingArray[i] + " ");
    }
}

Console.WriteLine("Заданный массив: ");
PrintArray(arr);
Console.WriteLine("Элементы массива размером три и менее знаков: ");
string[] searchingElements = SerchingLessThreeSymbolsElements(arr);
PrintArraySearching(searchingElements);