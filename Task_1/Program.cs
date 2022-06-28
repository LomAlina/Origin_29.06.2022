// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int digitTwo = ((number / 10) % 10);
// Console.WriteLine(digitTwo);

Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
Console.WriteLine("Вторая цифра этого числа: " + stringNumber[1]);