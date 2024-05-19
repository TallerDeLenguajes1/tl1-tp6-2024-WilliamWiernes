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