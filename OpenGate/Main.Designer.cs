namespace OpenGate
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PannelLogin = new Panel();
            SuspendLayout();
            // 
            // PannelLogin
            // 
            PannelLogin.Location = new Point(0, 0);
            PannelLogin.Name = "PannelLogin";
            PannelLogin.Size = new Size(298, 186);
            PannelLogin.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 310);
            Controls.Add(PannelLogin);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Open Gate Admin";
            ResumeLayout(false);
        }

        #endregion

        public Panel PannelLogin;
        private UC.Register register1;
    }
}