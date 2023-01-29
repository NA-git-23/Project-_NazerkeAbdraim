// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 это среда
// 5 это пятница


Console.WriteLine("Введите любое  число от 1 до 7: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
{
    Console.WriteLine("Это понедельник");  
}
if (number1 == 2)
{
    Console.WriteLine("Это вторник");  
}
if (number1 == 3)
{
    Console.WriteLine("Это среда");  
}
if (number1 == 4)
{
    Console.WriteLine("Это четверг");  
}
if (number1 == 5)
{
    Console.WriteLine("Это пятница");  
}
if (number1 == 6)
{
    Console.WriteLine("Это суббота");  
}
if (number1 == 7)
{
    Console.WriteLine("Это воскресенье");  
}
else 
{
    Console.WriteLine("такому числу не сответствует ни один день недели."); 
}
 
