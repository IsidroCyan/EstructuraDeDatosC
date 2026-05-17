public class Arreglos
{
    public void Ejemplo1()
    {
        string [] nombres = new string [3]; 

        string [] nombres1 = {"sofia", "maria", "ana"}; 
        Console.WriteLine(nombres1[0]);
        Console.WriteLine(nombres1[1]);
        Console.WriteLine(nombres1[2]);

        //para actualizar un dato 
        nombres1[5]= "martha"; 

        //eliminar datos
        Array.Clear(nombres1,2,1); 
        nombres1[1] = null;






    }

}
