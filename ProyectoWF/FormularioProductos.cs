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
        private SqlCommand cadenaInsertar, cadenaCategorias, cadenaProveedores, cadenaSelect;

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
            cadenaSelect = new SqlCommand("SELECT * FROM Productos WHERE @id = ProductoID", Conexion.conexion);
            cargarOpciones();
            

            
        }

        private void cargarOpciones() {
            toolTip1.SetToolTip(tbNombre, "Nombre del producto.");
            toolTip1.SetToolTip(tbCantidad, "Cantidad del producto.");
            toolTip1.SetToolTip(tbPrecio, "Precio unitario del producto.");
            toolTip1.SetToolTip(cbCategoria, "Categoría del producto.");
            toolTip1.SetToolTip(cbProveedor, "Proveedor del producto.");
            toolTip1.SetToolTip(tbStock, "Unidades en existencias.");

            cargarComboBox(cadenaProveedores, cbProveedor);
            cargarComboBox(cadenaCategorias, cbCategoria);
            

            if (modo == 0)
            {
                this.Text = "Alta de producto";
            }
            else if (modo == 1)
            {
                this.Text = "Modificación de producto";
                cargarProducto();
                

            }
            else if (modo == 2)
            {
                this.Text = "Vista de datos de producto";
                tbNombre.Enabled = false;
                tbCantidad.Enabled = false;
                tbPrecio.Enabled = false;
                cbProveedor.Enabled = false;
                cbCategoria.Enabled = false;
                tbStock.Enabled = false;
                btCancelar.Enabled = false;
                cargarProducto();

            }
        }

        private void cargarProducto() {
            cadenaSelect.Parameters.Clear();
            cadenaSelect.Parameters.AddWithValue("id", pk);
            SqlDataReader dr = cadenaSelect.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    tbNombre.Text = dr.GetString(1);
                    if (!dr.IsDBNull(2))
                        cbProveedor.Text = buscarProveedor(dr.GetInt32(2));
                    if (!dr.IsDBNull(3))
                        cbCategoria.Text = buscarCategoria(dr.GetInt32(3));
                    if (!dr.IsDBNull(4))
                        tbCantidad.Text = dr.GetString(4);
                    if (!dr.IsDBNull(5))
                        tbPrecio.Text = dr.GetSqlMoney(5).ToString();
                    if (!dr.IsDBNull(6))
                        tbStock.Text = dr.GetInt16(6).ToString();
                }

            }
            dr.Close();
        }
        private void cargarComboBox(SqlCommand cadena, ComboBox cb) {
            
            SqlDataReader dr = cadena.ExecuteReader();

            while (dr.Read()) {
                cb.Items.Add(dr[0]);
            }
            dr.Close();
            
        }

        private String buscarProveedor(int pk) {
            SqlCommand cadena = new SqlCommand("SELECT nombreCompania FROM Proveedores WHERE @id = ProveedorID", Conexion.conexion);
            cadena.Parameters.Clear();
            cadena.Parameters.AddWithValue("id",pk);
            SqlDataReader dr = cadena.ExecuteReader();
            String nombre;
            if (dr.Read()) {
                nombre = dr.GetString(0);
                dr.Close();
                return nombre;
            }

            dr.Close();
            return "";
        }

        private String buscarCategoria(int pk)
        {
            SqlCommand cadena = new SqlCommand("SELECT NombreCategoria FROM Categorias WHERE @id = CategoriaID", Conexion.conexion);
            cadena.Parameters.Clear();
            cadena.Parameters.AddWithValue("id", pk);
            SqlDataReader dr = cadena.ExecuteReader();
            String nombre;
            if (dr.Read())
            {
                nombre = dr.GetString(0);
                dr.Close();
                return nombre;
            }

            dr.Close();
            return "";
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
                Dispose();
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
