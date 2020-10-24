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
    public partial class FrmCalcular_Salario_Extra_y_Neto_de_un_Empleado : Form
    {
        Clases.Class_Orientada_Objeto POO = new Clases.Class_Orientada_Objeto();
        public FrmCalcular_Salario_Extra_y_Neto_de_un_Empleado()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
                TxtSalarioB.Focus();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtSalarioB.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese el Salario Base.");
                TxtSalarioB.Focus();
                return;
            }
            if (TxtHoraE.Text.Trim().Length == 0)
            {
                MessageBox.Show("Horas Extras es Necesario Ingresarlas.");
                TxtHoraE.Focus();
                return;
            }
            if (TxtValorH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Valor de la Hora.");
                TxtValorH.Focus();
                return;
            }

            double salbase, hrex, vlrh;

            salbase = Convert.ToDouble(TxtSalarioB.Text);
            hrex = Convert.ToDouble(TxtHoraE.Text);
            vlrh = Convert.ToDouble(TxtValorH.Text);
            
            TxtSalarioN.Text = POO.SalarioBase(salbase, hrex, vlrh).ToString();

        }
    }
}
