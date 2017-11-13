namespace ProyectoWF {
    partial class FormularioPedidos {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosPedido = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNPedido = new System.Windows.Forms.TextBox();
            this.lEmpleadoId = new System.Windows.Forms.Label();
            this.lNumPedido = new System.Windows.Forms.Label();
            this.tbEmpleadoId = new System.Windows.Forms.TextBox();
            this.lFechaPedido = new System.Windows.Forms.Label();
            this.lFechaEntrega = new System.Windows.Forms.Label();
            this.tbFechaPedido = new System.Windows.Forms.TextBox();
            this.tbFechaEntrega = new System.Windows.Forms.TextBox();
            this.tbViaEnvio = new System.Windows.Forms.TextBox();
            this.lViaEnvio = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDatosEncio = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lClienteID = new System.Windows.Forms.Label();
            this.lNombreEntrega = new System.Windows.Forms.Label();
            this.tbCLienteId = new System.Windows.Forms.TextBox();
            this.chDatosPredeterminados = new System.Windows.Forms.CheckBox();
            this.lDireccionEntrega = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lCiudadEntrega = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.lRegionEntrega = new System.Windows.Forms.Label();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.lPais = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.lCP = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDarAlta = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDatosPedido.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbDatosEncio.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(943, 770);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(943, 350);
            this.splitContainer2.SplitterDistance = 135;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.gbDatosPedido, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(943, 135);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // gbDatosPedido
            // 
            this.gbDatosPedido.Controls.Add(this.tableLayoutPanel5);
            this.gbDatosPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosPedido.Location = new System.Drawing.Point(10, 10);
            this.gbDatosPedido.Margin = new System.Windows.Forms.Padding(10);
            this.gbDatosPedido.Name = "gbDatosPedido";
            this.gbDatosPedido.Size = new System.Drawing.Size(923, 115);
            this.gbDatosPedido.TabIndex = 2;
            this.gbDatosPedido.TabStop = false;
            this.gbDatosPedido.Text = "Datos pedido";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel5.Controls.Add(this.tbNPedido, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lEmpleadoId, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lNumPedido, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbEmpleadoId, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lFechaPedido, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lFechaEntrega, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbFechaPedido, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbFechaEntrega, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbViaEnvio, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lViaEnvio, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(917, 96);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tbNPedido
            // 
            this.tbNPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNPedido.Location = new System.Drawing.Point(88, 38);
            this.tbNPedido.Name = "tbNPedido";
            this.tbNPedido.Size = new System.Drawing.Size(347, 20);
            this.tbNPedido.TabIndex = 6;
            // 
            // lEmpleadoId
            // 
            this.lEmpleadoId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lEmpleadoId.AutoSize = true;
            this.lEmpleadoId.Location = new System.Drawing.Point(3, 9);
            this.lEmpleadoId.Name = "lEmpleadoId";
            this.lEmpleadoId.Size = new System.Drawing.Size(79, 13);
            this.lEmpleadoId.TabIndex = 0;
            this.lEmpleadoId.Text = "ID empleado";
            // 
            // lNumPedido
            // 
            this.lNumPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lNumPedido.AutoSize = true;
            this.lNumPedido.Location = new System.Drawing.Point(3, 41);
            this.lNumPedido.Name = "lNumPedido";
            this.lNumPedido.Size = new System.Drawing.Size(79, 13);
            this.lNumPedido.TabIndex = 1;
            this.lNumPedido.Text = "Nº pedido";
            // 
            // tbEmpleadoId
            // 
            this.tbEmpleadoId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmpleadoId.Location = new System.Drawing.Point(88, 6);
            this.tbEmpleadoId.Name = "tbEmpleadoId";
            this.tbEmpleadoId.Size = new System.Drawing.Size(347, 20);
            this.tbEmpleadoId.TabIndex = 5;
            this.tbEmpleadoId.TextChanged += new System.EventHandler(this.tbEmpleadoId_TextChanged);
            // 
            // lFechaPedido
            // 
            this.lFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lFechaPedido.AutoSize = true;
            this.lFechaPedido.Location = new System.Drawing.Point(461, 9);
            this.lFechaPedido.Name = "lFechaPedido";
            this.lFechaPedido.Size = new System.Drawing.Size(79, 13);
            this.lFechaPedido.TabIndex = 2;
            this.lFechaPedido.Text = "Fecha pedido";
            // 
            // lFechaEntrega
            // 
            this.lFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lFechaEntrega.AutoSize = true;
            this.lFechaEntrega.Location = new System.Drawing.Point(461, 41);
            this.lFechaEntrega.Name = "lFechaEntrega";
            this.lFechaEntrega.Size = new System.Drawing.Size(79, 13);
            this.lFechaEntrega.TabIndex = 3;
            this.lFechaEntrega.Text = "Fecha entrega";
            // 
            // tbFechaPedido
            // 
            this.tbFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFechaPedido.Location = new System.Drawing.Point(546, 6);
            this.tbFechaPedido.Name = "tbFechaPedido";
            this.tbFechaPedido.Size = new System.Drawing.Size(347, 20);
            this.tbFechaPedido.TabIndex = 7;
            // 
            // tbFechaEntrega
            // 
            this.tbFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFechaEntrega.Location = new System.Drawing.Point(546, 38);
            this.tbFechaEntrega.Name = "tbFechaEntrega";
            this.tbFechaEntrega.Size = new System.Drawing.Size(347, 20);
            this.tbFechaEntrega.TabIndex = 8;
            // 
            // tbViaEnvio
            // 
            this.tbViaEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbViaEnvio.Location = new System.Drawing.Point(88, 70);
            this.tbViaEnvio.Name = "tbViaEnvio";
            this.tbViaEnvio.Size = new System.Drawing.Size(347, 20);
            this.tbViaEnvio.TabIndex = 9;
            // 
            // lViaEnvio
            // 
            this.lViaEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lViaEnvio.AutoSize = true;
            this.lViaEnvio.Location = new System.Drawing.Point(3, 73);
            this.lViaEnvio.Name = "lViaEnvio";
            this.lViaEnvio.Size = new System.Drawing.Size(79, 13);
            this.lViaEnvio.TabIndex = 4;
            this.lViaEnvio.Text = "Via Envio";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gbDatosEncio, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(943, 211);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // gbDatosEncio
            // 
            this.gbDatosEncio.Controls.Add(this.tableLayoutPanel4);
            this.gbDatosEncio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosEncio.Location = new System.Drawing.Point(10, 10);
            this.gbDatosEncio.Margin = new System.Windows.Forms.Padding(10);
            this.gbDatosEncio.Name = "gbDatosEncio";
            this.gbDatosEncio.Size = new System.Drawing.Size(923, 191);
            this.gbDatosEncio.TabIndex = 3;
            this.gbDatosEncio.TabStop = false;
            this.gbDatosEncio.Text = "Datos envio";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel4.Controls.Add(this.tbCodigoPostal, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.tbNombre, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lClienteID, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lNombreEntrega, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbCLienteId, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.chDatosPredeterminados, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lDireccionEntrega, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbDireccion, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.lCiudadEntrega, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tbCiudad, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lRegionEntrega, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.tbRegion, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.lPais, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.tbPais, 4, 4);
            this.tableLayoutPanel4.Controls.Add(this.lCP, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99999F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00001F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(917, 172);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoPostal.Location = new System.Drawing.Point(88, 143);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(347, 20);
            this.tbCodigoPostal.TabIndex = 15;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(88, 68);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(347, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // lClienteID
            // 
            this.lClienteID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lClienteID.AutoSize = true;
            this.lClienteID.Location = new System.Drawing.Point(3, 12);
            this.lClienteID.Name = "lClienteID";
            this.lClienteID.Size = new System.Drawing.Size(79, 13);
            this.lClienteID.TabIndex = 0;
            this.lClienteID.Text = "ID cliente";
            // 
            // lNombreEntrega
            // 
            this.lNombreEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreEntrega.AutoSize = true;
            this.lNombreEntrega.Location = new System.Drawing.Point(3, 72);
            this.lNombreEntrega.Name = "lNombreEntrega";
            this.lNombreEntrega.Size = new System.Drawing.Size(79, 13);
            this.lNombreEntrega.TabIndex = 2;
            this.lNombreEntrega.Text = "Nombre";
            // 
            // tbCLienteId
            // 
            this.tbCLienteId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCLienteId.Location = new System.Drawing.Point(88, 8);
            this.tbCLienteId.Name = "tbCLienteId";
            this.tbCLienteId.Size = new System.Drawing.Size(347, 20);
            this.tbCLienteId.TabIndex = 5;
            // 
            // chDatosPredeterminados
            // 
            this.chDatosPredeterminados.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.chDatosPredeterminados, 2);
            this.chDatosPredeterminados.Location = new System.Drawing.Point(10, 40);
            this.chDatosPredeterminados.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chDatosPredeterminados.Name = "chDatosPredeterminados";
            this.chDatosPredeterminados.Size = new System.Drawing.Size(212, 17);
            this.chDatosPredeterminados.TabIndex = 10;
            this.chDatosPredeterminados.Text = "Usar datos de entrega predeterminados";
            this.chDatosPredeterminados.UseVisualStyleBackColor = true;
            // 
            // lDireccionEntrega
            // 
            this.lDireccionEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lDireccionEntrega.AutoSize = true;
            this.lDireccionEntrega.Location = new System.Drawing.Point(461, 72);
            this.lDireccionEntrega.Name = "lDireccionEntrega";
            this.lDireccionEntrega.Size = new System.Drawing.Size(79, 13);
            this.lDireccionEntrega.TabIndex = 3;
            this.lDireccionEntrega.Text = "Dirección";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.Location = new System.Drawing.Point(546, 68);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(347, 20);
            this.tbDireccion.TabIndex = 8;
            // 
            // lCiudadEntrega
            // 
            this.lCiudadEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lCiudadEntrega.AutoSize = true;
            this.lCiudadEntrega.Location = new System.Drawing.Point(3, 109);
            this.lCiudadEntrega.Name = "lCiudadEntrega";
            this.lCiudadEntrega.Size = new System.Drawing.Size(79, 13);
            this.lCiudadEntrega.TabIndex = 4;
            this.lCiudadEntrega.Text = "Ciudad";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCiudad.Location = new System.Drawing.Point(88, 105);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(347, 20);
            this.tbCiudad.TabIndex = 9;
            // 
            // lRegionEntrega
            // 
            this.lRegionEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lRegionEntrega.AutoSize = true;
            this.lRegionEntrega.Location = new System.Drawing.Point(461, 109);
            this.lRegionEntrega.Name = "lRegionEntrega";
            this.lRegionEntrega.Size = new System.Drawing.Size(79, 13);
            this.lRegionEntrega.TabIndex = 1;
            this.lRegionEntrega.Text = "Región";
            // 
            // tbRegion
            // 
            this.tbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegion.Location = new System.Drawing.Point(546, 105);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(347, 20);
            this.tbRegion.TabIndex = 6;
            // 
            // lPais
            // 
            this.lPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lPais.AutoSize = true;
            this.lPais.Location = new System.Drawing.Point(461, 146);
            this.lPais.Name = "lPais";
            this.lPais.Size = new System.Drawing.Size(79, 13);
            this.lPais.TabIndex = 11;
            this.lPais.Text = "Pais";
            // 
            // tbPais
            // 
            this.tbPais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPais.Location = new System.Drawing.Point(546, 143);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(347, 20);
            this.tbPais.TabIndex = 14;
            // 
            // lCP
            // 
            this.lCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lCP.AutoSize = true;
            this.lCP.Location = new System.Drawing.Point(3, 146);
            this.lCP.Name = "lCP";
            this.lCP.Size = new System.Drawing.Size(79, 13);
            this.lCP.TabIndex = 12;
            this.lCP.Text = "CP";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btMenos, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btMas, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btEditar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btDarAlta, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btCancelar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgProductos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btMenos
            // 
            this.btMenos.Image = global::ProyectoWF.Properties.Resources.if_icon_minus_211864__1_;
            this.btMenos.Location = new System.Drawing.Point(890, 3);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(30, 23);
            this.btMenos.TabIndex = 0;
            this.btMenos.Text = "  -  ";
            this.btMenos.UseVisualStyleBackColor = true;
            // 
            // btMas
            // 
            this.btMas.Image = global::ProyectoWF.Properties.Resources.if_plus_103681;
            this.btMas.Location = new System.Drawing.Point(854, 3);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(30, 23);
            this.btMas.TabIndex = 1;
            this.btMas.Text = " +  ";
            this.btMas.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Image = global::ProyectoWF.Properties.Resources._183209_16;
            this.btEditar.Location = new System.Drawing.Point(818, 3);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(30, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.cantidad,
            this.descuento,
            this.precio});
            this.tableLayoutPanel1.SetColumnSpan(this.dgProductos, 4);
            this.dgProductos.Location = new System.Drawing.Point(15, 32);
            this.dgProductos.Margin = new System.Windows.Forms.Padding(15, 3, 0, 15);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(908, 320);
            this.dgProductos.TabIndex = 3;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProducto.HeaderText = "Id Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProducto.HeaderText = "Nombre Producto";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // descuento
            // 
            this.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // btDarAlta
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btDarAlta, 3);
            this.btDarAlta.Location = new System.Drawing.Point(854, 390);
            this.btDarAlta.Name = "btDarAlta";
            this.btDarAlta.Size = new System.Drawing.Size(75, 23);
            this.btDarAlta.TabIndex = 4;
            this.btDarAlta.Text = "Dar de alta";
            this.btDarAlta.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.btCancelar, 2);
            this.btCancelar.Location = new System.Drawing.Point(773, 390);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(88, 208);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(351, 20);
            this.textBox11.TabIndex = 13;
            // 
            // FormularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 770);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormularioPedidos";
            this.Text = "FormularioPedidos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbDatosPedido.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gbDatosEncio.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbDatosPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox tbNPedido;
        private System.Windows.Forms.Label lEmpleadoId;
        private System.Windows.Forms.Label lNumPedido;
        private System.Windows.Forms.TextBox tbEmpleadoId;
        private System.Windows.Forms.Label lFechaPedido;
        private System.Windows.Forms.Label lFechaEntrega;
        private System.Windows.Forms.TextBox tbFechaPedido;
        private System.Windows.Forms.TextBox tbFechaEntrega;
        private System.Windows.Forms.TextBox tbViaEnvio;
        private System.Windows.Forms.Label lViaEnvio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox gbDatosEncio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tbCodigoPostal;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lClienteID;
        private System.Windows.Forms.Label lNombreEntrega;
        private System.Windows.Forms.TextBox tbCLienteId;
        private System.Windows.Forms.CheckBox chDatosPredeterminados;
        private System.Windows.Forms.Label lDireccionEntrega;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lCiudadEntrega;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.Label lRegionEntrega;
        private System.Windows.Forms.TextBox tbRegion;
        private System.Windows.Forms.Label lPais;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label lCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button btDarAlta;
        private System.Windows.Forms.Button btCancelar;
    }
}