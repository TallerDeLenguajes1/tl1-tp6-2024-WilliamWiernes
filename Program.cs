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

// Ejercicio 2

int continuar = 1, opcion;
double suma, resta, multiplicacion, division;
while (continuar == 1)
{
    opcion = Menu();

    switch (opcion)
    {
        case 1:
            suma = Suma();
            Console.WriteLine("Resultado de la suma: " + suma);
            break;
        case 2:
            resta = Resta();
            Console.WriteLine("Resultado de la resta: " + resta);
            break;
        case 3:
            multiplicacion = Multiplicacion();
            Console.WriteLine("Resultado de la multiplicación: " + multiplicacion);
            break;
        case 4:
            division = Division();
            Console.WriteLine("Resultado de la división: " + division);
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

static double Suma()
{
    double num1, num2;
    bool resul;

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

    return num1 + num2;
}

static double Resta()
{
    double num1, num2;
    bool resul;

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

    return num1 - num2;
}

static double Multiplicacion()
{
    double num1, num2;
    bool resul;

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

    return num1 * num2;
}

static double Division()
{
    double num1, num2;
    bool resul;

    do
    {
        Console.WriteLine("Ingrese el número 1: ");
        string ingreso = Console.ReadLine();
        resul = double.TryParse(ingreso, out num1);
    } while (!resul);

    do
    {
        Console.WriteLine("Ingrese el número 2 (distinto de 0): ");
        string ingreso = Console.ReadLine();
        resul = double.TryParse(ingreso, out num2);
    } while (!resul || num2 == 0);

    return num1 / num2;
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