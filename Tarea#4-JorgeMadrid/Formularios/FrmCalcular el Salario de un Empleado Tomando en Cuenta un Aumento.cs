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
    public partial class FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento : Form
    {
        Clases.Class_Orientada_Objeto POO = new Clases.Class_Orientada_Objeto();
        public FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtSalarioE.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Salario Es Requerido.");
                TxtSalarioE.Focus();
                return;
            }
            if (TxtAumentoS.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Aumento Es Reqerido.");
                TxtAumentoS.Focus();
                return;
            }
            double sal, aumt;
            sal = Convert.ToDouble(TxtSalarioE.Text.Trim());
            aumt = Convert.ToDouble(TxtAumentoS.Text.Trim());

            POO.SalAument(TxtResultado.Text).ToString();
        }

        private void TxtSalarioE_TextChanged(object sender, EventArgs e)
        {
            if (TxtSalarioE.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtSalarioE.Text.Trim());
            }
        }

        private void TxtAumentoS_TextChanged(object sender, EventArgs e)
        {
            if (TxtAumentoS.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtAumentoS.Text.Trim());
            }
        }

        private void ClearForm()
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
            TxtSalarioE.Focus();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
