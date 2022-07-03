int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

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

int m = Input("Input m: ");
int n = Input("Input n: ");

int[,] numbers = new int[m, n];

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 10);
    }
}

PrintArray(numbers);