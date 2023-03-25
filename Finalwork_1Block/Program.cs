// Задача: Написать программу, 
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


//Печать одномерного массива 
void Print1DArry(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{array[i]}]\t");
    }

}
// метод нахождения строки в массиве длиной не больше заданного значения
// и запись их в новый массив 
string[] findArray(string[] array, int count)
{
    string[] result = new string[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index].Length <= count)
        {
            result = result.Concat(new string[] { array[index] }).ToArray();
        }
    }
    return result;
}

string[] startArray = new string[] { "1234", "345", "finish", "world", ":-", "-2" };

string[] finishArray = findArray(startArray, 3);

Console.WriteLine("Исходный массив:");
Print1DArry(startArray);
Console.WriteLine();
Console.WriteLine("Массив из строк длина которых не больше 3:");

if (finishArray.Length != 0)
{
    Print1DArry(finishArray);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Массив пустой!!!");
}
