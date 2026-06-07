using System.Net.NetworkInformation;

public class Papu
{
    public void ejemplo1()
    {
        /*Arreglos Unidimensionales
        Estructura que guarda distintos elementos del mismo tipo en la misma línea/lista
        Ejemplo: 
        */
        int[] numeros = { 13, 3, 22 };
        /*Cuando conocemos el tamaño pero no el contenido del arreglo
        string[] nombres= new string[3]; */

        //Métodos

        //Búsqueda: Para buscar un elemento
        string[] fruta = { "Ciruela", "Platano", "Uva" };
        Console.WriteLine(fruta[1]);

        //Actualización: Para cambiar un elemento
        string[] frutas = { "Ciruela", "Platano", "Uva" };
        frutas[1] = "Sandía";
        Console.WriteLine(frutas[1]);
        double[] numero = { 13.5, 1008, 20.91, 2845 };
        double[] numero2 = new double[2];
        numero2[1] = 12;
        /*
        Eliminación: Para borrar un elemento


        Ventajas:
        Permiten guardar muchos datos
        Ayudan a organizar información
        Es rápido


        Desventajas:
        Deben ser el mismo tipo
        En algunos lenguajes, es limitado 
        Si se elimina algún elemento, altera el posicionamiento y causar desorden



        Mini ejercicio:
        let nombres = ["Fiona", "Fredy", "Cosmo"];
        console.log(nombres);
        nombres[2] = "Fredo";
        console.log(nombres);

        Javascript no es tipado, C# sí lo es.
        Tipado = se debe definir el tipo de dato
        los corchetes los ponemos después del tipo de dato para decirle al compilador
        "ey cabrón, voy a crear un objeto de la clase arreglo"
        */
    }

    public void Ejemplo2()
    {
        int[] numeros3 = { 10, 20, 30, 13, 100 };
        for (int i = 0; i <= numeros3.Length-1; i++) /* ojo con el <= y con el i= [i]*/
        {
            Console.WriteLine($"El elemento en la posición {i} y es {numeros3[i]}");
        }

        Array.Clear(numeros3,1,numeros3.Length-1); /*se está limpiando*/
        
            Console.WriteLine("");
        for(int i=0; i<numeros3.Length; i++)
        {
            Console.WriteLine($"El elemento en la posición es {i} y es {numeros3[i]}");
        }
    }
}
