public class Habitos
{
    private string TituloHabito;
    private DateOnly FechaDeCreacion;
    private string? Descripcion;
    private TimeSpan TiempoInvertido; 
    private TimeSpan TiempoMinimo;
    private bool IsRealizado; 

    public Habitos(string TituloHabito, TimeSpan TiempoMinimo, string Descripcion)
    {
        this.TituloHabito = TituloHabito;
        this.TiempoMinimo = TiempoMinimo;
        this.Descripcion = Descripcion; 
        this.FechaDeCreacion = DateOnly.FromDateTime(DateTime.Now);
    }

   /* public Habitos(string titulo)
    {
        this.TituloHabito = titulo;
    }
    */
    
    public string Descripcions
    {
        get
        {
            return Descripcion; 
        }
    }

    public string Titulo
    {
        get
        {
            return TituloHabito;
        }
    }
    public void CompletarHabito()
    {
        Console.WriteLine(FechaDeCreacion); 
    }
    public void CambiarTitulo(string NuevoTitulo)
    {
        
    }
    public void CambiarDescripcion(string NuevaDescripcion)
    {
        
    }
    public void CambiarTiempoInvertido(TimeSpan NuevoTiempo)
    {
        
    }
    
}