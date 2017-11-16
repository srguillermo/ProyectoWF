using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF {
	public partial class FormProveedores : Form {
		public FormProveedores() {
			InitializeComponent();
		}

		private void btExaminar_Click(object sender, EventArgs e) {
			OpenFileDialog od = new OpenFileDialog();

			od.InitialDirectory = ".";
			od.Filter = "Imagenes de mapa de bits (*)|*.bmp;*.gif;*.jpg;";
			od.RestoreDirectory = true;

			if (od.ShowDialog() == DialogResult.OK) {
				try {
					tbLogo.Text = od.FileName;
					pbLogo.ImageLocation = tbLogo.Text;
				} catch (Exception ex) {
					MessageBox.Show("Error: No se ha podido leer el archivo.\n " + ex.Message);
				}
			}

		}
	}
}
