// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1 / 100 > 0)
     {while(number1 > 1000)
         {
             number1 = number1 / 10;
         }
    Console.WriteLine("Third number " + number1 % 10);
    }
else
    {
    Console.WriteLine("Third number not exists ");
    }