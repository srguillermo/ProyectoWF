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
    public partial class FormCliente : Form
    {
        public FormCliente(int modo, int clave)
        {
            InitializeComponent();
            txtPrueba.Text = clave + "," + modo;
            SqlConnection con = Conexion.getConexion();
            con.OpenAsync();
            SqlCommand cmd;
            cmd = new SqlCommand("insert into Clientes (ContactoNombre,NombreCompania,CodigoPostal,Pais) values ('nuevo','nuevo','3000','España')", con);
            cmd.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
