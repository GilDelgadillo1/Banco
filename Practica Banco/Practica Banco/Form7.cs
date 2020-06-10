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
    public partial class Form7 : Form
    {
        Conexion conexion = new Conexion();
        public Form7()
        {
            InitializeComponent();
        }

        private void textIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int id = Convert.ToInt32(textIdCliente.Text);
                cargar(id);
            }
        }

        public void cargar(int id)

        {
            dataGridView1.DataSource = conexion.cargarDatos("select * from cliente where idCliente=" + id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "insert into cuenta(idCliente) values(" +
                textIdCliente.Text + ")";

            if (conexion.ejecutarQuery(consulta))

            {

                MessageBox.Show("Cuenta Registrada");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
