﻿namespace Prototipo
{
    partial class wfMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMateria));
            this.btnIngreMat = new System.Windows.Forms.Button();
            this.lblMat = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngreMat
            // 
            this.btnIngreMat.Image = ((System.Drawing.Image)(resources.GetObject("btnIngreMat.Image")));
            this.btnIngreMat.Location = new System.Drawing.Point(386, 230);
            this.btnIngreMat.Name = "btnIngreMat";
            this.btnIngreMat.Size = new System.Drawing.Size(44, 36);
            this.btnIngreMat.TabIndex = 0;
            this.btnIngreMat.UseVisualStyleBackColor = true;
            this.btnIngreMat.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(192, 132);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(42, 13);
            this.lblMat.TabIndex = 1;
            this.lblMat.Text = "Materia";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(330, 132);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 20);
            this.txtMat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "INGRESO MATERIA";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(280, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(336, 230);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // wfMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 343);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.btnIngreMat);
            this.Name = "wfMateria";
            this.Text = "wfMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngreMat;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}