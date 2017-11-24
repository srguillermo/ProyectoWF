using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF {
    public partial class FormularioPedidos : Form {

        private ArrayList idClienteSegunPosicion;
        private ArrayList idCAgenciaSegunPosicion;
        private ArrayList idProductoSegunPosicion;
        private int primaryKey;
        private int modo;

        private int numeroFilaSeleccionado;
        private double precioFinal;

        public FormularioPedidos(int modo, int primaryKey)
        {
            InitializeComponent();
            this.primaryKey = primaryKey;
            this.modo = modo;

            lFd.Visible = false;
            lFd2.Visible = false;
            lFd3.Visible = false;
            lFd4.Visible = false;
            mtbPrecioFinal.Enabled = false;

            if (modo == 0)
            {
                //Modo Alta
                cargarDatosCbClientes();
                cargarDatosCbAgencias();
                dgProductos.Rows.Insert(0);
                cargarProductosCbDataGridView();

            }
            else if (modo == 1)
            {
                //Modo modificación
                cargarDatosCbClientes();
                cargarDatosCbAgencias();
                cargarFormularioConIdPedido(true);
                btDarAlta.Text = "Actualizar pedido";
                btEditar.Visible = false;
                btMas.Visible = false;
                btMenos.Visible = false;
                cargarLVConIdPedido(this.primaryKey);
                dgProductos.Columns[1].ReadOnly = true;

            }
            else if (modo == 2)
            {
                //Modo vista bloqueada                                                                                            
                cargarFormularioConIdPedido(false);

                cbViasEnvio.Enabled = false;
                dtFechaPedido.Enabled = false;
                dtFechaEntrega.Enabled = false;
                dtFechaRequerida.Enabled = false;
                tbNombreCliente.Enabled = false;
                btEditar.Visible = false;
                btMas.Visible = false;
                btMenos.Visible = false;
                dgProductos.Enabled = false;
                mtbPrecioFinal.Enabled = false;

                cargarLVConIdPedido(this.primaryKey);

                btCancelar.Text = "Atrás";
                btDarAlta.Visible = false;


            }

        }


        private void cargarDatosCbAgencias()
        {
            string comando = "Select AgenciaID,NombreCompania from dbo.Agencias";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            idCAgenciaSegunPosicion = new ArrayList();
            Console.WriteLine(cuenta.Tables[0].Rows.Count);
            for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
            {
                idCAgenciaSegunPosicion.Add(cuenta.Tables[0].Rows[i]["AgenciaID"].ToString());
                cbViasEnvio.Items.Add(cuenta.Tables[0].Rows[i]["NombreCompania"].ToString());
            }
        }

        private void cargarDatosCbClientes()
        {
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
        }

        private void cargarFormularioConIdPedido(bool isEdicion)
        {
            SqlCommand sqlComando = new SqlCommand("Select p.ShipVia,a.NombreCompania,PedidoFecha,FechaEntregado,RequiredFecha,ContactoNombre,c.Telefono,p.CiudadEntrega,p.DireccionEntrega,p.RegionEntrega,p.CodigoPostalEntrega,p.PaisEntrega from dbo.Pedidos p inner join dbo.Clientes c on c.ClienteId=p.ClienteID inner join dbo.Agencias a  on p.ShipVia=a.AgenciaID where PedidoID=@idPedido", Conexion.getConexion());
            sqlComando.Parameters.Add("@idPedido", SqlDbType.Int).Value = this.primaryKey;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlComando);
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);



            dtFechaPedido.Value = Convert.ToDateTime(cuenta.Tables[0].Rows[0]["PedidoFecha"].ToString());
            dtFechaEntrega.Value = Convert.ToDateTime(cuenta.Tables[0].Rows[0]["FechaEntregado"].ToString());
            dtFechaRequerida.Value = Convert.ToDateTime(cuenta.Tables[0].Rows[0]["RequiredFecha"].ToString());
            tbNombreCliente.Text = cuenta.Tables[0].Rows[0]["ContactoNombre"].ToString();
            tbTelefono.Text = cuenta.Tables[0].Rows[0]["Telefono"].ToString();
            tbCiudad.Text = cuenta.Tables[0].Rows[0]["CiudadEntrega"].ToString();
            tbDireccion.Text = cuenta.Tables[0].Rows[0]["DireccionEntrega"].ToString();
            tbRegion.Text = cuenta.Tables[0].Rows[0]["RegionEntrega"].ToString();
            tbCodigoPostal.Text = cuenta.Tables[0].Rows[0]["CodigoPostalEntrega"].ToString();
            tbPais.Text = cuenta.Tables[0].Rows[0]["PaisEntrega"].ToString();
            if (isEdicion)
            {
                for (int i = 0; i < idCAgenciaSegunPosicion.Count; i++)
                {
                    Convert.ToInt16(cuenta.Tables[0].Rows[0]["ShipVia"].ToString());
                    if (Convert.ToInt16(idCAgenciaSegunPosicion[i]) == Convert.ToInt16(cuenta.Tables[0].Rows[0]["ShipVia"]))
                    {
                        cbViasEnvio.SelectedIndex = i;
                    }
                }
            }
            else
            {
                cbViasEnvio.Text = cuenta.Tables[0].Rows[0]["NombreCompania"].ToString();
            }
        }

        private void cargarLVConIdPedido(int idPedido)
        {
            SqlCommand sqlComando = new SqlCommand("Select pd.ProductoID,ProductoNombre,Cantidad,Descuento,pd.PrecioUnidad from dbo.PedidoDetalles pd inner join dbo.Productos p on p.ProductoID = pd.ProductoID where PedidoID =@idPedido", Conexion.getConexion());
            sqlComando.Parameters.Add("@idPedido", SqlDbType.Int).Value = idPedido;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlComando);
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            for (int i = 0; i < cuenta.Tables[0].Rows.Count; i++)
            {
                dgProductos.Rows.Insert(0);
                ((DataGridViewComboBoxCell)dgProductos.Rows[0].Cells["nombreProd"]).Items.Add(cuenta.Tables[0].Rows[i]["ProductoNombre"].ToString());
                ((DataGridViewComboBoxCell)dgProductos.Rows[0].Cells["nombreProd"]).Value = ((DataGridViewComboBoxCell)dgProductos.Rows[0].Cells["nombreProd"]).Items[0];
                dgProductos.Rows[0].Cells["idProducto"].Value = cuenta.Tables[0].Rows[i]["ProductoID"].ToString();
                dgProductos.Rows[0].Cells["cantidad"].Value = cuenta.Tables[0].Rows[i]["Cantidad"].ToString();
                dgProductos.Rows[0].Cells["descuento"].Value = cuenta.Tables[0].Rows[i]["Descuento"].ToString();
                dgProductos.Rows[0].Cells["precioUnidad"].Value = cuenta.Tables[0].Rows[i]["PrecioUnidad"];
                double precio = Double.Parse(dgProductos.Rows[0].Cells["cantidad"].Value.ToString()) * Double.Parse(dgProductos.Rows[0].Cells["precioUnidad"].Value.ToString());
                dgProductos.Rows[0].Cells["precio"].Value = precio - ((precio * Double.Parse(dgProductos.Rows[0].Cells["descuento"].Value.ToString()) / 100));
            }
            calcularPrecioFinal();
        }



        private void cbNombreCliente_Validating(object sender, CancelEventArgs e)
        {

            borrarDatosCliente();
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
            dgProductos.CurrentRow.Cells["idProducto"].Value = idProductoSegunPosicion[((ComboBox)sender).SelectedIndex];
            calculoCeldaPrecio();
        }




        private void tb_Validating(object sender, EventArgs e)
        {

            calculoCeldaPrecio();

        }

        public void calculoCeldaPrecio()
        {
            if (dgProductos.CurrentRow.Cells["cantidad"].Value != null)
            {
                double descuento = ((Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value) > 0 || dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value != null) ? Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["cantidad"].Value) * (Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["descuento"].Value) / 100) : 0);
                double precioConDescuentoAplicado = (Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["cantidad"].Value) - descuento) * Convert.ToDouble(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells["precioUnidad"].Value);
                dgProductos.CurrentRow.Cells["precio"].Value = precioConDescuentoAplicado;
                calcularPrecioFinal();
            }
        }

        public void calcularPrecioFinal()
        {
            precioFinal = 0;
            for (int i = 0; i < dgProductos.Rows.Count; i++)
            {
                precioFinal += Convert.ToDouble(dgProductos.Rows[i].Cells["precio"].Value);

            }

            mtbPrecioFinal.Text = precioFinal.ToString("C", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void dgProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


            if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[3].DisplayIndex)
            {
                TextBox tb = (TextBox)e.Control;
                if (tb != null)
                {
                    tb.LostFocus -= new EventHandler(tb_Validating);
                    tb.LostFocus += new EventHandler(tb_Validating);
                }
            }
            else if (this.dgProductos.CurrentCellAddress.X == dgProductos.Columns[2].DisplayIndex)
            {
                TextBox tb = (TextBox)e.Control;
                if (tb != null)
                {
                    tb.LostFocus -= new EventHandler(tb_Validating);
                    tb.LostFocus += new EventHandler(tb_Validating);
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
            numeroFilaSeleccionado = dgProductos.CurrentRow.Index;
            if (numeroFilaSeleccionado > 0)
            {
                dgProductos.CurrentRow.Cells["nombreProd"].ReadOnly = false;
                dgProductos.CurrentRow.DefaultCellStyle.BackColor = Color.LightGray;
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
            lFd.Visible = false;
            lFd2.Visible = false;
            lFd3.Visible = false;
            lFd4.Visible = false;
            bool puedoDarDeAlta = true;

            if (cbViasEnvio.SelectedItem == null)
            {
                lFd.Visible = true;
                lFd2.Visible = true;
                lFd4.Visible = true;
                puedoDarDeAlta = false;
            }

            if (tbNombreCliente.SelectedItem == null)
            {
                lFd.Visible = true;
                lFd2.Visible = true;
                lFd3.Visible = true;
                puedoDarDeAlta = false;
            }


            if (puedoDarDeAlta)
            {
                if (modo == 0)
                {

                    actualizarPrecioAntesDeOperar();
                    SqlCommand sqlCommand = new SqlCommand("insert into dbo.Pedidos(ClienteID,EmpleadoID,PedidoFecha,RequiredFecha,FechaEntregado,ShipVia,Freight,NombreEntrega,DireccionEntrega,CiudadEntrega,RegionEntrega,CodigoPostalEntrega,PaisEntrega) values(@idCliente,@idEmpleado,@join_date,@join_date2,@join_date3,@idAgencia," +
                        "@precioFinal,@nombreCliente,@direccionCliente,@ciudadCliente,@regionCliente,@cpCliente,@paisCliente)", Conexion.getConexion());

                    sqlCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = idClienteSegunPosicion[tbNombreCliente.SelectedIndex];
                    sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = primaryKey;
                    sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
                    sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = precioFinal;
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
                        sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = primaryKey;
                        sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
                        sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = precioFinal;
                        sqlCommand.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = tbNombreCliente.Text;

                    }

                }
                else
                {
                    actualizarPedido();
                }
            }

        }

        private void btMenos_Click(object sender, EventArgs e)
        {


            if (dgProductos.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dgProductos.SelectedRows)
                {
                    dgProductos.Rows.Remove(row);
                }

            }
        }



        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarPedido()
        {

            actualizarPrecioAntesDeOperar();


            SqlTransaction transaction;


            transaction = Conexion.getConexion().BeginTransaction("SampleTransaction");
            try
            {
                SqlCommand sqlCommand = new SqlCommand("update dbo.Pedidos set ClienteID=@idCliente,RequiredFecha=@join_date2,FechaEntregado=@join_date3,ShipVia=@idAgencia,Freight=@precioFinal,NombreEntrega=@nombreCliente,DireccionEntrega=@direccionCliente,CiudadEntrega=@ciudadCliente,RegionEntrega=@regionCliente,CodigoPostalEntrega=@cpCliente,PaisEntrega=@paisCliente where PedidoID=@idPedido", Conexion.getConexion());
                sqlCommand.Transaction = transaction;
                Console.WriteLine(cbViasEnvio.SelectedIndex);
                Console.WriteLine(idCAgenciaSegunPosicion.Count);
                sqlCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = idClienteSegunPosicion[tbNombreCliente.SelectedIndex];
                sqlCommand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = primaryKey;
                sqlCommand.Parameters.Add("@idAgencia", SqlDbType.Int).Value = idCAgenciaSegunPosicion[cbViasEnvio.SelectedIndex];
                sqlCommand.Parameters.Add("@precioFinal", SqlDbType.Decimal).Value = precioFinal;
                sqlCommand.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = tbNombreCliente.Text;
                sqlCommand.Parameters.Add("@direccionCliente", SqlDbType.VarChar).Value = tbDireccion.Text;
                sqlCommand.Parameters.Add("@ciudadCliente", SqlDbType.VarChar).Value = tbCiudad.Text;
                sqlCommand.Parameters.Add("@regionCliente", SqlDbType.VarChar).Value = tbRegion.Text;
                sqlCommand.Parameters.Add("@cpCliente", SqlDbType.VarChar).Value = tbCodigoPostal.Text;
                sqlCommand.Parameters.Add("@paisCliente", SqlDbType.VarChar).Value = tbPais.Text;
                sqlCommand.Parameters.Add("@join_date", SqlDbType.Date).Value = DateTime.Now;
                sqlCommand.Parameters.Add("@join_date2", SqlDbType.Date).Value = dtFechaRequerida.Value;
                sqlCommand.Parameters.Add("@join_date3", SqlDbType.Date).Value = dtFechaEntrega.Value;
                sqlCommand.Parameters.Add("@idPedido", SqlDbType.Int).Value = this.primaryKey;
                sqlCommand.ExecuteNonQuery();


                for (int i = 0; i < dgProductos.RowCount; i++)
                {

                    sqlCommand = new SqlCommand("update dbo.PedidoDetalles set Cantidad=@cantidad,Descuento=@descuento where PedidoID=@idPedido and ProductoID=@idProducto", Conexion.getConexion());
                    sqlCommand.Transaction = transaction;
                    sqlCommand.Parameters.Add("@idProducto", SqlDbType.Int).Value = dgProductos.Rows[i].Cells["idProducto"].Value;
                    sqlCommand.Parameters.Add("@cantidad", SqlDbType.Int).Value = dgProductos.Rows[i].Cells["cantidad"].Value;
                    sqlCommand.Parameters.Add("@descuento", SqlDbType.Decimal).Value = dgProductos.Rows[i].Cells["descuento"].Value;
                    sqlCommand.Parameters.Add("@idPedido", SqlDbType.Int).Value = this.primaryKey;
                    sqlCommand.ExecuteNonQuery();


                }
                transaction.Commit();
                MessageBox.Show("Pedido actualizado correctamente", "Actualización de pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException)
            {
                transaction.Rollback();
                MessageBox.Show("Error al actualizar el pedido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void actualizarPrecioAntesDeOperar()
        {
            for (int i = 0; i < dgProductos.RowCount; i++)
            {

                double descuento = ((Convert.ToDouble(dgProductos.Rows[i].Cells["descuento"].Value) > 0 || dgProductos.Rows[i].Cells["descuento"].Value != null) ? Convert.ToDouble(dgProductos.Rows[i].Cells["cantidad"].Value) * (Convert.ToDouble(dgProductos.Rows[i].Cells["descuento"].Value) / 100) : 0);
                double precioConDescuentoAplicado = (Convert.ToDouble(dgProductos.Rows[i].Cells["cantidad"].Value) - descuento) * Convert.ToDouble(dgProductos.Rows[i].Cells["precioUnidad"].Value);
                dgProductos.Rows[i].Cells["precio"].Value = precioConDescuentoAplicado;
                calcularPrecioFinal();


            }
        }
    }
}

