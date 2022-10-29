// В прямоугольной матрице найти строку с наименьшей суммой элементов
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
int SmallestSumOfElements(int[,] matr)
{
  int MinStr = 0;
  int MinSum = 0;

  for (int j = 0; j < matr.GetLength(1); j++)
  {
    MinSum = MinSum + matr[0,j];
  }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Sum = Sum + matr[i,j];
        }
        if (Sum < MinSum)
        {
            MinStr = i;
            MinSum = Sum;
        }
    }
    return MinStr;
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
Console.WriteLine("Строка с наименьшей суммой: " + SmallestSumOfElements(matrix));
