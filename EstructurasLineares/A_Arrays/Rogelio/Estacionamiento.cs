/*Algoritmo: 
Un Estacionamiento
-Ver todos los carros
-Contar carros
-Buscar el carro
-Meter el carro
-Sacar el carro
*/

public class RegistroEstacionamiento
{
    private int[] slotEstacionamiento;
    private int indice = 0;
     
  public RegistroEstacionamiento(int tamañoEstacionamiento) //Constructor
  {
        slotEstacionamiento = new int [tamañoEstacionamiento]; //* Para iniciarlizar valores
        Console.WriteLine($"El tamaño del arreglo es:{tamañoEstacionamiento}");
    }


     public void AgregarCarro(int carro)
        {
        //*Buscar espacio disponible, encontrar un cajón vacío y colocar el carro ahí
        //*Tomando en cuenta que "0" es la representación de un espació vacío.
        //*Si contiene 0: guardar el nuevo carro ahí y termina
        //*Si no contiene 0: continuar
        //*Si se recorrio todo y no hay lugar: regresar mensaje que dice "no hay espacio"

        if (indice < slotEstacionamiento.Length)
        {
            slotEstacionamiento[indice] = carro;
            indice = indice + 1;
        }
        
        }

    



}