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
        private SqlCommand cadenaInsertar, cadenaCategorias, cadenaProveedores;

        public FormularioProductos()
        {
        }
        public FormularioProductos(int modo, int primaryKey) {
            InitializeComponent();
            this.modo = modo;
            this.pk = primaryKey;

            Conexion.getConexion();

            cadenaInsertar = new SqlCommand("insert into Productos (ProductoNombre) " +
                                  "values (@nombre)", Conexion.conexion);
            cadenaCategorias = new SqlCommand("SELECT nombreCategoria FROM Categorias", Conexion.conexion);
            cadenaProveedores = new SqlCommand("SELECT contactNombre FROM Proveedores", Conexion.conexion);
            cargarOpciones();
            

            
        }

        private void cargarOpciones() {
            toolTip1.SetToolTip(tbNombre, "Nombre del producto.");
            toolTip1.SetToolTip(tbCantidad, "Cantidad del producto.");
            toolTip1.SetToolTip(tbPrecio, "Precio unitario del producto.");
            toolTip1.SetToolTip(cbCategoria, "Categoría del producto.");
            toolTip1.SetToolTip(cbProveedor, "Proveedor del producto.");

            cbProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

            cargarComboBox(cadenaProveedores, cbProveedor);
            cargarComboBox(cadenaCategorias, cbCategoria);
            

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
            else if (modo == 2)
            {
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

        private void cargarComboBox(SqlCommand cadena, ComboBox cb) {
            SqlDataReader dr = cadena.ExecuteReader();

            while (dr.Read()) {
                cb.Items.Add(dr[0]);
            }
            dr.Close();
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Conexion.cerrarConexion();
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
                    cadenaInsertar.Parameters.Clear();
                    cadenaInsertar.Parameters.AddWithValue("nombre", tbNombre.Text);

                    int res = cadenaInsertar.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Datos almacenados.");
                    }
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
            Conexion.cerrarConexion();
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
