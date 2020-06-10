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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            Form7 fem = new Form7();
            fem.Show();
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            Form8 fem = new Form8();
            fem.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form9 fem = new Form9();
            fem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
