Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int numberMax = 0;
if (number1>number2)
{
    numberMax = number1;
}
else
{
    numberMax = number2;
}
if (numberMax < number3)
{
    numberMax = number3;
}
Console.WriteLine("Максимум " + numberMax);