using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInterfaz
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPRESTAMO_Click(object sender, EventArgs e)
        {

            using (FormPrestamos ventanaprestamos = new FormPrestamos(txtnombre.Text))
                ventanaprestamos.ShowDialog();



        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            btnPRESTAMO.Enabled = false;
        }

        private void controlbotones()
        {

            if (txtnombre.Text.Trim() != string.Empty && txtnombre.Text.All(Char.IsLetter))
            {
                btnPRESTAMO.Enabled = true;
                errorProvider1.SetError(txtnombre,"");

            }
            else
            {

                if (!(txtnombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtnombre, "El nombre solo debe contener LETRAS");
                }
                else
                {
                    errorProvider1.SetError(txtnombre, "Debe introducir su nombre");

                }
                btnPRESTAMO.Enabled= false;
                txtnombre.Focus();

            }

        }


        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            controlbotones();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
