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
        int idEmpleado;

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
                cbNombreCliente.Items.Add(cuenta.Tables[0].Rows[i]["ContactoNombre"].ToString());
            }
            this.idEmpleado = idEmpleado;

            comando = "Select concat(Nombre ,' ',Apellidos) as 'nombreCompleto' from dbo.Empleados where EmpleadoID=2";
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
            if (cbNombreCliente.SelectedItem != null)
            {
                string comando = String.Format("Select * from dbo.Clientes where ClienteID=" + idClienteSegunPosicion[cbNombreCliente.SelectedIndex]);
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
            if (cbNombreCliente.SelectedItem == null)
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
            }

        }

        private void cbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            colocarDatosCliente();
        }


    }
}
