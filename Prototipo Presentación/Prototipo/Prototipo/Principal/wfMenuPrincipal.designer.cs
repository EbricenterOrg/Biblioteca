/*
 * Created by SharpDevelop.
 * User: FamGutierrez
 * Date: 08/10/2013
 * Time: 07:24 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prototipo
{
	partial class btnprodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnprodu));
            this.wfMenuPrincipal = new System.Windows.Forms.MenuStrip();
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
            this.btnLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnElim = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCLiteraria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTrabajadores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btninfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wfMenuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wfMenuPrincipal
            // 
            this.wfMenuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.wfMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnLibros,
            this.btnAlquiler,
            this.btnCLiteraria,
            this.btnConsulta,
            this.btnTrabajadores,
            this.btnAyuda});
            this.wfMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.wfMenuPrincipal.Name = "wfMenuPrincipal";
            this.wfMenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.wfMenuPrincipal.Size = new System.Drawing.Size(794, 55);
            this.wfMenuPrincipal.TabIndex = 0;
            this.wfMenuPrincipal.Text = "menuStrip1";
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
            this.btnNuevo.Size = new System.Drawing.Size(152, 22);
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
            this.btnBuscar.Size = new System.Drawing.Size(152, 22);
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
            // 
            // btnLibros
            // 
            this.btnLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIngresar,
            this.btnGu,
            this.btnElim,
            this.buscarToolStripMenuItem});
            this.btnLibros.Image = global::Prototipo.Properties.Resources.library_icon;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLibros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(51, 51);
            this.btnLibros.Text = "&Libros";
            this.btnLibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = global::Prototipo.Properties.Resources.Add;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(117, 22);
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // btnGu
            // 
            this.btnGu.Image = global::Prototipo.Properties.Resources.Modify;
            this.btnGu.Name = "btnGu";
            this.btnGu.Size = new System.Drawing.Size(117, 22);
            this.btnGu.Text = "Editar";
            this.btnGu.Click += new System.EventHandler(this.btnGu_Click);
            // 
            // btnElim
            // 
            this.btnElim.Image = global::Prototipo.Properties.Resources.Delete;
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(117, 22);
            this.btnElim.Text = "Eliminar";
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Search;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.Image = ((System.Drawing.Image)(resources.GetObject("btnAlquiler.Image")));
            this.btnAlquiler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlquiler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(60, 51);
            this.btnAlquiler.Text = "&Alquiler";
            this.btnAlquiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlquiler.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnCLiteraria
            // 
            this.btnCLiteraria.Image = ((System.Drawing.Image)(resources.GetObject("btnCLiteraria.Image")));
            this.btnCLiteraria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCLiteraria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCLiteraria.Name = "btnCLiteraria";
            this.btnCLiteraria.Size = new System.Drawing.Size(80, 51);
            this.btnCLiteraria.Text = "C. Literarias";
            this.btnCLiteraria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCLiteraria.Click += new System.EventHandler(this.btnCLiteraria_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCAutor,
            this.editorialToolStripMenuItem,
            this.materiaToolStripMenuItem});
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(60, 51);
            this.btnConsulta.Text = "&Reporte";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCAutor
            // 
            this.btnCAutor.Image = global::Prototipo.Properties.Resources.Loading;
            this.btnCAutor.Name = "btnCAutor";
            this.btnCAutor.Size = new System.Drawing.Size(117, 22);
            this.btnCAutor.Text = "Autor";
            this.btnCAutor.Click += new System.EventHandler(this.btnCAutor_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Loading;
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editorialToolStripMenuItem.Text = "Editorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.editorialToolStripMenuItem_Click);
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Image = global::Prototipo.Properties.Resources.Loading;
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.btnTrabajadores.Image = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.Image")));
            this.btnTrabajadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrabajadores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Size = new System.Drawing.Size(87, 51);
            this.btnTrabajadores.Text = "&Trabajadores";
            this.btnTrabajadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Prototipo.Properties.Resources.Add;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Ingreso";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btninfo});
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
            // btnprodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototipo.Properties.Resources.Fondo_completo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wfMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.wfMenuPrincipal;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "btnprodu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.Load += new System.EventHandler(this.WfMenuLoad);
            this.wfMenuPrincipal.ResumeLayout(false);
            this.wfMenuPrincipal.PerformLayout();
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
		private System.Windows.Forms.ToolStripMenuItem btnTrabajadores;
		private System.Windows.Forms.ToolStripMenuItem btnLibros;
		private System.Windows.Forms.ToolStripMenuItem btnCliente;
		private System.Windows.Forms.ToolStripMenuItem btnProd;
		private System.Windows.Forms.ToolStripMenuItem btnProvee;
		private System.Windows.Forms.ToolStripMenuItem btnProye;
        private System.Windows.Forms.ToolStripMenuItem btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem btnProduc;
		private System.Windows.Forms.ToolStripMenuItem btnNuevo;
		private System.Windows.Forms.ToolStripMenuItem btnCLiteraria;
		private System.Windows.Forms.ToolStripMenuItem btnAlquiler;
		private System.Windows.Forms.ToolStripMenuItem btnInicio;
		private System.Windows.Forms.MenuStrip wfMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnIngresar;
        private System.Windows.Forms.ToolStripMenuItem btnGu;
        private System.Windows.Forms.ToolStripMenuItem btnElim;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnCAutor;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
	}
}
