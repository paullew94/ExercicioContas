using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAPagar_Click(object sender, EventArgs e)
        {
            ContasAPagar form = new ContasAPagar();
            form.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesForm form = new ClientesForm();
            form.Visible = true;
        }

        private void btnContasAReceber_Click(object sender, EventArgs e)
        {
            ContasAReceber form = new ContasAReceber();
            form.Visible = true;
        }
    }
}
