public class MyArray
{
    private int[] data;
    private int indice = 0; 
public void mostrardatos()
    {
        foreach(int x in data)
        {
            Console.WriteLine(x);
        }
    }
    public MyArray(int tamaño)
    {
        data = new int [tamaño];
        Console.WriteLine("Yo fui ejecutado desde el constructor");
    }
    public void Average()
    {
        Console.WriteLine($"El tamaño de data es {data.Length}");
    }

    private void QuickSort()
    {
        
    }

    public void Agregar(int datoUsuario)
    {
        if (indice < data.Length)
        {    
        data[indice++] = datoUsuario;
        //int.TryParse(datoUsuario, out int resultado); 
        }
    }
}