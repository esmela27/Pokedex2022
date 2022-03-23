namespace Pokedex2022
{
    partial class cadenaEvolutiva
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
            this.nombre1 = new System.Windows.Forms.Label();
            this.nombre2 = new System.Windows.Forms.Label();
            this.nombre3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tercero = new System.Windows.Forms.PictureBox();
            this.segundo = new System.Windows.Forms.PictureBox();
            this.primero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primero)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre1
            // 
            this.nombre1.Location = new System.Drawing.Point(27, 55);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(141, 36);
            this.nombre1.TabIndex = 5;
            this.nombre1.Text = "label1";
            this.nombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombre2
            // 
            this.nombre2.Location = new System.Drawing.Point(256, 55);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(148, 36);
            this.nombre2.TabIndex = 6;
            this.nombre2.Text = "label2";
            this.nombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombre3
            // 
            this.nombre3.Location = new System.Drawing.Point(483, 55);
            this.nombre3.Name = "nombre3";
            this.nombre3.Size = new System.Drawing.Size(148, 36);
            this.nombre3.TabIndex = 7;
            this.nombre3.Text = "label3";
            this.nombre3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pokedex2022.Properties.Resources.flecha1;
            this.pictureBox5.Location = new System.Drawing.Point(410, 163);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pokedex2022.Properties.Resources.flecha1;
            this.pictureBox4.Location = new System.Drawing.Point(182, 163);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // tercero
            // 
            this.tercero.Location = new System.Drawing.Point(483, 120);
            this.tercero.Name = "tercero";
            this.tercero.Size = new System.Drawing.Size(148, 134);
            this.tercero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tercero.TabIndex = 2;
            this.tercero.TabStop = false;
            // 
            // segundo
            // 
            this.segundo.BackgroundImage = global::Pokedex2022.Properties.Resources.cruz;
            this.segundo.Location = new System.Drawing.Point(256, 120);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(148, 134);
            this.segundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.segundo.TabIndex = 1;
            this.segundo.TabStop = false;
            // 
            // primero
            // 
            this.primero.Location = new System.Drawing.Point(27, 120);
            this.primero.Name = "primero";
            this.primero.Size = new System.Drawing.Size(148, 134);
            this.primero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.primero.TabIndex = 0;
            this.primero.TabStop = false;
            this.primero.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cadenaEvolutiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 328);
            this.Controls.Add(this.nombre3);
            this.Controls.Add(this.nombre2);
            this.Controls.Add(this.nombre1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tercero);
            this.Controls.Add(this.segundo);
            this.Controls.Add(this.primero);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "cadenaEvolutiva";
            this.Text = "cadenaEvolutiva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tercero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox primero;
        private System.Windows.Forms.PictureBox segundo;
        private System.Windows.Forms.PictureBox tercero;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label nombre1;
        private System.Windows.Forms.Label nombre2;
        private System.Windows.Forms.Label nombre3;
    }
}