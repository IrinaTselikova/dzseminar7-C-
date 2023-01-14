/* Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] newMatrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatrix[i,j] = rnd.Next(1, 10);
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Console.Write($"{newMatrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

    
void GetAverage (int[,] newMatrix, int m)
{   
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                
                average += newMatrix[i, j];
            }
        average = average/ m;
        Console.Write(average + "; ");  
    }
Console.WriteLine();
return;
}

int m = GetNumber("Введите количество строк");
int n = GetNumber("Введите количество столбцов");
int[,] newMatrix = InitMatrix(m, n);
PrintMatrix(newMatrix);
GetAverage(newMatrix, m);

