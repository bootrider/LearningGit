// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hola Mundo");

int suma_fibo_par = 2, i = 1, j = 2, suma = 0;
while (i < 4000000)
{
    suma = i + j;
    i = j;
    j = suma;
    Console.WriteLine(suma);
    if (suma % 2 == 0)
    {
        Console.WriteLine("suma es par" + suma);
        suma_fibo_par += suma;
    }
}
Console.WriteLine("fibo suma= ", suma_fibo_par);


Console.ReadKey();