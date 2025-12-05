int diez = 10;
int cero = 0;

try
{
	int resultado = diez/0;
}
catch (DivideByZeroException ex)
{
	Console.WriteLine("No se puede dividir entre 0");
	
}
finally
{
	Console.WriteLine("programa terminado");
}
