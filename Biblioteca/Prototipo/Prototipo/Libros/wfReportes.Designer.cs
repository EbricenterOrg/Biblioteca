namespace Prototipo.Libros
{
    partial class wfReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfReportes));
            this.btnPortitulo = new System.Windows.Forms.Button();
            this.grbTiporeportes = new System.Windows.Forms.GroupBox();
            this.btnAutor = new System.Windows.Forms.Button();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlquilados = new System.Windows.Forms.TextBox();
            this.txtDisponibles = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grbTiporeportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPortitulo
            // 
            this.btnPortitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortitulo.Image = ((System.Drawing.Image)(resources.GetObject("btnPortitulo.Image")));
            this.btnPortitulo.Location = new System.Drawing.Point(197, 22);
            this.btnPortitulo.Name = "btnPortitulo";
            this.btnPortitulo.Size = new System.Drawing.Size(44, 36);
            this.btnPortitulo.TabIndex = 0;
            this.btnPortitulo.UseVisualStyleBackColor = true;
            // 
            // grbTiporeportes
            // 
            this.grbTiporeportes.Controls.Add(this.button3);
            this.grbTiporeportes.Controls.Add(this.button2);
            this.grbTiporeportes.Controls.Add(this.txtDisponibles);
            this.grbTiporeportes.Controls.Add(this.txtAlquilados);
            this.grbTiporeportes.Controls.Add(this.label5);
            this.grbTiporeportes.Controls.Add(this.label4);
            this.grbTiporeportes.Controls.Add(this.button1);
            this.grbTiporeportes.Controls.Add(this.txtEditorial);
            this.grbTiporeportes.Controls.Add(this.label3);
            this.grbTiporeportes.Controls.Add(this.label2);
            this.grbTiporeportes.Controls.Add(this.label1);
            this.grbTiporeportes.Controls.Add(this.txtAutor);
            this.grbTiporeportes.Controls.Add(this.txtEdicion);
            this.grbTiporeportes.Controls.Add(this.btnAutor);
            this.grbTiporeportes.Controls.Add(this.btnPortitulo);
            this.grbTiporeportes.Location = new System.Drawing.Point(27, 68);
            this.grbTiporeportes.Name = "grbTiporeportes";
            this.grbTiporeportes.Size = new System.Drawing.Size(854, 109);
            this.grbTiporeportes.TabIndex = 1;
            this.grbTiporeportes.TabStop = false;
            this.grbTiporeportes.Text = "Tipo de Reportes";
            // 
            // btnAutor
            // 
            this.btnAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnAutor.Image")));
            this.btnAutor.Location = new System.Drawing.Point(472, 23);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(44, 36);
            this.btnAutor.TabIndex = 1;
            this.btnAutor.UseVisualStyleBackColor = true;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(91, 29);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(100, 20);
            this.txtEdicion.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(366, 31);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año de Edición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(295, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mismo Autor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(621, 30);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(727, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 36);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Libros Alquilados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Libros Disponibles";
            // 
            // txtAlquilados
            // 
            this.txtAlquilados.Location = new System.Drawing.Point(286, 75);
            this.txtAlquilados.Name = "txtAlquilados";
            this.txtAlquilados.Size = new System.Drawing.Size(100, 20);
            this.txtAlquilados.TabIndex = 11;
            // 
            // txtDisponibles
            // 
            this.txtDisponibles.Location = new System.Drawing.Point(567, 75);
            this.txtDisponibles.Name = "txtDisponibles";
            this.txtDisponibles.Size = new System.Drawing.Size(100, 20);
            this.txtDisponibles.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(392, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 36);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(677, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 36);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // wfReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 380);
            this.Controls.Add(this.grbTiporeportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfReportes";
            this.Text = "Reportes";
            this.grbTiporeportes.ResumeLayout(false);
            this.grbTiporeportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPortitulo;
        private System.Windows.Forms.GroupBox grbTiporeportes;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDisponibles;
        private System.Windows.Forms.TextBox txtAlquilados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label3;
    }
}