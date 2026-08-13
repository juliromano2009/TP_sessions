public class Usuario
{
    public string Nombre { get; set; }
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public string Apellido { get; set; }
    public string TipoUsuario { get; set; }

    public Usuario(string nombre, string nombreUsuario, string contraseña, string apellido, string tipoUsuario)
    {
        Nombre = nombre;
        NombreUsuario = nombreUsuario;
        Contraseña = contraseña;
        Apellido = apellido;
        TipoUsuario = tipoUsuario;
    }
}