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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblNombre = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            btmAceptar = new Button();
            btmCancelar = new Button();
            cbmModulo = new ComboBox();
            gpbDatos = new GroupBox();
            gpbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 79);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(26, 140);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(32, 210);
            lblModulo.Margin = new Padding(4, 0, 4, 0);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(75, 25);
            lblModulo.TabIndex = 7;
            lblModulo.Text = "Módulo";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.MenuHighlight;
            txtNombre.Location = new Point(133, 76);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 10;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 31);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.ForeColor = SystemColors.WindowText;
            txtContraseña.Location = new Point(133, 137);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '★';
            txtContraseña.Size = new Size(171, 31);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btmAceptar
            // 
            btmAceptar.Location = new Point(225, 275);
            btmAceptar.Margin = new Padding(4, 5, 4, 5);
            btmAceptar.Name = "btmAceptar";
            btmAceptar.Size = new Size(107, 38);
            btmAceptar.TabIndex = 3;
            btmAceptar.Text = "Aceptar";
            btmAceptar.UseVisualStyleBackColor = true;
            btmAceptar.Click += button1_Click;
            // 
            // btmCancelar
            // 
            btmCancelar.Location = new Point(94, 275);
            btmCancelar.Margin = new Padding(4, 5, 4, 5);
            btmCancelar.Name = "btmCancelar";
            btmCancelar.Size = new Size(107, 38);
            btmCancelar.TabIndex = 4;
            btmCancelar.Text = "Cancelar";
            btmCancelar.UseVisualStyleBackColor = true;
            btmCancelar.Click += btmCancelar_Click;
            // 
            // cbmModulo
            // 
            cbmModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmModulo.FormattingEnabled = true;
            cbmModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cbmModulo.Location = new Point(133, 206);
            cbmModulo.Margin = new Padding(4, 5, 4, 5);
            cbmModulo.Name = "cbmModulo";
            cbmModulo.Size = new Size(171, 33);
            cbmModulo.TabIndex = 2;
            cbmModulo.SelectedIndexChanged += cbmModulo_SelectedIndexChanged;
            // 
            // gpbDatos
            // 
            gpbDatos.AccessibleDescription = "gpbDatos";
            gpbDatos.Controls.Add(cbmModulo);
            gpbDatos.Controls.Add(btmCancelar);
            gpbDatos.Controls.Add(btmAceptar);
            gpbDatos.Controls.Add(lblNombre);
            gpbDatos.Controls.Add(lblContraseña);
            gpbDatos.Controls.Add(lblModulo);
            gpbDatos.Controls.Add(txtContraseña);
            gpbDatos.Controls.Add(txtNombre);
            gpbDatos.FlatStyle = FlatStyle.System;
            gpbDatos.Location = new Point(386, 100);
            gpbDatos.Name = "gpbDatos";
            gpbDatos.Size = new Size(389, 353);
            gpbDatos.TabIndex = 9;
            gpbDatos.TabStop = false;
            gpbDatos.Text = "Ingrese sus datos";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(gpbDatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = " ";
            Load += frmLogin_Load;
            gpbDatos.ResumeLayout(false);
            gpbDatos.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox gpbDatos;
    }
}