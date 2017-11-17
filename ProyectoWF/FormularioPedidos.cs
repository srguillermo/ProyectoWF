using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF {
    public partial class FormularioPedidos : Form {

        ArrayList idClienteSegunPosicion;
        ArrayList idCAgenciaSegunPosicion;
        ArrayList idProductoSegunPosicion;
        int idEmpleado;
        int numeroFilaSeleccionado;

        public FormularioPedidos(int idEmpleado)
        {
            InitializeComponent();
            string comando = "Select ContactoNombre,ClienteID from dbo.Clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            idClienteSegunPosicion = new ArrayList();
            for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
            {
                idClienteSegunPosicion.Add(cuenta.Tables[0].Rows[i]["ClienteID"].ToString());
                tbNombreCliente.Items.Add(cuenta.Tables[0].Rows[i]["ContactoNombre"].ToString());
            }
            this.idEmpleado = idEmpleado;

            comando = "Select concat(Nombre ,' ',Apellidos) as 'nombreCompleto' from dbo.Empleados where EmpleadoID=" + idEmpleado;
            adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            cuenta = new DataSet();
            adapter.Fill(cuenta);
            tbEmpleadoNombre.Text = cuenta.Tables[0].Rows[0]["nombreCompleto"].ToString();

            comando = "Select AgenciaID,NombreCompania from dbo.Agencias";
            adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            cuenta = new DataSet();
            adapter.Fill(cuenta);
            idCAgenciaSegunPosicion = new ArrayList();
            Console.WriteLine(cuenta.Tables[0].Rows.Count);
            for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
            {
                idCAgenciaSegunPosicion.Add(cuenta.Tables[0].Rows[i]["AgenciaID"].ToString());
                cbViasEnvio.Items.Add(cuenta.Tables[0].Rows[i]["NombreCompania"].ToString());
            }


            dgProductos.Rows.Insert(0);
            cargarProductosCbDataGridView();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbEmpleadoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lFechaEntrega_Click(object sender, EventArgs e)
        {

        }

        private void tbFechaPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void lFechaRequerida_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNombreCliente_Validating(object sender, CancelEventArgs e)
        {

            borrarDatosCliente();
        }



        private void cbNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void colocarDatosCliente()
        {
            if (tbNombreCliente.SelectedItem != null)
            {
                string comando = String.Format("Select * from dbo.Clientes where ClienteID=" + idClienteSegunPosicion[tbNombreCliente.SelectedIndex]);
                SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
                DataSet cuenta = new DataSet();
                adapter.Fill(cuenta);
                tbDireccion.Text = cuenta.Tables[0].Rows[0]["Direccion"].ToString();
                tbCiudad.Text = cuenta.Tables[0].Rows[0]["Ciudad"].ToString();
                tbRegion.Text = cuenta.Tables[0].Rows[0]["Region"].ToString();
                tbPais.Text = cuenta.Tables[0].Rows[0]["Pais"].ToString();
                tbCodigoPostal.Text = cuenta.Tables[0].Rows[0]["CodigoPostal"].ToString();
                tbTelefono.Text = cuenta.Tables[0].Rows[0]["Telefono"].ToString();
            }
        }

        private void cbNombreCliente_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode.Equals(Keys.Return))
            {
                borrarDatosCliente();
            }

        }


        private void borrarDatosCliente()
        {
            if (tbNombreCliente.SelectedItem == null)
            {
                tbDireccion.Text = "";
                tbCiudad.Text = "";
                tbRegion.Text = "";
                tbPais.Text = "";
                tbCodigoPostal.Text = "";
                tbTelefono.Text = "";
            }

        }
        private void btMas_Click(object sender, EventArgs e)
        {
            dgProductos.Rows.Insert(0);
            for (int i = 0; i < dgProductos.Rows.Count; i++)
            {
                dgProductos.Rows[1].Cells["cantidad"].ReadOnly = true;
                dgProductos.Rows[1].Cells["nombreProd"].ReadOnly = true;
            }

        }

        private void cbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            colocarDatosCliente();
        }

        public void cargarProductosCbDataGridView()
        {

            string comando = "select ProductoID,ProductoNombre from dbo.Productos order by ProductoID";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            idProductoSegunPosicion = new ArrayList();
            for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
            {
                idProductoSegunPosicion.Add(cuenta.Tables[0].Rows[i]["ProductoID"].ToString());
                ((DataGridViewComboBoxColumn)dgProductos.Columns[1]).Items.Add(cuenta.Tables[0].Rows[i]["ProductoNombre"].ToString());
            }


        }

        void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comando = "select PrecioUnidad from dbo.Productos where ProductoID=" + idProductoSegunPosicion[((ComboBox)sender).SelectedIndex];
            SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            dgProductos.CurrentRow.Cells["idProducto"].Value = idProductoSegunPosicion[((ComboBox)sender).SelectedIndex];
            dgProductos.CurrentRow.Cells["precioUnidad"].Value = cuenta.Tables[0].Rows[0]["PrecioUnidad"].ToString();
            calculoCeldaPrecio();
        }




        private void tb_Validating(object sender, EventArgs e)
        {

            calculoCeldaPrecio();

        }
        private void tb_prueba(object sender, EventArgs e)
        {

            MessageBox.Show(this, "hola");

        }

        public void calculoCeldaPrecio()
        {
            if (dgProductos.CurrentRow.Cells["cantidad"].Value != null)
            {
                double descuento = ((Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value) > 0 || dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value != null) ? Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["cantidad"].Value) * (Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value) / 100) : 0);
                double precioConDescuentoAplicado = (Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["cantidad"].Value) - descuento) * Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["precioUnidad"].Value);
                dgProductos.CurrentRow.Cells["precio"].Value = precioConDescuentoAplicado;

                double precioFinal = 0;
                for (int i = 0; i < dgProductos.Rows.Count; i++)
                {
                    precioFinal += Convert.ToDouble(dgProductos.Rows[i].Cells["precio"].Value);

                }

                mtbPrecioFinal.Text = Convert.ToString(precioFinal);


            }
        }

        private void dgProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


            if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[3].DisplayIndex)
            {
                TextBox tb = (TextBox)e.Control;
                if (tb != null)
                {
                    tb.Validating -= new CancelEventHandler(tb_Validating);
                    tb.Validating += new CancelEventHandler(tb_Validating);
                }
            }
            else if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[2].DisplayIndex)
            {
                TextBox tb = (TextBox)e.Control;
                if (tb != null)
                {
                    tb.Validating -= new CancelEventHandler(tb_Validating);
                    tb.Validating += new CancelEventHandler(tb_Validating);
                }
            }
            else if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[1].DisplayIndex)
            {
                ComboBox cb = (ComboBox)e.Control;
                if (cb != null)
                {
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);
                    cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
                }
            }
        }

        private void btEditar_MouseClick(object sender, MouseEventArgs e)
        {
            if (numeroFilaSeleccionado > 0)
            {
                dgProductos.CurrentRow.Cells["nombreProd"].ReadOnly = false;
                dgProductos.CurrentRow.DefaultCellStyle.BackColor = Color.Aquamarine;
                dgProductos.CurrentRow.Cells["descuento"].ReadOnly = false;
                dgProductos.CurrentRow.Cells["cantidad"].ReadOnly = false;
                numeroFilaSeleccionado = dgProductos.CurrentRow.Index;
            }
        }

        private void dgProductos_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (numeroFilaSeleccionado > 0)
            {
                dgProductos.CurrentRow.Cells["nombreProd"].ReadOnly = true;
                dgProductos.Rows[numeroFilaSeleccionado].Cells["descuento"].ReadOnly = true;
                dgProductos.Rows[numeroFilaSeleccionado].Cells["cantidad"].ReadOnly = true;
                dgProductos.CurrentRow.DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        private void btDarAlta_Click(object sender, EventArgs e)

        {
            SqlCommand sqlCommand = new SqlCommand("insert into dbo.Pedidos(ClienteID,EmpleadoID,PedidoFecha,RequiredFecha,FechaEntregado,ShipVia,Freight,NombreEntrega,DireccionEntrega,CiudadEntrega,RegionEntrega,CodigoPostalEntrega,PaisEntrega) values(@idCliente,@idEmpleado,@join_date,@join_date2,@join_date3,@idAgencia," +
                "@precioFinal,@nombreCliente,@direccionCliente,@ciudadCliente,@regionCliente,@cpCliente,@paisCliente)", Conexion.getConexion());

            sqlCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = idClienteSegunPosicion[tbNombreCliente.SelectedIndex];
            sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
            sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
            sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = Convert.ToDouble(mtbPrecioFinal.Text);
            sqlCommand.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = tbNombreCliente.Text;
            sqlCommand.Parameters.Add("@direccionCliente", SqlDbType.VarChar).Value = tbDireccion.Text;
            sqlCommand.Parameters.Add("@ciudadCliente", SqlDbType.VarChar).Value = tbCiudad.Text;
            sqlCommand.Parameters.Add("@regionCliente", SqlDbType.VarChar).Value = tbRegion.Text;
            sqlCommand.Parameters.Add("@cpCliente", SqlDbType.VarChar).Value = tbCodigoPostal.Text;
            sqlCommand.Parameters.Add("@paisCliente", SqlDbType.VarChar).Value = tbPais.Text;
            sqlCommand.Parameters.Add("@join_date", SqlDbType.Date).Value = DateTime.Now;
            sqlCommand.Parameters.Add("@join_date2", SqlDbType.Date).Value = dtFechaRequerida.Value;
            sqlCommand.Parameters.Add("@join_date3", SqlDbType.Date).Value = dtFechaEntrega.Value;

            sqlCommand.ExecuteNonQuery();

            

            for (int i = 0; i < dgProductos.RowCount; i++)
            {

                sqlCommand = new SqlCommand("insert into");
                sqlCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = dgProductos.Rows[i].Cells["idProducto"].Value; ;
                sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
                sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
                sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = Convert.ToDouble(mtbPrecioFinal.Text);
                sqlCommand.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = tbNombreCliente.Text;

            }

        }
    }
}
