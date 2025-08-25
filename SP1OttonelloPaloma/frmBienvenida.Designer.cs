namespace SP1OttonelloPaloma
{
    partial class frmBienvenida
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
            lblLogo = new Label();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.Location = new Point(301, 89);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(245, 64);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Sinterpart";
            lblLogo.Click += label1_Click;
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogo);
            Name = "frmBienvenida";
            Text = "frmBienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
    }
}