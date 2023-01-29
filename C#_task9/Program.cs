// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
// 5--> 2,4
// 8--> 2,4,6,8

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = 0;
while (number2 <= number1)
{
 number2=number2+2;
 number2++;
}

Console.Write($"четные числа введенного числа: ");
