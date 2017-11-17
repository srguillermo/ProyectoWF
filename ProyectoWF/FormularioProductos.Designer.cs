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
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbIdProducto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDirección = new System.Windows.Forms.GroupBox();
            this.tlOtrosDatos = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbObligatorio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDatosP.SuspendLayout();
            this.tlPersonales.SuspendLayout();
            this.gbDirección.SuspendLayout();
            this.tlOtrosDatos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.gbDatosP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDirección, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbObligatorio, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDatosP
            // 
            this.gbDatosP.Controls.Add(this.tlPersonales);
            this.gbDatosP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDatosP.Location = new System.Drawing.Point(15, 15);
            this.gbDatosP.Margin = new System.Windows.Forms.Padding(15, 15, 10, 0);
            this.gbDatosP.Name = "gbDatosP";
            this.gbDatosP.Padding = new System.Windows.Forms.Padding(10, 5, 25, 10);
            this.gbDatosP.Size = new System.Drawing.Size(314, 156);
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
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersonales.Controls.Add(this.tbPrecio, 0, 2);
            this.tlPersonales.Controls.Add(this.tbCantidad, 1, 1);
            this.tlPersonales.Controls.Add(this.label6, 0, 1);
            this.tlPersonales.Controls.Add(this.tbNombre, 1, 0);
            this.tlPersonales.Controls.Add(this.label1, 2, 0);
            this.tlPersonales.Controls.Add(this.lbIdProducto, 0, 0);
            this.tlPersonales.Controls.Add(this.label7, 0, 2);
            this.tlPersonales.Location = new System.Drawing.Point(10, 18);
            this.tlPersonales.Name = "tlPersonales";
            this.tlPersonales.RowCount = 3;
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPersonales.Size = new System.Drawing.Size(276, 128);
            this.tlPersonales.TabIndex = 0;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecio.Location = new System.Drawing.Point(57, 96);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(172, 20);
            this.tbPrecio.TabIndex = 12;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCantidad.Location = new System.Drawing.Point(57, 53);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(172, 20);
            this.tbCantidad.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cant/u";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(57, 11);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(172, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // lbIdProducto
            // 
            this.lbIdProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbIdProducto.AutoSize = true;
            this.lbIdProducto.Location = new System.Drawing.Point(3, 14);
            this.lbIdProducto.Name = "lbIdProducto";
            this.lbIdProducto.Size = new System.Drawing.Size(44, 13);
            this.lbIdProducto.TabIndex = 7;
            this.lbIdProducto.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio/u";
            // 
            // gbDirección
            // 
            this.gbDirección.Controls.Add(this.tlOtrosDatos);
            this.gbDirección.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDirección.Location = new System.Drawing.Point(354, 15);
            this.gbDirección.Margin = new System.Windows.Forms.Padding(15, 15, 10, 0);
            this.gbDirección.Name = "gbDirección";
            this.gbDirección.Padding = new System.Windows.Forms.Padding(0, 5, 25, 50);
            this.gbDirección.Size = new System.Drawing.Size(314, 156);
            this.gbDirección.TabIndex = 1;
            this.gbDirección.TabStop = false;
            this.gbDirección.Text = "Otros datos";
            // 
            // tlOtrosDatos
            // 
            this.tlOtrosDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlOtrosDatos.ColumnCount = 3;
            this.tlOtrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.75F));
            this.tlOtrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25F));
            this.tlOtrosDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlOtrosDatos.Controls.Add(this.label2, 0, 0);
            this.tlOtrosDatos.Controls.Add(this.cbProveedor, 1, 0);
            this.tlOtrosDatos.Controls.Add(this.label5, 0, 1);
            this.tlOtrosDatos.Controls.Add(this.cbCategoria, 1, 1);
            this.tlOtrosDatos.Location = new System.Drawing.Point(18, 18);
            this.tlOtrosDatos.Name = "tlOtrosDatos";
            this.tlOtrosDatos.RowCount = 2;
            this.tlOtrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlOtrosDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlOtrosDatos.Size = new System.Drawing.Size(276, 85);
            this.tlOtrosDatos.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btAceptar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btCancelar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(342, 174);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 34);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(255, 3);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(174, 3);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbObligatorio
            // 
            this.lbObligatorio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbObligatorio.AutoSize = true;
            this.lbObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObligatorio.Location = new System.Drawing.Point(25, 184);
            this.lbObligatorio.Margin = new System.Windows.Forms.Padding(25, 0, 3, 0);
            this.lbObligatorio.Name = "lbObligatorio";
            this.lbObligatorio.Size = new System.Drawing.Size(104, 13);
            this.lbObligatorio.TabIndex = 3;
            this.lbObligatorio.Text = "*   Campo obligatorio";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(72, 10);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(176, 21);
            this.cbProveedor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoría";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(72, 53);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(176, 21);
            this.cbCategoria.TabIndex = 14;
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormularioProductos";
            this.Text = "Alta de Producto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbDatosP.ResumeLayout(false);
            this.tlPersonales.ResumeLayout(false);
            this.tlPersonales.PerformLayout();
            this.gbDirección.ResumeLayout(false);
            this.tlOtrosDatos.ResumeLayout(false);
            this.tlOtrosDatos.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDatosP;
        private System.Windows.Forms.Label lbObligatorio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TableLayoutPanel tlPersonales;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox gbDirección;
        private System.Windows.Forms.TableLayoutPanel tlOtrosDatos;
        private System.Windows.Forms.Label lbIdProducto;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}