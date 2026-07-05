using Liz;
Liz.CuentaBancaria CuentaAhorro = new Liz.CuentaBancaria (5);
Liz.CuentaBancaria deposito = new Liz.CuentaBancaria(3); 

CuentaAhorro.AgregarMonto(200);
CuentaAhorro.AgregarMonto(100);

deposito.AgregarMonto(50);
deposito.AgregarMonto(100);

Console.WriteLine("Dinero de deposito");
deposito.MostrarDatos();

Console.WriteLine("Dinero de cuenta ahorro");
CuentaAhorro.MostrarDatos();
//     //*llamar el metodo, colocando el objeto y después el metodo
//  //*adentro del parentesis, cuando llamamos la funcion pasamos a un argumento


// /*CuentaAhorro.AgregarMonto(529);
// CuentaAhorro.AgregarMonto(800);
// CuentaAhorro.AgregarMonto(498);
// CuentaAhorro.AgregarMonto(901);
// CuentaAhorro.AgregarMonto(1000);
// //[10,50,100,50,30]
// //CuentaAhorro.EliminarMonto(2)
// //[10,50,0,50,30]
// CuentaAhorro.Average();
// CuentaAhorro.EliminarMonto(2);
// CuentaAhorro.mostrardatos();
// */
// CuentaAhorro.AgregarMonto(0);
// CuentaAhorro.AgregarMonto(10);
// CuentaAhorro.AgregarMonto(0);
// CuentaAhorro.AgregarMonto(25);
// CuentaAhorro.AgregarMonto(0);

// CuentaAhorro.capacidad();
// CuentaAhorro.tamaño();


// /*
// int busqueda = CuentaAhorro.Buscar(70);
// Console.WriteLine($"{busqueda}");
// CuentaAhorro.MostrarDatos();

// Console.WriteLine("");
// CuentaAhorro.Average();
// Console.WriteLine("");
// */
// //CuentaAhorro.EliminarMontoPorIndice(3); 
// /*Console.WriteLine("\n\n");
// CuentaAhorro.MostrarDatos();
// Console.WriteLine("\n\n");
// CuentaAhorro.mostrarIndice();
// Console.WriteLine("");
// //CuentaAhorro.AgregarMonto(600);
// //CuentaAhorro.AgregarMonto(500);
// //CuentaAhorro.AgregarMonto(700);
// CuentaAhorro.MostrarDatos();
// Console.WriteLine("\n");
// CuentaAhorro.mostrarIndice();
// Console.WriteLine("\n\n");
// // CuentaAhorro.EliminarMontoPorIndice(4); 
// // CuentaAhorro.EliminarMontoPorIndice(4); 
// // CuentaAhorro.MostrarDatos();
// // Console.WriteLine("\n");
// // CuentaAhorro.mostrarIndice();

// CuentaAhorro.is_vacio();
// */

// int eliminado = CuentaAhorro.pop();
// Console.WriteLine($"{eliminado}");