﻿/*
 * Created by SharpDevelop.
 * User: FamGutierrez
 * Date: 08/10/2013
 * Time: 07:24 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prototipo
{
	partial class wfMenuAdministrador
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMenuAdministrador));
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProye = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProvee = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corrienteLiterariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCLiteraria = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btninfo = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.toolStripMenuItem2,
            this.btnLibros,
            this.btnConsulta,
            this.btnCLiteraria,
            this.btnAyuda});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMenuPrincipal.Size = new System.Drawing.Size(794, 55);
            this.msMenuPrincipal.TabIndex = 0;
            this.msMenuPrincipal.Text = "menuStrip1";
            this.msMenuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMenuPrincipal_ItemClicked);
            // 
            // btnInicio
            // 
            this.btnInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnBuscar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(48, 51);
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNuevo
            // 
            this.btnNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProduc});
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 22);
            this.btnNuevo.Text = "&Nuevo";
            // 
            // btnProduc
            // 
            this.btnProduc.Image = ((System.Drawing.Image)(resources.GetObject("btnProduc.Image")));
            this.btnProduc.Name = "btnProduc";
            this.btnProduc.Size = new System.Drawing.Size(123, 22);
            this.btnProduc.Text = "Pro&ducto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCliente,
            this.btnProye,
            this.btnProvee,
            this.btnProd});
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 22);
            this.btnBuscar.Text = "&Buscar";
            // 
            // btnCliente
            // 
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(128, 22);
            this.btnCliente.Text = "&Cliente";
            // 
            // btnProye
            // 
            this.btnProye.Image = ((System.Drawing.Image)(resources.GetObject("btnProye.Image")));
            this.btnProye.Name = "btnProye";
            this.btnProye.Size = new System.Drawing.Size(128, 22);
            this.btnProye.Text = "&Proyecto";
            // 
            // btnProvee
            // 
            this.btnProvee.Image = ((System.Drawing.Image)(resources.GetObject("btnProvee.Image")));
            this.btnProvee.Name = "btnProvee";
            this.btnProvee.Size = new System.Drawing.Size(128, 22);
            this.btnProvee.Text = "Pro&veedor";
            // 
            // btnProd
            // 
            this.btnProd.Image = ((System.Drawing.Image)(resources.GetObject("btnProd.Image")));
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(128, 22);
            this.btnProd.Text = "Pro&ducto";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem,
            this.formularioToolStripMenuItem});
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 51);
            this.toolStripMenuItem2.Text = "&Alquiler";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Add;
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.registroClienteToolStripMenuItem.Text = "Registro Cliente";
            this.registroClienteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // formularioToolStripMenuItem
            // 
            this.formularioToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Add;
            this.formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            this.formularioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.formularioToolStripMenuItem.Text = "Formulario";
            this.formularioToolStripMenuItem.Click += new System.EventHandler(this.formularioToolStripMenuItem_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIngresar,
            this.buscarToolStripMenuItem});
            this.btnLibros.Image = global::Prototipo.Properties.Resources.library_icon;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLibros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(46, 51);
            this.btnLibros.Text = "&Libro";
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = global::Prototipo.Properties.Resources.Add;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 22);
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Search;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCAutor,
            this.editorialToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.corrienteLiterariaToolStripMenuItem});
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(78, 51);
            this.btnConsulta.Text = "&Asignacion";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCAutor
            // 
            this.btnCAutor.Image = global::Prototipo.Properties.Resources.Add;
            this.btnCAutor.Name = "btnCAutor";
            this.btnCAutor.Size = new System.Drawing.Size(168, 22);
            this.btnCAutor.Text = "Autor";
            this.btnCAutor.Click += new System.EventHandler(this.btnCAutor_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Add;
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editorialToolStripMenuItem.Text = "Editorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.editorialToolStripMenuItem_Click_1);
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Add;
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click_1);
            // 
            // corrienteLiterariaToolStripMenuItem
            // 
            this.corrienteLiterariaToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Add;
            this.corrienteLiterariaToolStripMenuItem.Name = "corrienteLiterariaToolStripMenuItem";
            this.corrienteLiterariaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.corrienteLiterariaToolStripMenuItem.Text = "Corriente Literaria";
            this.corrienteLiterariaToolStripMenuItem.Click += new System.EventHandler(this.corrienteLiterariaToolStripMenuItem_Click);
            // 
            // btnCLiteraria
            // 
            this.btnCLiteraria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem});
            this.btnCLiteraria.Image = ((System.Drawing.Image)(resources.GetObject("btnCLiteraria.Image")));
            this.btnCLiteraria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCLiteraria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCLiteraria.Name = "btnCLiteraria";
            this.btnCLiteraria.Size = new System.Drawing.Size(60, 51);
            this.btnCLiteraria.Text = "Reporte";
            this.btnCLiteraria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCLiteraria.Click += new System.EventHandler(this.btnCLiteraria_Click);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Add;
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ingresoToolStripMenuItem.Text = "Exportar reporte";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btninfo,
            this.manualToolStripMenuItem});
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(53, 51);
            this.btnAyuda.Text = "A&yuda";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btninfo
            // 
            this.btninfo.Image = ((System.Drawing.Image)(resources.GetObject("btninfo.Image")));
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(139, 22);
            this.btninfo.Text = "Información";
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tecnicoToolStripMenuItem,
            this.uToolStripMenuItem});
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // tecnicoToolStripMenuItem
            // 
            this.tecnicoToolStripMenuItem.Name = "tecnicoToolStripMenuItem";
            this.tecnicoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.tecnicoToolStripMenuItem.Text = "Usuario";
            this.tecnicoToolStripMenuItem.Click += new System.EventHandler(this.tecnicoToolStripMenuItem_Click);
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.uToolStripMenuItem.Text = "Tecnico";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 30);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // wfMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototipo.Properties.Resources.Fondo_completo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuPrincipal;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "wfMenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control BiblioRedes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WfMenuLoad);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnSalir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem btninfo;
		private System.Windows.Forms.ToolStripMenuItem btnAyuda;
        private System.Windows.Forms.ToolStripMenuItem btnConsulta;
		private System.Windows.Forms.ToolStripMenuItem btnLibros;
		private System.Windows.Forms.ToolStripMenuItem btnCliente;
		private System.Windows.Forms.ToolStripMenuItem btnProd;
		private System.Windows.Forms.ToolStripMenuItem btnProvee;
		private System.Windows.Forms.ToolStripMenuItem btnProye;
        private System.Windows.Forms.ToolStripMenuItem btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem btnProduc;
		private System.Windows.Forms.ToolStripMenuItem btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnCLiteraria;
		private System.Windows.Forms.ToolStripMenuItem btnInicio;
		private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnIngresar;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCAutor;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem registroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corrienteLiterariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
	}
}
