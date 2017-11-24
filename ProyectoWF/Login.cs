using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoWF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            byte[] prueba = { (byte)'h', (byte)'o', (byte)'l', (byte)'a' };
            SHA512 sha = new SHA512Managed();
          
            SecureString se = new SecureString();
            se.AppendChar(sha.ComputeHash(prueba));
        }
    }
}
