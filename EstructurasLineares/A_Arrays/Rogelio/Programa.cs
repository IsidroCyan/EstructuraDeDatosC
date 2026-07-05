

public class Ejecutor
{
    public static void Ejecutar()
    {
        RegistroEstacionamiento Cajon = new RegistroEstacionamiento(10);


        Cajon.AgregarCarro(5158);
        Cajon.AgregarCarro(1313);
        Cajon.AgregarCarro(2020);
        Cajon.AgregarCarro(9874);
        Cajon.AgregarCarro(1845);
        Cajon.AgregarCarro(0);
        Cajon.AgregarCarro(1234);
        Cajon.AgregarCarro(3333);
        Cajon.AgregarCarro(0);
        Cajon.AgregarCarro(1010);
    }
}