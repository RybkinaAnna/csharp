/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"{arr[i]}");
    }
}


bool FindNumber(int[] arrSec, int numb )
{
    bool result = false;
    for (int i = 0; i < arrSec.Length; i++)
    {
        if (arrSec[i] == numb)
        result = true;
    }
    return result;
}

int[] userArray = RandomArray();
PrintArray(userArray);
System.Console.WriteLine("Введите число: ");
int numb  = convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindNumber(userArray, numb));

