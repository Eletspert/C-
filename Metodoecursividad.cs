void ImprimirNumero(int x)
{
    if (x > 0)
    {
        Console.WriteLine(x);
        ImprimirNumero(x - 1);
    }
}

ImprimirNumero(5);
