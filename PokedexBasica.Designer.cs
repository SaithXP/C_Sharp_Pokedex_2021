namespace PruebaBBDD
{
    partial class PokedexBasica
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelTipo2 = new System.Windows.Forms.Label();
            this.pictureBoxEvolucion1 = new System.Windows.Forms.PictureBox();
            this.imagenEvolucion1 = new System.Windows.Forms.PictureBox();
            this.nombreEvolucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvolucion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEvolucion1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(289, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(197, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(301, 417);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(131, 18);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peso";
            // 
            // labelPeso
            // 
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(332, 456);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(100, 18);
            this.labelPeso.TabIndex = 8;
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAltura
            // 
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(335, 478);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(97, 18);
            this.labelAltura.TabIndex = 9;
            this.labelAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTipo
            // 
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(330, 501);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(51, 18);
            this.labelTipo.TabIndex = 10;
            this.labelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTipo2
            // 
            this.labelTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo2.Location = new System.Drawing.Point(381, 501);
            this.labelTipo2.Name = "labelTipo2";
            this.labelTipo2.Size = new System.Drawing.Size(51, 18);
            this.labelTipo2.TabIndex = 11;
            this.labelTipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEvolucion1
            // 
            this.pictureBoxEvolucion1.Image = global::PruebaBBDD.Properties.Resources._188940;
            this.pictureBoxEvolucion1.Location = new System.Drawing.Point(517, 21);
            this.pictureBoxEvolucion1.Name = "pictureBoxEvolucion1";
            this.pictureBoxEvolucion1.Size = new System.Drawing.Size(82, 78);
            this.pictureBoxEvolucion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvolucion1.TabIndex = 12;
            this.pictureBoxEvolucion1.TabStop = false;
            this.pictureBoxEvolucion1.Click += new System.EventHandler(this.pictureBoxEvolucion1_Click);
            // 
            // imagenEvolucion1
            // 
            this.imagenEvolucion1.Location = new System.Drawing.Point(582, 21);
            this.imagenEvolucion1.Name = "imagenEvolucion1";
            this.imagenEvolucion1.Size = new System.Drawing.Size(82, 78);
            this.imagenEvolucion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenEvolucion1.TabIndex = 14;
            this.imagenEvolucion1.TabStop = false;
            // 
            // nombreEvolucion
            // 
            this.nombreEvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEvolucion.Location = new System.Drawing.Point(517, 102);
            this.nombreEvolucion.Name = "nombreEvolucion";
            this.nombreEvolucion.Size = new System.Drawing.Size(147, 23);
            this.nombreEvolucion.TabIndex = 15;
            this.nombreEvolucion.Text = "label1";
            this.nombreEvolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PokedexBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PruebaBBDD.Properties.Resources.pokedex1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 678);
            this.Controls.Add(this.nombreEvolucion);
            this.Controls.Add(this.imagenEvolucion1);
            this.Controls.Add(this.labelTipo2);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxEvolucion1);
            this.DoubleBuffered = true;
            this.Name = "PokedexBasica";
            this.Text = "PokedexBasica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvolucion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenEvolucion1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelTipo2;
        private System.Windows.Forms.PictureBox pictureBoxEvolucion1;
        private System.Windows.Forms.PictureBox imagenEvolucion1;
        private System.Windows.Forms.Label nombreEvolucion;
    }
}