// EJERCICIO 1
/*
 * guardar los siguientes datos en variables y mostrarlos por consola:
 * Nombre: 
 * Apellido: 
 * DNI:
 * Edad:
 * Altura:
*/
Console.WriteLine("EJERCICIO 1");
String sNombre;
String sApellido;
int iDNI;
int iEdad;
double dAltura;


Console.WriteLine("Ingrese su nombre:");
sNombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido:");
sApellido = Console.ReadLine();
Console.WriteLine("Ingrese su DNI:");
iDNI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su edad:");
iEdad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su altura:");
dAltura = double.Parse(Console.ReadLine());


Console.WriteLine("Nombre: {0}, Apellido: {1}, DNI: {2}, Edad: {3}, altura: {4}", sNombre, sApellido, iDNI, iEdad, dAltura);


//EJERCICIO 2
/*Ingresar dos números por teclado y luego 
 * mostrar el resultado de la suma por consola.
 */
Console.WriteLine("EJERCICIO 2");
int iNum1, iNum2, suma;
Console.WriteLine("Ingrese un numero:");
iNum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero:");
iNum2 = Convert.ToInt32(Console.ReadLine());
suma = iNum1 + iNum2;
Console.WriteLine("La suma de los dos numeros es: " + suma);

//EJERCICIO 3
/*Utilizando las variables nombre y apellido de la actividad 1 . 
 * Muestre las dos variables en un solo console.readline , 
 * poniendo en el medio su alias.
 */
Console.WriteLine("EJERCICIO 3");
Console.WriteLine("Mi nombre es:" + sNombre + "'el canario' " + sApellido);
Console.ReadKey();