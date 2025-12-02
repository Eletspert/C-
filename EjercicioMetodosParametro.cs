int[] nums = {1,6543,1242,13,4};


void encontrarMenorMayor (int[] arreglo)
{
    int mayor = arreglo[0];
    int menor = arreglo[0];
    Console.WriteLine("Array:");
    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.Write ( $" {  arreglo[i] } ");
        if (mayor < arreglo[i])
        {
            mayor = arreglo[i];
        }
        else if (menor > arreglo[i])
        {
            menor = arreglo[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"El mayor es {mayor} y el menor es {menor}");
}


encontrarMenorMayor(nums);
