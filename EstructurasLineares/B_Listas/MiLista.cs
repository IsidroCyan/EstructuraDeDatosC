public class MiLista
{
    private int[] data; //almacen
    public MiLista()
    {
        data = new int[5]; //tamaño de almacen 
    }

    private int contador= 0;
    public void Agregar(int Elemento) //agregar nuevos datos al almacen
    {   
        if(contador >= data.Length)
        {
            Incremento();
        }

       data[contador]=Elemento;
       contador++; 

    }

    private void Incremento() //incrementa el tamaño del almacen 
    {
        int[] data2 = new int[contador+3]; 
        for(int i=0; i<data.Length; i++)
        {
            data2[i] = data[i];

        }
         data = data2; 
    }

    public void MostrarDatos()
    {
        foreach(int elemento in data)
        {
            Console.WriteLine(elemento);
        }
    }

    public void EliminarPorIndice(int indiceElemento)
    {
        if (data[indiceElemento] == 0)
        {
            return;
        }
        data[indiceElemento]=0;
        RecorrerPosicion(indiceElemento);
        /*
        for(int i=0; i<contador; i++)
        {
            if(data[i] == data[indiceElemento])
            {
                RecorrerPosicion();
            }
        }*/
        
    }

    public void EliminarElemento(int elementoBorrar)
    {
        for(int i=0; i<data.Length; i++)
        {
            if(data[i] == elementoBorrar)
            {
                data[i]=0; 
                RecorrerPosicion(elementoBorrar-1);
            }
        }
       //data[elementoBorrar] = 0;
        //RecorrerPosicion(elementoBorrar);
            
    }

    private void RecorrerPosicion(int desdeEliminar)
    {   
        for (int i=desdeEliminar; i<contador; i++)  //recorre la lista hasta 1 menos del tamaño del contador
        {
            data[i] = data[i + 1];  //i toma el valor de i+1
        }
        contador--; //disminuye el tamaño del contador
    }
}

