using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_4_Orientada_a_Objetos.Repaso.Formularios;

namespace Tarea_4_Orientada_a_Objetos.Repaso.Clases
{
    class Class_Orientada_Objeto
    {
        public double SalarioBase(double salb, double hraex, double vlhr)
        {
            double resl;
            double sub = salb - (salb * 0.05);
            double salextra = hraex * vlhr;
            resl = sub + salextra;
            return resl;
        }

        public double PrestamoM(double prest, double plazo, double interes)
        {
            double resl;
            double tol = prest * plazo * interes;
            resl = tol / (plazo * 12);
            return resl;
        }
        public void MsgWarning(string str)
        {
            MessageBox.Show(str, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AlertNotNumber(string str)
        {
            double x;
            if (!double.TryParse(str, out x))
            {
                MsgWarning("El Valor Debe Ser Númerico.");
            }
        }
         public double SalAument(double sal, double aumt)
            {
                double resl;
                resl = sal + (aumt / 100);
                return resl;
            }    

         public string CheckIfIsNumber(string str)
        {
            string resp = "";
            double x;
            if(double.TryParse(str, out x))
            {
                resp = "S";
            }
            else
            {
                resp = "N";
            }
            return resp;
        }

        public double ReturnsNumber(string str)
        {
            double value = 0;
            if(double.TryParse(str, out value))
            {
                value = Convert.ToDouble(str);
            }
            return value;
        }
    
        
    }
}

