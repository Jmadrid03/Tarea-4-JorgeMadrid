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
    public partial class FrmCalcular_el_Total_de_Ventas_de_un_Vendedor : Form
    {
        Clases.Class_Orientada_Objeto POO = new Clases.Class_Orientada_Objeto();
        public FrmCalcular_el_Total_de_Ventas_de_un_Vendedor()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Total_de_Ventas_de_un_Vendedor_Load(object sender, EventArgs e)
        {

        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }
            DtpFecha.Text = "";
            TxtNombre.Focus();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo Del Nombre Es Requerido.");
                TxtNombre.Focus();
                return;
            }
            if (TxtRuta.Text.Trim().Length == 0)
            {
                POO.MsgWarning("El Campo De Ruta Es Requerido.");
                TxtRuta.Focus();
                return;
            }
            if(DtpFecha.Value > DateTime.Today)
            {
                POO.MsgWarning("La Fecha No Puede Ser Mayor Que El Sistema.");
                DtpFecha.Focus();
                return;
            }
            if (POO.chekIfsNumber(TxtVenta.Text.Trim()) == "N")
            {
                POO.MsgWarning("El Valor De La Venta Debe Ser Númerico.");
                TxtVenta.Focus();
                return;
            }

            string vendedor, ruta, fecha, venta;

            vendedor = TxtNombre.Text.Trim();
            ruta = TxtRuta.Text.Trim();
            fecha = DtpFecha.Text.Trim();
            venta = TxtVenta.Text.Trim();

            DgvDatosVenta.Rows.Add(vendedor, ruta, fecha, venta);

            double total = POO.ReturnsNumber(TxtTotalVta.Text) + POO.ReturnsNumber(venta);
            TxtTotalVta.Text = total.ToString();
        }

        private void TxtVenta_TextChanged(object sender, EventArgs e)
        {
            if (TxtVenta.Text.Trim().Length > 0)
            {
                POO.AlertNotNumber(TxtVenta.Text.Trim());
            }
        }
    }
}
