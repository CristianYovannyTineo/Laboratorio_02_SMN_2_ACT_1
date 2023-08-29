// See https://aka.ms/new-console-template for more information

//Se desea realizar un programa en C#. Que calcule el mayor de 3 numeros enteros ingresador por teclado.

int numero1, numero2, numero3;

// ingresar los numeros

Console.WriteLine("Ingrese el numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el numero");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el numero");
numero3 = int.Parse(Console.ReadLine());

if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
{
    int numeromayor = numero1;

    if (numero2 > numero1)
    {
        numeromayor = numero2;
    }
    if (numero3 > numeromayor) { numeromayor = numero3; }

    Console.WriteLine("El numero mayor es: " + numeromayor);
}
else
{
    Console.WriteLine("Los numeros no deben de ser iguales");
}
