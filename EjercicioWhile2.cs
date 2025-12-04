
double Promedio = 0;
int i = 0;
while (i <= 5 )
{
 
    Console.WriteLine($"Escribe el promedio de las materias numero {i}");
    double notas = Convert.ToDouble(Console.ReadLine());
    Promedio += notas;
    i++;
}

Console.WriteLine($"Aqui esta tu promedio bb {Promedio / 5}");

