using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series_y_Ciclos
{
    public partial class Form1 : Form
    {
        int[] VectorFactorial;

        public Form1()
        {
            InitializeComponent();
        }

        public double ResCos(double ValorX, int Repeticiones)
        {
            int Factorial = 1;
            double Cos = 0.0;
            short Bandera = 0;
            int cont = 0;
            int dif = 1;
            int Rept = Repeticiones;

            for (int i = 1; i <= Repeticiones + 1; i++)
            {
                cont++;
                if (cont > 3)
                {
                    Rept = Rept + dif;
                    //txtResultado.Text = cont+"--"+i+"--"+Rept.ToString();
                }
            }
            VectorFactorial = new int[Rept + 1];

            for (int i = 1; i <= Rept; i++)
            {
                Factorial = i * Factorial;//Funciona perfectamente
                VectorFactorial[i] = Factorial;
                //txtResultado.Text += i + " -- " + Rept + " -- " + VectorFactorial[i].ToString() + Environment.NewLine;
            }

            for (int i = 1; i <= Rept; i++)
            {
                if (i == 1 || i == 2)
                {
                    if (i == 1)
                    {
                        Cos = 1.0;
                    }
                    else if (i == 2)
                    {
                        Cos = Cos - (Math.Pow(ValorX, i) / i);
                    }
                    //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                }
                else if (i % 2 == 0)
                {
                    if (Bandera == 0)
                    {
                        Cos = Cos + (Math.Pow(ValorX, i) / (VectorFactorial[i]));
                        Bandera = 1;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                    else if (Bandera == 1)
                    {
                        Cos = Cos - (Math.Pow(ValorX, i) / (VectorFactorial[i]));
                        Bandera = 0;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                }
            }
            return Cos;
        }

        public double ResSeno(double ValorX, int Repeticiones)
        {
            int Factorial = 1;
            double Seno = 0.0;
            Seno = (ValorX)*(1.0);
            short Bandera = 0;
            int cont = 0;
            int dif = 1;
            int Rept = Repeticiones;
            int rept = Rept;

            for (int i = 1; i <= Repeticiones + 1; i++)
            {
                cont++;
                if (cont > 2)
                {
                    Rept = Rept + dif;
                }
                //txtResultado.Text = Rept.ToString();Funciona de 3,5,7,9 ect
            }
            VectorFactorial = new int[Rept + 1];

            for (int i = 1; i <= Rept; i++)
            {
                Factorial = i * Factorial;//Funciona perfectamente
                VectorFactorial[i] = Factorial;
                //txtResultado.Text += i + " -- " + Rept + " -- " + VectorFactorial[i].ToString() + Environment.NewLine;
            }
            cont = 0;
            for (int j = 1; j <= Repeticiones + 1; j++)
            {
                cont++;
                if (cont > 2)
                {
                    rept = rept + dif;
                }
                if (j>=2)
                {
                    if (Bandera == 0)
                    {
                        Seno = Seno - (Math.Pow(ValorX, rept) / (VectorFactorial[rept]));
                        Bandera = 1;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                    else if (Bandera == 1)
                    {
                        Seno = Seno + (Math.Pow(ValorX, rept) / (VectorFactorial[rept]));
                        Bandera = 0;
                        //txtResultado.Text += i + "--" + VectorFactorial[i] + "--" + Cos.ToString() + Environment.NewLine;
                    }
                }
            }
            return Seno;
        }

        public double ResIn(double ValorX, int Repeticiones)
        {
            double In = 0.0;
            double Elv = 1.0;
            double Elv1 = 0.0; 

            for (int i = 1; i < Repeticiones + 1; i++)
            {
                Elv = (ValorX - 1.0)/(ValorX);
                Elv1 = Math.Pow(Elv, i);
                In = In + (1.0/i)*(Elv1);
            }
            return In;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            int Repeticiones1 = 0;
            double ValorX1 = 0.0;

            Repeticiones1 = Convert.ToInt32(txtReparticiones.Text);
            ValorX1 = Convert.ToDouble(txtX.Text);

            if (txtList.Text == "COS")
            {
                txtResultado.Text = ResCos(ValorX1, Repeticiones1).ToString();
            }
            else if (txtList.Text == "SENO")
            {
                txtResultado.Text = ResSeno(ValorX1, Repeticiones1).ToString();
                //ResSeno(ValorX1, Repeticiones1);
            }
            else if (txtList.Text == "IN")
            {
                txtResultado.Text = ResIn(ValorX1, Repeticiones1).ToString();
            }
        }
    }
}
