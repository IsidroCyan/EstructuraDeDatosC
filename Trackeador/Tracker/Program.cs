/*
Console.WriteLine(habitoComer.Descripcion); 
//Console.WriteLine(habitoComer.Descripcion); 
habitoComer.CompletarHabito();

Habitos habitoLectura = new Habitos("Leer", new TimeSpan(0,20,0), "Leer un poco antes de dormir");
Console.WriteLine(habitoLectura.Descripcion);
habitoLectura.CompletarHabito();

Habitos habitoDescanso = new Habitos("Dormir", new TimeSpan(8,0,0), "Dormir 8 horas diarias"); 
Console.WriteLine(habitoDescanso.Descripcion);
habitoDescanso.CompletarHabito(); 
*/

Tracker administradorHabitos = new Tracker(5); 
/*
//administradorHabitos.MostrarDatos();
//administradorHabitos.AgregarHabito(habitoDescanso);
//administradorHabitos.AgregarHabito(new Habitos("Ejercicio", new TimeSpan(1,0,0), "Hacer ejercicio una hora al dia"));
//administradorHabitos.MostrarDatos();

Console.WriteLine("Agrega un nombre corto para el habito");
string nombreHabito = Console.ReadLine();
Console.WriteLine("Agrega un tiempo separado por comas. Comienza por Hora, Minutos");
//Almacenar hora y minutos
int[] tiempos = new int[2];
string[] data= Console.ReadLine().Split(",");
int index=0;
foreach(string dato in data)
{
    tiempos[index]=Convert.ToInt32(dato);
    index++;
    
}
Console.WriteLine("Agrega una descripcion para el habito");
string descripcionHabito = Console.ReadLine();

Habitos nuevoHabito = new Habitos (nombreHabito, new TimeSpan (tiempos[0],tiempos[1],0), descripcionHabito); 
*/
Habitos habitoComer = new Habitos("Desayunar", new TimeSpan(0,30,0) , "Desayunar algo ligero antes de empezar las actividades del dia"); 
Habitos habitoEjercicio = new Habitos("Ejercicio", new TimeSpan(1,0,0), "Hacer ejercicio una hora al dia");
Habitos habitoCorrer = new Habitos("Correr", new TimeSpan(0,20,0), "Intenta correr 20 min al dia");
Habitos habitoEstudiar = new Habitos("Estudiar", new TimeSpan(2,0,0), "Estudia 2 hoas al dia");


/*
//administradorHabitos.AgregarHabito(nuevoHabito); 
administradorHabitos.AgregarHabito(habitoComer); 
administradorHabitos.AgregarHabito(habitoEjercicio);
administradorHabitos.AgregarHabito(habitoCorrer);
administradorHabitos.AgregarHabito(habitoEstudiar);
*/
/*
//administradorHabitos.MostrarDatos(); 

//administradorHabitos.EliminarHabitoPorIndice(1);
//administradorHabitos.MostrarDatos();

//administradorHabitos.Buscar("Desayunar");
//administradorHabitos.MostrarDatos();

//administradorHabitos.EliminarHabitos(habitoComer);
//administradorHabitos.MostrarDatos();
//administradorHabitos.cantidadDeHabitos();
*/


bool iniciarPrograma = true;
while (iniciarPrograma){
    Console.WriteLine("Menu de habitos");
    Console.WriteLine(" ");
    Console.WriteLine("Escribe una opcion del 1-7: ");
    Console.WriteLine(" ");
    Console.WriteLine("1. Ver informacion de los habitos");
    Console.WriteLine("2. Agregar un habito nuevo");
    Console.WriteLine("3. Eliminar un habito por su indice");
    Console.WriteLine("4. Eliminar un habito por su nombre");
    Console.WriteLine("5. Buscar un habito por su nombre");
    Console.WriteLine("6. Conocer la cantidad de habitos guardados");
    Console.WriteLine("7. Salir");

    string? opcionElegida = Console.ReadLine();
    switch (opcionElegida)
    {
        case"1":
        Console.WriteLine("Elegiste la opcion 1. Ver informacion de los habitos");
        administradorHabitos.MostrarDatos();
        break;

        case"2":
        Console.WriteLine("Elegiste la opcion 2. Agregar un habito nuevo");
        Console.WriteLine(" ");
        Console.WriteLine("Agrega un nombre corto para el habito: ");
        string? nombreHabito = Console.ReadLine();
        Console.WriteLine("Agrega un tiempo separado por comas. Comienza por Hora, Minutos: ");
        int[] tiempos = new int[2];
        string[] data= Console.ReadLine().Split(",");
        int index=0;
        foreach(string dato in data)
        {
            tiempos[index]=Convert.ToInt32(dato);
            index++;
            
        }
            Console.WriteLine("Agrega una descripcion para el habito");
            string? descripcionHabito = Console.ReadLine();

            Habitos nuevoHabito = new Habitos (nombreHabito, new TimeSpan (tiempos[0],tiempos[1],0), descripcionHabito); 

            administradorHabitos.AgregarHabito(nuevoHabito);
            Console.WriteLine(" ");
            break;

        case"3":
            Console.WriteLine("Elegiste la opcion 3. Eliminar un habito por su indice");
            Console.WriteLine("Escribe un indice valido para eliminar el habito guardado en esa posicion: ");
            int indiceDatoUsuario = Convert.ToInt32(Console.ReadLine()); 
            administradorHabitos.EliminarHabitoPorIndice(indiceDatoUsuario);
            Console.WriteLine("Esta es la lista de datos actualizada: ");
            administradorHabitos.MostrarDatos();
             Console.WriteLine(" ");
            break;

        case"4":
            Console.WriteLine("Elegiste la opcion 4. Eliminar un habito por su nombre");
            Console.WriteLine("Escribe el nombre del habito que deseas eliminar: "); 
            string? EliminarDatoUsuario = Console.ReadLine();
            //Habitos habito = new Habitos(EliminarUsuario);
            administradorHabitos.EliminarHabitos(EliminarDatoUsuario);
            Console.WriteLine("Esta es la lista de datos actualizada: ");
            administradorHabitos.MostrarDatos();
            Console.WriteLine(" ");
            break;

        case"5":
            Console.WriteLine("Elegiste la opcion 5. Buscar un habito por su nombre");
            Console.WriteLine("Escribe el nombre del habito que deseas buscar: ");
            string? buscarDatoUsuario = Console.ReadLine();
            administradorHabitos.Buscar(buscarDatoUsuario);
            //Console.WriteLine($"Aqui estan los datos del habito: {buscarDatoUsuario}");
            Console.WriteLine(" ");
            
            break;

        case"6":
            Console.WriteLine("Elegiste la opcion 6. Conocer la cantidad de habitos guardados");
            //Console.WriteLine("La cantidad de habitos guardados es: ");
            administradorHabitos.cantidadDeHabitos();
            Console.WriteLine(" ");
        break;

        case"7":
            Console.WriteLine("Elegiste la opcion 7. Salir");
            Console.WriteLine("Adios");
            iniciarPrograma = false; 
            Console.WriteLine(" ");
            break;

        default:
        Console.WriteLine("Opcion no valida");
        break;

    }

}



