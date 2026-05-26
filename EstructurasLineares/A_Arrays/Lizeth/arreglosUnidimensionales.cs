public class Arreglos
{
    public void Ejemplo1()
    {   
        //cuando conocemos el tamaño pero no el contenido del arreglo
        string [] nombres = new string [3]; 

        //cuando el contenido define el tamaño y sabemos el contenido  
        string [] nombres1 = {"sofia", "maria", "ana"}; 
        Console.WriteLine(nombres1[0]);
        Console.WriteLine(nombres1[1]);
        Console.WriteLine(nombres1[2]);

        //para actualizar un dato 
        nombres1[1]= "martha"; 

        //eliminar datos
        Array.Clear(nombres1,2,1); 

       // nombres1[1] = null;

    }

    public void Ejemplo2()
    {
        string[] nombre = {"maria", "ana", "flor", "andrea", "juana"};
        

        for(int i=0; i<nombre.Length; i++)
        {
            Console.WriteLine($"El elemnto en la posicion es {i} y es {nombre[i]}"); 
        }

        Array.Clear(nombre,2,2);
         
         Console.WriteLine(""); 
        for(int i=0; i<nombre.Length; i++)
        {
            Console.WriteLine($"El elemento en la posicion es {i} y es {nombre[i]}"); 
        }
    }

    public void Metodos()
    {      
        
        //array.sort ordena los datos de menos a mas 

        int[] edades = [10, 5, 16, 8];
        Array.Sort(edades); 
        
        Array.ForEach(edades, Console.WriteLine);

        Console.WriteLine(""); 

        Array.Reverse(edades);
        Array.ForEach(edades, Console.WriteLine); 

        Console.WriteLine(""); 

        //average 

        int[] calificaciones = [8, 6, 9, 7]; 
        double promedioCalificaciones = calificaciones.Average(); 
        Console.WriteLine($"El promedio es: {promedioCalificaciones}"); 

        Console.WriteLine("");


        //contains

        string[] colores = ["morado", "rosa", "verde", "azul"];
        bool buscar =  colores.Contains("amarillo");
        Console.WriteLine($"existe el amarillo en el array? {buscar}"); 
        Console.WriteLine("");
        
        
        //clear 

        string[] nombres = ["maria", "ana", "alma", "juana"];
         Console.WriteLine(nombres[0]);
        Console.WriteLine(nombres[1]);
        Console.WriteLine(nombres[2]);
        Console.WriteLine(nombres[3]);
        Console.WriteLine(""); 
        Array.Clear(nombres,2,1);
        Console.WriteLine(nombres[0]);
        Console.WriteLine(nombres[1]);
        Console.WriteLine(nombres[2]);
        Console.WriteLine(nombres[3]);
    
    }

}
