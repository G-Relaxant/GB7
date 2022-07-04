int ver = 12;
int gor = 13;
int[,] array = new int[ver, gor];
FillArray(array);
PrintArray(array);
RefillOddIndexesArray(array);
Console.WriteLine();
Console.WriteLine("Квадраты на нечётных ячейках:");
PrintArray(array);

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

void RefillOddIndexesArray(int [,] a)
{
    for(int i = 1; i < a.GetLength(0); i=i+2)
    {
        for(int j = 1; j < a.GetLength(1); j=j+2)
        {
            a[i, j] = a[i, j] * a[i, j];
        }
    }
}