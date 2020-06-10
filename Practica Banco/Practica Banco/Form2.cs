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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            Form3 fem = new Form3();
            fem.Show();

            this.Close();
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            Form4 fem = new Form4();
            fem.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form5 fem = new Form5();
            fem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 fem = new Form11();
            fem.Show();
        }
    }
}
