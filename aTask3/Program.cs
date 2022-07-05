int[] arr (int N, int len)
{
    int[] result = new int [N];
    for (int i = 0; i < len; i++)
    {
        int random = new Random().Next(0, N);
        result[i] = random;
        Console.Write(result[i] + " ");
    }
    Console.WriteLine();
    return result;
    
}

arr(100,5);
arr(50, 8);
arr(20, 15);



