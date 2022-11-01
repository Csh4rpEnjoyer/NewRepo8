int[,] GenerateMatr(int n)
{
    int[,] matr = new int[n, n];
    Random r = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = r.Next(8);
        }
    }
    return matr;
}

void WriteMatr(int[,] matr, string path)
{
    int n = matr.Length;
    using (StreamWriter writer = new StreamWriter(path))
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                writer.Write("{0} ", matr[i, j]);
            writer.WriteLine();
        }
    }
}

int[,] ReadMatr(string path, int n)
{
    using StreamReader reader = new StreamReader(path);
    int[,] matr = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        string[] s = reader.ReadLine().Split(" ");
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = int.Parse(s[j]);
        }

    }
    return matr;
}

void Print(int[,] matr)
{
    int n = matr.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{matr[i, j],4}");
        Console.WriteLine();
    }
}


// 1 variant
bool simple(int n)
{
    for (int i = 2; i < n / 2; i++)
    {
        if (n % i == 0)
            return false;
        break;
    }
    return true;
}

int[,] arr = GenerateMatr(3);
Print(arr);
int mn = int.MinValue;
int mx = int.MaxValue;
int i_min = 0;
int j_min = 0;
int i_max = 0;
int j_max = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] < mn)
        {
            mn = arr[i, j];
            i_min = i;
            j_min = j;
        }
        if (arr[i, j] > mx)
        {    
            mx = arr[i, j];
            i_max = i;
            j_max = j;
    }
}
Console.WriteLine($" max = {mx}, min = {mn}");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i=i_min)
            {
                arr[i_min, j] =
            }
        }




