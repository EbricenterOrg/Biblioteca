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
            this.SuspendLayout();
            // 
            // btnIngreAutor
            // 
            this.btnIngreAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnIngreAutor.Image")));
            this.btnIngreAutor.Location = new System.Drawing.Point(349, 237);
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
            this.lblNomAutor.Location = new System.Drawing.Point(153, 113);
            this.lblNomAutor.Name = "lblNomAutor";
            this.lblNomAutor.Size = new System.Drawing.Size(44, 13);
            this.lblNomAutor.TabIndex = 1;
            this.lblNomAutor.Text = "Nombre";
            // 
            // txtNomAutor
            // 
            this.txtNomAutor.Location = new System.Drawing.Point(293, 106);
            this.txtNomAutor.Name = "txtNomAutor";
            this.txtNomAutor.Size = new System.Drawing.Size(100, 20);
            this.txtNomAutor.TabIndex = 2;
            // 
            // lblIngresoAutor
            // 
            this.lblIngresoAutor.AutoSize = true;
            this.lblIngresoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoAutor.Location = new System.Drawing.Point(151, 19);
            this.lblIngresoAutor.Name = "lblIngresoAutor";
            this.lblIngresoAutor.Size = new System.Drawing.Size(199, 25);
            this.lblIngresoAutor.TabIndex = 3;
            this.lblIngresoAutor.Text = "INGRESO AUTOR";
            // 
            // txtApeAutor
            // 
            this.txtApeAutor.Location = new System.Drawing.Point(293, 150);
            this.txtApeAutor.Name = "txtApeAutor";
            this.txtApeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtApeAutor.TabIndex = 4;
            // 
            // lblApeAutor
            // 
            this.lblApeAutor.AutoSize = true;
            this.lblApeAutor.Location = new System.Drawing.Point(153, 153);
            this.lblApeAutor.Name = "lblApeAutor";
            this.lblApeAutor.Size = new System.Drawing.Size(44, 13);
            this.lblApeAutor.TabIndex = 5;
            this.lblApeAutor.Text = "Apellido";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(293, 237);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Prototipo.Properties.Resources.Delete;
            this.btnSalir.Location = new System.Drawing.Point(243, 237);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // wfAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 320);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblApeAutor);
            this.Controls.Add(this.txtApeAutor);
            this.Controls.Add(this.lblIngresoAutor);
            this.Controls.Add(this.txtNomAutor);
            this.Controls.Add(this.lblNomAutor);
            this.Controls.Add(this.btnIngreAutor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfAutor";
            this.Text = "Ingreso Autor";
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
    }
}