using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double resultado;
          
            n1 = double.Parse(txtpeso.Text);
            n2 = double.Parse(txtaltura.Text);
            resultado = n1 / Math.Pow(n2, 2);
            if (resultado < 18.5)
            {
                lblresultado.Text = "Você está abaixo do peso!";

            }
            else if (resultado > 18.5 && resultado < 24.9)
            {
                lblresultado.Text = "Seu peso está normal";

            } 
            else if (resultado > 25 && resultado < 29.9)
            {
                lblresultado.Text = "Sobrepeso";

            } 
            else if (resultado > 30 && resultado < 34.9)
            {
                lblresultado.Text = "Obesidade Grau I";

            }
            else if (resultado > 35 && resultado < 39.9)
            {
                lblresultado.Text = "Obesidade Grau II";

            }
            else 
            {
                lblresultado.Text = "Obesidade Grau III ou Mórbida";
            }

        }

       
    }
}
