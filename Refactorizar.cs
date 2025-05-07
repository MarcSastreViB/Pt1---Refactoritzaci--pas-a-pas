using System;

class Refactorizar
{
	public static void Main()
	{
    	string nombre = "Juan";
    	int edad = 45;
    	double salario = 2500;

    	if (edad >= 18) {
        	Console.WriteLine("Bienvenido: " + nombre);
        	Console.WriteLine("Edad: " + edad);
        	Console.WriteLine("Salario: " + salario);
        	double aumento = 0.05;
        	salario = salario + salario * aumento;
        	Console.WriteLine("Nuevo salario: " + salario);
    	}
	}
	static void MostrarInformacion(string nombre, int edad, double salario)
	{
		Console.WriteLine("Bienvenido: " + nombre);
		Console.WriteLine("Edad: " + edad);
		Console.WriteLine("Salario: " + salario);
		double aumento = 0.05;
		salario = salario + salario * aumento;
		Console.WriteLine("Nuevo salario: " + salario);
	}

	static bool esMayor(string n, int e)
	{
    	return e >= 18;
	}
}