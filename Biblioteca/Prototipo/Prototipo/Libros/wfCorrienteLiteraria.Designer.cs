﻿namespace Prototipo
{
    partial class wfCorrienteLiteraria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCorrienteLiteraria));
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomCorriente = new System.Windows.Forms.Label();
            this.txtNomCorriente = new System.Windows.Forms.TextBox();
            this.btnIgreCorriente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "CORRIENTE LITERARIA";
            // 
            // lblNomCorriente
            // 
            this.lblNomCorriente.AutoSize = true;
            this.lblNomCorriente.Location = new System.Drawing.Point(123, 125);
            this.lblNomCorriente.Name = "lblNomCorriente";
            this.lblNomCorriente.Size = new System.Drawing.Size(44, 13);
            this.lblNomCorriente.TabIndex = 9;
            this.lblNomCorriente.Text = "Nombre";
            // 
            // txtNomCorriente
            // 
            this.txtNomCorriente.Location = new System.Drawing.Point(257, 125);
            this.txtNomCorriente.Name = "txtNomCorriente";
            this.txtNomCorriente.Size = new System.Drawing.Size(100, 20);
            this.txtNomCorriente.TabIndex = 10;
            // 
            // btnIgreCorriente
            // 
            this.btnIgreCorriente.Image = ((System.Drawing.Image)(resources.GetObject("btnIgreCorriente.Image")));
            this.btnIgreCorriente.Location = new System.Drawing.Point(313, 222);
            this.btnIgreCorriente.Name = "btnIgreCorriente";
            this.btnIgreCorriente.Size = new System.Drawing.Size(44, 36);
            this.btnIgreCorriente.TabIndex = 14;
            this.btnIgreCorriente.UseVisualStyleBackColor = true;
            this.btnIgreCorriente.Click += new System.EventHandler(this.btnIgresarCorriente_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(263, 222);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(213, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // wfCorrienteLiteraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 337);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIgreCorriente);
            this.Controls.Add(this.txtNomCorriente);
            this.Controls.Add(this.lblNomCorriente);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCorrienteLiteraria";
            this.Text = "Corriente Literaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomCorriente;
        private System.Windows.Forms.TextBox txtNomCorriente;
        private System.Windows.Forms.Button btnIgreCorriente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}