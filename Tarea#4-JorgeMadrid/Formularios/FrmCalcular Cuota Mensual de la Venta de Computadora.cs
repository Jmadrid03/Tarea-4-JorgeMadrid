using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4_Orientada_a_Objetos.Repaso.Formularios
{
    public partial class FrmCalcular_Cuota_Mensual_de_la_Venta_de_Computadora : Form
    {
        Clases.Class_Orientada_Objeto POO = new Clases.Class_Orientada_Objeto();
        public FrmCalcular_Cuota_Mensual_de_la_Venta_de_Computadora()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text.Trim().Length == 0)
            {
                POO.MsgWarning("Ingresar el Producto Requerido.");
                TxtDescripcion.Focus();
                return;
            }
            if (TxtPrecio.Text.Trim().Length == 0)
            {
                POO.MsgWarning("Ingresar el Precio del Producto.");
                TxtPrecio.Focus();
                return;
            }

            if (POO.chekIfsNumber(TxtPrecio.Text.Trim()) == "N")
            {
                POO.MsgWarning("El Valor Del Precio Debe Ser Númerico.");
                TxtPrecio.Focus();
                return;
            }

            if (RbtContado.Checked == true)
            {
                TxtResultado.Text = TxtPrecio.Text;
            }else
            {
                TxtResultado.Text = (POO.ReturnsNumber(TxtPrecio.Text) * (1.35)).ToString();
            }
        }
    }
}
