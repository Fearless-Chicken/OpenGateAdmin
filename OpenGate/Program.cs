using Microsoft.Data.SqlClient; // Utilisation du driver SQL Server
using OpenGate.UC;

namespace OpenGate
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Splash screen
            Loading splash = new Loading();
            splash.Show();
            splash.Refresh();

            DatabaseConnection db = new DatabaseConnection();

            // 2. On utilise SqlConnection (et non MySqlConnection)
            SqlConnection conn = db.CreateConnection();

            try
            {
                conn.Open();

                splash.Close();

                // On lance l'application
                Application.Run(new Main(conn));
            }
            catch (Exception ex)
            {
                if (!splash.IsDisposed) splash.Close();

                MessageBox.Show("Impossible de se connecter à la base de données :\n" + ex.Message,
                                "Erreur Critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //finally
            //{
            //    // On ferme proprement si c'est resté ouvert
            //    if (conn != null && conn.State == System.Data.ConnectionState.Open)
            //        conn.Close();
            //}
        }
    }
}