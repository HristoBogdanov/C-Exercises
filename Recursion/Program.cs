using System;

int n=int.Parse(Console.ReadLine());

static int Factorial(int n)
{
    if(n==0)
    {
        return 1;
    }
    else
    {
        return n*Factorial(n-1);
    }
}

static int Fibonacci(int n)
{
    if(n==1 || n==2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

Console.WriteLine(Factorial(n));
Console.WriteLine(Fibonacci(n));