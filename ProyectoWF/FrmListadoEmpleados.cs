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
using System.Configuration;

namespace ProyectoWF
{
    public partial class FrmListadoEmpleados : Form
    {
        
        public FrmListadoEmpleados()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            consulta();


        }

        //Conexion



        public void consulta()
        {
            string sConnection = ConfigurationManager.ConnectionStrings["proyectoWF"].ConnectionString;
            SqlConnection con = new SqlConnection(sConnection);
            SqlDataAdapter adapter;
            DataTable table;
            //SqlDataReader reader;
            SqlCommand command;
            string sql = "SELECT * FROM Empleados";
            command = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.AutoSize = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                button5.Text = "Cerrar";
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.SplitterDistance = 100;
            }
            else
            {
                button5.Text = "Abrir";
                splitContainer1.Panel1Collapsed = true;

            }

           
        }
    }
}
