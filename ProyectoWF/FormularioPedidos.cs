using System;
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
        public FormularioPedidos()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lFechaPedido_Click(object sender, EventArgs e)
        {

        }

        private void gbDatosPedido_Enter(object sender, EventArgs e)
        {

        }

        private void gbDatosEncio_Enter(object sender, EventArgs e)
        {

        }

        private void tbEmpleadoId_TextChanged(object sender, EventArgs e)
        {
            string comando = "Select NombreCompania from dbo.Clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(comando, Conexion.getConexion());
            DataSet cuenta = new DataSet();
            adapter.Fill(cuenta);
            tbCiudad.Text = cuenta.Tables[0].Rows[0]["NombreCompania"].ToString();

        }
    }
}
