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
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label_Nom_Click(object sender, EventArgs e)
        {

        }

        private void label_Email_Click(object sender, EventArgs e)
        {

        }

        private bool ConfNom()
        {
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConfDir()
        {
            if (string.IsNullOrEmpty(textDir.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConfTelf()
        {
            if (string.IsNullOrEmpty(textTelf.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConfEm()
        {
            if (string.IsNullOrEmpty(textNom.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (ConfNom() && ConfDir() && ConfTelf() && ConfEm())
             {
                Datos.Centros.Add(new Centro(textEmail.Text, textDir.Text, textTelf.Text, textNom.Text));
                DialogResult b = MessageBox.Show("Datos Guardados", "Confirmar", MessageBoxButtons.OK);
                if (b == DialogResult.OK)
                {
                    textEmail.Clear();
                    textDir.Clear();
                    textTelf.Clear();
                    textNom.Clear();
                }
            }
            else
            {
                DialogResult a = MessageBox.Show("Rellenar campos vacios", "Confirmar", MessageBoxButtons.OK);
            }
            
            
        }
    }
}
