using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form2 fem = new Form2();
            fem.Show();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Form6 fem = new Form6();
            fem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 fem = new Form10();
            fem.Show();
        }
    }
}
