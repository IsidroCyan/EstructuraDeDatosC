/// <summary>
/// Clase didáctica que implementa una estructura basada en un arreglo (array)
/// para comprender cómo funcionan internamente algunas colecciones de C#.
///
/// La clase permite almacenar números enteros, agregarlos en posiciones
/// consecutivas y recorrer los elementos almacenados.
///
/// El propósito es que los alumnos implementen manualmente operaciones
/// comunes como búsqueda, ordenamiento, promedio, etc.
/// </summary>
public class MyArray
{
    /// <summary>
    /// Arreglo interno donde se almacenan los datos.
    /// Este arreglo es la estructura principal de almacenamiento.
    /// </summary>
    private int[] data;

    /// <summary>
    /// Indica la siguiente posición disponible dentro del arreglo.
    /// También representa la cantidad de elementos agregados.
    /// </summary>
    private int indice = 0;

    /// <summary>
    /// Constructor de la clase.
    /// Crea un arreglo con el tamaño especificado por el usuario.
    /// </summary>
    /// <param name="tamaño">
    /// Número máximo de elementos que podrá almacenar el arreglo.
    /// </param>
    public MyArray(int tamaño)
    {
        data = new int[tamaño];
        Console.WriteLine("Yo fui ejecutado desde el constructor");
    }

    /// <summary>
    /// Muestra todos los elementos contenidos en el arreglo.
    ///
    /// Actualmente recorre todas las posiciones del array,
    /// incluso aquellas que aún no han sido utilizadas.
    /// </summary>
    public void MostrarDatos()
    {
        foreach (int x in data)
        {
            Console.WriteLine(x);
        }
    }

    /// <summary>
    /// Muestra el tamaño total del arreglo.
    ///
    /// Este valor corresponde a la capacidad máxima
    /// definida al crear el objeto.
    /// </summary>
    public void Average()
    {
        Console.WriteLine($"El tamaño de data es {data.Length}");
    }

    /// <summary>
    /// Método reservado para implementar el algoritmo QuickSort.
    ///
    /// El objetivo es que los alumnos desarrollen desde cero
    /// un algoritmo de ordenamiento eficiente para los datos
    /// almacenados en el arreglo.
    /// </summary>
    private void QuickSort()
    {

    }

    /// <summary>
    /// Agrega un nuevo elemento al arreglo.
    ///
    /// El valor se almacena en la siguiente posición libre
    /// y posteriormente se incrementa el índice.
    ///
    /// Si el arreglo ya está lleno, el dato no se agrega.
    /// </summary>
    /// <param name="datoUsuario">
    /// Valor entero que se desea almacenar.
    /// </param>
    public void Agregar(int datoUsuario)
    {
        if (indice < data.Length)
        {
            data[indice++] = datoUsuario;
        }
    }
}
