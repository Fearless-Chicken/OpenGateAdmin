using Microsoft.Data.SqlClient; // <--- TRÈS IMPORTANT : Utiliser SqlClient, pas MySql
using System.Data;

public class DatabaseConnection
{
    // Pour SSMS, la chaîne de connexion change de format
    private string connectionString = @"Server=SRV-BDD.opengate.net;Database=PTUT;User Id=ptut;Password=ptut;Encrypt=True;TrustServerCertificate=True;";
    public SqlConnection CreateConnection() // Retourne un SqlConnection
    {
        return new SqlConnection(connectionString);
    }
}