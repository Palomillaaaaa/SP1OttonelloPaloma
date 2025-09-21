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
            lblNombre.Location = new Point(343, 230);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(337, 291);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(343, 361);
            lblModulo.Margin = new Padding(4, 0, 4, 0);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(75, 25);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Módulo";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.MenuHighlight;
            txtNombre.Location = new Point(444, 227);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 10;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 31);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.ForeColor = SystemColors.WindowText;
            txtContraseña.Location = new Point(444, 288);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '★';
            txtContraseña.Size = new Size(171, 31);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btmAceptar
            // 
            btmAceptar.Location = new Point(801, 425);
            btmAceptar.Margin = new Padding(4, 5, 4, 5);
            btmAceptar.Name = "btmAceptar";
            btmAceptar.Size = new Size(109, 38);
            btmAceptar.TabIndex = 6;
            btmAceptar.Text = "Aceptar";
            btmAceptar.UseVisualStyleBackColor = true;
            btmAceptar.Click += button1_Click;
            // 
            // btmCancelar
            // 
            btmCancelar.Location = new Point(670, 425);
            btmCancelar.Margin = new Padding(4, 5, 4, 5);
            btmCancelar.Name = "btmCancelar";
            btmCancelar.Size = new Size(107, 38);
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
            cbmModulo.Location = new Point(444, 357);
            cbmModulo.Margin = new Padding(4, 5, 4, 5);
            cbmModulo.Name = "cbmModulo";
            cbmModulo.Size = new Size(171, 33);
            cbmModulo.TabIndex = 8;
            cbmModulo.SelectedIndexChanged += cbmModulo_SelectedIndexChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(cbmModulo);
            Controls.Add(btmCancelar);
            Controls.Add(btmAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Margin = new Padding(4, 5, 4, 5);
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