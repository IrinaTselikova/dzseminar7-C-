/* Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */



int[,] InitMatrix(int am, int an)
{
    int[,] resultMatrix = new int[am, an];
    Random rnd = new Random();
    for (int i = 0; i < am; i++)
    {
        for (int j = 0; j < an; j++)
        {
            resultMatrix[i, j] = rnd.Next(-10, 10);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            Console.Write($"{resultMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetElement(int[,] resultMatrix, int m, int n)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (m > resultMatrix.GetLength(0) || n > resultMatrix.GetLength(1))
            {
                Console.WriteLine($"{m} {n} - такого элемента нет");
                return;
            }
            else
            {
                object c = resultMatrix.GetValue(m, n);
                Console.WriteLine(c);
                return;
            }
        }
    }
}




int[,] resultMatrix = InitMatrix(4, 4);
PrintMatrix(resultMatrix);
int m = GetNumber("Введите номер строки");
int n = GetNumber("Введите номер столбца");
GetElement(resultMatrix, m, n);

