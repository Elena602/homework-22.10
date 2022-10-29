// Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива
Console.WriteLine("Введите количество строк (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [n, m];

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
void SelectionSort(int[,] matr)
{
    for (int k = 0; k < matr.GetLength(0) ; k++)
    {
        for (int i = 0; i < matr.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < matr.GetLength(1); j++)
            {
            if (matr[k,j] > matr[k,i])
            {
            int temporary = matr[k,i];
            matr[k,i] = matr[k,j];
            matr[k,j] = temporary; //для замены местами записываем во временную переменную
            }
            }
        }
    }
}

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
SelectionSort(matrix);
PrintArray(matrix);
