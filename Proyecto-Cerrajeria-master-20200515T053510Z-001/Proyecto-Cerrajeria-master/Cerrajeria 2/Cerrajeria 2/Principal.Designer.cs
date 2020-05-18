namespace Cerrajeria_2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnTrabajos = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCCliente = new System.Windows.Forms.Button();
            this.btnCTrabajo = new System.Windows.Forms.Button();
            this.btnCFecha = new System.Windows.Forms.Button();
            this.btnLLave = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tabTrabajos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPorciento = new System.Windows.Forms.TextBox();
            this.lblPorciento = new System.Windows.Forms.Label();
            this.rbIVA = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpLlaves = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gpTrabajo = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tabTrabajos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpLlaves.SuspendLayout();
            this.gpTrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Location = new System.Drawing.Point(39, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 12);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.btnEmpleado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpleado.Image = global::Cerrajeria_2.Properties.Resources.hombres__1_;
            this.btnEmpleado.Location = new System.Drawing.Point(133, 43);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(177, 39);
            this.btnEmpleado.TabIndex = 16;
            this.btnEmpleado.Text = "    Empleado";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Visible = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.Info;
            this.btnCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCliente.Image = global::Cerrajeria_2.Properties.Resources.seo_y_web__1_;
            this.btnCliente.Location = new System.Drawing.Point(133, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(177, 39);
            this.btnCliente.TabIndex = 15;
            this.btnCliente.Text = "     Cliente";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Visible = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultas.Image = global::Cerrajeria_2.Properties.Resources.Consulta;
            this.btnConsultas.Location = new System.Drawing.Point(14, 359);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(120, 120);
            this.btnConsultas.TabIndex = 14;
            this.btnConsultas.Text = "Consultas y Reportes";
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInventario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInventario.Image = global::Cerrajeria_2.Properties.Resources.almacenar;
            this.btnInventario.Location = new System.Drawing.Point(14, 240);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(120, 120);
            this.btnInventario.TabIndex = 13;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnTrabajos
            // 
            this.btnTrabajos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrabajos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTrabajos.Image = global::Cerrajeria_2.Properties.Resources.personas;
            this.btnTrabajos.Location = new System.Drawing.Point(14, 121);
            this.btnTrabajos.Name = "btnTrabajos";
            this.btnTrabajos.Size = new System.Drawing.Size(120, 120);
            this.btnTrabajos.TabIndex = 12;
            this.btnTrabajos.Text = "Trabajos";
            this.btnTrabajos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTrabajos.UseVisualStyleBackColor = false;
            this.btnTrabajos.Click += new System.EventHandler(this.btnTrabajos_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistros.BackgroundImage = global::Cerrajeria_2.Properties.Resources.white;
            this.btnRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistros.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistros.Image = global::Cerrajeria_2.Properties.Resources.negocios_y_finanzas__1_;
            this.btnRegistros.Location = new System.Drawing.Point(14, 4);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(120, 120);
            this.btnRegistros.TabIndex = 11;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegistros.UseVisualStyleBackColor = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Cerrajeria_2.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.Info;
            this.btnConsulta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsulta.Image = global::Cerrajeria_2.Properties.Resources.monitor__1_;
            this.btnConsulta.Location = new System.Drawing.Point(133, 359);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(177, 60);
            this.btnConsulta.TabIndex = 19;
            this.btnConsulta.Text = "  Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Visible = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.Info;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReporte.Image = global::Cerrajeria_2.Properties.Resources.icon__1_;
            this.btnReporte.Location = new System.Drawing.Point(133, 419);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(177, 60);
            this.btnReporte.TabIndex = 20;
            this.btnReporte.Text = "   Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Visible = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnCCliente
            // 
            this.btnCCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCCliente.Location = new System.Drawing.Point(308, 359);
            this.btnCCliente.Name = "btnCCliente";
            this.btnCCliente.Size = new System.Drawing.Size(177, 25);
            this.btnCCliente.TabIndex = 21;
            this.btnCCliente.Text = "Cliente";
            this.btnCCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCCliente.UseVisualStyleBackColor = false;
            this.btnCCliente.Visible = false;
            // 
            // btnCTrabajo
            // 
            this.btnCTrabajo.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCTrabajo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTrabajo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCTrabajo.Location = new System.Drawing.Point(308, 383);
            this.btnCTrabajo.Name = "btnCTrabajo";
            this.btnCTrabajo.Size = new System.Drawing.Size(177, 25);
            this.btnCTrabajo.TabIndex = 22;
            this.btnCTrabajo.Text = "Trabajo";
            this.btnCTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTrabajo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCTrabajo.UseVisualStyleBackColor = false;
            this.btnCTrabajo.Visible = false;
            // 
            // btnCFecha
            // 
            this.btnCFecha.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCFecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCFecha.Location = new System.Drawing.Point(308, 407);
            this.btnCFecha.Name = "btnCFecha";
            this.btnCFecha.Size = new System.Drawing.Size(177, 25);
            this.btnCFecha.TabIndex = 23;
            this.btnCFecha.Text = "Fecha";
            this.btnCFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCFecha.UseVisualStyleBackColor = false;
            this.btnCFecha.Visible = false;
            // 
            // btnLLave
            // 
            this.btnLLave.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLLave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLLave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLLave.Location = new System.Drawing.Point(308, 419);
            this.btnLLave.Name = "btnLLave";
            this.btnLLave.Size = new System.Drawing.Size(177, 25);
            this.btnLLave.TabIndex = 24;
            this.btnLLave.Text = "Llave mas usada";
            this.btnLLave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLLave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLLave.UseVisualStyleBackColor = false;
            this.btnLLave.Visible = false;
            // 
            // btnSemana
            // 
            this.btnSemana.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSemana.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSemana.Location = new System.Drawing.Point(308, 442);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(177, 25);
            this.btnSemana.TabIndex = 25;
            this.btnSemana.Text = "Semana";
            this.btnSemana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSemana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSemana.UseVisualStyleBackColor = false;
            this.btnSemana.Visible = false;
            // 
            // btnMes
            // 
            this.btnMes.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMes.Location = new System.Drawing.Point(308, 466);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(177, 25);
            this.btnMes.TabIndex = 26;
            this.btnMes.Text = "Mes";
            this.btnMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Visible = false;
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsuarios.Controls.Add(this.pictureBox1);
            this.pnlUsuarios.Controls.Add(this.lblUsuario);
            this.pnlUsuarios.Location = new System.Drawing.Point(688, 12);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(100, 49);
            this.pnlUsuarios.TabIndex = 27;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.Controls.Add(this.btnTrabajos);
            this.pnlMenu.Controls.Add(this.btnRegistros);
            this.pnlMenu.Controls.Add(this.btnMes);
            this.pnlMenu.Controls.Add(this.btnInventario);
            this.pnlMenu.Controls.Add(this.btnSemana);
            this.pnlMenu.Controls.Add(this.btnConsultas);
            this.pnlMenu.Controls.Add(this.btnLLave);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.btnCFecha);
            this.pnlMenu.Controls.Add(this.btnEmpleado);
            this.pnlMenu.Controls.Add(this.btnCTrabajo);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.btnCCliente);
            this.pnlMenu.Controls.Add(this.btnReporte);
            this.pnlMenu.Location = new System.Drawing.Point(1, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(492, 491);
            this.pnlMenu.TabIndex = 28;
            // 
            // tabTrabajos
            // 
            this.tabTrabajos.Controls.Add(this.tabPage1);
            this.tabTrabajos.Controls.Add(this.tabPage2);
            this.tabTrabajos.Location = new System.Drawing.Point(1, 2);
            this.tabTrabajos.Name = "tabTrabajos";
            this.tabTrabajos.SelectedIndex = 0;
            this.tabTrabajos.Size = new System.Drawing.Size(620, 436);
            this.tabTrabajos.TabIndex = 29;
            this.tabTrabajos.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnComprobante);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gpLlaves);
            this.tabPage1.Controls.Add(this.gpTrabajo);
            this.tabPage1.Controls.Add(this.txtCliente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtTicket);
            this.tabPage1.Controls.Add(this.lblTicket);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trabajos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Cerrajeria_2.Properties.Resources.Equis;
            this.btnCancelar.Location = new System.Drawing.Point(494, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 59);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.Image = global::Cerrajeria_2.Properties.Resources.negocios_y_finanzas1;
            this.btnComprobante.Location = new System.Drawing.Point(468, 51);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(141, 59);
            this.btnComprobante.TabIndex = 8;
            this.btnComprobante.Text = "Generar Comprobante";
            this.btnComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprobante.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPorciento);
            this.groupBox1.Controls.Add(this.lblPorciento);
            this.groupBox1.Controls.Add(this.rbIVA);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(173, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago";
            // 
            // txtPorciento
            // 
            this.txtPorciento.Location = new System.Drawing.Point(230, 25);
            this.txtPorciento.Name = "txtPorciento";
            this.txtPorciento.Size = new System.Drawing.Size(27, 22);
            this.txtPorciento.TabIndex = 8;
            // 
            // lblPorciento
            // 
            this.lblPorciento.AutoSize = true;
            this.lblPorciento.Location = new System.Drawing.Point(263, 27);
            this.lblPorciento.Name = "lblPorciento";
            this.lblPorciento.Size = new System.Drawing.Size(18, 16);
            this.lblPorciento.TabIndex = 7;
            this.lblPorciento.Text = "%";
            // 
            // rbIVA
            // 
            this.rbIVA.AutoSize = true;
            this.rbIVA.Location = new System.Drawing.Point(176, 27);
            this.rbIVA.Name = "rbIVA";
            this.rbIVA.Size = new System.Drawing.Size(47, 20);
            this.rbIVA.TabIndex = 6;
            this.rbIVA.TabStop = true;
            this.rbIVA.Text = "IVA";
            this.rbIVA.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(59, 70);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(59, 27);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Monto";
            // 
            // gpLlaves
            // 
            this.gpLlaves.Controls.Add(this.btnBorrar);
            this.gpLlaves.Controls.Add(this.listBox1);
            this.gpLlaves.Controls.Add(this.txtCantidad);
            this.gpLlaves.Controls.Add(this.label4);
            this.gpLlaves.Controls.Add(this.label3);
            this.gpLlaves.Controls.Add(this.comboBox2);
            this.gpLlaves.Enabled = false;
            this.gpLlaves.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLlaves.Location = new System.Drawing.Point(247, 155);
            this.gpLlaves.Name = "gpLlaves";
            this.gpLlaves.Size = new System.Drawing.Size(215, 231);
            this.gpLlaves.TabIndex = 6;
            this.gpLlaves.TabStop = false;
            this.gpLlaves.Text = "Llaves";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(132, 113);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 116);
            this.listBox1.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(74, 65);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(41, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "LLaves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Duplicado",
            "Apertura",
            "Hechura",
            "Otro"});
            this.comboBox2.Location = new System.Drawing.Point(74, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // gpTrabajo
            // 
            this.gpTrabajo.Controls.Add(this.richTextBox1);
            this.gpTrabajo.Controls.Add(this.label2);
            this.gpTrabajo.Controls.Add(this.comboBox1);
            this.gpTrabajo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTrabajo.Location = new System.Drawing.Point(9, 155);
            this.gpTrabajo.Name = "gpTrabajo";
            this.gpTrabajo.Size = new System.Drawing.Size(215, 231);
            this.gpTrabajo.TabIndex = 5;
            this.gpTrabajo.TabStop = false;
            this.gpTrabajo.Text = "Trabajo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 124);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Duplicado",
            "Apertura",
            "Hechura",
            "Otro"});
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(50, 103);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Image = global::Cerrajeria_2.Properties.Resources.seguridad2;
            this.button1.Location = new System.Drawing.Point(9, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTicket
            // 
            this.txtTicket.Enabled = false;
            this.txtTicket.Location = new System.Drawing.Point(58, 34);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(100, 20);
            this.txtTicket.TabIndex = 1;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(6, 35);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(46, 16);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "Ticket";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cotización";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.tabTrabajos);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlUsuarios);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Principal";
            this.Text = "Cerrajería";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.tabTrabajos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpLlaves.ResumeLayout(false);
            this.gpLlaves.PerformLayout();
            this.gpTrabajo.ResumeLayout(false);
            this.gpTrabajo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnTrabajos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCCliente;
        private System.Windows.Forms.Button btnCTrabajo;
        private System.Windows.Forms.Button btnCFecha;
        private System.Windows.Forms.Button btnLLave;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TabControl tabTrabajos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPorciento;
        private System.Windows.Forms.Label lblPorciento;
        private System.Windows.Forms.RadioButton rbIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpLlaves;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gpTrabajo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.TabPage tabPage2;
    }
}