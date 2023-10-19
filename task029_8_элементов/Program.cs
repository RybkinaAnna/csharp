/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int createArray()
{
    int[] array8 = new int[8];
    for (int i = 0; i < array8.Length; i++)
    {
        array8[i] = new Random().Next(0, 101);
        printElement(array8[i]);
    }
    return 0;
}

void printElement(int element)
{
    Console.WriteLine(element);
}

createArray();            