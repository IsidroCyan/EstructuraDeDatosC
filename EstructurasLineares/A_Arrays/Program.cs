CuentaBancaria CuentaAhorro = new CuentaBancaria (5);
    //*llamar el metodo, colocando el objeto y después el metodo
 //*adentro del parentesis, cuando llamamos la funcion pasamos a un argumento


CuentaAhorro.AgregarMonto(529);
CuentaAhorro.AgregarMonto(800);
CuentaAhorro.AgregarMonto(498);
CuentaAhorro.AgregarMonto(901);
CuentaAhorro.AgregarMonto(1000);
//[10,50,100,50,30]
//CuentaAhorro.EliminarMonto(2)
//[10,50,0,50,30]
CuentaAhorro.Average();
CuentaAhorro.EliminarMonto(2);
CuentaAhorro.mostrardatos();
