namespace Cerrajeria_2
{
    partial class Inventario
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
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExistente = new System.Windows.Forms.RadioButton();
            this.cmbExistente = new System.Windows.Forms.ComboBox();
            this.cmbNuevo = new System.Windows.Forms.ComboBox();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnImprimirListado = new System.Windows.Forms.Button();
            this.btnCapturarInventario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsuarios.Controls.Add(this.pictureBox1);
            this.pnlUsuarios.Controls.Add(this.lblUsuario);
            this.pnlUsuarios.Location = new System.Drawing.Point(515, 12);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(100, 49);
            this.pnlUsuarios.TabIndex = 28;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 290);
            this.dataGridView1.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Llave";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbNuevo);
            this.groupBox1.Controls.Add(this.rbNuevo);
            this.groupBox1.Controls.Add(this.cmbExistente);
            this.groupBox1.Controls.Add(this.rbExistente);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(299, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 278);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Material";
            // 
            // rbExistente
            // 
            this.rbExistente.AutoSize = true;
            this.rbExistente.Location = new System.Drawing.Point(7, 43);
            this.rbExistente.Name = "rbExistente";
            this.rbExistente.Size = new System.Drawing.Size(98, 23);
            this.rbExistente.TabIndex = 0;
            this.rbExistente.TabStop = true;
            this.rbExistente.Text = "Existente";
            this.rbExistente.UseVisualStyleBackColor = true;
            // 
            // cmbExistente
            // 
            this.cmbExistente.FormattingEnabled = true;
            this.cmbExistente.Location = new System.Drawing.Point(28, 72);
            this.cmbExistente.Name = "cmbExistente";
            this.cmbExistente.Size = new System.Drawing.Size(121, 27);
            this.cmbExistente.TabIndex = 1;
            // 
            // cmbNuevo
            // 
            this.cmbNuevo.FormattingEnabled = true;
            this.cmbNuevo.Location = new System.Drawing.Point(28, 153);
            this.cmbNuevo.Name = "cmbNuevo";
            this.cmbNuevo.Size = new System.Drawing.Size(121, 27);
            this.cmbNuevo.TabIndex = 3;
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Location = new System.Drawing.Point(7, 124);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(77, 23);
            this.rbNuevo.TabIndex = 2;
            this.rbNuevo.TabStop = true;
            this.rbNuevo.Text = "Nuevo";
            this.rbNuevo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(91, 234);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 5;
            // 
            // btnImprimirListado
            // 
            this.btnImprimirListado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirListado.Location = new System.Drawing.Point(84, 330);
            this.btnImprimirListado.Name = "btnImprimirListado";
            this.btnImprimirListado.Size = new System.Drawing.Size(90, 55);
            this.btnImprimirListado.TabIndex = 31;
            this.btnImprimirListado.Text = "Imprimir Listado";
            this.btnImprimirListado.UseVisualStyleBackColor = true;
            // 
            // btnCapturarInventario
            // 
            this.btnCapturarInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturarInventario.Location = new System.Drawing.Point(192, 330);
            this.btnCapturarInventario.Name = "btnCapturarInventario";
            this.btnCapturarInventario.Size = new System.Drawing.Size(106, 55);
            this.btnCapturarInventario.TabIndex = 32;
            this.btnCapturarInventario.Text = "Capturar Inventario";
            this.btnCapturarInventario.UseVisualStyleBackColor = true;
            this.btnCapturarInventario.Click += new System.EventHandler(this.btnCapturarInventario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Cerrajeria_2.Properties.Resources.Equis;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(545, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 33);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Cerrajeria_2.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 405);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCapturarInventario);
            this.Controls.Add(this.btnImprimirListado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlUsuarios);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNuevo;
        private System.Windows.Forms.RadioButton rbNuevo;
        private System.Windows.Forms.ComboBox cmbExistente;
        private System.Windows.Forms.RadioButton rbExistente;
        private System.Windows.Forms.Button btnImprimirListado;
        private System.Windows.Forms.Button btnCapturarInventario;
        private System.Windows.Forms.Button btnCancelar;
    }
}