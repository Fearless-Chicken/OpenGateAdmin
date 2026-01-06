using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace OpenGate.UC
{
    public partial class Register : UserControl
    {
        private SqlConnection _conn;
        public Register(SqlConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void AddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main maFenetre = (Main)this.FindForm();
            maFenetre.ClearPanel();
            maFenetre.Resize_Window("Login");
            maFenetre.PannelLogin.Controls.Add(new Login(_conn));
        }

        private void But_Register_Click(object sender, EventArgs e)
        {
            if (Passwd.Text != Passwd_Conf.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas !");
                return;
            }

            string token = "";

            string hashedpasswd = Utils.HashUtils.HashPASSWD(Passwd.Text);

            string sql_res = string.Format("insert into PTUT.dbo.OGA_Users (username, passwd, token) VALUES ('{0}', '{1}', '{2}')", Username.Text, hashedpasswd, token);

            SqlCommand cmd = new SqlCommand(sql_res, _conn);

            cmd.ExecuteNonQuery();
        }
    }
}
