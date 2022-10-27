// Написать программу, которая в двумерном массиве заменяет строки на столбцы, или сообщить, 
// что это невозможно (в случае,если матрица не квадратная)

Console.WriteLine("Введите количество строк (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [n, m];
if (n != m)
{
Console.Write($"Невозможно, т.к. матрица не квадратная");
return;
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random random = new Random();
            matr[i, j] = random.Next(-10, 10);
        }
    }
}
void ChangeArray(int[,] matr)
{
    int a = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i; j < matr.GetLength(1); j++)
        {
            if (n == m)
            {
                a = matr[i,j];
                matr[i,j] = matr[j,i];
                matr[j,i] = a;
            }
        }
    }
   //else Console.Write($"Невозможно, т.к. матрица не квадратная");
}
//else Console.Write($"Невозможно, т.к. матрица не квадратная");

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeArray(matrix);
PrintArray(matrix);