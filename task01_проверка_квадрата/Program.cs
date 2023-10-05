/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/
System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

string txtResult = $"Число {a} не является квадратом числа {b}";     // вывод результата проверки на экран

if (a == b * b) 
{
    txtResult = txtResult.Replace(" не", "");   // если условие выполняется, то частица "не" заменяется пустым значением
}
System.Console.WriteLine(txtResult);




