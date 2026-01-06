using Microsoft.Data.SqlClient; // <--- TRÈS IMPORTANT : Utiliser SqlClient, pas MySql
using System.Data;

public class DatabaseConnection
{
    // Pour SSMS, la chaîne de connexion change de format
    private string connectionString = @"Server=192.168.0.1;Database=ptut;User Id=test;Password=test;TrustServerCertificate=True;";

    public SqlConnection GetConnection() // Retourne un SqlConnection
    {
        SqlConnection connection = null;
        try
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Erreur SSMS : {ex.Message}");
            return null;
        }
    }

    public void CloseConnection(SqlConnection connection)
    {
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}