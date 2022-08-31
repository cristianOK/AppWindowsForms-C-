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
    public partial class FormPrestamos : Form
    {
        string nombre_cliente;
        string[] razas_disponibles = { "JUJUY", "BUENOS AIRES" , "SALTA" , "TUCUMAN" , "SANTIAGO DEL ESTERO" , "ENTRE RIOS" , "MISIONES" , "FORMOSA" , "RIO NEGRO", "LA PAMPA" , "CHUBUT" , "MENDOZA", "TIERRA DEL FUEGO", "SAN LUIS", "SAN JUAN", "LA RIOJA", "CATAMARCA", "CORDOBA", "SANTA CRUZ", "NEUQUEN", "SANTA FE", "CORRIENTES", "CHACO", "CIUDAD AUTONOMA DE BUENOS AIRES"};
        int[] cuotas_disponibles = { 12, 24, 36, 48, 60, 72, 84 };
        string[] lugares_disponibles;
        Dictionary<int, double> intereses_bases;


        public FormPrestamos(string txtnombre)
        {
            InitializeComponent();
            nombre_cliente = txtnombre;

            string listado_ciudades = Properties.Resources.lugaresAppprovincia.ToString();
            lugares_disponibles = listado_ciudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            intereses_bases = new Dictionary<int, double>();

            int i;
            double intereses;
            for (i = 0, intereses = 3.0; i < cuotas_disponibles.Length; i++, intereses += 0.5)
            {
                intereses_bases[cuotas_disponibles[i]] = intereses;



            }




    }

        private void saludo_Click(object sender, EventArgs e)
        {

        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {

            popularcuotas();
            popularrazas();
            popularciudades();

            saludo.Text += nombre_cliente;


        }

        void popularcuotas()
        {

            for (int i = 0; i < cuotas_disponibles.Length; i++){ 
            
                comboCUOTAS.Items.Add(cuotas_disponibles[i]);

            }

        }

        void popularrazas()
        {

            for (int i = 0; i < razas_disponibles.Length; i++){
            
                comboRAZA.Items.Add(razas_disponibles[i]);

            }

        }

        void popularciudades()
        {

            for (int i = 0; i < lugares_disponibles.Length; i++){
            
                comboORIGEN.Items.Add(lugares_disponibles[i]);

            }

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcular_intereses()
        {

            int cuotas_pedidas = (int)comboCUOTAS.SelectedItem;
            string razas_seleccionada = comboRAZA.SelectedItem.ToString().ToLower();
            string lugar_seleccionado = comboORIGEN.SelectedItem.ToString().ToLower();
            double intereses = intereses_bases[cuotas_pedidas];

            if (new[] { "ENTRE RIOS", "JUJUY", "SALTA","SANTA CRUZ", "FORMOSA", "SANTA FE" }.Contains(razas_seleccionada))
            {
                intereses += 0.3;

            }

            if (new[] {"Paraná","San Salvador de Jujuy", "Salta","Formosa","Santa Fe","Rio Gallegos"}.Contains(lugar_seleccionado))
            {
                intereses -= 0.3;
            }
            return intereses;

        }

        private void btnconfirmarsolicitud_Click(object sender, EventArgs e)
        {


            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(panelDatos, "");
                        errorProvider1.SetError(panelDetalles, "");
                        double intereses_mensual = calcular_intereses();
                        double monto_pedido = double.Parse(monto.Text);
                        int cuotas_pedidas = (int)comboCUOTAS.SelectedItem;
                        double intereses_total = monto_pedido * (intereses_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + intereses_total;
                        string mensaje = "Su prestamo por $" + monto_pedido + " en " + cuotas_pedidas + " cuotas se concedera con un interes del " + intereses_mensual + "% mensual.\nEl monto asciende a $" + monto_a_pagar;
                        MessageBoxButtons botonOK = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Total a Pagar ");
                        break;




                    }
                case 1:
                    {
                        errorProvider1.SetError(panelDatos, "DEBE COMPLETAR TODOS LOS DATOS PERSONALES...");
                        errorProvider1.SetError(panelDetalles,"");
                        break;

                    }
                case 2:
                    {

                        errorProvider1.SetError(panelDetalles, "DEBE INGRESAR UN MONTO NUMERICO Y EL NUMERO DE CUOTAS");
                        errorProvider1.SetError(panelDatos,"");
                        break;
                    }



               
            }      

        }

        int validaciones()
        {
            if ((comboRAZA.SelectedIndex <= -1) || (comboORIGEN.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(monto.Text.All(Char.IsDigit)) || (monto.Text == "") || (comboCUOTAS.SelectedIndex <= -1))
                {
                    return 2;


                }
                else
                {
                    return 0;
                }



            }

        }



    }
}
