using HolaMundo;
// See https://aka.ms/new-console-template for more information

String sNombre;
int iEdad;
Bienvenida bienvenida = new Bienvenida();

Console.WriteLine("Bienvenidos al curso de C#");

Console.WriteLine("Ingrese su nombre: ");
sNombre = Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
iEdad = int.Parse(Console.ReadLine());

if (iEdad >= 18)
{
    bienvenida.DarBienvenida(sNombre,iEdad);
}
else {
    Console.WriteLine("{0} es menor de edad", sNombre);
}



Console.ReadKey();
