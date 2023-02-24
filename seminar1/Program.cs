Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine("Максимум = " + number1);
    Console.WriteLine("Минимум = " + number2);
}
else
{
    Console.WriteLine("Максимум = " + number2);
    Console.WriteLine("Минимум = " + number1);
}