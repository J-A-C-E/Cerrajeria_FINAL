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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUsuarios.SuspendLayout();
            this.pnlMenu.SuspendLayout();
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlUsuarios);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Cerrajería";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
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
    }
}