using System.Timers;
namespace ClaseRogelio;
public class CuentaBancaria
{
    private int[] data;
    private int indice = 0;

    public void mostrardatos()
    {
        foreach (int x in data)
        {
            Console.WriteLine(x);
        }
    }
    public CuentaBancaria(int tamañoCuenta)
    {
        data = new int[tamañoCuenta];
        Console.WriteLine("Yo fui ejecutado en el constructor cuando me hicieron new");
    }
  
  
  //* Promedio = Suma(sumaTotal)/Cantidad que se sumo
    public void Average()
    {
        //*Console.WriteLine($"El tamañoCuenta de data es {data.Length}");
        if(data.Length == 0)
        {
            Console.WriteLine("El tamaño del arreglo debe ser mayor a 0");
            return;
        }
        
        decimal sumaTotal = 0m; 
        for (int indice = 0; indice < data.Length; indice++) //*for sirve para hacer una acción X de veces (por la cantidad de data.Length)
        {
            sumaTotal += data[indice]; 
        }

        decimal Promedio = sumaTotal/data.Length; //*double es para numeros grandes, es mejor decimal para cantidades que se refieran al dinero porque es más preciso
        Console.WriteLine($"El promedio es: {Promedio}");
    }

    private void QuickSort()
    {

    }

    public void AgregarMonto(int dinero)
    {

        if (indice < data.Length)
        {
            data[indice] = dinero;
            indice = indice + 1;
        }
        
    }

    
    public void EliminarMonto(int indiceDelMonto) //* entre parentesis, es el parametro, cuando se está definiendo, nos sirve para saber sobre que posicion eliminar el dato
    {
       Console.WriteLine("Yo soy el indiceDelMonto");
    
    if(indiceDelMonto < indice)
        {
            data[indiceDelMonto] = 0;
        }

    }

     public void EliminarMonto(decimal EliminarCantidad)
    {
         Console.WriteLine("Yo soy el EliminarCantidad");
    }

    public int Buscar(int ElementoBusqueda)
    {
      //[10,20,30,50]
      for (int i=0; i<data.Length; i++) //* con el for recorremos los elementos del indice, 
        {
            if(data[i] == ElementoBusqueda) //*si en la posicion i de nuestro arreglo data hay que es igual al elemento busqueda, return (te saldras de la función)
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
        for(int i = 0; i < data.Length; i++)
        {
            if( data[i] != 0)
            {
                tamaño++;
            }
        } 
        Console.WriteLine($"El tamaño es {tamaño}");
    }

    public void mostrarIndice()
    {
        Console.WriteLine(indice);
    }
}