int ver = 12;
int gor = 13;
int[,] array = new int[ver, gor];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Сумма значений ячеек по главной(от нуля) диагонали: " + SumZeroDiagonal(array));

void FillArray(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(-9, 10);
        }
    }
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 0)
            {
                Console.Write(a[i, j] + " ");
            }
            if(a[i, j] < 10 && a[i, j] >= 0)
            {
                Console.Write(" " + a[i, j] + " ");
            }
            if(a[i, j] > 10)
            {
                Console.Write(a[i, j] + " ");
            }
            
        }
    Console.WriteLine("");
    }
}

int SumZeroDiagonal(int [,] a)
{
    int sum = 0;
    for(int i = 0; i < a.GetLength(0) && i < a.GetLength(1); i++)
    {
        sum = sum + a[i, i];
    }
    return sum;
}