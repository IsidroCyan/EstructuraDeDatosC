#region Arrays

/*

// 1. DECLAR UN ARRAY = reservar espacios en la plancha
// Aquí caben 5 tacos. Ni uno más... por ahora
string[] plancha = new string[5];

Console.WriteLine("Bienvenido a Taquería Arrays");
Console.WriteLine($"Capacidad inicial: {plancha.Length} tacos\n");

// 2. ACCEDER POR ÍNDICE = poner taco en posición específica
// Los índices empiezan en 0
plancha[0] = "Suadero";
plancha[1] = "Pastor";
plancha[2] = "Tripa";

// 3. RECORRER CON FOR = checar toda la plancha
Console.WriteLine("Revisando la plancha:");
for (int i = 0; i < plancha.Length; i++)
{
    if (plancha[i] != null)
        Console.WriteLine($"Posición {i}: {plancha[i]}");
    else
        Console.WriteLine($"Posición {i}: VACÍA");
}

// 4. EL PROBLEMA: se llenó la plancha
Console.WriteLine("\n Llegó el cliente de las 3am... quiere 3 tacos más");
plancha[3] = "Chorizo";
plancha[4] = "Cabeza";

// Intentar poner el 6to taco -> BOOM
// plancha[5] = "Lengua"; // Exception: Index was outside the bounds

Console.WriteLine("¡SE LLENÓ LA PLANCHA! Necesitamos una más grande...");

// 5. REDIMENSIONAR = cambiar de plancha chica a plancha industrial
// Arrays no crecen solos. Tienes que hacer uno nuevo y copiar todo
string[] planchaGrande = new string[10]; // nueva plancha del doble

for (int i = 0; i < plancha.Length; i++)
{
    planchaGrande[i] = plancha[i]; // copiar taco por taco
}

plancha = planchaGrande; // ahora usamos la grande
plancha[5] = "Lengua"; // ya cabe

Console.WriteLine($"Nueva capacidad: {plancha.Length} tacos");
Console.WriteLine("Taco agregado: " + plancha[5] + "\n");

// 6. BÚSQUEDA = encontrar dónde está el pastor
Console.WriteLine("Cliente: ¿Dónde está el pastor?");
for (int i = 0; i < plancha.Length; i++)
{
    if (plancha[i] == "Pastor")
    {
        Console.WriteLine($"¡Aquí mero! Posición {i}");
        break;
    }
}
*/
#endregion

#region  Listas
//Creamos Nuestra pokedex
List<Pokemon> Pokedex = new();

//Agregamos Nuestros pokedemonioss


Pokedex.Add(new(100, 25, "Pikachu"));
Pokedex.Add(new(100, 25, "Charizard"));
Pokedex.Add(new(100, 25, "Motapod"));

Console.WriteLine($"Capturaste {Pokedex.Count} pokemons");

//Vamos a capturar otro mas
Pokedex.Insert(1, new(10, 20, "Miaou"));

Console.WriteLine($"Miaou atrapado: {Pokedex[1]}");


//Te mudaste a la Indepe y te robaron.

var NumeroDePokemonsRobados = Pokedex.RemoveAll((PokemonRobado) => PokemonRobado.Nombre == "Motapod");

Console.WriteLine($"Te robaron {NumeroDePokemonsRobados}");

//Vamos a ver si no me robaron a Charizard
if (Pokedex.Exists((Pokemon) => Pokemon.Nombre == "Charizard"))
{
    var PosicionPokemon = Pokedex.FindIndex((PokemonFavorito) => PokemonFavorito.Nombre == "Charizard");
    Console.WriteLine($"Bieeen! aún lo tengo, esta en la posicion: {PosicionPokemon}");
}


#endregion

#region Diccionarios

// 1. CREAR EL DICCIONARIO = clave: meme gringo, valor: traducción mexicana
Dictionary<string, string> traductor = new Dictionary<string, string>();

traductor.Add("sus", "sospechoso");
traductor.Add("no cap", "sin mentir");
traductor.Add("based", "basado");
traductor.Add("cringe", "vergonzoso");
traductor.Add("ghosting", "te dejó en visto");
traductor.Add("flex", "presumir");

Console.WriteLine("MEME TRANSLATOR 3000");
Console.WriteLine("Escribe un meme en inglés. Escribe 'salir' para terminar.\n");

// 2. BÚSQUEDA RÁPIDA = el waos moment
while (true)
{
    Console.Write("Meme: ");
    string input = Console.ReadLine().ToLower();

    if (input == "salir") break;

    
    if (traductor.ContainsKey(input))
    {
        Console.WriteLine($"Traducción: {traductor[input]}\n");
    }
    else
    {
        Console.WriteLine("No conozco ese meme aún. Agregalo tú!\n");

        Console.Write("¿Cómo lo dirías en mexicano? ");
        string traduccion = Console.ReadLine();
        traductor.Add(input, traduccion); // aprende sobre la marcha
        Console.WriteLine("¡Guardado!\n");
    }
}

// 3. MOSTRAR TODO = recorrer el diccionario
Console.WriteLine("\n--- Diccionario Completo ---");
foreach (var par in traductor)
{
    Console.WriteLine($"{par.Key} = {par.Value}");
}


#endregion

