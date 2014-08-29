namespace Prototipo
{
    partial class wfAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAutor));
            this.btnIngreAutor = new System.Windows.Forms.Button();
            this.lblNomAutor = new System.Windows.Forms.Label();
            this.txtNomAutor = new System.Windows.Forms.TextBox();
            this.lblIngresoAutor = new System.Windows.Forms.Label();
            this.txtApeAutor = new System.Windows.Forms.TextBox();
            this.lblApeAutor = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngreAutor
            // 
            this.btnIngreAutor.Enabled = false;
            this.btnIngreAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnIngreAutor.Image")));
            this.btnIngreAutor.Location = new System.Drawing.Point(237, 239);
            this.btnIngreAutor.Name = "btnIngreAutor";
            this.btnIngreAutor.Size = new System.Drawing.Size(44, 36);
            this.btnIngreAutor.TabIndex = 0;
            this.btnIngreAutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngreAutor.UseVisualStyleBackColor = true;
            this.btnIngreAutor.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNomAutor
            // 
            this.lblNomAutor.AutoSize = true;
            this.lblNomAutor.Location = new System.Drawing.Point(62, 108);
            this.lblNomAutor.Name = "lblNomAutor";
            this.lblNomAutor.Size = new System.Drawing.Size(44, 13);
            this.lblNomAutor.TabIndex = 1;
            this.lblNomAutor.Text = "Nombre";
            // 
            // txtNomAutor
            // 
            this.txtNomAutor.Enabled = false;
            this.txtNomAutor.Location = new System.Drawing.Point(231, 108);
            this.txtNomAutor.Name = "txtNomAutor";
            this.txtNomAutor.Size = new System.Drawing.Size(100, 20);
            this.txtNomAutor.TabIndex = 2;
            this.txtNomAutor.TextChanged += new System.EventHandler(this.txtNomAutor_TextChanged);
            this.txtNomAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomAutor_KeyPress);
            // 
            // lblIngresoAutor
            // 
            this.lblIngresoAutor.AutoSize = true;
            this.lblIngresoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoAutor.Location = new System.Drawing.Point(104, 23);
            this.lblIngresoAutor.Name = "lblIngresoAutor";
            this.lblIngresoAutor.Size = new System.Drawing.Size(199, 25);
            this.lblIngresoAutor.TabIndex = 3;
            this.lblIngresoAutor.Text = "INGRESO AUTOR";
            // 
            // txtApeAutor
            // 
            this.txtApeAutor.Enabled = false;
            this.txtApeAutor.Location = new System.Drawing.Point(231, 152);
            this.txtApeAutor.Name = "txtApeAutor";
            this.txtApeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtApeAutor.TabIndex = 4;
            this.txtApeAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeAutor_KeyPress);
            // 
            // lblApeAutor
            // 
            this.lblApeAutor.AutoSize = true;
            this.lblApeAutor.Location = new System.Drawing.Point(62, 159);
            this.lblApeAutor.Name = "lblApeAutor";
            this.lblApeAutor.Size = new System.Drawing.Size(44, 13);
            this.lblApeAutor.TabIndex = 5;
            this.lblApeAutor.Text = "Apellido";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(187, 239);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Prototipo.Properties.Resources.Delete;
            this.btnSalir.Location = new System.Drawing.Point(137, 239);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Prototipo.Properties.Resources.Add;
            this.btnAgregar.Location = new System.Drawing.Point(287, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 36);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // wfAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 291);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblApeAutor);
            this.Controls.Add(this.txtApeAutor);
            this.Controls.Add(this.lblIngresoAutor);
            this.Controls.Add(this.txtNomAutor);
            this.Controls.Add(this.lblNomAutor);
            this.Controls.Add(this.btnIngreAutor);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfAutor";
            this.Text = " Autor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.wfAutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngreAutor;
        private System.Windows.Forms.Label lblNomAutor;
        private System.Windows.Forms.TextBox txtNomAutor;
        private System.Windows.Forms.Label lblIngresoAutor;
        private System.Windows.Forms.TextBox txtApeAutor;
        private System.Windows.Forms.Label lblApeAutor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
    }
}