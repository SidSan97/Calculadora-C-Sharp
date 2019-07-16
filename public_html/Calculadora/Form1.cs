using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        string operador;
        Double a /*= 0*/;
        double angulo, radiano;
        bool validar;     

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            /*if((Tela.Text == "0") || (validar))
            {
                Tela.Clear();
            }*/

            Button button = (Button)sender;
            Tela.Text = Tela.Text + button.Text;
        }

        private void button_Click_CE(object sender, EventArgs e)
        {
            Tela.Text = "";
        }

        private void button_Click_C(object sender, EventArgs e)
        {
            Tela.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        //Numeros e simbolos aritimeticos que aparecerão na tela
        private void button_Click_Adc(object sender, EventArgs e)
        {
            if (validar == true)
            {                 
                 a = a + Convert.ToDouble(Tela.Text);
                 label1.Text = Convert.ToString(a) + "+";
                 Tela.Text = "";
                 operador = "+";                   
            }
            else
            {
                label1.Text = Tela.Text + buttonAdc.Text;
                a = Convert.ToDouble(Tela.Text);
                Tela.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void button_Click_Sub(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToDouble(Tela.Text);
                label1.Text = Convert.ToString(a) + "+";
                Tela.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = Tela.Text + buttonSub.Text;
                a = Convert.ToDouble(Tela.Text);
                Tela.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void button_Click_Multi(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToDouble(Tela.Text);
                label1.Text = Convert.ToString(a) + "*";
                Tela.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = Tela.Text + buttonMulti.Text;
                a = Convert.ToDouble(Tela.Text);
                Tela.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void button_Click_Div(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToDouble(Tela.Text);
                label1.Text = Convert.ToString(a) + "/";
                Tela.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = Tela.Text + buttonDiv.Text;
                a = Convert.ToDouble(Tela.Text);
                Tela.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void Porcentagem_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = Convert.ToDouble(a / 100 * Convert.ToDouble(Tela.Text));
                label1.Text = Convert.ToString(a) + "%";
                Tela.Text = "";
                operador = "%";
            }
            else
            {
                label1.Text = Tela.Text + Porcentagem.Text;
                a = Convert.ToDouble(Tela.Text);
                Tela.Text = "";
                operador = "%";
                validar = true;
            }
        }

        private void buttonPot_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {            
                a = Math.Pow(a, Convert.ToDouble(Tela.Text));
                label1.Text = Convert.ToString(a) + "^";
                Tela.Text = "";
                operador = "^";
            }
            else
            {
                label1.Text = Tela.Text + buttonPot.Text;
                a = Convert.ToDouble(Tela.Text);
                Tela.Text = "";
                operador = "^";
                validar = true;
            }           
        }      

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            Convert.ToString(Tela.Text);
            double Valor_Raiz = Math.Sqrt(Convert.ToDouble(Tela.Text));
            label1.Text = "sqrt" + "(" + Tela.Text + ")" + " = ";
            Tela.Text = Convert.ToString(Valor_Raiz);
        }

        private void buttonCosseno_Click(object sender, EventArgs e)
        {
            angulo = Math.PI * Convert.ToDouble(Tela.Text) / 180;
            double Valor_Cos = Math.Cos(angulo);
            label1.Text = "cos" + "(" + Tela.Text + ")" + " = ";
            Tela.Text = Convert.ToString(Valor_Cos);
        }

        private void buttonSeno_Click(object sender, EventArgs e)
        {
            angulo = Math.PI * Convert.ToDouble(Tela.Text) / 180;
            double Valor_Sin = Math.Sin(angulo);
            label1.Text = "sen" + "(" + Tela.Text + ")" + " = ";
            Tela.Text = Convert.ToString(Valor_Sin);
        }

        private void buttonTangente_Click(object sender, EventArgs e)
        {
            radiano = Convert.ToDouble(Tela.Text) * (Math.PI / 180);
            double Valor_Tan = Math.Tan(radiano);
            label1.Text = "tan" + "(" + Tela.Text + ")" + " = ";
            Tela.Text = Convert.ToString(Valor_Tan);
        }

        private void button_ln_Click(object sender, EventArgs e)
        {
            Convert.ToString(Tela.Text);
            Double Valor_ln = Math.Log(Convert.ToDouble(Tela.Text));
            label1.Text = "ln" + "(" + Tela.Text + ")" + " = ";
            Tela.Text = Convert.ToString(Valor_ln);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Double Valor_Log10 = Math.Log10(Convert.ToDouble(Tela.Text));
            label1.Text = "log10" + "(" + Tela.Text + ")" + " = ";
            Tela.Text = Convert.ToString(Valor_Log10);
        }

        private void buttonFatorial_Click(object sender, EventArgs e)
        {
            double valor, fat;
            valor = Convert.ToDouble(Tela.Text);

            for(fat = 1; valor > 1; valor = valor - 1)              
                fat = fat * valor;

            label1.Text = "fact" + "(" + Tela.Text + ")" + " = ";
            Tela.Text = Convert.ToString(fat);
        }            

        private void buttonPI_Click(object sender, EventArgs e)
        {       
            Tela.Text = "3.14159265359";                                       
        }

        private void buttonParentese1_Click(object sender, EventArgs e)
        {
            if (Tela.Text == "(")
            {
                Tela.Text = Tela.Text + ")";
            }     
        }

        private void buttonParentese2_Click(object sender, EventArgs e)
        {
            Tela.Text = Tela.Text + "(";
        }

        private void buttonEuller_Click(object sender, EventArgs e)
        {
            Tela.Text = "2.71828182846";
        }

        //Botões referente aos operandos da calculadora e o sinal de '='
        private void button_Click_Igual(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + Tela.Text + "=";
                label1.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                Tela.Text = Convert.ToString(a + Convert.ToSingle(Tela.Text));
            }

            else if (operador == "-")
            {
              /*  if(Tela.Text != null)
                {
                    label1.Text = Tela.Text
                }*/
                label1.Text = label1.Text + Tela.Text + "=";
                label1.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                Tela.Text = Convert.ToString(a - Convert.ToSingle(Tela.Text));
            }

            else if (operador == "*")
            {
                label1.Text = label1.Text + Tela.Text + "=";
                label1.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                Tela.Text = Convert.ToString(a * Convert.ToSingle(Tela.Text));
            }

            else if (operador == "/")
            {
                label1.Text = label1.Text + Tela.Text + "=";
                label1.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                Tela.Text = Convert.ToString(a / Convert.ToSingle(Tela.Text));
            }

            else if (operador == "%")
            {
                label1.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                label1.Text = label1.Text + Tela.Text + "=";
                //label1.MaxLegth = 23;
                Tela.Text = Convert.ToString(a / 100 * Convert.ToSingle(Tela.Text));
            }

            else if (operador == "^")
            {
                label1.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                label1.Text = label1.Text + Tela.Text + "=";
                Tela.Text = Convert.ToString(Math.Pow(a, Convert.ToSingle(Tela.Text)));
            }            
        }

        private void buttonSinal_Click(object sender, EventArgs e)
        {
            Tela.Text = Convert.ToString(Convert.ToSingle(Tela.Text) - (Convert.ToSingle(Tela.Text) * 2));
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Tela.Text != "")
                Tela.Text = Tela.Text.Remove(Tela.TextLength - 1);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //Para a calculadora ser usada pelo teclado
        private void buttons_Teclado(object sender, KeyPressEventArgs e)
        {
            /*Tela.Text += e.KeyChar;

            e.Handled = true;*/

            switch (e.KeyChar)
            {
                case (char)40: Tela.Text = Tela.Text + "("; break;
                case (char)41: Tela.Text = Tela.Text + ")"; break;
                case (char)44: Tela.Text = Tela.Text + ","; break;
                case (char)46: Tela.Text = Tela.Text + ","; break;
                case (char)48: Tela.Text = Tela.Text + "0"; break;
                case (char)49: Tela.Text = Tela.Text + "1"; break;
                case (char)50: Tela.Text = Tela.Text + "2"; break;
                case (char)51: Tela.Text = Tela.Text + "3"; break;
                case (char)52: Tela.Text = Tela.Text + "4"; break;
                case (char)53: Tela.Text = Tela.Text + "5"; break;
                case (char)54: Tela.Text = Tela.Text + "6"; break;
                case (char)55: Tela.Text = Tela.Text + "7"; break;
                case (char)56: Tela.Text = Tela.Text + "8"; break;
                case (char)57: Tela.Text = Tela.Text + "9"; break;             

                // Manipula o `+`
                case (char)43: button_Click_Adc(this, EventArgs.Empty); break;
                // Manipula o `-`
                case (char)45: button_Click_Sub(this, EventArgs.Empty); break;
                // Manipula o `*`
                case (char)42: button_Click_Multi(this, EventArgs.Empty); break;
                // Manipula o `/`
                case (char)47: button_Click_Div(this, EventArgs.Empty); break;
                // Manipula o `=`
                case (char)13: button_Click_Igual(this, EventArgs.Empty); break;
                // Manipula o 'Backspace'
                case (char)08: button10_Click(this, EventArgs.Empty); break;
                // Manipula o 'C'
                case (char)127: button_Click_C(this, EventArgs.Empty); break;

            }
        }
        //Para sair da calculadora
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void Tela_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }           
     }        
}        

