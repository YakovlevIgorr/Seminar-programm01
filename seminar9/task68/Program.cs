// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = 2;
int n = 4;
int summ = 0;

Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    if(summ > 2400000) return summ;
    if(m == 0) summ = n + 1;
    if(m > 0 && n  == 0) 
    {
        summ = Akkerman(m - 1, 1);
    }
    if(m > 0 && n > 0)
    {
        summ = Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return summ;

}