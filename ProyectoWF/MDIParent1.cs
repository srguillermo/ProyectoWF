using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF {
    public partial class MDIParent1 : Form {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            tssUsuario.Spring = true;
            tssUsuario.Alignment = ToolStripItemAlignment.Right;
            TreeNode nodo = new TreeNode();
            nodo.Text = "Maestro";
            TreeNode nodoClientes = new TreeNode();
            nodoClientes.Text = "Clientes";
            TreeNode nodoProveedores = new TreeNode();
            nodoProveedores.Text = "Proveedores";
            TreeNode nodoProductos = new TreeNode();
            nodoProductos.Text = "Productos";
            TreeNode nodoEmpleados = new TreeNode();
            nodoEmpleados.Text = "Empleados";
            nodo.Nodes.Add(nodoClientes);
            nodo.Nodes.Add(nodoProveedores);
            nodo.Nodes.Add(nodoProductos);
            nodo.Nodes.Add(nodoEmpleados);
            tvSecciones.Nodes.Add(nodo);
            TreeNode nodoAuxiliares = new TreeNode();
            nodoAuxiliares.Text = "Auxiliares";
            TreeNode nodoCategorias = new TreeNode();
            nodoCategorias.Text = "Categorias";
            TreeNode nodoAgencias = new TreeNode();
            nodoAgencias.Text = "Agencias";
            nodoAuxiliares.Nodes.Add(nodoCategorias);
            nodoAuxiliares.Nodes.Add(nodoAgencias);
            tvSecciones.Nodes.Add(nodoAuxiliares);
            TreeNode nodoPedidos = new TreeNode();
            nodoPedidos.Text = "Pedidos";
            tvSecciones.Nodes.Add(nodoPedidos);
            tvSecciones.ExpandAll();


        }

        private void ShowNewForm(object sender, EventArgs e)
        {

            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            splitter1.Visible = false;
            tvSecciones.Visible = false;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            splitter1.Visible = true;
            tvSecciones.Visible = true;
        }
    }
}
