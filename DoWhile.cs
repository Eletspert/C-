//Dar el peso ideal



Console.WriteLine("Escribe tu altura en centimetros");
double Altura = Convert.ToInt32(Console.ReadLine());

String Genero = "";

double Peso = 0;
do
{
    Console.WriteLine("Escribe tu genero: \n1)H \n2)M");
    Genero = Console.ReadLine();
}
while(Genero.Equals("H",StringComparison.OrdinalIgnoreCase) && Genero.Equals("M", StringComparison.OrdinalIgnoreCase)) ;


if (Genero.Equals("H", StringComparison.OrdinalIgnoreCase))
{

    Peso = 10;

}
else if (Genero.Equals("M", StringComparison.OrdinalIgnoreCase))
{
    Peso = -10;
}

Console.WriteLine($"Tu peso ideal es de {Altura + Peso} ");
