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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDatosP = new System.Windows.Forms.GroupBox();
            this.gbDirección = new System.Windows.Forms.GroupBox();
            this.lbObligatorio = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlContacto = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbTelf2 = new System.Windows.Forms.Label();
            this.lbTelf1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDatosP.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlPersonales.SuspendLayout();
            this.tlContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbDatosP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDirección, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbObligatorio, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlContacto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(25, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(25, 5, 10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 5, 25, 10);
            this.groupBox1.Size = new System.Drawing.Size(304, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto";
            // 
            // gbDatosP
            // 
            this.gbDatosP.Controls.Add(this.tlPersonales);
            this.gbDatosP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDatosP.Location = new System.Drawing.Point(25, 15);
            this.gbDatosP.Margin = new System.Windows.Forms.Padding(25, 15, 10, 5);
            this.gbDatosP.Name = "gbDatosP";
            this.gbDatosP.Padding = new System.Windows.Forms.Padding(10, 5, 25, 10);
            this.gbDatosP.Size = new System.Drawing.Size(304, 90);
            this.gbDatosP.TabIndex = 0;
            this.gbDatosP.TabStop = false;
            this.gbDatosP.Text = "Datos personales";
            // 
            // gbDirección
            // 
            this.gbDirección.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDirección.Location = new System.Drawing.Point(349, 15);
            this.gbDirección.Margin = new System.Windows.Forms.Padding(10, 15, 6, 5);
            this.gbDirección.Name = "gbDirección";
            this.gbDirección.Padding = new System.Windows.Forms.Padding(10, 5, 25, 10);
            this.tableLayoutPanel1.SetRowSpan(this.gbDirección, 2);
            this.gbDirección.Size = new System.Drawing.Size(323, 200);
            this.gbDirección.TabIndex = 1;
            this.gbDirección.TabStop = false;
            this.gbDirección.Text = "Dirección";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(342, 223);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 35);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(255, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(174, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tlPersonales
            // 
            this.tlPersonales.ColumnCount = 3;
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.75F));
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25F));
            this.tlPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPersonales.Controls.Add(this.label2, 2, 1);
            this.tlPersonales.Controls.Add(this.textBox2, 1, 1);
            this.tlPersonales.Controls.Add(this.lbApellidos, 0, 1);
            this.tlPersonales.Controls.Add(this.lbNombre, 0, 0);
            this.tlPersonales.Controls.Add(this.textBox1, 1, 0);
            this.tlPersonales.Controls.Add(this.label1, 2, 0);
            this.tlPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersonales.Location = new System.Drawing.Point(10, 18);
            this.tlPersonales.Name = "tlPersonales";
            this.tlPersonales.RowCount = 2;
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPersonales.Size = new System.Drawing.Size(269, 62);
            this.tlPersonales.TabIndex = 0;
            this.tlPersonales.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(3, 9);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellidos
            // 
            this.lbApellidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(3, 40);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(49, 13);
            this.lbApellidos.TabIndex = 2;
            this.lbApellidos.Text = "Apellidos";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(72, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(72, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "*";
            // 
            // tlContacto
            // 
            this.tlContacto.ColumnCount = 3;
            this.tlContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.75F));
            this.tlContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.25F));
            this.tlContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlContacto.Controls.Add(this.lbEmail, 0, 2);
            this.tlContacto.Controls.Add(this.textBox3, 1, 1);
            this.tlContacto.Controls.Add(this.lbTelf2, 0, 1);
            this.tlContacto.Controls.Add(this.lbTelf1, 0, 0);
            this.tlContacto.Controls.Add(this.textBox4, 1, 0);
            this.tlContacto.Controls.Add(this.label6, 2, 0);
            this.tlContacto.Controls.Add(this.textBox5, 1, 2);
            this.tlContacto.Controls.Add(this.label3, 2, 2);
            this.tlContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlContacto.Location = new System.Drawing.Point(10, 18);
            this.tlContacto.Name = "tlContacto";
            this.tlContacto.RowCount = 3;
            this.tlContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlContacto.Size = new System.Drawing.Size(269, 72);
            this.tlContacto.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(72, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 4;
            // 
            // lbTelf2
            // 
            this.lbTelf2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTelf2.AutoSize = true;
            this.lbTelf2.Location = new System.Drawing.Point(3, 49);
            this.lbTelf2.Name = "lbTelf2";
            this.lbTelf2.Size = new System.Drawing.Size(58, 13);
            this.lbTelf2.TabIndex = 2;
            this.lbTelf2.Text = "Teléfono 2";
            // 
            // lbTelf1
            // 
            this.lbTelf1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTelf1.AutoSize = true;
            this.lbTelf1.Location = new System.Drawing.Point(3, 12);
            this.lbTelf1.Name = "lbTelf1";
            this.lbTelf1.Size = new System.Drawing.Size(58, 13);
            this.lbTelf1.TabIndex = 0;
            this.lbTelf1.Text = "Teléfono 1";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(72, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "*";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 77);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "E mail";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(72, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "*";
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
            this.groupBox1.ResumeLayout(false);
            this.gbDatosP.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlPersonales.ResumeLayout(false);
            this.tlPersonales.PerformLayout();
            this.tlContacto.ResumeLayout(false);
            this.tlContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDatosP;
        private System.Windows.Forms.GroupBox gbDirección;
        private System.Windows.Forms.Label lbObligatorio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tlPersonales;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlContacto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbTelf2;
        private System.Windows.Forms.Label lbTelf1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
    }
}