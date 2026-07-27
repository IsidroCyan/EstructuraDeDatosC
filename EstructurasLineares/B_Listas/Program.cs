/*List<int>listaNumeros=new List<int>();
listaNumeros.Add(1);
listaNumeros.Add(5);
listaNumeros.Add(6);
listaNumeros.Add(7);
listaNumeros.Add(3);

foreach(int listaNumero in listaNumeros)
{
    Console.WriteLine(listaNumero); 
}

for(int i=0; i<listaNumeros.Count; i++)
{
    Console.WriteLine($"{listaNumeros[i]}");
}
*/
MiLista administradorDatos = new MiLista(); 
administradorDatos.Agregar(1);
administradorDatos.Agregar(2);
administradorDatos.Agregar(3);
administradorDatos.Agregar(4);
administradorDatos.Agregar(5);
administradorDatos.Agregar(6);
administradorDatos.Agregar(7);
administradorDatos.Agregar(8);
administradorDatos.Agregar(9);
administradorDatos.Agregar(10);
administradorDatos.Agregar(11);
administradorDatos.Agregar(12);
administradorDatos.Agregar(13);
administradorDatos.Agregar(14);
administradorDatos.Agregar(15);

administradorDatos.MostrarDatos();
administradorDatos.EliminarElemento(3);
Console.WriteLine(" ");
administradorDatos.MostrarDatos(); 
