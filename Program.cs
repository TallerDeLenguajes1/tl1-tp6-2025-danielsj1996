// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;
a = 10;
b = a;

Console.WriteLine("Valor de a: " + a);

Console.WriteLine("Valor de b: " + b);

/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.*/
int numero=0;
bool esNumeroValido = false;

while (!esNumeroValido || numero <= 0)
{

    Console.WriteLine("Ingrese un numero entero positivo: ");
    string? entrada = Console.ReadLine();

    // Verifica si es un número entero válido
    esNumeroValido = int.TryParse(entrada, out numero);

    if (!esNumeroValido || numero <= 0)
    {
        Console.WriteLine("Numero invalido. Intente nuevamente");
    }
}


    int original = numero;
    int invertido = 0;
    while (original > 0)
    {
        int digito = original % 10;
        invertido = invertido * 10 + digito;
        original /= 10;
    }
    Console.WriteLine($"Numero Invertido: {invertido}");

    


