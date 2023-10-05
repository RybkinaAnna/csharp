/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

System.Console.Write("Введите трёхзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber % 10;   // "%" - остаток от деления, "/" - деление.
System.Console.WriteLine(result);