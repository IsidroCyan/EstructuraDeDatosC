CuentaBancaria CuentaAhorro = new CuentaBancaria(5); 
//CuentaAhorro.Average();

CuentaAhorro.AgregarMonto(55);
CuentaAhorro.AgregarMonto(10);
CuentaAhorro.AgregarMonto(32);
CuentaAhorro.AgregarMonto(25);
CuentaAhorro.AgregarMonto(70);


Console.WriteLine("");
CuentaAhorro.MostrarDatos();

Console.WriteLine("");
CuentaAhorro.Average();
Console.WriteLine("");

CuentaAhorro.EliminarMonto(2);
Console.WriteLine("");
CuentaAhorro.MostrarDatos();
