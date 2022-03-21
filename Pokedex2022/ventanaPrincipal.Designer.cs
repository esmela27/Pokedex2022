namespace Pokedex2022
{
    partial class ventanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            this.izquierda = new System.Windows.Forms.Button();
            this.derecha = new System.Windows.Forms.Button();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombrePantalla = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.evolucion = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.Color.Transparent;
            this.izquierda.FlatAppearance.BorderSize = 0;
            this.izquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.izquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.izquierda.Location = new System.Drawing.Point(299, 453);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(53, 43);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.Transparent;
            this.derecha.FlatAppearance.BorderSize = 0;
            this.derecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.derecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.derecha.Location = new System.Drawing.Point(373, 453);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(52, 43);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.Color.Black;
            this.altura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.altura.ForeColor = System.Drawing.Color.Lime;
            this.altura.Location = new System.Drawing.Point(568, 496);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(136, 40);
            this.altura.TabIndex = 5;
            this.altura.Text = "Altura:";
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.Color.Black;
            this.peso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.peso.ForeColor = System.Drawing.Color.Lime;
            this.peso.Location = new System.Drawing.Point(733, 496);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(140, 40);
            this.peso.TabIndex = 6;
            this.peso.Text = "Peso:";
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Yellow;
            this.descripcion.FlatAppearance.BorderSize = 0;
            this.descripcion.Font = new System.Drawing.Font("Roboto Condensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(560, 433);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(153, 45);
            this.descripcion.TabIndex = 7;
            this.descripcion.Text = "Descripción";
            this.descripcion.UseVisualStyleBackColor = false;
            this.descripcion.Click += new System.EventHandler(this.descripcion_Click);
            // 
            // pantalla
            // 
            this.pantalla.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pantalla.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pantalla.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.ForeColor = System.Drawing.Color.Lime;
            this.pantalla.Location = new System.Drawing.Point(560, 171);
            this.pantalla.Multiline = true;
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pantalla.Size = new System.Drawing.Size(313, 136);
            this.pantalla.TabIndex = 8;
            this.pantalla.Text = "|...";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Roboto Condensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(572, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Posevolución";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.posevolucion);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(98, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nombrePantalla
            // 
            this.nombrePantalla.BackColor = System.Drawing.Color.Transparent;
            this.nombrePantalla.CausesValidation = false;
            this.nombrePantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePantalla.Location = new System.Drawing.Point(113, 486);
            this.nombrePantalla.Name = "nombrePantalla";
            this.nombrePantalla.Size = new System.Drawing.Size(147, 50);
            this.nombrePantalla.TabIndex = 16;
            this.nombrePantalla.Text = "...";
            this.nombrePantalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Roboto Condensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(572, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Preevolución";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.preevolucion);
            // 
            // evolucion
            // 
            this.evolucion.BackColor = System.Drawing.Color.MistyRose;
            this.evolucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.evolucion.Location = new System.Drawing.Point(737, 334);
            this.evolucion.Name = "evolucion";
            this.evolucion.Size = new System.Drawing.Size(136, 144);
            this.evolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.evolucion.TabIndex = 18;
            this.evolucion.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 29);
            this.button3.TabIndex = 19;
            this.button3.Text = "Datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 589);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.evolucion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombrePantalla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Name = "ventanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Button descripcion;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombrePantalla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox evolucion;
        private System.Windows.Forms.Button button3;
    }
}

