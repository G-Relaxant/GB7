int m = 5;
int n = 5;

int[,] array = new int[m, n];

FillArray(array);

PrintArray(array);


void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($" {a[i, j]} ");
        }
    Console.WriteLine("");
    }
}

void FillArray(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = i + j;
        }
    }
}