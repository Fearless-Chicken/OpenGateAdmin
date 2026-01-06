namespace OpenGate.UC
{
    partial class Register
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            MainTitle = new Label();
            Passwd = new TextBox();
            Username = new TextBox();
            Lab_Passwd = new Label();
            Lab_Username = new Label();
            Passwd_Conf = new TextBox();
            But_Register = new Button();
            SuspendLayout();
            // 
            // MainTitle
            // 
            MainTitle.AutoSize = true;
            MainTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainTitle.Location = new Point(93, 10);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(110, 30);
            MainTitle.TabIndex = 5;
            MainTitle.Text = "OpenGate";
            // 
            // Passwd
            // 
            Passwd.Location = new Point(123, 87);
            Passwd.Name = "Passwd";
            Passwd.PasswordChar = '*';
            Passwd.PlaceholderText = "Password";
            Passwd.Size = new Size(169, 23);
            Passwd.TabIndex = 9;
            // 
            // Username
            // 
            Username.Location = new Point(123, 54);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(169, 23);
            Username.TabIndex = 8;
            // 
            // Lab_Passwd
            // 
            Lab_Passwd.AutoSize = true;
            Lab_Passwd.Location = new Point(18, 88);
            Lab_Passwd.Name = "Lab_Passwd";
            Lab_Passwd.Size = new Size(77, 15);
            Lab_Passwd.TabIndex = 7;
            Lab_Passwd.Text = "Mot de passe";
            // 
            // Lab_Username
            // 
            Lab_Username.AutoSize = true;
            Lab_Username.Location = new Point(18, 58);
            Lab_Username.Name = "Lab_Username";
            Lab_Username.Size = new Size(99, 15);
            Lab_Username.TabIndex = 6;
            Lab_Username.Text = "Nom d'utilisateur";
            // 
            // Passwd_Conf
            // 
            Passwd_Conf.Location = new Point(123, 116);
            Passwd_Conf.Name = "Passwd_Conf";
            Passwd_Conf.PasswordChar = '*';
            Passwd_Conf.PlaceholderText = "Confirm password";
            Passwd_Conf.Size = new Size(169, 23);
            Passwd_Conf.TabIndex = 10;
            // 
            // But_Register
            // 
            But_Register.Location = new Point(74, 145);
            But_Register.Name = "But_Register";
            But_Register.Size = new Size(160, 34);
            But_Register.TabIndex = 12;
            But_Register.Text = "Créer utilisateur";
            But_Register.UseVisualStyleBackColor = true;
            But_Register.Click += But_Register_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(But_Register);
            Controls.Add(Passwd_Conf);
            Controls.Add(Passwd);
            Controls.Add(Username);
            Controls.Add(Lab_Passwd);
            Controls.Add(Lab_Username);
            Controls.Add(MainTitle);
            Name = "Register";
            Size = new Size(326, 189);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainTitle;
        private TextBox Passwd;
        private TextBox Username;
        private Label Lab_Passwd;
        private Label Lab_Username;
        private TextBox Passwd_Conf;
        private Button But_Register;
    }
}
