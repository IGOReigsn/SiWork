//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
/*
int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}
//------------------------------------------------------------------------------------------------------
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
//----------------------------------------------------------------------------------------------
int[,] matr = FillMatrix(3, 4);
PrintMatrix(matr);
int[] result = new int[10];
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        result[matr[i, j]]++;
    }
}
System.Console.WriteLine(string.Join(" ", result));
for (int i = 0; i < result.Length; i++)
{
    if (result[i] != 0)
    {
        Console.WriteLine($"{i} встечается {result[i]} раз");
    }
}*/

/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}
//------------------------------------------------------------------------------------------------------
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
//----------------------------------------------------------------------------------------------
int[,] matr = FillMatrix(4, 4);
PrintMatrix(matr);
int min = matr[0, 0];
int minIndexI = 0;
int minIndexJ = 0;
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (matr[i, j] < min)
        {
            min = matr[i, j];
            minIndexI = i;
            minIndexJ = j;
        }
    }
}
int[,] resiult = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
int countI=0;
for (int i = 0; i < matr.GetLength(0); i++)
{
    int countJ=0;
    if (i==minIndexI) continue;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       if (j==minIndexJ) continue;
       resiult[countI,countJ]=matr[i,j];
       countJ++;
    }
    countI++;
}

PrintMatrix(resiult);