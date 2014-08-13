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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfIngresoLibro));
            this.txtNomLib = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lblNomLib = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNoPag = new System.Windows.Forms.TextBox();
            this.lblNoPag = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.nudVol = new System.Windows.Forms.NumericUpDown();
            this.lblEdi = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.cboEdit = new System.Windows.Forms.ComboBox();
            this.lblEstant = new System.Windows.Forms.Label();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.cboCorriente = new System.Windows.Forms.ComboBox();
            this.lblCorriLite = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.cboMat = new System.Windows.Forms.ComboBox();
            this.lblEjem = new System.Windows.Forms.Label();
            this.nudEjem = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEntre = new System.Windows.Forms.Label();
            this.cboEstante = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.cboApellido = new System.Windows.Forms.ComboBox();
            this.nudEdi = new System.Windows.Forms.NumericUpDown();
            this.cboEntre = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjem)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomLib
            // 
            this.txtNomLib.Location = new System.Drawing.Point(117, 14);
            this.txtNomLib.Name = "txtNomLib";
            this.txtNomLib.Size = new System.Drawing.Size(100, 20);
            this.txtNomLib.TabIndex = 0;
            this.txtNomLib.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngreso.BackgroundImage")));
            this.btnIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIngreso.Location = new System.Drawing.Point(666, 439);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(44, 36);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomLib
            // 
            this.lblNomLib.AutoSize = true;
            this.lblNomLib.Location = new System.Drawing.Point(26, 20);
            this.lblNomLib.Name = "lblNomLib";
            this.lblNomLib.Size = new System.Drawing.Size(70, 13);
            this.lblNomLib.TabIndex = 3;
            this.lblNomLib.Text = "Nombre Libro";
            // 
            // txtLib
            // 
            this.txtLib.Location = new System.Drawing.Point(117, 40);
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(100, 20);
            this.txtLib.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(26, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtNoPag
            // 
            this.txtNoPag.Location = new System.Drawing.Point(117, 66);
            this.txtNoPag.Name = "txtNoPag";
            this.txtNoPag.Size = new System.Drawing.Size(100, 20);
            this.txtNoPag.TabIndex = 6;
            // 
            // lblNoPag
            // 
            this.lblNoPag.AutoSize = true;
            this.lblNoPag.Location = new System.Drawing.Point(26, 73);
            this.lblNoPag.Name = "lblNoPag";
            this.lblNoPag.Size = new System.Drawing.Size(62, 13);
            this.lblNoPag.TabIndex = 7;
            this.lblNoPag.Text = "No Paginas";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(26, 98);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(48, 13);
            this.lblVol.TabIndex = 8;
            this.lblVol.Text = "Volumen";
            // 
            // nudVol
            // 
            this.nudVol.Location = new System.Drawing.Point(117, 92);
            this.nudVol.Name = "nudVol";
            this.nudVol.Size = new System.Drawing.Size(120, 20);
            this.nudVol.TabIndex = 9;
            this.nudVol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVol.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblEdi
            // 
            this.lblEdi.AutoSize = true;
            this.lblEdi.Location = new System.Drawing.Point(26, 130);
            this.lblEdi.Name = "lblEdi";
            this.lblEdi.Size = new System.Drawing.Size(42, 13);
            this.lblEdi.TabIndex = 10;
            this.lblEdi.Text = "Edicion";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(26, 158);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(44, 13);
            this.lblEdit.TabIndex = 11;
            this.lblEdit.Text = "Editorial";
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
            // lblEstant
            // 
            this.lblEstant.AutoSize = true;
            this.lblEstant.Location = new System.Drawing.Point(353, 99);
            this.lblEstant.Name = "lblEstant";
            this.lblEstant.Size = new System.Drawing.Size(43, 13);
            this.lblEstant.TabIndex = 13;
            this.lblEstant.Text = "Estante";
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(477, 12);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(121, 21);
            this.cboAutor.TabIndex = 15;
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(353, 12);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 16;
            this.lblAutor.Text = "Autor";
            // 
            // cboCorriente
            // 
            this.cboCorriente.FormattingEnabled = true;
            this.cboCorriente.Location = new System.Drawing.Point(477, 38);
            this.cboCorriente.Name = "cboCorriente";
            this.cboCorriente.Size = new System.Drawing.Size(121, 21);
            this.cboCorriente.TabIndex = 17;
            this.cboCorriente.SelectedIndexChanged += new System.EventHandler(this.cboCorriente_SelectedIndexChanged);
            // 
            // lblCorriLite
            // 
            this.lblCorriLite.AutoSize = true;
            this.lblCorriLite.Location = new System.Drawing.Point(353, 38);
            this.lblCorriLite.Name = "lblCorriLite";
            this.lblCorriLite.Size = new System.Drawing.Size(89, 13);
            this.lblCorriLite.TabIndex = 18;
            this.lblCorriLite.Text = "Corriente Literaria";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(353, 73);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(42, 13);
            this.lblMat.TabIndex = 19;
            this.lblMat.Text = "Materia";
            // 
            // cboMat
            // 
            this.cboMat.FormattingEnabled = true;
            this.cboMat.Location = new System.Drawing.Point(477, 65);
            this.cboMat.Name = "cboMat";
            this.cboMat.Size = new System.Drawing.Size(121, 21);
            this.cboMat.TabIndex = 20;
            this.cboMat.SelectedIndexChanged += new System.EventHandler(this.cboMat_SelectedIndexChanged);
            // 
            // lblEjem
            // 
            this.lblEjem.AutoSize = true;
            this.lblEjem.Location = new System.Drawing.Point(353, 157);
            this.lblEjem.Name = "lblEjem";
            this.lblEjem.Size = new System.Drawing.Size(58, 13);
            this.lblEjem.TabIndex = 21;
            this.lblEjem.Text = "Ejemplares";
            this.lblEjem.Click += new System.EventHandler(this.label11_Click);
            // 
            // nudEjem
            // 
            this.nudEjem.Location = new System.Drawing.Point(477, 155);
            this.nudEjem.Name = "nudEjem";
            this.nudEjem.Size = new System.Drawing.Size(120, 20);
            this.nudEjem.TabIndex = 22;
            this.nudEjem.Value = new decimal(new int[] {
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
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Location = new System.Drawing.Point(353, 126);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(56, 13);
            this.lblEntre.TabIndex = 24;
            this.lblEntre.Text = "Entrepaño";
            // 
            // cboEstante
            // 
            this.cboEstante.FormattingEnabled = true;
            this.cboEstante.Location = new System.Drawing.Point(476, 96);
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
            this.tabControl1.Size = new System.Drawing.Size(779, 288);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.cboApellido);
            this.tabPage.Controls.Add(this.nudEdi);
            this.tabPage.Controls.Add(this.cboEntre);
            this.tabPage.Controls.Add(this.txtNomLib);
            this.tabPage.Controls.Add(this.cboEstante);
            this.tabPage.Controls.Add(this.lblNomLib);
            this.tabPage.Controls.Add(this.lblEntre);
            this.tabPage.Controls.Add(this.txtLib);
            this.tabPage.Controls.Add(this.lblTitulo);
            this.tabPage.Controls.Add(this.nudEjem);
            this.tabPage.Controls.Add(this.txtNoPag);
            this.tabPage.Controls.Add(this.lblEjem);
            this.tabPage.Controls.Add(this.lblNoPag);
            this.tabPage.Controls.Add(this.cboMat);
            this.tabPage.Controls.Add(this.lblVol);
            this.tabPage.Controls.Add(this.lblMat);
            this.tabPage.Controls.Add(this.nudVol);
            this.tabPage.Controls.Add(this.lblCorriLite);
            this.tabPage.Controls.Add(this.lblEdi);
            this.tabPage.Controls.Add(this.cboCorriente);
            this.tabPage.Controls.Add(this.lblEdit);
            this.tabPage.Controls.Add(this.lblAutor);
            this.tabPage.Controls.Add(this.cboEdit);
            this.tabPage.Controls.Add(this.cboAutor);
            this.tabPage.Controls.Add(this.lblEstant);
            this.tabPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(771, 262);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "Nuevo";
            this.tabPage.UseVisualStyleBackColor = true;
            this.tabPage.Click += new System.EventHandler(this.tabPage_Click);
            // 
            // cboApellido
            // 
            this.cboApellido.FormattingEnabled = true;
            this.cboApellido.Location = new System.Drawing.Point(625, 14);
            this.cboApellido.Name = "cboApellido";
            this.cboApellido.Size = new System.Drawing.Size(121, 21);
            this.cboApellido.TabIndex = 30;
            // 
            // nudEdi
            // 
            this.nudEdi.Location = new System.Drawing.Point(117, 128);
            this.nudEdi.Name = "nudEdi";
            this.nudEdi.Size = new System.Drawing.Size(120, 20);
            this.nudEdi.TabIndex = 29;
            this.nudEdi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboEntre
            // 
            this.cboEntre.FormattingEnabled = true;
            this.cboEntre.Location = new System.Drawing.Point(477, 128);
            this.cboEntre.Name = "cboEntre";
            this.cboEntre.Size = new System.Drawing.Size(121, 21);
            this.cboEntre.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 262);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Existente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.Location = new System.Drawing.Point(616, 439);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Location = new System.Drawing.Point(566, 439);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 36);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // wfIngresoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 490);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnIngreso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfIngresoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Ingreso Libro";
            this.Load += new System.EventHandler(this.wfIngresoLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjem)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomLib;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label lblNomLib;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNoPag;
        private System.Windows.Forms.Label lblNoPag;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.NumericUpDown nudVol;
        private System.Windows.Forms.Label lblEdi;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.ComboBox cboEdit;
        private System.Windows.Forms.Label lblEstant;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.ComboBox cboCorriente;
        private System.Windows.Forms.Label lblCorriLite;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.ComboBox cboMat;
        private System.Windows.Forms.Label lblEjem;
        private System.Windows.Forms.NumericUpDown nudEjem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEntre;
        private System.Windows.Forms.ComboBox cboEstante;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboEntre;
        private System.Windows.Forms.NumericUpDown nudEdi;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboApellido;

    }
}