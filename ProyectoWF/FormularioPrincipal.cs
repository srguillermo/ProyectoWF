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
    public partial class FormularioPrincipal : Form {
        private int childFormNumber = 0;

        public FormularioPrincipal()
        {
            InitializeComponent();
            tsbExpandir.Visible = false;
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
            splitter.Visible = false;
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
            splitter.Visible = true;
            tvSecciones.Visible = true;
        }

        private void tsbRetraer_Click(object sender, EventArgs e)
        {
            splitter.Visible = false;
            tvSecciones.Visible = false;
            tsbRetraer.Visible = false;
            tsbExpandir.Visible = true;
        }

        private void tsbExpandir_Click(object sender, EventArgs e)
        {
            splitter.Visible = true;
            tvSecciones.Visible = true;
            tsbRetraer.Visible = true;
            tsbExpandir.Visible = false;
        }



        private void tvSecciones_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (tvSecciones.SelectedNode.Text)
            {
                case "Clientes":
                    Console.WriteLine(tvSecciones.SelectedNode.Text);
                    break;
                case "Proveedores":
                    Console.WriteLine(tvSecciones.SelectedNode.Text);
                    break;
                case "Empleados":
                    Console.WriteLine(tvSecciones.SelectedNode.Text);
                    break;
                case "Productos":
                    Console.WriteLine(tvSecciones.SelectedNode.Text);
                    break;
                case "Agencias":
                    Console.WriteLine(tvSecciones.SelectedNode.Text);
                    break;
                case "Categorias":
                    Console.WriteLine(tvSecciones.SelectedNode.Text);
                    break;
                case "Pedidos":
                    Console.WriteLine(tvSecciones.SelectedNode.Text);
                    break;

            }
        }

        private void msOpcionesFormPrincipal_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem opcionPulsada = (ToolStripMenuItem)sender;
            switch (opcionPulsada.Text)
            {
                case "Clientes":
                    Console.WriteLine(opcionPulsada.Text);
                    break;
                case "Proveedores":
                    Console.WriteLine(opcionPulsada.Text);
                    break;
                case "Empleados":
                    Console.WriteLine(opcionPulsada.Text);
                    break;
                case "Productos":
                    Console.WriteLine(opcionPulsada.Text);
                    break;
                case "Agencias":
                    Console.WriteLine(opcionPulsada.Text);
                    break;
                case "Categorias":
                    Console.WriteLine(opcionPulsada.Text);
                    break;
                case "Pedidos":
                    Console.WriteLine(opcionPulsada.Text);
                    break;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsbClientes_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clientes");
            FormularioPedidos formPedidos = new FormularioPedidos(1,1);
            formPedidos.MdiParent = this;
            formPedidos.Show();

        }

        private void tsbPedidos_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Pedidos");
        }

        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (MessageBox.Show("Hay formularios abiertos.\n¿Desea salir?", "Diálogo salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
