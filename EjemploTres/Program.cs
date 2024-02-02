Console.Title = "Ejemplo4 utilizando la instrucción foreach";
int[] Edades = new int[5];
int Total = 0;
Edades = new int[5];

for (int x = 0; x < Edades.Length; x++)
{
    Console.WriteLine("Ingresa la edad del estudiante" + (x + 1));
    Edades[x] = int.Parse(Console.ReadLine());
}

foreach (int element in Edades)
{
    Total = Total + element;
}
    Console.WriteLine("La sumatoria de las edades es: " + Total);

    Console.ReadKey();
