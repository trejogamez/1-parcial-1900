using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            decimal num1 = 0;
            num1 = Convert.ToDecimal(txtbox1.Text);
            if (num1 % 2 == 0)
            {
                MessageBox.Show("EL NUMERO ES PAR:");
            }
            else { MessageBox.Show("EL NUMERO ES IMPAR:");}


            if (num1 > 0) 
            {
                MessageBox.Show("EL NUMERO ES POSITIVO");
            }
            else { MessageBox.Show("EL NUMERO ES NEGATIVO"); }


        }
    }
}
