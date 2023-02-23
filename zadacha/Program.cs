// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
// Примеры: ["hello", "2", "world", ":-)"] -> ["2", "-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> D

// string[] arrayStart = new string[]{"Russia", "Denmark", "Kazan"};
string[] arrayStart = new string[] { "Hello", "2", "world", ":)" };
// string[] arrayStart = new string[] {"1234", "1567", "-2", "computer science"};
int result = SizeArrayFinish(arrayStart);
string[] arrayFinish = new string[result];
RedusedArray(arrayStart, arrayFinish);
PrintArray(arrayStart);
Console.Write(" => ");
PrintArray(arrayFinish);

void RedusedArray(string[] arrayStart, string[] arrayFinish)
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {

        if (arrayStart[i].Length <= 3)
        {
            arrayFinish[count] = arrayStart[i];
            count++;
        }

    }

}

int SizeArrayFinish(string[] array)
{
    int sum = 0;
    for (int i = 0; i < arrayStart.Length - 1; i++)
    {
        if (arrayStart[i].Length >= 3)
            sum++;

    }
    return sum;
}

void PrintArray(string[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}