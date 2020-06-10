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
    public partial class Form4 : Form
    {
        Conexion conexion = new Conexion();
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int id = Convert.ToInt32(textBox1.Text);
                cargar(id);
            }
        }

        public void cargar(int id)

        {
            dataGridView1.DataSource = conexion.cargarDatos("select * from cliente where idCliente="+id);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string consulta = "delete from cliente where idcliente =" + textBox1.Text;
            if (conexion.ejecutarQuery(consulta))

            {
                MessageBox.Show("Cliente eliminado correctamente");

            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
