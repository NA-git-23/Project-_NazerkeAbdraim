// Напишите программу, которая на вход принимает два числа и проаеряет, является ом первое число квадратом второго 
// a=26, b = 5  да, является
// a = 2, b = 10  нет, не является
// a = 9, b = -3  да
// a = -3, b = 9  нет


Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
 if(number1 == number2 * number2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else 
{
Console.WriteLine($"{number1} не является квадратом {number2}");
}
