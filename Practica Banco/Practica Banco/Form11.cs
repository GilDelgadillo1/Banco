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
    public partial class Form11 : Form
    {
        Conexion conexion = new Conexion();
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int id = Convert.ToInt32(textCliente.Text);
                cargar(id);
            }
        }
        public void cargar(int id)

        {
            dataGridView1.DataSource = conexion.cargarDatos("select cliente.nombre, cuenta.idcuenta from cliente inner join cuenta on cliente.idCliente="+id+" where cliente.idcliente=cuenta.idcliente;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
