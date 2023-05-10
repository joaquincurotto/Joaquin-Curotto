using Joaquin_Curotto;



Usuario u1 = new Usuario(10, "nombre", "apellido","nombreUsuario", "contrasena", "mail");


Console.WriteLine("Ingrese su nombre");

String p= Console.ReadLine();

u1.SetNombre(p);

Console.WriteLine(u1.GetNombre());  