void Output(int[]? array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.WriteLine(array[i]);
    }
}

void Input(int[]? array)
{
    for (int i = 0; i < 8; ++i)
        array[i] = int.Parse(Console.ReadLine());
}

int[] array = new int[8];
Input(array);

Console.WriteLine();

Output(array);