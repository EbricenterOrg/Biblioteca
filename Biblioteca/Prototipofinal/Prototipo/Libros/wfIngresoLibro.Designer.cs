namespace Prototipo
{
    partial class wfIngresoLibro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfIngresoLibro));
            this.txtNomLib = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lblNomLib = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNoPag = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.nudVol = new System.Windows.Forms.NumericUpDown();
            this.lblEdi = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.cboEdit = new System.Windows.Forms.ComboBox();
            this.lblEstant = new System.Windows.Forms.Label();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.cboCorriente = new System.Windows.Forms.ComboBox();
            this.lblCorriLite = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.cboMat = new System.Windows.Forms.ComboBox();
            this.lblEjem = new System.Windows.Forms.Label();
            this.nudEjem = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cboEstante = new System.Windows.Forms.ComboBox();
            this.tcIngresoLibro = new System.Windows.Forms.TabControl();
            this.tpNuevo = new System.Windows.Forms.TabPage();
            this.nudpag = new System.Windows.Forms.NumericUpDown();
            this.nudEdi = new System.Windows.Forms.NumericUpDown();
            this.tpExistente = new System.Windows.Forms.TabPage();
            this.cboEVol = new System.Windows.Forms.ComboBox();
            this.lblEVol = new System.Windows.Forms.Label();
            this.txtEEjem = new System.Windows.Forms.TextBox();
            this.lblEEjem = new System.Windows.Forms.Label();
            this.cboEMat = new System.Windows.Forms.ComboBox();
            this.cboECate = new System.Windows.Forms.ComboBox();
            this.cboETitulo = new System.Windows.Forms.ComboBox();
            this.lblECat = new System.Windows.Forms.Label();
            this.lblEMat = new System.Windows.Forms.Label();
            this.cboENomLib = new System.Windows.Forms.ComboBox();
            this.lblETit = new System.Windows.Forms.Label();
            this.lblENomLib = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mostrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjem)).BeginInit();
            this.tcIngresoLibro.SuspendLayout();
            this.tpNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudpag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdi)).BeginInit();
            this.tpExistente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomLib
            // 
            this.txtNomLib.Enabled = false;
            this.txtNomLib.Location = new System.Drawing.Point(117, 14);
            this.txtNomLib.Name = "txtNomLib";
            this.txtNomLib.Size = new System.Drawing.Size(100, 20);
            this.txtNomLib.TabIndex = 0;
            this.txtNomLib.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNomLib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomLib_KeyPress);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngreso.BackgroundImage")));
            this.btnIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIngreso.Enabled = false;
            this.btnIngreso.Location = new System.Drawing.Point(666, 439);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(44, 36);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomLib
            // 
            this.lblNomLib.AutoSize = true;
            this.lblNomLib.Location = new System.Drawing.Point(26, 20);
            this.lblNomLib.Name = "lblNomLib";
            this.lblNomLib.Size = new System.Drawing.Size(70, 13);
            this.lblNomLib.TabIndex = 3;
            this.lblNomLib.Text = "Nombre Libro";
            // 
            // txtLib
            // 
            this.txtLib.Enabled = false;
            this.txtLib.Location = new System.Drawing.Point(117, 40);
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(100, 20);
            this.txtLib.TabIndex = 4;
            this.txtLib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLib_KeyPress);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(26, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblNoPag
            // 
            this.lblNoPag.AutoSize = true;
            this.lblNoPag.Location = new System.Drawing.Point(26, 73);
            this.lblNoPag.Name = "lblNoPag";
            this.lblNoPag.Size = new System.Drawing.Size(62, 13);
            this.lblNoPag.TabIndex = 7;
            this.lblNoPag.Text = "No Paginas";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(26, 98);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(48, 13);
            this.lblVol.TabIndex = 8;
            this.lblVol.Text = "Volumen";
            // 
            // nudVol
            // 
            this.nudVol.Enabled = false;
            this.nudVol.Location = new System.Drawing.Point(117, 92);
            this.nudVol.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudVol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVol.Name = "nudVol";
            this.nudVol.Size = new System.Drawing.Size(120, 20);
            this.nudVol.TabIndex = 9;
            this.nudVol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVol.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nudVol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudVol_KeyPress);
            // 
            // lblEdi
            // 
            this.lblEdi.AutoSize = true;
            this.lblEdi.Location = new System.Drawing.Point(26, 130);
            this.lblEdi.Name = "lblEdi";
            this.lblEdi.Size = new System.Drawing.Size(42, 13);
            this.lblEdi.TabIndex = 10;
            this.lblEdi.Text = "Edicion";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(26, 158);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(44, 13);
            this.lblEdit.TabIndex = 11;
            this.lblEdit.Text = "Editorial";
            // 
            // cboEdit
            // 
            this.cboEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdit.Enabled = false;
            this.cboEdit.FormattingEnabled = true;
            this.cboEdit.Location = new System.Drawing.Point(117, 158);
            this.cboEdit.Name = "cboEdit";
            this.cboEdit.Size = new System.Drawing.Size(121, 21);
            this.cboEdit.TabIndex = 12;
            // 
            // lblEstant
            // 
            this.lblEstant.AutoSize = true;
            this.lblEstant.Location = new System.Drawing.Point(353, 108);
            this.lblEstant.Name = "lblEstant";
            this.lblEstant.Size = new System.Drawing.Size(101, 13);
            this.lblEstant.TabIndex = 13;
            this.lblEstant.Text = "Estante - Entrepaño";
            // 
            // cboAutor
            // 
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.Enabled = false;
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(477, 12);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(121, 21);
            this.cboAutor.TabIndex = 15;
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(353, 12);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 16;
            this.lblAutor.Text = "Autor";
            // 
            // cboCorriente
            // 
            this.cboCorriente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCorriente.Enabled = false;
            this.cboCorriente.FormattingEnabled = true;
            this.cboCorriente.Location = new System.Drawing.Point(477, 38);
            this.cboCorriente.Name = "cboCorriente";
            this.cboCorriente.Size = new System.Drawing.Size(121, 21);
            this.cboCorriente.TabIndex = 17;
            this.cboCorriente.SelectedIndexChanged += new System.EventHandler(this.cboCorriente_SelectedIndexChanged);
            // 
            // lblCorriLite
            // 
            this.lblCorriLite.AutoSize = true;
            this.lblCorriLite.Location = new System.Drawing.Point(353, 38);
            this.lblCorriLite.Name = "lblCorriLite";
            this.lblCorriLite.Size = new System.Drawing.Size(89, 13);
            this.lblCorriLite.TabIndex = 18;
            this.lblCorriLite.Text = "Corriente Literaria";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(353, 73);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(42, 13);
            this.lblMat.TabIndex = 19;
            this.lblMat.Text = "Materia";
            // 
            // cboMat
            // 
            this.cboMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMat.Enabled = false;
            this.cboMat.FormattingEnabled = true;
            this.cboMat.Location = new System.Drawing.Point(477, 65);
            this.cboMat.Name = "cboMat";
            this.cboMat.Size = new System.Drawing.Size(121, 21);
            this.cboMat.TabIndex = 20;
            this.cboMat.SelectedIndexChanged += new System.EventHandler(this.cboMat_SelectedIndexChanged);
            // 
            // lblEjem
            // 
            this.lblEjem.AutoSize = true;
            this.lblEjem.Location = new System.Drawing.Point(353, 157);
            this.lblEjem.Name = "lblEjem";
            this.lblEjem.Size = new System.Drawing.Size(58, 13);
            this.lblEjem.TabIndex = 21;
            this.lblEjem.Text = "Ejemplares";
            this.lblEjem.Click += new System.EventHandler(this.label11_Click);
            // 
            // nudEjem
            // 
            this.nudEjem.Enabled = false;
            this.nudEjem.Location = new System.Drawing.Point(477, 155);
            this.nudEjem.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEjem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEjem.Name = "nudEjem";
            this.nudEjem.Size = new System.Drawing.Size(120, 20);
            this.nudEjem.TabIndex = 22;
            this.nudEjem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEjem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudEjem_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(299, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "INGRESO LIBRO";
            // 
            // cboEstante
            // 
            this.cboEstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstante.Enabled = false;
            this.cboEstante.FormattingEnabled = true;
            this.cboEstante.Location = new System.Drawing.Point(477, 108);
            this.cboEstante.Name = "cboEstante";
            this.cboEstante.Size = new System.Drawing.Size(121, 21);
            this.cboEstante.TabIndex = 27;
            // 
            // tcIngresoLibro
            // 
            this.tcIngresoLibro.Controls.Add(this.tpNuevo);
            this.tcIngresoLibro.Controls.Add(this.tpExistente);
            this.tcIngresoLibro.Location = new System.Drawing.Point(58, 81);
            this.tcIngresoLibro.Name = "tcIngresoLibro";
            this.tcIngresoLibro.SelectedIndex = 0;
            this.tcIngresoLibro.Size = new System.Drawing.Size(779, 288);
            this.tcIngresoLibro.TabIndex = 10;
            // 
            // tpNuevo
            // 
            this.tpNuevo.Controls.Add(this.nudpag);
            this.tpNuevo.Controls.Add(this.nudEdi);
            this.tpNuevo.Controls.Add(this.txtNomLib);
            this.tpNuevo.Controls.Add(this.cboEstante);
            this.tpNuevo.Controls.Add(this.lblNomLib);
            this.tpNuevo.Controls.Add(this.txtLib);
            this.tpNuevo.Controls.Add(this.lblTitulo);
            this.tpNuevo.Controls.Add(this.nudEjem);
            this.tpNuevo.Controls.Add(this.lblEjem);
            this.tpNuevo.Controls.Add(this.lblNoPag);
            this.tpNuevo.Controls.Add(this.cboMat);
            this.tpNuevo.Controls.Add(this.lblVol);
            this.tpNuevo.Controls.Add(this.lblMat);
            this.tpNuevo.Controls.Add(this.nudVol);
            this.tpNuevo.Controls.Add(this.lblCorriLite);
            this.tpNuevo.Controls.Add(this.lblEdi);
            this.tpNuevo.Controls.Add(this.cboCorriente);
            this.tpNuevo.Controls.Add(this.lblEdit);
            this.tpNuevo.Controls.Add(this.lblAutor);
            this.tpNuevo.Controls.Add(this.cboEdit);
            this.tpNuevo.Controls.Add(this.cboAutor);
            this.tpNuevo.Controls.Add(this.lblEstant);
            this.tpNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tpNuevo.Location = new System.Drawing.Point(4, 22);
            this.tpNuevo.Name = "tpNuevo";
            this.tpNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tpNuevo.Size = new System.Drawing.Size(771, 262);
            this.tpNuevo.TabIndex = 1;
            this.tpNuevo.Text = "Nuevo";
            this.tpNuevo.UseVisualStyleBackColor = true;
            this.tpNuevo.Click += new System.EventHandler(this.tabPage_Click);
            // 
            // nudpag
            // 
            this.nudpag.Enabled = false;
            this.nudpag.Location = new System.Drawing.Point(117, 66);
            this.nudpag.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudpag.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudpag.Name = "nudpag";
            this.nudpag.Size = new System.Drawing.Size(120, 20);
            this.nudpag.TabIndex = 30;
            this.nudpag.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudpag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudpag_KeyPress);
            // 
            // nudEdi
            // 
            this.nudEdi.Enabled = false;
            this.nudEdi.Location = new System.Drawing.Point(117, 128);
            this.nudEdi.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudEdi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdi.Name = "nudEdi";
            this.nudEdi.Size = new System.Drawing.Size(120, 20);
            this.nudEdi.TabIndex = 29;
            this.nudEdi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudEdi_KeyPress);
            // 
            // tpExistente
            // 
            this.tpExistente.Controls.Add(this.cboEVol);
            this.tpExistente.Controls.Add(this.lblEVol);
            this.tpExistente.Controls.Add(this.txtEEjem);
            this.tpExistente.Controls.Add(this.lblEEjem);
            this.tpExistente.Controls.Add(this.cboEMat);
            this.tpExistente.Controls.Add(this.cboECate);
            this.tpExistente.Controls.Add(this.cboETitulo);
            this.tpExistente.Controls.Add(this.lblECat);
            this.tpExistente.Controls.Add(this.lblEMat);
            this.tpExistente.Controls.Add(this.cboENomLib);
            this.tpExistente.Controls.Add(this.lblETit);
            this.tpExistente.Controls.Add(this.lblENomLib);
            this.tpExistente.Location = new System.Drawing.Point(4, 22);
            this.tpExistente.Name = "tpExistente";
            this.tpExistente.Padding = new System.Windows.Forms.Padding(3);
            this.tpExistente.Size = new System.Drawing.Size(771, 262);
            this.tpExistente.TabIndex = 2;
            this.tpExistente.Text = "Existente";
            this.tpExistente.UseVisualStyleBackColor = true;
            this.tpExistente.Click += new System.EventHandler(this.tpExistente_Click);
            // 
            // cboEVol
            // 
            this.cboEVol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEVol.Enabled = false;
            this.cboEVol.FormattingEnabled = true;
            this.cboEVol.Location = new System.Drawing.Point(127, 198);
            this.cboEVol.Name = "cboEVol";
            this.cboEVol.Size = new System.Drawing.Size(121, 21);
            this.cboEVol.TabIndex = 11;
            this.cboEVol.SelectedIndexChanged += new System.EventHandler(this.cboEVol_SelectedIndexChanged);
            // 
            // lblEVol
            // 
            this.lblEVol.AutoSize = true;
            this.lblEVol.Location = new System.Drawing.Point(16, 198);
            this.lblEVol.Name = "lblEVol";
            this.lblEVol.Size = new System.Drawing.Size(48, 13);
            this.lblEVol.TabIndex = 10;
            this.lblEVol.Text = "Volumen";
            // 
            // txtEEjem
            // 
            this.txtEEjem.Enabled = false;
            this.txtEEjem.Location = new System.Drawing.Point(514, 60);
            this.txtEEjem.Name = "txtEEjem";
            this.txtEEjem.Size = new System.Drawing.Size(121, 20);
            this.txtEEjem.TabIndex = 9;
            this.txtEEjem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEEjem_KeyPress);
            // 
            // lblEEjem
            // 
            this.lblEEjem.AutoSize = true;
            this.lblEEjem.Location = new System.Drawing.Point(406, 59);
            this.lblEEjem.Name = "lblEEjem";
            this.lblEEjem.Size = new System.Drawing.Size(58, 13);
            this.lblEEjem.TabIndex = 8;
            this.lblEEjem.Text = "Ejemplares";
            // 
            // cboEMat
            // 
            this.cboEMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEMat.Enabled = false;
            this.cboEMat.FormattingEnabled = true;
            this.cboEMat.Location = new System.Drawing.Point(127, 93);
            this.cboEMat.Name = "cboEMat";
            this.cboEMat.Size = new System.Drawing.Size(121, 21);
            this.cboEMat.TabIndex = 7;
            this.cboEMat.SelectedIndexChanged += new System.EventHandler(this.cboEMat_SelectedIndexChanged);
            // 
            // cboECate
            // 
            this.cboECate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboECate.Enabled = false;
            this.cboECate.FormattingEnabled = true;
            this.cboECate.Location = new System.Drawing.Point(127, 59);
            this.cboECate.Name = "cboECate";
            this.cboECate.Size = new System.Drawing.Size(121, 21);
            this.cboECate.TabIndex = 6;
            this.cboECate.SelectedIndexChanged += new System.EventHandler(this.cboECate_SelectedIndexChanged);
            // 
            // cboETitulo
            // 
            this.cboETitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboETitulo.Enabled = false;
            this.cboETitulo.FormattingEnabled = true;
            this.cboETitulo.Location = new System.Drawing.Point(127, 161);
            this.cboETitulo.Name = "cboETitulo";
            this.cboETitulo.Size = new System.Drawing.Size(121, 21);
            this.cboETitulo.TabIndex = 5;
            this.cboETitulo.SelectedIndexChanged += new System.EventHandler(this.cboETitulo_SelectedIndexChanged);
            // 
            // lblECat
            // 
            this.lblECat.AutoSize = true;
            this.lblECat.Location = new System.Drawing.Point(16, 59);
            this.lblECat.Name = "lblECat";
            this.lblECat.Size = new System.Drawing.Size(89, 13);
            this.lblECat.TabIndex = 4;
            this.lblECat.Text = "Corriente Literaria";
            // 
            // lblEMat
            // 
            this.lblEMat.AutoSize = true;
            this.lblEMat.Location = new System.Drawing.Point(16, 93);
            this.lblEMat.Name = "lblEMat";
            this.lblEMat.Size = new System.Drawing.Size(42, 13);
            this.lblEMat.TabIndex = 3;
            this.lblEMat.Text = "Materia";
            // 
            // cboENomLib
            // 
            this.cboENomLib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboENomLib.Enabled = false;
            this.cboENomLib.FormattingEnabled = true;
            this.cboENomLib.Location = new System.Drawing.Point(127, 130);
            this.cboENomLib.Name = "cboENomLib";
            this.cboENomLib.Size = new System.Drawing.Size(121, 21);
            this.cboENomLib.TabIndex = 2;
            this.cboENomLib.SelectedIndexChanged += new System.EventHandler(this.cboENomLib_SelectedIndexChanged);
            // 
            // lblETit
            // 
            this.lblETit.AutoSize = true;
            this.lblETit.Location = new System.Drawing.Point(16, 169);
            this.lblETit.Name = "lblETit";
            this.lblETit.Size = new System.Drawing.Size(33, 13);
            this.lblETit.TabIndex = 1;
            this.lblETit.Text = "Titulo";
            // 
            // lblENomLib
            // 
            this.lblENomLib.AutoSize = true;
            this.lblENomLib.Location = new System.Drawing.Point(16, 133);
            this.lblENomLib.Name = "lblENomLib";
            this.lblENomLib.Size = new System.Drawing.Size(70, 13);
            this.lblENomLib.TabIndex = 0;
            this.lblENomLib.Text = "Nombre Libro";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(616, 439);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.Location = new System.Drawing.Point(566, 439);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 36);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Prototipo.Properties.Resources.Add;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(716, 439);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 36);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(516, 439);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(44, 36);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // wfIngresoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 490);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tcIngresoLibro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfIngresoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Ingreso Libro";
            this.Load += new System.EventHandler(this.wfIngresoLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEjem)).EndInit();
            this.tcIngresoLibro.ResumeLayout(false);
            this.tpNuevo.ResumeLayout(false);
            this.tpNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudpag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdi)).EndInit();
            this.tpExistente.ResumeLayout(false);
            this.tpExistente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomLib;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label lblNomLib;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNoPag;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.NumericUpDown nudVol;
        private System.Windows.Forms.Label lblEdi;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.ComboBox cboEdit;
        private System.Windows.Forms.Label lblEstant;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.ComboBox cboCorriente;
        private System.Windows.Forms.Label lblCorriLite;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.ComboBox cboMat;
        private System.Windows.Forms.Label lblEjem;
        private System.Windows.Forms.NumericUpDown nudEjem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboEstante;
        private System.Windows.Forms.TabControl tcIngresoLibro;
        private System.Windows.Forms.TabPage tpNuevo;
        private System.Windows.Forms.TabPage tpExistente;
        private System.Windows.Forms.NumericUpDown nudEdi;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown nudpag;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource mostrarBindingSource;
        //private mostrar mostrar;
        //private Prototipo.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label lblETit;
        private System.Windows.Forms.Label lblENomLib;
        private System.Windows.Forms.Label lblECat;
        private System.Windows.Forms.Label lblEMat;
        private System.Windows.Forms.ComboBox cboENomLib;
        private System.Windows.Forms.ComboBox cboEMat;
        private System.Windows.Forms.ComboBox cboECate;
        private System.Windows.Forms.ComboBox cboETitulo;
        private System.Windows.Forms.TextBox txtEEjem;
        private System.Windows.Forms.Label lblEEjem;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblEVol;
        private System.Windows.Forms.ComboBox cboEVol;

    }
}