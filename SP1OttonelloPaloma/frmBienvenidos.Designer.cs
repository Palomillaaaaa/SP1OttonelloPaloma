namespace SP1OttonelloPaloma
{
    partial class frmBienvenidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenidos));
            btmIngresar = new Button();
            pictureBox1 = new PictureBox();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btmIngresar
            // 
            btmIngresar.FlatStyle = FlatStyle.System;
            btmIngresar.ForeColor = SystemColors.ControlLightLight;
            btmIngresar.Location = new Point(529, 608);
            btmIngresar.Margin = new Padding(4, 5, 4, 5);
            btmIngresar.Name = "btmIngresar";
            btmIngresar.Size = new Size(165, 45);
            btmIngresar.TabIndex = 0;
            btmIngresar.Text = "Ingresar";
            btmIngresar.UseVisualStyleBackColor = true;
            btmIngresar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._417_xlarge;
            pictureBox1.Location = new Point(-823, 133);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.FromArgb(231, 0, 0);
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(267, 43);
            pbLogo.Margin = new Padding(4, 5, 4, 5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(647, 515);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // frmBienvenidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 0, 0);
            ClientSize = new Size(1136, 793);
            Controls.Add(pbLogo);
            Controls.Add(pictureBox1);
            Controls.Add(btmIngresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmBienvenidos";
            Text = "frmBienvenidos";
            Load += frmBienvenidos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btmIngresar;
        private PictureBox pictureBox1;
        private PictureBox pbLogo;
    }
}