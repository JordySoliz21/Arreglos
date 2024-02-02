Double[] Sueldos;
Sueldos = new Double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese el sueldo del empleado" + (i + 1));
    Sueldos[i] = Double.Parse(Console.ReadLine());
}
Console.WriteLine("Los sueldos ingresados son:");
    for (int i = 0; i < 5; i++)
    {
     Console.Write("\t" + Sueldos[i]);
    }

Console.ReadKey();