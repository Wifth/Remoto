// See https://aka.ms/new-console-template for more information

//Ejercicio 13

int T = 0, s = 0, f = 0, sm, dm = 0, sd, Stotal = 0, t1 = 0, t2 = 0;

Console.Write("Ingrese la cantidad de trabajadores: ");
T = int.Parse(Console.ReadLine());

for (int x = 1; x <= T; x++) 
{
    Console.Write("Ingrese su nombre: ");
    string n = Console.ReadLine();
    Console.Write("Ingrese su sueldo: ");
    s = int.Parse(Console.ReadLine());
    Console.Write("Ingrese la cantidad de faltas: ");
    f = int.Parse(Console.ReadLine());

    Stotal += s;
    dm = 30 - f;
    sd = s / 30;
    sm = s - (f * sd);

    if (sm >= 2500 && sm <= 3500)
        t1++;
    else if (sm < 1000 || sm > 4000)
        t2++;

    Console.WriteLine("Días trabajados: " + dm);
    Console.WriteLine("Sueldo: " + sm);
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("Sueldos totales: " + Stotal);
Console.WriteLine("");
Console.WriteLine("Entre 2500 y 3500: " + t1);
Console.WriteLine("Menos de 1000 y más de 4000: " + t2);
