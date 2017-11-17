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
    public partial class FrmListadoEmpleados : Form
    {
        
        public FrmListadoEmpleados()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            consulta();


        }

        //Conexion

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoWF;"+
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");
        SqlDataAdapter adapter;
        DataTable table;
        SqlDataReader reader;
        SqlCommand command;


        public void consulta()
        {
            string sql = "SELECT * FROM Empleados";
            command = new SqlCommand(sql,con);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.AutoSize = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (splitContainer1.SplitterDistance == 40) {
                splitContainer1.SplitterDistance = 150;
                button5.Text = "Cerrar búsqueda";
            }
            else
            {
                splitContainer1.SplitterDistance = 40;
                button5.Text = "Abrir búsqueda";
            }
        }
    }
}
