void num (int a)
{
    int result = 0;
    while (a > 0)
    {
        int sum = a % 10;
        result = result + sum;
        a = a / 10;
        
    }
    Console.WriteLine(result);
    
}

num(568);
num(57943);
num(19);







