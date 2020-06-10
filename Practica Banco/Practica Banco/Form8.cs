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
    public partial class Form8 : Form
    {
        Conexion conexion = new Conexion();
        public Form8()
        {
            InitializeComponent();
        }

        private void textIdCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int id = Convert.ToInt32(textIdCuenta.Text);
                cargar(id);
            }
        }

        public void cargar(int id)

        {
            dataGridView1.DataSource = conexion.cargarDatos("select cliente.nombre, cuenta.idcuenta from cliente inner join cuenta on cuenta.idcuenta="+id+" where cuenta.idcliente=cliente.idcliente;");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string consulta = "delete from cuenta where idcuenta =" + textIdCuenta.Text;
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
