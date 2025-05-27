// See https://aka.ms/new-console-template for more information
/*Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
calculadora.. Solicite al usuario un número y muestre por pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
*/
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
            Adicionales();

            break;
        case 6:
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
    Console.WriteLine(" 5) OPERACIONES ADICIONALES");
    Console.WriteLine(" 6) Salir");
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

void Adicionales()
{

    int numero = LeerNumero("Ingrese el numero para realizar las operaciones adicionales: ");

    Console.WriteLine($"Valor Absoluto =" + Math.Abs(numero));

    Console.WriteLine($"Cuadrado = " + Math.Pow(numero, 2));
    if (numero >= 0)
    {
        Console.WriteLine($"Raiz Cuadrada = " + Math.Sqrt(numero));

    }
    else
    {
        Console.WriteLine("No es posible calcular (numero negativo)");
    }

    double radianes = numero * (Math.PI / 180);
    Console.WriteLine($"Seno (grados): {Math.Sin(radianes)}");
    Console.WriteLine($"Coseno (grados): {Math.Cos(radianes)}");

    double numero2 = 0;
    double.TryParse(Console.ReadLine(), out numero2);
    Console.WriteLine($"Parte entera (Truncada): {Math.Truncate(numero2)}");
}

static int LeerNumero(string mensaje)
{
    Console.Write(mensaje);
    int numero = 0;
    while (!int.TryParse(Console.ReadLine(), out numero))
    {
        Console.Write("Entrada inválida. Intente de nuevo: ");
    }
    return numero;
}
