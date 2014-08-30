namespace busqueda
{
    partial class wfBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBuscar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnAutor = new System.Windows.Forms.RadioButton();
            this.rbtnEditorial = new System.Windows.Forms.RadioButton();
            this.rbtnEdicion = new System.Windows.Forms.RadioButton();
            this.rbtnNinguno = new System.Windows.Forms.RadioButton();
            this.grpbTipobusqueda = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpbTipobusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(271, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 36);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(237, 43);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(406, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // rbtnAutor
            // 
            this.rbtnAutor.AutoSize = true;
            this.rbtnAutor.Location = new System.Drawing.Point(25, 44);
            this.rbtnAutor.Name = "rbtnAutor";
            this.rbtnAutor.Size = new System.Drawing.Size(50, 17);
            this.rbtnAutor.TabIndex = 3;
            this.rbtnAutor.Text = "Autor";
            this.rbtnAutor.UseVisualStyleBackColor = true;
            this.rbtnAutor.CheckedChanged += new System.EventHandler(this.rbtnAutor_CheckedChanged);
            // 
            // rbtnEditorial
            // 
            this.rbtnEditorial.AutoSize = true;
            this.rbtnEditorial.Location = new System.Drawing.Point(117, 19);
            this.rbtnEditorial.Name = "rbtnEditorial";
            this.rbtnEditorial.Size = new System.Drawing.Size(62, 17);
            this.rbtnEditorial.TabIndex = 4;
            this.rbtnEditorial.Text = "Editorial";
            this.rbtnEditorial.UseVisualStyleBackColor = true;
            this.rbtnEditorial.CheckedChanged += new System.EventHandler(this.rbtnEditorial_CheckedChanged);
            // 
            // rbtnEdicion
            // 
            this.rbtnEdicion.AutoSize = true;
            this.rbtnEdicion.Location = new System.Drawing.Point(119, 44);
            this.rbtnEdicion.Name = "rbtnEdicion";
            this.rbtnEdicion.Size = new System.Drawing.Size(60, 17);
            this.rbtnEdicion.TabIndex = 5;
            this.rbtnEdicion.Text = "Edicion";
            this.rbtnEdicion.UseVisualStyleBackColor = true;
            // 
            // rbtnNinguno
            // 
            this.rbtnNinguno.AutoSize = true;
            this.rbtnNinguno.Checked = true;
            this.rbtnNinguno.Location = new System.Drawing.Point(25, 19);
            this.rbtnNinguno.Name = "rbtnNinguno";
            this.rbtnNinguno.Size = new System.Drawing.Size(65, 17);
            this.rbtnNinguno.TabIndex = 6;
            this.rbtnNinguno.TabStop = true;
            this.rbtnNinguno.Text = "Ninguno";
            this.rbtnNinguno.UseVisualStyleBackColor = true;
            this.rbtnNinguno.CheckedChanged += new System.EventHandler(this.rbtnNinguno_CheckedChanged);
            // 
            // grpbTipobusqueda
            // 
            this.grpbTipobusqueda.Controls.Add(this.rbtnNinguno);
            this.grpbTipobusqueda.Controls.Add(this.rbtnEdicion);
            this.grpbTipobusqueda.Controls.Add(this.rbtnAutor);
            this.grpbTipobusqueda.Controls.Add(this.rbtnEditorial);
            this.grpbTipobusqueda.Location = new System.Drawing.Point(12, 27);
            this.grpbTipobusqueda.Name = "grpbTipobusqueda";
            this.grpbTipobusqueda.Size = new System.Drawing.Size(199, 70);
            this.grpbTipobusqueda.TabIndex = 7;
            this.grpbTipobusqueda.TabStop = false;
            this.grpbTipobusqueda.Text = "Tipo de busqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(387, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(512, 69);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // wfBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 424);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpbTipobusqueda);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfBuscar";
            this.Text = "Busqueda de libros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpbTipobusqueda.ResumeLayout(false);
            this.grpbTipobusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbtnAutor;
        private System.Windows.Forms.RadioButton rbtnEditorial;
        private System.Windows.Forms.RadioButton rbtnEdicion;
        private System.Windows.Forms.RadioButton rbtnNinguno;
        private System.Windows.Forms.GroupBox grpbTipobusqueda;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

