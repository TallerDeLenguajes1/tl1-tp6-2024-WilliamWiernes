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

// Ejercicio 3
double num;
bool resul;

do
{
    Console.WriteLine("Ingrese un número decimal: ");
    string ingreso = Console.ReadLine();
    resul = double.TryParse(ingreso, out num);
} while (!resul);

Console.WriteLine("Valor absoluto: " + Math.Abs(num));
Console.WriteLine("Cuadrado : " + Math.Pow(num, 2));
Console.WriteLine("Raíz cuadrada: " + (num >= 0 ? Math.Sqrt(num).ToString() : "Número no válido"));
Console.WriteLine("Seno: " + Math.Sin(num));
Console.WriteLine("Coseno: " + Math.Cos(num));
Console.WriteLine("Parte entera: " + Math.Truncate(num));

int num1, num2;

do
{
    Console.WriteLine("Ingrese el primer número: ");
    string ingreso = Console.ReadLine();
    resul = int.TryParse(ingreso, out num1);
} while (!resul);

do
{
    Console.WriteLine("Ingrese el segundo número: ");
    string ingreso = Console.ReadLine();
    resul = int.TryParse(ingreso, out num2);
} while (!resul);

if (num1 > num2)
{
    Console.WriteLine("Número 1 es el máximo");
    Console.WriteLine("Número 2 es el mínimo");
}
else if (num2 > num1)
{
    Console.WriteLine("Número 2 es el máximo");
    Console.WriteLine("Número 1 es el mínimo");
}
else
{
    Console.WriteLine("Los números son iguales");
}