// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
// 4 да
//-3 Нет
//7 нет

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.WriteLine($"Число {number1} четное");
}
else
{Console.WriteLine($"Число {number1} не четное");}