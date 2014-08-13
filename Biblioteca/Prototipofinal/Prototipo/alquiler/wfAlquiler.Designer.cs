namespace Prototipo.alquiler
{
    partial class wfAlquiler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblnombrecliente = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelecOrden = new System.Windows.Forms.Label();
            this.lblIdAlquiler = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSelecGenero = new System.Windows.Forms.Label();
            this.cboSelecCliente = new System.Windows.Forms.ComboBox();
            this.lblSelecCliente = new System.Windows.Forms.Label();
            this.txtcontrolalquiler = new System.Windows.Forms.TextBox();
            this.btncompletarlista = new System.Windows.Forms.Button();
            this.btnagregarlibro = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblnombrecliente);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblSelecOrden);
            this.panel1.Controls.Add(this.lblIdAlquiler);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.lblSelecGenero);
            this.panel1.Controls.Add(this.cboSelecCliente);
            this.panel1.Controls.Add(this.lblSelecCliente);
            this.panel1.Controls.Add(this.txtcontrolalquiler);
            this.panel1.Controls.Add(this.btncompletarlista);
            this.panel1.Controls.Add(this.btnagregarlibro);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 405);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnombrecliente
            // 
            this.lblnombrecliente.AutoSize = true;
            this.lblnombrecliente.Location = new System.Drawing.Point(238, 70);
            this.lblnombrecliente.Name = "lblnombrecliente";
            this.lblnombrecliente.Size = new System.Drawing.Size(35, 13);
            this.lblnombrecliente.TabIndex = 52;
            this.lblnombrecliente.Text = "label2";
            this.lblnombrecliente.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 48;
            // 
            // lblSelecOrden
            // 
            this.lblSelecOrden.AutoSize = true;
            this.lblSelecOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecOrden.Location = new System.Drawing.Point(68, 229);
            this.lblSelecOrden.Name = "lblSelecOrden";
            this.lblSelecOrden.Size = new System.Drawing.Size(41, 16);
            this.lblSelecOrden.TabIndex = 51;
            this.lblSelecOrden.Text = "Libro:";
            // 
            // lblIdAlquiler
            // 
            this.lblIdAlquiler.AutoSize = true;
            this.lblIdAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAlquiler.Location = new System.Drawing.Point(507, 32);
            this.lblIdAlquiler.Name = "lblIdAlquiler";
            this.lblIdAlquiler.Size = new System.Drawing.Size(100, 16);
            this.lblIdAlquiler.TabIndex = 39;
            this.lblIdAlquiler.Text = "No. ALQUILER:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(186, 224);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 50;
            // 
            // lblSelecGenero
            // 
            this.lblSelecGenero.AutoSize = true;
            this.lblSelecGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecGenero.Location = new System.Drawing.Point(68, 121);
            this.lblSelecGenero.Name = "lblSelecGenero";
            this.lblSelecGenero.Size = new System.Drawing.Size(103, 16);
            this.lblSelecGenero.TabIndex = 42;
            this.lblSelecGenero.Text = "Elegir Corriente:";
            // 
            // cboSelecCliente
            // 
            this.cboSelecCliente.FormattingEnabled = true;
            this.cboSelecCliente.Location = new System.Drawing.Point(241, 36);
            this.cboSelecCliente.Name = "cboSelecCliente";
            this.cboSelecCliente.Size = new System.Drawing.Size(151, 21);
            this.cboSelecCliente.TabIndex = 40;
            this.cboSelecCliente.SelectedIndexChanged += new System.EventHandler(this.cboSelecCliente_SelectedIndexChanged);
            // 
            // lblSelecCliente
            // 
            this.lblSelecCliente.AutoSize = true;
            this.lblSelecCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecCliente.Location = new System.Drawing.Point(68, 41);
            this.lblSelecCliente.Name = "lblSelecCliente";
            this.lblSelecCliente.Size = new System.Drawing.Size(167, 16);
            this.lblSelecCliente.TabIndex = 41;
            this.lblSelecCliente.Text = "SELECCIÓN DE CLIENTE:";
            // 
            // txtcontrolalquiler
            // 
            this.txtcontrolalquiler.Location = new System.Drawing.Point(613, 32);
            this.txtcontrolalquiler.Name = "txtcontrolalquiler";
            this.txtcontrolalquiler.Size = new System.Drawing.Size(100, 20);
            this.txtcontrolalquiler.TabIndex = 43;
            // 
            // btncompletarlista
            // 
            this.btncompletarlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompletarlista.Location = new System.Drawing.Point(613, 331);
            this.btncompletarlista.Name = "btncompletarlista";
            this.btncompletarlista.Size = new System.Drawing.Size(75, 42);
            this.btncompletarlista.TabIndex = 46;
            this.btncompletarlista.Text = "Terminar Pedido";
            this.btncompletarlista.UseVisualStyleBackColor = true;
            // 
            // btnagregarlibro
            // 
            this.btnagregarlibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarlibro.Location = new System.Drawing.Point(314, 269);
            this.btnagregarlibro.Name = "btnagregarlibro";
            this.btnagregarlibro.Size = new System.Drawing.Size(75, 42);
            this.btnagregarlibro.TabIndex = 45;
            this.btnagregarlibro.Text = "Agregar Libro";
            this.btnagregarlibro.UseVisualStyleBackColor = true;
            this.btnagregarlibro.Click += new System.EventHandler(this.btnagregarlibro_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(272, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(235, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "ALQUILER DE LIBRO";
            // 
            // wfAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 498);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel1);
            this.Name = "wfAlquiler";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.wfAlquiler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelecOrden;
        private System.Windows.Forms.Label lblIdAlquiler;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSelecGenero;
        private System.Windows.Forms.ComboBox cboSelecCliente;
        private System.Windows.Forms.Label lblSelecCliente;
        private System.Windows.Forms.TextBox txtcontrolalquiler;
        private System.Windows.Forms.Button btncompletarlista;
        private System.Windows.Forms.Button btnagregarlibro;
        private System.Windows.Forms.Label lblnombrecliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
    }
}