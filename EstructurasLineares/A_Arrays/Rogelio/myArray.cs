using System.Timers;

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


}