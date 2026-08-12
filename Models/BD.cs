using Microsoft.Data.SqlClient;
using Dapper; 

public class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=login_tp;Integrated Security=True;TrustServerCertificate=True;";

    public void AgregarUsuario(string nombre , string nombreUsuario , string contraseña , string apellido , int tipoUsuario)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = @"INSERT INTO Usuarios (nombre, nombreUsuario, contraseña, apellido, tipoUsuario)
                             VALUES (@nombre, @nombreUsuario, @contraseña, @apellido, @tipoUsuario)";

            connection.Execute(query, new
            {
                nombre,
                nombreUsuario,
                contraseña,
                apellido,
                tipoUsuario
            });
        }
    }
}