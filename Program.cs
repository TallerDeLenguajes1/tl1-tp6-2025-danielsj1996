// See https://aka.ms/new-console-template for more information
/*Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.*/
string respuesta;
do
{
 Console.Clear(); // Limpia la pantalla antes de mostrar el menú
    int opcion = MostrarMenu();
    switch (opcion)
    {
        case 1:
            RealizarSuma();
            break;
        case 2:
            RealizarResta();

            break;
        case 3:
            RealizarMultiplicacion();

            break;
        case 4:
            RealizarDivision();

            break;
        case 5:
            Console.WriteLine("Saliendo del programa.....");
            break;
        default:
            Console.WriteLine("opcion no válida.");
            break;
    }
            Console.Write("¿Desea realizar otra operación? (s/n): ");
            respuesta = Console.ReadLine().ToLower();

} while (respuesta == "s");

// Función para mostrar el menú y devolver la opción elegida
int MostrarMenu()
{
    Console.WriteLine("\nBienvenido a la Calculadora");
    Console.WriteLine("Seleccione la opción deseada: ");
    Console.WriteLine(" 1) SUMA");
    Console.WriteLine(" 2) RESTA");
    Console.WriteLine(" 3) MULTIPLICACIÓN");
    Console.WriteLine(" 4) DIVISIÓN");
    Console.WriteLine(" 5) SALIR");
    Console.Write("Opción: ");

    if (int.TryParse(Console.ReadLine(), out int opcion))
        return opcion;
    else
        return -1; // valor inválido
}

void RealizarSuma()
{
    Console.WriteLine("SUMA");
    int num1 = LeerNumero("Ingrese el primer numero: ");
    int num2 = LeerNumero("Ingrese el segundo numero: ");
    Console.WriteLine($"Resultado = {num1 + num2}");

}
void RealizarResta()
{
    Console.WriteLine("RESTA");
    int num1 = LeerNumero("Ingrese el primer numero: ");
    int num2 = LeerNumero("Ingrese el segundo numero: ");
    Console.WriteLine($"Resultado = {num1 - num2}");

}
void RealizarMultiplicacion()
{
    Console.WriteLine("MULTIPLICACION");
    int num1 = LeerNumero("Ingrese el primer numero: ");
    int num2 = LeerNumero("Ingrese el segundo numero: ");
    Console.WriteLine($"Resultado = {num1 * num2}");
}
void RealizarDivision()
{
    Console.WriteLine("DIVISION");
    int num1 = LeerNumero("Ingrese el primer numero: ");
    int num2 = LeerNumero("Ingrese el segundo numero: ");
    if (num2 != 0)
    {

        Console.WriteLine($"Resultado = {(double)num1 / num2}");
    }
    else
    {
        Console.WriteLine("No puede realizarse una division por 0");
    }
}

static int LeerNumero(string mensaje)
{
    Console.Write(mensaje);
    int numero=0;
    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.Write("Entrada inválida. Intente de nuevo: ");
    }
    return numero;
}
