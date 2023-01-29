// Напишите програсмму, которая на вход принимает три числа и выдает максимальное из этих чисел
// 2, 3, 7 --> 7
// 44, 5, 78 -->78


Console.WriteLine("Введите 3 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());


if (number1>number2)
{   
    Console.WriteLine($"max={number1}");
    if (number1>number3) 
    {
        Console.WriteLine($"max={number1}");
        }
    else 
    {
        Console.WriteLine($"max={number3}");
        }

}
else 
{
    Console.WriteLine($"max={number3}");
    if (number2>number3) 
    {
        if (number2>number1) 
            {
            Console.WriteLine($"max={number2}");
            }
    else 
        {
        Console.WriteLine($"max={number1}");
        }
    
    }
}


