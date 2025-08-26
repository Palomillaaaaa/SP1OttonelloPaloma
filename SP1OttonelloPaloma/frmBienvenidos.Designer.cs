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
            btmIngresar = new Button();
            pictureBox1 = new PictureBox();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btmIngresar
            // 
            btmIngresar.Location = new Point(315, 303);
            btmIngresar.Name = "btmIngresar";
            btmIngresar.Size = new Size(204, 52);
            btmIngresar.TabIndex = 2;
            btmIngresar.Text = "Ingresar";
            btmIngresar.UseVisualStyleBackColor = true;
            btmIngresar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._417_xlarge;
            pictureBox1.Location = new Point(-576, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources._417_xlarge;
            pbLogo.Location = new Point(136, 91);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(534, 182);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // frmBienvenidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(795, 476);
            Controls.Add(pbLogo);
            Controls.Add(pictureBox1);
            Controls.Add(btmIngresar);
            Name = "frmBienvenidos";
            Text = "frmBienvenidos";
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