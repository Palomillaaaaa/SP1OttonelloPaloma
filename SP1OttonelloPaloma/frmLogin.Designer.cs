namespace SP1OttonelloPaloma
{
    partial class frmLogin
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
            lblNombre = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            btmAceptar = new Button();
            btmCancelar = new Button();
            cbmModulo = new ComboBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(240, 139);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(236, 176);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(240, 217);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(49, 15);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Módulo";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.MenuHighlight;
            txtNombre.Location = new Point(311, 136);
            txtNombre.MaxLength = 10;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(111, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.ForeColor = SystemColors.WindowText;
            txtContraseña.Location = new Point(311, 173);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '★';
            txtContraseña.Size = new Size(111, 23);
            txtContraseña.TabIndex = 4;
            // 
            // btmAceptar
            // 
            btmAceptar.Location = new Point(508, 131);
            btmAceptar.Name = "btmAceptar";
            btmAceptar.Size = new Size(75, 23);
            btmAceptar.TabIndex = 6;
            btmAceptar.Text = "Aceptar";
            btmAceptar.UseVisualStyleBackColor = true;
            btmAceptar.Click += button1_Click;
            // 
            // btmCancelar
            // 
            btmCancelar.Location = new Point(508, 217);
            btmCancelar.Name = "btmCancelar";
            btmCancelar.Size = new Size(75, 23);
            btmCancelar.TabIndex = 7;
            btmCancelar.Text = "Cancelar";
            btmCancelar.UseVisualStyleBackColor = true;
            btmCancelar.Click += btmCancelar_Click;
            // 
            // cbmModulo
            // 
            cbmModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmModulo.FormattingEnabled = true;
            cbmModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cbmModulo.Location = new Point(311, 214);
            cbmModulo.Name = "cbmModulo";
            cbmModulo.Size = new Size(121, 23);
            cbmModulo.TabIndex = 8;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbmModulo);
            Controls.Add(btmCancelar);
            Controls.Add(btmAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Name = "frmLogin";
            Text = " ";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private Button btmAceptar;
        private Button btmCancelar;
        private ComboBox cbmModulo;
    }
}