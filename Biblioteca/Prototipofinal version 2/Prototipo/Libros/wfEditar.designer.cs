namespace Prototipo
{
    partial class wfEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEditar));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.lblNumpag = new System.Windows.Forms.Label();
            this.nudpag = new System.Windows.Forms.NumericUpDown();
            this.nudVol = new System.Windows.Forms.NumericUpDown();
            this.nudEdi = new System.Windows.Forms.NumericUpDown();
            this.lbl = new System.Windows.Forms.Label();
            this.txtlibro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudpag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Libro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(271, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(320, 55);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(159, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(23, 122);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(42, 13);
            this.lblEdicion.TabIndex = 12;
            this.lblEdicion.Text = "Edicion";
            this.lblEdicion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(271, 93);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(48, 13);
            this.lblVolumen.TabIndex = 13;
            this.lblVolumen.Text = "Volumen";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(356, 177);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 36);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(264, 177);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 36);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(310, 177);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(40, 36);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgrega
            // 
            this.btnAgrega.Image = ((System.Drawing.Image)(resources.GetObject("btnAgrega.Image")));
            this.btnAgrega.Location = new System.Drawing.Point(402, 177);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(40, 36);
            this.btnAgrega.TabIndex = 16;
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // lblNumpag
            // 
            this.lblNumpag.AutoSize = true;
            this.lblNumpag.Location = new System.Drawing.Point(23, 86);
            this.lblNumpag.Name = "lblNumpag";
            this.lblNumpag.Size = new System.Drawing.Size(64, 13);
            this.lblNumpag.TabIndex = 20;
            this.lblNumpag.Text = "No. paginas";
            // 
            // nudpag
            // 
            this.nudpag.Enabled = false;
            this.nudpag.Location = new System.Drawing.Point(93, 86);
            this.nudpag.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudpag.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudpag.Name = "nudpag";
            this.nudpag.Size = new System.Drawing.Size(120, 20);
            this.nudpag.TabIndex = 31;
            this.nudpag.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudVol
            // 
            this.nudVol.Enabled = false;
            this.nudVol.Location = new System.Drawing.Point(320, 84);
            this.nudVol.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudVol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVol.Name = "nudVol";
            this.nudVol.Size = new System.Drawing.Size(120, 20);
            this.nudVol.TabIndex = 33;
            this.nudVol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEdi
            // 
            this.nudEdi.Enabled = false;
            this.nudEdi.Location = new System.Drawing.Point(93, 122);
            this.nudEdi.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEdi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdi.Name = "nudEdi";
            this.nudEdi.Size = new System.Drawing.Size(120, 20);
            this.nudEdi.TabIndex = 34;
            this.nudEdi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(46, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(41, 13);
            this.lbl.TabIndex = 35;
            this.lbl.Text = "Id_libro";
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(94, 26);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(100, 20);
            this.txtlibro.TabIndex = 36;
            // 
            // wfEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 252);
            this.Controls.Add(this.txtlibro);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.nudEdi);
            this.Controls.Add(this.nudVol);
            this.Controls.Add(this.nudpag);
            this.Controls.Add(this.lblNumpag);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEditar";
            this.Text = "Editar Libro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudpag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Label lblNumpag;
        private System.Windows.Forms.NumericUpDown nudpag;
        private System.Windows.Forms.NumericUpDown nudVol;
        private System.Windows.Forms.NumericUpDown nudEdi;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtlibro;
    }
}

