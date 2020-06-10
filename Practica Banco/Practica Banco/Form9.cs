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
    public partial class Form9 : Form
    {
        Conexion conexion = new Conexion();
        public Form9()
        {
            InitializeComponent();
        }

        private void idCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int id = Convert.ToInt32(idCuenta.Text);
                cargar(id);
            }
        }

        public void cargar(int id)

        {
            dataGridView1.DataSource = conexion.cargarDatos("select cliente.nombre, cuenta.idcuenta from cliente inner join cuenta on cuenta.idcuenta="+ idCuenta.Text +" where cliente.idcliente=cuenta.idcliente;");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cuenta = Convert.ToInt32(idCuenta.Text);
            int cliente = Convert.ToInt32(textIdCliente.Text);
            string consulta = "update cuenta set idcliente ='" + cliente + "'where idCuenta=" + cuenta;
           // update cliente set nombre = '"+textNombre.Text +"', tel = " + textTelefono.Text ;


            if (conexion.ejecutarQuery(consulta))

            {
                MessageBox.Show("Cuenta Modificada");

            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
