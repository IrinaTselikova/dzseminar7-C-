/* Задача 47. Задайте двумерный массив размером m×n, заполненный
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void InitMatrix(double[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int m = GetNumber("Введите число строк:");
int n = GetNumber("Введите число столбцов:");
double[,] newMatrix = new double[m, n];
InitMatrix(newMatrix);
PrintMatrix(newMatrix);

