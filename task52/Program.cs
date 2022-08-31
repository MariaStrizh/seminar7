/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] matrix=FillMatrix(4,4);
PrintMatrix(matrix);

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
 
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double ArithMean=0;
        double sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           sum=(sum+matrix[i,j]);
        }
     ArithMean=sum/4; 
    Console.WriteLine($"Стреднее арифметическе {j} столбца {ArithMean:f2}");
    }
