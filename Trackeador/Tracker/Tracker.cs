public class Tracker
{
    /// <summary>
    /// Arreglo interno donde se almacenan los datos.
    /// Este arreglo es la estructura principal de almacenamiento.
    /// </summary>
    private Habitos[]? data;

    /// <summary>
    /// Indica la siguiente posición disponible dentro del arreglo.
    /// También representa la cantidad de elementos agregados.
    /// </summary>
    private int espaciosOcupados = 0;

    /// <summary>
    /// Constructor de la clase.
    /// Crea un arreglo con el tamaño especificado por el usuario.
    /// </summary>
    /// <param name="tamaño">
    /// Número máximo de elementos que podrá almacenar el arreglo.
    /// </param>
    public Tracker(int tamaño)
    {
        data = new Habitos[tamaño];
        //data[0] = null;
    }

    /// <summary>
    /// Muestra todos los elementos contenidos en el arreglo.
    ///
    /// Actualmente recorre todas las posiciones del array,
    /// incluso aquellas que aún no han sido utilizadas.
    /// </summary>
    public void MostrarDatos()
    {
        string Info = "";  //se inicializa como vacia con comillas al ser un string 

        foreach (Habitos x in data)  //recorre el arreglo 
        {
            if (x != null)  //si x es distinta a null, entonces: 
            {
                Info += $"Titulo: {x.Titulo} Descripcion= {x.Descripcions} \n";  //toma los datos que no sean nulos y los almacena en info
            }

        }
        //Console.Clear(); 
        Console.WriteLine(Info); //los muestra

    }
    

    //crear una funcion que busque solo 1 habito, el que coincida con el que busca el usuario
    

    public void AgregarHabito(Habitos datoUsuario)
    {

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == null)
            {
                data[i] = datoUsuario;
                return;
            }

        }
    }
    
    public void capacidad()
    {
         Console.WriteLine($"El tamaño de data es: {data.Length}");
    }

    public void EliminarHabitoPorIndice(int indiceDelHabito)
    {
        if (data == null)
        {
            return; 
        }

        if (indiceDelHabito >= data.Length)
        {
            Console.WriteLine("Indice Invalido");
            return;
        }

        if (data[indiceDelHabito] == null)
        {
            Console.WriteLine("Este espacio ya estaba desocupado");
            return;
        }

        data[indiceDelHabito] = null;
        espaciosOcupados--; 
    }

    public void Buscar(string BusquedaTitulo)
    {
        for(int i=0; i<data.Length; i++)
        {   
            //Habitos ObjetoHabito = data[i]; 
            if(data[i] != null && data[i].Titulo.ToLower() == BusquedaTitulo.ToLower())
            {
                Console.WriteLine($"La informacion de tu busqueda es: {data[i].Descripcions}"); 
                return;
            }
        }  
               Console.WriteLine("El titulo que buscas no existe"); 
                return; 
    }

   
    
    public void EliminarHabitos(string EliminarHabito)
    {
      // bool seEncontro = false; 

        for(int i=0; i<data.Length; i++)
        {
            if(data[i] != null && data[i].Titulo.ToLower() == EliminarHabito.ToLower())
            {
                data[i] = null;
                //seEncontro = true;
            }
        }
        Console.WriteLine("Escribe un nombre valido para eliminar");
        Console.WriteLine(" ");
    }

     public void cantidadDeHabitos()
    {   Console.Clear();
        int tamaño = 0;
        for (int i=0; i<data.Length; i++)
        {
            if (data[i] != null)
            {
                tamaño++;
            }
        }
        Console.WriteLine($"La cantidad de habitos guardados es: {tamaño}"); 
    }


        
}

