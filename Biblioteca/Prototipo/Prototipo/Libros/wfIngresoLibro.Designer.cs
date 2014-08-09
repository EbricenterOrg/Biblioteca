namespace Prototipo
{
    partial class wfIngresoLibro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbofecha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEdit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCorriente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMat = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cboEstante = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbofecha
            // 
            this.cbofecha.FormattingEnabled = true;
            this.cbofecha.Location = new System.Drawing.Point(116, 127);
            this.cbofecha.Name = "cbofecha";
            this.cbofecha.Size = new System.Drawing.Size(121, 21);
            this.cbofecha.TabIndex = 2;
            this.cbofecha.Text = "2014";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Libro";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Paginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Volumen";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(117, 92);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Edicion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Editorial";
            // 
            // cboEdit
            // 
            this.cboEdit.FormattingEnabled = true;
            this.cboEdit.Location = new System.Drawing.Point(117, 158);
            this.cboEdit.Name = "cboEdit";
            this.cboEdit.Size = new System.Drawing.Size(121, 21);
            this.cboEdit.TabIndex = 12;
            this.cboEdit.Text = "Santillana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estante";
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(527, 21);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(121, 21);
            this.cboAutor.TabIndex = 15;
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Autor";
            // 
            // cboCorriente
            // 
            this.cboCorriente.FormattingEnabled = true;
            this.cboCorriente.Location = new System.Drawing.Point(527, 47);
            this.cboCorriente.Name = "cboCorriente";
            this.cboCorriente.Size = new System.Drawing.Size(121, 21);
            this.cboCorriente.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Corriente Literaria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Materia";
            // 
            // cboMat
            // 
            this.cboMat.FormattingEnabled = true;
            this.cboMat.Location = new System.Drawing.Point(527, 74);
            this.cboMat.Name = "cboMat";
            this.cboMat.Size = new System.Drawing.Size(121, 21);
            this.cboMat.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ejemplares";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(527, 164);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 22;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(299, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "INGRESO LIBRO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(403, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Entrepaño";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(527, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 26;
            // 
            // cboEstante
            // 
            this.cboEstante.FormattingEnabled = true;
            this.cboEstante.Location = new System.Drawing.Point(526, 105);
            this.cboEstante.Name = "cboEstante";
            this.cboEstante.Size = new System.Drawing.Size(121, 21);
            this.cboEstante.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(58, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 283);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.textBox1);
            this.tabPage.Controls.Add(this.cboEstante);
            this.tabPage.Controls.Add(this.cbofecha);
            this.tabPage.Controls.Add(this.textBox5);
            this.tabPage.Controls.Add(this.label1);
            this.tabPage.Controls.Add(this.label13);
            this.tabPage.Controls.Add(this.textBox2);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Controls.Add(this.numericUpDown2);
            this.tabPage.Controls.Add(this.textBox3);
            this.tabPage.Controls.Add(this.label11);
            this.tabPage.Controls.Add(this.label3);
            this.tabPage.Controls.Add(this.cboMat);
            this.tabPage.Controls.Add(this.label4);
            this.tabPage.Controls.Add(this.label10);
            this.tabPage.Controls.Add(this.numericUpDown1);
            this.tabPage.Controls.Add(this.label9);
            this.tabPage.Controls.Add(this.label5);
            this.tabPage.Controls.Add(this.cboCorriente);
            this.tabPage.Controls.Add(this.label6);
            this.tabPage.Controls.Add(this.label8);
            this.tabPage.Controls.Add(this.cboEdit);
            this.tabPage.Controls.Add(this.cboAutor);
            this.tabPage.Controls.Add(this.label7);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(712, 257);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "Nuevo";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 257);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Existente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wfIngresoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfIngresoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Ingreso Libro";
            this.Load += new System.EventHandler(this.wfIngresoLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbofecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCorriente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cboEstante;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage1;

    }
}