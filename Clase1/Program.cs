// Imprimimos el mensaje
Console.WriteLine("Hola MUNDO!");

//Declaramos variables de tipo string
String sNombre;
String sApellido;
int iEdad;

//Asignemos valor a las variables previamente creadas
//sNombre
Console.WriteLine("Ingrese su nombre: ");
sNombre = Console.ReadLine();

//sApellido
Console.WriteLine("Ingrese su apellido: ");
sApellido = Console.ReadLine();

//iEdad
Console.WriteLine("Ingrese su edad: ");
/*Para almacenar el tipo de dato entero que obtenemos por consola,
 * tenemos que convertirlo ya que al obtenerlo de la consola
 * C# lo obtiene como String
*/
iEdad = int.Parse(Console.ReadLine());
//iEdad = Convert.ToInt32(Console.ReadLine());

//Mostrar los datos ingresados
Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}", sNombre, sApellido, iEdad);

//Se queda esperando a que el usuario presione alguna tecla
Console.ReadKey();