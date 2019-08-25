using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Base_Datos
{
    public partial class categorias : Form
    {
        Conexion con = new Conexion(); // instanciando la clase conexion
        public categorias()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.insertar2(cod.Text, nombres_c.Text, estad.Text));
            con.CargarBase2(dataGrid2);
        }

        private void categorias_Load(object sender, EventArgs e)
        {
            con.CargarBase2(dataGrid2);
        }
    }
}
