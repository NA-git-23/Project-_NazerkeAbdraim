// Напишите програсмму, которая на вход принимает два числа и выдает, какое больше, а какое меньше
// a=5 b=7  then max=7 min=5
//a=-9 b=-3 then max=-3 min=-9


Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
{   Console.WriteLine($"max={number1} and min={number2}");
}
else 
{
Console.WriteLine($"max={number2} and min={number1}");
}
