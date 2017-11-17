namespace ProyectoWF
{
    partial class FormularioProductos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosP = new System.Windows.Forms.GroupBox();
            this.tlPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDirección = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbObligatorio = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDatosP.SuspendLayout();
            this.tlPersonales.SuspendLayout();
            this.gbDirección.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDatosP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDirección, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbObligatorio, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDatosP
            // 
            this.gbDatosP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDatosP.Controls.Add(this.tlPersonales);
            this.gbDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDatosP.Location = new System.Drawing.Point(25, 15);
            this.gbDatosP.Margin = new System.Windows.Forms.Padding(25, 15, 10, 0);
            this.gbDatosP.Name = "gbDatosP";
            this.gbDatosP.Padding = new System.Windows.Forms.Padding(10, 5, 25, 10);
            this.gbDatosP.Size = new System.Drawing.Size(304, 90);
            this.gbDatosP.TabIndex = 0;
            this.gbDatosP.TabStop = false;
            this.gbDatosP.Text = "Datos del producto";
            // 
            // tlPersonales
            // 
            this.tlPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlPersonales.ColumnCount = 3;
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.75F));
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25F));
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlPersonales.Controls.Add(this.label2, 2, 1);
            this.tlPersonales.Controls.Add(this.tbApellidos, 1, 1);
            this.tlPersonales.Controls.Add(this.tbNombre, 1, 0);
            this.tlPersonales.Controls.Add(this.label1, 2, 0);
            this.tlPersonales.Location = new System.Drawing.Point(10, 18);
            this.tlPersonales.Name = "tlPersonales";
            this.tlPersonales.RowCount = 2;
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPersonales.Size = new System.Drawing.Size(269, 62);
            this.tlPersonales.TabIndex = 0;
            this.tlPersonales.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "*";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidos.Location = new System.Drawing.Point(71, 36);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(172, 20);
            this.tbApellidos.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(71, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(172, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "*";
            // 
            // gbDirección
            // 
            this.gbDirección.Controls.Add(this.tableLayoutPanel3);
            this.gbDirección.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDirección.Location = new System.Drawing.Point(349, 15);
            this.gbDirección.Margin = new System.Windows.Forms.Padding(10, 15, 6, 5);
            this.gbDirección.Name = "gbDirección";
            this.gbDirección.Padding = new System.Windows.Forms.Padding(10, 5, 10, 75);
            this.gbDirección.Size = new System.Drawing.Size(323, 200);
            this.gbDirección.TabIndex = 1;
            this.gbDirección.TabStop = false;
            this.gbDirección.Text = "Dirección";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Controls.Add(this.tbNumero, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbCalle, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbCP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbPoblacion, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(303, 107);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumero.Location = new System.Drawing.Point(73, 29);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(204, 20);
            this.tbNumero.TabIndex = 4;
            // 
            // tbCalle
            // 
            this.tbCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCalle.Location = new System.Drawing.Point(73, 3);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(204, 20);
            this.tbCalle.TabIndex = 3;
            // 
            // tbCP
            // 
            this.tbCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCP.Location = new System.Drawing.Point(73, 55);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(204, 20);
            this.tbCP.TabIndex = 8;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPoblacion.Location = new System.Drawing.Point(73, 82);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(204, 20);
            this.tbPoblacion.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btAceptar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btCancelar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(342, 223);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 35);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(255, 4);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(174, 4);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // lbObligatorio
            // 
            this.lbObligatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbObligatorio.AutoSize = true;
            this.lbObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObligatorio.Location = new System.Drawing.Point(25, 234);
            this.lbObligatorio.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.lbObligatorio.Name = "lbObligatorio";
            this.lbObligatorio.Size = new System.Drawing.Size(104, 13);
            this.lbObligatorio.TabIndex = 3;
            this.lbObligatorio.Text = "*   Campo obligatorio";
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormularioProductos";
            this.Text = "Alta de Producto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbDatosP.ResumeLayout(false);
            this.tlPersonales.ResumeLayout(false);
            this.tlPersonales.PerformLayout();
            this.gbDirección.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDatosP;
        private System.Windows.Forms.GroupBox gbDirección;
        private System.Windows.Forms.Label lbObligatorio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TableLayoutPanel tlPersonales;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbPoblacion;
    }
}