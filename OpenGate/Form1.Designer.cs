namespace OpenGate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem1 = new ToolStripMenuItem();
            test2ToolStripMenuItem2 = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            but_rooms = new Button();
            but_auth = new Button();
            but_users = new Button();
            but_dashboard = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            menuStrip2 = new MenuStrip();
            teToolStripMenuItem = new ToolStripMenuItem();
            teToolStripMenuItem1 = new ToolStripMenuItem();
            teToolStripMenuItem2 = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            dToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(0, 0);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(597, 376);
            dataGridViewUsers.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem1, test2ToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem1
            // 
            testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            testToolStripMenuItem1.Size = new Size(54, 20);
            testToolStripMenuItem1.Text = "Fichier";
            testToolStripMenuItem1.Click += testToolStripMenuItem1_Click;
            // 
            // test2ToolStripMenuItem2
            // 
            test2ToolStripMenuItem2.Name = "test2ToolStripMenuItem2";
            test2ToolStripMenuItem2.Size = new Size(39, 20);
            test2ToolStripMenuItem2.Text = "Vue";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 404);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(but_rooms);
            panel3.Controls.Add(but_auth);
            panel3.Controls.Add(but_users);
            panel3.Controls.Add(but_dashboard);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 404);
            panel3.TabIndex = 5;
            // 
            // but_rooms
            // 
            but_rooms.Dock = DockStyle.Top;
            but_rooms.Location = new Point(0, 114);
            but_rooms.Name = "but_rooms";
            but_rooms.Size = new Size(200, 38);
            but_rooms.TabIndex = 3;
            but_rooms.Text = "Salles";
            but_rooms.UseVisualStyleBackColor = true;
            but_rooms.Click += but_rooms_Click;
            // 
            // but_auth
            // 
            but_auth.Dock = DockStyle.Top;
            but_auth.Location = new Point(0, 76);
            but_auth.Name = "but_auth";
            but_auth.Size = new Size(200, 38);
            but_auth.TabIndex = 2;
            but_auth.Text = "Authorisations";
            but_auth.UseVisualStyleBackColor = true;
            but_auth.Click += but_auth_Click;
            // 
            // but_users
            // 
            but_users.Dock = DockStyle.Top;
            but_users.Location = new Point(0, 38);
            but_users.Name = "but_users";
            but_users.Size = new Size(200, 38);
            but_users.TabIndex = 1;
            but_users.Text = "Utilisateurs";
            but_users.UseVisualStyleBackColor = true;
            but_users.Click += but_users_Click;
            // 
            // but_dashboard
            // 
            but_dashboard.Dock = DockStyle.Top;
            but_dashboard.Location = new Point(0, 0);
            but_dashboard.Name = "but_dashboard";
            but_dashboard.Size = new Size(200, 38);
            but_dashboard.TabIndex = 0;
            but_dashboard.Text = "Dashboard";
            but_dashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(206, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 404);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(203, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(597, 404);
            panel4.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridViewUsers);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 28);
            panel6.Name = "panel6";
            panel6.Size = new Size(597, 376);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(menuStrip2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(597, 28);
            panel5.TabIndex = 1;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { teToolStripMenuItem, teToolStripMenuItem1, teToolStripMenuItem2, dToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(597, 24);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // teToolStripMenuItem
            // 
            teToolStripMenuItem.Name = "teToolStripMenuItem";
            teToolStripMenuItem.Size = new Size(58, 20);
            teToolStripMenuItem.Text = "Ajouter";
            teToolStripMenuItem.Click += TableMenuAjouter_Click;
            // 
            // teToolStripMenuItem1
            // 
            teToolStripMenuItem1.Name = "teToolStripMenuItem1";
            teToolStripMenuItem1.Size = new Size(74, 20);
            teToolStripMenuItem1.Text = "Supprimer";
            teToolStripMenuItem1.Click += TableMenuSupp_Click;
            // 
            // teToolStripMenuItem2
            // 
            teToolStripMenuItem2.Name = "teToolStripMenuItem2";
            teToolStripMenuItem2.Size = new Size(64, 20);
            teToolStripMenuItem2.Text = "Modifier";
            teToolStripMenuItem2.Click += TableMenuMod_Click;
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(26, 20);
            dToolStripMenuItem.Text = "d";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button but_rooms;
        private Button but_auth;
        private Button but_users;
        private Button but_dashboard;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem testToolStripMenuItem1;
        private ToolStripMenuItem test2ToolStripMenuItem2;
        private Panel panel5;
        private Panel panel6;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem teToolStripMenuItem;
        private ToolStripMenuItem teToolStripMenuItem1;
        private ToolStripMenuItem teToolStripMenuItem2;
        private ToolStripMenuItem dToolStripMenuItem;
    }
}
