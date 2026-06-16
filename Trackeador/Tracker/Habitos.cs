public class Habitos
{
    public string TituloHabito;
    public DateOnly FechaDeCreacion;
    public string Descripcion;
    public TimeSpan TiempoInvertido; 
    public TimeSpan TiempoMinimo;
    public bool IsRealizado; 

    public Habitos(string TituloHabito, TimeSpan TiempoMinimo, string Descripcion)
    {
        this.TituloHabito = TituloHabito;
        this.TiempoMinimo = TiempoMinimo;
        this.Descripcion = Descripcion; 
        this.FechaDeCreacion = DateOnly.FromDateTime(DateTime.Now);
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