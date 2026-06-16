using System.Numerics;
namespace Liz; 
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
public class CuentaBancaria
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
    public CuentaBancaria(int tamañoCuenta)
    {
        data = new int[tamañoCuenta];
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
        if (data.Length == 0)
        {
            Console.WriteLine("El tamaño del arrreglo debe ser mayor a 0");
            return;
        }
        decimal sumaTotal=0m;
        for (int indice=0; indice<data.Length; indice++)
        {
            sumaTotal += data[indice];
        }
        decimal promedio = sumaTotal/data.Length;
        Console.WriteLine($"el promedio es: {promedio}"); 
       
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
    public void AgregarMonto(int datoUsuario)
    {
       /*if (indice < data.Length)
        {
            data[indice++] = datoUsuario;
        }*/
       // int indiceDisponible= -1; 
        for(int i=0; i<data.Length; i++)
        {
            if (data[i] == 0)
            {
                //indiceDisponible =i;
                data[i] = datoUsuario; 
                return;
            }
            // if (indiceDisponible != -1)
            // {
                
            // }
        }
    }

    public void EliminarMontoPorIndice(int IndiceDelMonto)
    {
        Console.WriteLine($"indice del monto: {IndiceDelMonto}");
        Console.WriteLine($"indice: {indice}");
        if (IndiceDelMonto < indice)
        {
            data[IndiceDelMonto] = 0;
        }
       // indice--;
       
        
        
    }
    public void EliminarMonto(decimal EliminarCantidad)
    {
       bool seEncontro = false; 

        for(int i=0; i<data.Length; i++)
        {
            if(data[i] == EliminarCantidad)
            {
                data[i] = 0;
                seEncontro = true;
               /* 
               detiene el if y hace que solo se cambie el primer dato de cumpla con la condicion
               break; */
            }
        }

        if (seEncontro)
        {
        Console.WriteLine($"La cantidad buscada fue: {EliminarCantidad} ");
            
        }
        else
        {
            Console.WriteLine($"La cantidad {EliminarCantidad} no fue encontrada");
        }
    }

    public int Buscar(int ElementoBusqueda)
    {  
      //[10,20,30,50]  
      for(int i=0; i<data.Length; i++)
        {
            if(data[i] == ElementoBusqueda)
            {
                return i;
            }
            
        }
        return -1; 
    }

    public void capacidad()
    {
         Console.WriteLine($"El tamaño de data es: {data.Length}");
    }

    public void tamaño()
    {   
        int tamaño = 0;
        for (int i=0; i<data.Length; i++)
        {
            if (data[i] != 0)
            {
                tamaño++;
            }
        }
        Console.WriteLine(tamaño); 
    }

    public void mostrarIndice()
    {
        Console.WriteLine(indice); 
    }
}
