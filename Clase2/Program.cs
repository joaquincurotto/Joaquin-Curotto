// EJERCICIO 1
/* Saber si persona es >= de edad
short sEdad;
Console.WriteLine("EJERCICIO 1");
Console.WriteLine("Ingrese su edad: ");
sEdad = short.Parse(Console.ReadLine());
    if (sEdad>=18)
    {
        Console.WriteLine("Es mayor de edad/");
    }
*/
// EJERCICIO 2
/* Si es mayor de edad indicar que es mayor
 * en caso contrario indicar que es menor de edad

Console.WriteLine("EJERCICIO 2");
if (sEdad < 18)
{
    Console.WriteLine("Es menor de edad");
}
else
{
    Console.WriteLine("Es mayor de edad");
}
 */
// EJERCICIO 3
/* Validar contrasena
 */

using System.Diagnostics.Contracts;

const int iContra = 99999999;
int iIntentos = 0;
Console.WriteLine("Ingrese su contrasena: ");
String  sContra = Console.ReadLine();


    if (Int32.Parse(sContra).Equals(iContra))
    {
        Console.WriteLine("Bienvenido!!!");
    }
    if (!Int32.Parse(sContra).Equals(iContra))
    {
        Console.WriteLine("Ingrese su contrasena: ");
        sContra = Console.ReadLine();
            if (Int32.Parse(sContra).Equals(iContra))
            {
                Console.WriteLine("Bienvenido!!!");
            }else { Console.WriteLine("CHAU!!!"); }
}
