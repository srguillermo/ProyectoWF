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
    public partial class FormularioProductos : Form
    {
        private int modo;
        private int pk;

        public FormularioProductos()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(tbNombre, "Nombre del producto.");
            toolTip1.SetToolTip(tbCantidad, "Cantidad del producto.");
            toolTip1.SetToolTip(tbPrecio, "Precio unitario del producto.");
            toolTip1.SetToolTip(cbCategoria, "Categoría del producto.");
            toolTip1.SetToolTip(cbProveedor, "Proveedor del producto.");
            Conexion.getConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.conexion;


        }
        public FormularioProductos(int modo, int primaryKey) {
            this.modo = modo;
            this.pk = primaryKey;
            toolTip1.SetToolTip(tbNombre, "Nombre del producto.");
            toolTip1.SetToolTip(tbCantidad, "Cantidad del producto.");
            toolTip1.SetToolTip(tbPrecio, "Precio unitario del producto.");
            toolTip1.SetToolTip(cbCategoria, "Categoría del producto.");
            toolTip1.SetToolTip(cbProveedor, "Proveedor del producto.");
            



            if (modo == 0)
            {
                this.Text = "Alta de producto";
                this.lbExistencias.Visible = false;
            }
            else if (modo == 1)
            {
                this.Text = "Modificación de producto";
                this.lbExistencias.Visible = true;
            }
            else if (modo == 2) {
                this.Text = "Vista de datos de producto";
                tbNombre.Enabled = false;
                tbCantidad.Enabled = false;
                tbPrecio.Enabled = false;
                cbProveedor.Enabled = false;
                cbCategoria.Enabled = false;
                this.lbExistencias.Visible = true;
                btCancelar.Enabled = false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                if (!DatosObligatorios())
                {
                    MessageBox.Show("Faltan datos obligatorios.","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {

                }
            }
            else if (modo == 1)
            {
                Dispose();
            }
            else if (modo == 2)
            {

            }
        }

        private void FormularioProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private Boolean DatosObligatorios() {
            if (!tbNombre.Text.Equals("")) {
                return true;
            }
            return false;
        }
    }
}
