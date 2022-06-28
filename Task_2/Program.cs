// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(anyNumber);

if (stringNumber.Length > 2)
{
   Console.WriteLine("Третья цифра числа: " + stringNumber[2]); 
}

else
{
    Console.WriteLine("третьей цифры нет");
}
