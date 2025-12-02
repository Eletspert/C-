double[][] calificaciones = new double[3][];
calificaciones[0] = new [] {10,9,8.8};
calificaciones[1] = new[] {2.6,7.7 };
calificaciones[2] = new[] {9,9,10,4.5,2};

double numero = 0;
double promedio = 0;
double resultado = 0;


for  (int i = 0;i <calificaciones.Length;i++)
{
    for (int j = 0; j < calificaciones[i].Length; j++)
    {
        numero =+ calificaciones[i][j];
        promedio += numero;

    }

    resultado = promedio / calificaciones[i].Length;
    Console.WriteLine($"La calificacion del alumno No. {i+1} es: {resultado:0.##} ");
    promedio = 0;
    
}
