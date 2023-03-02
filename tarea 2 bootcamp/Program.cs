
Console.WriteLine("Ingrese sus datos");

Console.WriteLine("ingresa tu nombre: ");
string Nombre=Console.ReadLine();

Console.WriteLine("ingresa tu apellido: ");
string Apellido=Console.ReadLine();

Console.WriteLine("ingresa tu edad: ");
int edad=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿sabe programar? ");
string respuesta=Console.ReadLine();


string mensaje = ("Hola, "+Nombre +" "+ Apellido + ",tu edad es "+edad + " y "+respuesta+" sabes programar.");
Console.WriteLine(mensaje);






