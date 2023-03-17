// ConsoleKeyInfo cki;
// cki = Console.ReadKey();
// string ckiString = cki.Key.ToString();
// if(cki.Key.ToString() == "F") Console.Write(" --- You pressed " + ckiString);
Console.Clear();
ConsoleKeyInfo push;
string [,] matrix = new string[16,10];

string [,] Figure(string[,] matrixFig) //создает фигуру
{
    matrixFig[2,4] = "#";
    matrixFig[2,5] = "#";
    matrixFig[2,6] = "#";
    matrixFig[3,4] = "#";
    matrix = matrixFig;
    return matrix;
}

string [,] MoveLeft(string [,] matr)//Двигает фигуру налево 
{
   
        for (int i = 1; i < matr.GetLength(0) - 1; i++)
         {
            for (int j = 1; j < matr.GetLength(1) - 1; j++)
            {
                if(matr[i,j] == "#")
                {
                    matr[i,j - 1] = "#";
                    matr[i,j] = " ";
                }
     
            }
    
        }
 
    matrix = matr;
    return matrix;
}
void PrintArray(string[,] endArray) //печатает массив
{
    for (int k = 0; k < endArray.GetLength(0); k++)
    {
        for (int l = 0; l < endArray.GetLength(1); l++)
        {
            Console.Write($"{endArray[k, l]} ");
        }
        Console.WriteLine();
    }
}
void Push() //считывает кнопку от пользователя 
{
    for(int t = 0; t < 10; t++)
    {
        push = Console.ReadKey();
        if(push.Key.ToString() == "Z") 
        {
            MoveLeft(matrix);
            PrintArray(matrix);
        }
        if(push.Key.ToString() == "C")
        {
            MoveRight(matrix);
            PrintArray(matrix);
        }
    
    }
}
string [,] GetArray(string [,] array) //Заполнение массива пробелами
{
    bool fence;
    for (int i = 0; i < array.GetLength(0); i++)
         {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                fence = j == 0 || j == array.GetLength(1) - 1 || i == array.GetLength(0) - 1;
                if(fence) 
                {
                    array[i,j] = "/";
                }
                else array[i,j] = " ";
            }
        }
    matrix = array;
    return matrix;
}
string[,] MoveRight(string[,] matrRight)
{
      for (int i = 1; i < matrRight.GetLength(0) - 1; i++)
         {
            for (int j = 1; j < matrRight.GetLength(1) - 1; j++)
            {
                if(matrRight[i,j] == "#")
                {
                    matrRight[i,j + 1] = "#";
                    matrRight[i,j] = " ";
                }
     
            }
    
        }
 
    matrix = matrRight;
    return matrix;




}
GetArray(matrix);
Figure(matrix);
PrintArray(matrix);
Push();