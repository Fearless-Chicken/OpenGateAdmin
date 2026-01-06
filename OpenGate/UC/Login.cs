using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace OpenGate.UC
{
    public partial class Login : UserControl
    {
        private SqlConnection _conn;

        public Login(SqlConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void But_Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string passwd = Passwd.Text;

            // 1. Utilisation de paramètres pour la sécurité (@user)
            string sql = "SELECT passwd FROM PTUT.dbo.OGA_Users WHERE username = @user";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@user", username);

            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                // 2. On récupère le résultat
                object result = cmd.ExecuteScalar();

                // 3. On vérifie d'abord si l'utilisateur existe
                if (result != null)
                {
                    string dbHash = result.ToString();

                    // 4. On vérifie le mot de passe seulement si on a un hash
                    if (Utils.HashUtils.verifyPASSWD(passwd, dbHash))
                    {
                        MessageBox.Show("Connexion réussie !");
                        // Logique de redirection ici
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur ou mot de passe incorrect !");
                    }
                }
                else
                {
                    // L'utilisateur n'existe pas dans la base
                    MessageBox.Show("Utilisateur ou mot de passe incorrect !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }
    }
}
