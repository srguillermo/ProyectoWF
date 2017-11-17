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

namespace ProyectoWF
{
    public partial class FrmListadoClientes : Form
    {
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter da;

        public FrmListadoClientes()
        {
            InitializeComponent();
            splitContainerPrincipal.IsSplitterFixed = true;
            cargar(dataGridView1);
            dataGridView1.Columns["ClienteID"].Visible = false;
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            if (splitContainerPrincipal.SplitterDistance == 50)
            {
                splitContainerPrincipal.SplitterDistance = 150;
            }
            else {
                splitContainerPrincipal.SplitterDistance = 50;
            }
            
            
        }


        private void cargar(DataGridView dgv) {

            try {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
                    "Initial Catalog=ProyectoWF;" +
                    "Integrated Security=True;" +
                    "Connect Timeout=30;" +
                    "Encrypt=False;" +
                    "TrustServerCertificate=True;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False");//objeto conexion
                con.Open();//abrimos conexion
                dt = new DataTable();//creamos datatable
                da = new SqlDataAdapter("select * from Clientes",con);//creamos adapter con la consulta
                da.Fill(dt);//cargamos el datatable con el adapter
                dgv.DataSource = dt;//cargamos el datagridview con datatable

            }
            catch (Exception e) {
                MessageBox.Show("no se pudo llenar el datagridview"+e.ToString());
            }
            
        }

        
    }
}
