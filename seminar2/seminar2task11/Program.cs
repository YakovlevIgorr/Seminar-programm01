// Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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


//325- остаток от деления
//3256- разделить на 10, остаток от деления
//32569- разделить на 100, остаток от деления
//325697- разделить на 1000, остаток от деления


// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// int numberMax = 0;
// if (number1>number2)
// {
//     numberMax = number1;
// }
// else
// {
//     numberMax = number2;
// }
// if (numberMax < number3)
// {
//     numberMax = number3;
// }
// Console.WriteLine("Максимум " + numberMax);