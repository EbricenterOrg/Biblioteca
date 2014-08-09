namespace Prototipo
{
    partial class wfBusquedaLibro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBusquedaLibro));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.dgvDatosBusqueda = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clboTipobusqueda = new System.Windows.Forms.CheckedListBox();
            this.grbTipoBusqueda = new System.Windows.Forms.GroupBox();
            this.grbDatosLibro = new System.Windows.Forms.GroupBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBusqueda)).BeginInit();
            this.grbTipoBusqueda.SuspendLayout();
            this.grbDatosLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(8, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(6, 85);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor:";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(6, 111);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(47, 13);
            this.lblEditorial.TabIndex = 4;
            this.lblEditorial.Text = "Editorial:";
            this.lblEditorial.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(64, 56);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(64, 82);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 7;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(64, 108);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 8;
            // 
            // dgvDatosBusqueda
            // 
            this.dgvDatosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Editorial,
            this.Edición,
            this.Volumen,
            this.Ubicación});
            this.dgvDatosBusqueda.Location = new System.Drawing.Point(51, 261);
            this.dgvDatosBusqueda.Name = "dgvDatosBusqueda";
            this.dgvDatosBusqueda.RowHeadersVisible = false;
            this.dgvDatosBusqueda.Size = new System.Drawing.Size(391, 150);
            this.dgvDatosBusqueda.TabIndex = 10;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Visible = false;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Visible = false;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            this.Editorial.Visible = false;
            // 
            // Edición
            // 
            this.Edición.HeaderText = "Edición";
            this.Edición.Name = "Edición";
            this.Edición.ReadOnly = true;
            this.Edición.Visible = false;
            // 
            // Volumen
            // 
            this.Volumen.HeaderText = "Volumen";
            this.Volumen.Name = "Volumen";
            this.Volumen.ReadOnly = true;
            this.Volumen.Visible = false;
            // 
            // Ubicación
            // 
            this.Ubicación.HeaderText = "Ubicación";
            this.Ubicación.Name = "Ubicación";
            this.Ubicación.ReadOnly = true;
            this.Ubicación.Visible = false;
            // 
            // clboTipobusqueda
            // 
            this.clboTipobusqueda.FormattingEnabled = true;
            this.clboTipobusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Titulo ",
            "Autor ",
            "Editorial",
            "Edición",
            "Volumen",
            "Ubicación"});
            this.clboTipobusqueda.Location = new System.Drawing.Point(19, 33);
            this.clboTipobusqueda.Name = "clboTipobusqueda";
            this.clboTipobusqueda.Size = new System.Drawing.Size(120, 109);
            this.clboTipobusqueda.TabIndex = 11;
            // 
            // grbTipoBusqueda
            // 
            this.grbTipoBusqueda.Controls.Add(this.clboTipobusqueda);
            this.grbTipoBusqueda.Location = new System.Drawing.Point(40, 10);
            this.grbTipoBusqueda.Name = "grbTipoBusqueda";
            this.grbTipoBusqueda.Size = new System.Drawing.Size(159, 154);
            this.grbTipoBusqueda.TabIndex = 15;
            this.grbTipoBusqueda.TabStop = false;
            this.grbTipoBusqueda.Text = "Tipo de Búsqueda";
            // 
            // grbDatosLibro
            // 
            this.grbDatosLibro.Controls.Add(this.txtVolumen);
            this.grbDatosLibro.Controls.Add(this.lblVolumen);
            this.grbDatosLibro.Controls.Add(this.txtEdicion);
            this.grbDatosLibro.Controls.Add(this.lblEdicion);
            this.grbDatosLibro.Controls.Add(this.lblNombre);
            this.grbDatosLibro.Controls.Add(this.lblEditorial);
            this.grbDatosLibro.Controls.Add(this.lblAutor);
            this.grbDatosLibro.Controls.Add(this.lblTitulo);
            this.grbDatosLibro.Controls.Add(this.txtNombre);
            this.grbDatosLibro.Controls.Add(this.txtTitulo);
            this.grbDatosLibro.Controls.Add(this.txtEditorial);
            this.grbDatosLibro.Controls.Add(this.txtAutor);
            this.grbDatosLibro.Location = new System.Drawing.Point(253, 10);
            this.grbDatosLibro.Name = "grbDatosLibro";
            this.grbDatosLibro.Size = new System.Drawing.Size(198, 194);
            this.grbDatosLibro.TabIndex = 16;
            this.grbDatosLibro.TabStop = false;
            this.grbDatosLibro.Text = "Datos del Libro a buscar";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(64, 160);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtVolumen.TabIndex = 12;
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(6, 163);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(51, 13);
            this.lblVolumen.TabIndex = 11;
            this.lblVolumen.Text = "Volumen:";
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(64, 134);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(100, 20);
            this.txtEdicion.TabIndex = 10;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(6, 137);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(45, 13);
            this.lblEdicion.TabIndex = 9;
            this.lblEdicion.Text = "Edición:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(294, 217);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 26);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(375, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wfBusquedaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbDatosLibro);
            this.Controls.Add(this.grbTipoBusqueda);
            this.Controls.Add(this.dgvDatosBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wfBusquedaLibro";
            this.Text = "Busqueda de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBusqueda)).EndInit();
            this.grbTipoBusqueda.ResumeLayout(false);
            this.grbDatosLibro.ResumeLayout(false);
            this.grbDatosLibro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.DataGridView dgvDatosBusqueda;
        private System.Windows.Forms.CheckedListBox clboTipobusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicación;
        private System.Windows.Forms.GroupBox grbTipoBusqueda;
        private System.Windows.Forms.GroupBox grbDatosLibro;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

