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
        string Info = "";

        foreach (Habitos x in data)
        {
            if (x != null)
            {
                Info += $"Titulo: {x.TituloHabito} Descripcion= {x.Descripcion} \n";
            }

        }
        Console.Clear();
        Console.WriteLine(Info);

    }

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
    /*
    public void capacidad()
    {
         Console.WriteLine($"El tamaño de data es: {data.Length}");
    }

    public void EliminarHabitoPorIndice(int IndiceDelHabito)
    {
        if (IndiceDelHabito >= data.Length)
        {
            Console.WriteLine("Indice Invalido");
            return;
        }

        if (data[IndiceDelHabito] == null)
        {
            Console.WriteLine("Cajita ya estaba desocupada");
            return;
        }

        data[IndiceDelHabito] = null;
        espaciosOcupados--; 
    }
    */
        
}

