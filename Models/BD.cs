using Microsoft.Data.SqlClient;
using Dapper; 

public class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=login_tp;Integrated Security=True;TrustServerCertificate=True;";

 
    public void AgregarUsuario(Usuario usuario)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = @"INSERT INTO Usuarios (nombre, nombreUsuario, contraseña, apellido, tipoUsuario)
                             VALUES usuario.Nombre, usuario.NombreUsuario, usuario.Contraseña, usuario.Apellido, usuario.TipoUsuario)";
            connection.Execute(query, new
            {
                nombre = usuario.Nombre,
                nombreUsuario = usuario.NombreUsuario,
                contraseña = usuario.Contraseña,
                apellido = usuario.Apellido,
                tipoUsuario = usuario.TipoUsuario
            });
        }
    }

    public bool FijarseSiExisteUsuario(string nombreUsuario)
    {
        bool existe = false;

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT COUNT(*) FROM Usuarios WHERE nombreUsuario = @nombreUsuario";
            
            int count = connection.QueryFirstOrDefault<int>(query, new { nombreUsuario = nombreUsuario });
            
            if (count > 0)
            {
                existe = true;
            }
        }

        return existe;
    }

}