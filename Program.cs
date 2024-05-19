// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b); */

/* // Ejercicio 1
int salida;
bool resul;

do
{
    Console.WriteLine("Ingrese un número mayor a 0: ");
    string ingreso = Console.ReadLine();
    resul = int.TryParse(ingreso, out salida);
} while (!resul || salida <= 0);

int numInvertido = 0, ultimoDig;

while (salida > 0)
{
    ultimoDig = salida % 10;
    numInvertido = numInvertido * 10 + ultimoDig;
    salida /= 10;
}

Console.WriteLine("Número invertido: " + numInvertido); */

// Ejercicio 4
string cadena1, cadena2;

Console.Write("Ingrese una cadena de texto: ");
cadena1 = Console.ReadLine();
Console.WriteLine($"Longitud de la cadena de texto: {cadena1.Length}");

Console.Write("Ingrese una segunda candena de texto: ");
cadena2 = Console.ReadLine();
Console.WriteLine($"Cadenas de texto concatenadas: {string.Concat(cadena1, cadena2)}");

Console.WriteLine($"Subcadena de la primera cadena de texto: {cadena1.Substring(1, 6)}");

// Calculadore ejercicio 2

int continuar = 1, opcion;
double num1, num2;
bool resul;
while (continuar == 1)
{
    opcion = Menu();

    switch (opcion)
    {
        case 1:
            do
            {
                Console.WriteLine("Ingrese el número 1: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num1);
            } while (!resul);

            do
            {
                Console.WriteLine("Ingrese el número 2: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num2);
            } while (!resul);

            Console.WriteLine($"La suma de {num1} y de {num2} es igual a: {num1 + num2}");
            break;
        case 2:
            do
            {
                Console.WriteLine("Ingrese el número 1: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num1);
            } while (!resul);

            do
            {
                Console.WriteLine("Ingrese el número 2: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num2);
            } while (!resul);

            Console.WriteLine($"La resta de {num1} y de {num2} es igual a: {num1 - num2}");
            break;
        case 3:
            do
            {
                Console.WriteLine("Ingrese el número 1: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num1);
            } while (!resul);

            do
            {
                Console.WriteLine("Ingrese el número 2: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num2);
            } while (!resul);

            Console.WriteLine($"La multiplicación de {num1} y de {num2} es igual a: {num1 * num2}");
            break;
        case 4:
            do
            {
                Console.WriteLine("Ingrese el número 1: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num1);
            } while (!resul);

            do
            {
                Console.WriteLine("Ingrese el número 2: ");
                string ingreso = Console.ReadLine();
                resul = double.TryParse(ingreso, out num2);
            } while (!resul || num2 == 0);

            Console.WriteLine($"La division de {num1} y de {num2} es igual a: {num1 / num2}");
            break;
        default:
            Console.WriteLine("Opcion no reconocida...");
            break;
    }

    continuar = Continuar();
}

static int Menu()
{
    int opcion;
    bool resul;

    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    do
    {
        Console.WriteLine("Opcion: ");
        string ingreso = Console.ReadLine();
        resul = int.TryParse(ingreso, out opcion);
    } while (!resul);

    return opcion;
}

static int Continuar()
{
    int continuar;
    bool resul;

    do
    {
        Console.WriteLine("Desea realziar otra operación? [0] NO [1] SI");
        string ingreso = Console.ReadLine();
        resul = int.TryParse(ingreso, out continuar);
    } while (!resul || (continuar != 0 && continuar != 1));

    return continuar;
}

Console.WriteLine("Mostrando elemento por elemento de la primera cadena:");
foreach (char elemento in cadena1)
{
    Console.WriteLine(elemento);
}

string palabraABuscar;
Console.Write("Ingrese la palabra a buscar en la primer cadena: ");
palabraABuscar = Console.ReadLine();

int palabraEncontradaIndex = cadena1.IndexOf(palabraABuscar);

Console.WriteLine($"{(palabraEncontradaIndex != -1 ? $"Palabra encontrada en la posición {palabraEncontradaIndex}" : "Palabra no encontrada")}");

Console.WriteLine($"Cadena 1 en mayúsculas: {cadena1.ToUpper()}");
Console.WriteLine($"Cadena 1 en minúsuclas: {cadena1.ToLower()}");

string cadenaASeparar;
Console.Write("Ingrese una cadena de texto separada por /: ");
cadenaASeparar = Console.ReadLine();

string[] cadenaSeparada = cadenaASeparar.Split("/");
foreach (string palabra in cadenaSeparada)
{
    Console.WriteLine(palabra);
}

// Calculadore ejercicio 2
continuar = 1;
string operacion;
string[] operacionSeparada;
bool resul2;
opcion = 0;
while (continuar == 1)
{
    do
    {
        Console.Write("Ingrese una ecuación simple (+, -, *, /): ");
        operacion = Console.ReadLine();
        operacionSeparada = operacion.Split('+', '-', '*', '/');

        resul = double.TryParse(operacionSeparada[0], out num1);
        resul2 = double.TryParse(operacionSeparada[1], out num2);
    } while (!resul || !resul2);

    if (operacion.Contains('+'))
    {
        opcion = 1;
    }
    else if (operacion.Contains('-'))
    {
        opcion = 2;
    }
    else if (operacion.Contains('*'))
    {
        opcion = 3;
    }
    else if (operacion.Contains('/'))
    {
        opcion = 4;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"La suma de {num1} y de {num2} es igual a: {num1 + num2}");
            break;
        case 2:
            Console.WriteLine($"La resta de {num1} y de {num2} es igual a: {num1 - num2}");
            break;
        case 3:
            Console.WriteLine($"La multiplicación de {num1} y de {num2} es igual a: {num1 * num2}");
            break;
        case 4:
            Console.WriteLine($"La division de {num1} y de {num2} es igual a: {num1 / num2}");
            break;
        default:
            Console.WriteLine("Operación no reconocida...");
            break;
    }

    continuar = Continuar();
}