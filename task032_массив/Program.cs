/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.Clear();

int[] GetArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
    Console.ResetColor();
}

int[] ChangeArray(int[] arrMax)
{
    System.Console.WriteLine();
    for (int i = 0; i < arrMax.Length ; i++)
    {
        arrMax[i] *= -1;
    }
    return arrMax;
}



System.Console.WriteLine("Задай диапазон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай диапазон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());


int[] userArray = GetArray(userStart, userEnd, userSize);

PrintArray(userArray);

int[] userArraySec = ChangeArray (userArray);
PrintArray(userArraySec);


