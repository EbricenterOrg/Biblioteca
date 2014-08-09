namespace Prototipo
{
    partial class wfAlquiler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAlquiler));
            this.txtIdAlquiler = new System.Windows.Forms.TextBox();
            this.lblIdAlquiler = new System.Windows.Forms.Label();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboIdPersona = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idlibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdAlquiler
            // 
            this.txtIdAlquiler.Location = new System.Drawing.Point(137, 31);
            this.txtIdAlquiler.Name = "txtIdAlquiler";
            this.txtIdAlquiler.Size = new System.Drawing.Size(100, 20);
            this.txtIdAlquiler.TabIndex = 0;
            // 
            // lblIdAlquiler
            // 
            this.lblIdAlquiler.AutoSize = true;
            this.lblIdAlquiler.Location = new System.Drawing.Point(45, 37);
            this.lblIdAlquiler.Name = "lblIdAlquiler";
            this.lblIdAlquiler.Size = new System.Drawing.Size(53, 13);
            this.lblIdAlquiler.TabIndex = 1;
            this.lblIdAlquiler.Text = "Id Alquiler";
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Location = new System.Drawing.Point(287, 31);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(58, 13);
            this.lblIdPersona.TabIndex = 2;
            this.lblIdPersona.Text = "Id Persona";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cboIdPersona
            // 
            this.cboIdPersona.FormattingEnabled = true;
            this.cboIdPersona.Location = new System.Drawing.Point(366, 29);
            this.cboIdPersona.Name = "cboIdPersona";
            this.cboIdPersona.Size = new System.Drawing.Size(121, 21);
            this.cboIdPersona.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(409, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(481, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(45, 128);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 128);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(408, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Detalle Alquiler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idlibro,
            this.nombre_libro,
            this.autor,
            this.corriente,
            this.tipo_alquiler,
            this.fecha_alquiler,
            this.fecha_entrega});
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Idlibro
            // 
            this.Idlibro.HeaderText = "Idlibro";
            this.Idlibro.Name = "Idlibro";
            // 
            // nombre_libro
            // 
            this.nombre_libro.HeaderText = "nombre_libro";
            this.nombre_libro.Name = "nombre_libro";
            // 
            // autor
            // 
            this.autor.HeaderText = "autor";
            this.autor.Name = "autor";
            // 
            // corriente
            // 
            this.corriente.HeaderText = "corriente";
            this.corriente.Name = "corriente";
            // 
            // tipo_alquiler
            // 
            this.tipo_alquiler.HeaderText = "tipo_alquiler";
            this.tipo_alquiler.Name = "tipo_alquiler";
            // 
            // fecha_alquiler
            // 
            this.fecha_alquiler.HeaderText = "fecha_alquiler";
            this.fecha_alquiler.Name = "fecha_alquiler";
            // 
            // fecha_entrega
            // 
            this.fecha_entrega.HeaderText = "fecha_entrega";
            this.fecha_entrega.Name = "fecha_entrega";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1081, 382);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(971, 388);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 15;
            this.Total.Text = "Total";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(582, 399);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 26);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(501, 399);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 26);
            this.btnConsulta.TabIndex = 16;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wfAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.cboIdPersona);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdPersona);
            this.Controls.Add(this.lblIdAlquiler);
            this.Controls.Add(this.txtIdAlquiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wfAlquiler";
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdAlquiler;
        private System.Windows.Forms.Label lblIdAlquiler;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboIdPersona;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn corriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_entrega;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button button1;
    }
}

