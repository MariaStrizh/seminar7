/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет*/

int[,] matrix=FillMatrix(3,4);
PrintMatrix(matrix);
Console.Write ("Введиет номер строки ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введиет номер столбца ");
int n=Convert.ToInt32(Console.ReadLine());

int [,] FillMatrix(int rowsCount, int columnsCount, int leftRange=-10, int rightRange=10)
{
    int[,] matrix=new int[rowsCount, columnsCount];
    Random rand=new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=rand.Next(leftRange,rightRange+1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j]+ "  ");
        }
        Console.WriteLine();
    }
}

    int numb=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (i==m && j==n)
        numb=matrix[i,j]; 
        }
    }
 if (numb==0)
    Console.Write("Такого числа нет");
else
     Console.Write(numb);
   
