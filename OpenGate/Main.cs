using OpenGate.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OpenGate
{
    public partial class Main : Form
    {
        public Main(SqlConnection conn)
        {
            InitializeComponent();
            // 1. Créer une instance de votre UserControl
            if (isStayLogin())
            {
                Resize_Window("Login");
                Login monUC = new Login(conn);
                monUC.Dock = DockStyle.Fill;
                PannelLogin.Controls.Clear();
                PannelLogin.Controls.Add(monUC);
            } else
            {
                Resize_Window("Default");
            }
        }


        private bool isStayLogin()
        {
            if (Properties.Resources.Token is not null)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public void ClearPanel()
        {
            PannelLogin.Controls.Clear();
        }

        public void Resize_Window(string Type)
        {
            if (this.FindForm() is Main maFenetre)
            {
                string S = OpenGate.Res.Sizes.ResourceManager.GetString(Type);
                string[] parts = S.Split(',');

                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);

                maFenetre.Size = new Size(x, y);

                maFenetre.StartPosition = FormStartPosition.CenterScreen; // Définit la logique
                maFenetre.Location = new Point(
                    (Screen.PrimaryScreen.WorkingArea.Width - maFenetre.Width) / 2,
                    (Screen.PrimaryScreen.WorkingArea.Height - maFenetre.Height) / 2
                );
            }
        }
    }
}
