using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class ListaPersonales : Form
    {
        public ListaPersonales()
        {
            InitializeComponent();
        }

        private void ListaPersonales_Leave(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.Personanles;
        }
    }
}
