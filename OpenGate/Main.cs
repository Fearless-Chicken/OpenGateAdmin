using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI.Common;
using OpenGate.UC;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OpenGate
{
    public partial class Main : Form
    {
        private SqlConnection _conn;

        public Main(SqlConnection conn)
        {
            InitializeComponent();
            // On stocke la connexion dans la variable de classe pour la réutiliser partout
            _conn = conn;

            showLogin(_conn);
        }

        public void LockWindow()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        public void DelockWindow()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
        }

        public void showLogin(SqlConnection connectionPartagee)
        {
            LockWindow();
            Resize_Window("Login");

            PannelLogin.Visible = true;
            // Taille fixe pour le formulaire de login
            PannelLogin.Size = new Size(400, 300);

            Login monUC = new Login(connectionPartagee);
            monUC.Dock = DockStyle.Fill;

            ClearPanel();
            PannelLogin.Controls.Add(monUC);
        }

        public void ClearPanel()
        {
            PannelLogin.Controls.Clear();
        }

        public void Resize_Window(string Type)
        {
            try
            {
                string S = OpenGate.Res.Sizes.ResourceManager.GetString(Type)!;
                string[] parts = S.Split(',');

                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);

                this.Size = new Size(x, y);
                this.CenterToScreen(); // Plus simple que le calcul manuel de Point
            }
            catch { /* Gérer l'erreur si la ressource 'Type' n'existe pas */ }
        }

        public void StartUp(string username)
        {
            DelockWindow();
            PannelOptions.Visible = false;
            PannelLogin.Visible = false;
            ClearPanel();
            Resize_Window("Default");

            Label_UserName.Text = username;

        }

        public void HomePage()
        {
            PannelMain.Controls.Clear();
        }

        private void RegisterPage()
        {
            PannelMain.Controls.Clear();
            Register reg = new Register(_conn);
            reg.Location = new Point(469, 175);
            reg.BorderStyle = BorderStyle.FixedSingle;
            PannelMain.Controls.Add(reg);
        }

        private void LogOut()
        {
            showLogin(_conn);
        }

        private void But_Logoff_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void But_Profile_Click(object sender, EventArgs e)
        {
            PannelOptions.Visible = !PannelOptions.Visible;
        }

        private void But_Home_Click(object sender, EventArgs e)
        {
            HomePage();
        }

        private void But_NewUser_Click(object sender, EventArgs e)
        {
            RegisterPage();
        }

        private void ManagePage(object sender, EventArgs e)
        {
            SuspendLayout();
            PannelMain.Controls.Clear();
            UC.GestionBat contentUC = new UC.GestionBat(_conn);
            contentUC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            contentUC.Dock = DockStyle.Fill;
            PannelMain.Controls.Add(contentUC);
            PannelMain.HorizontalScroll.Visible = false;
            PannelMain.VerticalScroll.Visible = false;
            ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            PannelMain.Controls.Clear();
            UC.LDAP.GestionLDAP contentUC = new UC.LDAP.GestionLDAP();
            contentUC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            contentUC.Dock = DockStyle.Fill;
            PannelMain.Controls.Add(contentUC);
            PannelMain.HorizontalScroll.Visible = false;
            PannelMain.VerticalScroll.Visible = false;
            ResumeLayout();
        }
    }
}