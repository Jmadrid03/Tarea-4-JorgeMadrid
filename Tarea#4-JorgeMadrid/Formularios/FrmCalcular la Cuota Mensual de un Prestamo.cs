using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4_Orientada_a_Objetos.Repaso.Formularios
{
    public partial class FrmCalcular_la_Cuota_Mensual_de_un_Prestamo : Form
    {
        Clases.Class_Orientada_Objeto POO = new Clases.Class_Orientada_Objeto();
        public FrmCalcular_la_Cuota_Mensual_de_un_Prestamo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double prest, plazo, tasa;
            prest = Convert.ToDouble(TxtPrestamo.Text.Trim());
            plazo = Convert.ToDouble(TxtPlazo.Text.Trim());
            tasa = Convert.ToDouble(TxtTasaA.Text.Trim());

           TxtCuota.Text = POO.PrestamoM(prest, plazo, tasa).ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtPrestamo.Focus();
            }
        }
    }
}
