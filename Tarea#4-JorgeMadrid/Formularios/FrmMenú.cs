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
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_Salario_Extra_y_Neto_de_un_Empleado neto = new Formularios.FrmCalcular_Salario_Extra_y_Neto_de_un_Empleado();
            neto.Show();

        }

        private void FrmMenú_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_la_Cuota_Mensual_de_un_Prestamo cuota = new Formularios.FrmCalcular_la_Cuota_Mensual_de_un_Prestamo();
            cuota.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento aumento = new Formularios.FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento();
            aumento.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_Cuota_Mensual_de_la_Venta_de_Computadora compu = new Formularios.FrmCalcular_Cuota_Mensual_de_la_Venta_de_Computadora();
            compu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmCalcular_el_Total_de_Ventas_de_un_Vendedor vende = new Formularios.FrmCalcular_el_Total_de_Ventas_de_un_Vendedor();
            vende.Show();
        }
    }
}
