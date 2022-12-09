using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JedDatTyp09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool obsahuje = false;
            int min = -1;

            int i = 0;
            while(i <textBox1.Lines.Count() && !obsahuje)
            {
                int cifra = int.Parse(textBox1.Lines[i].ToString());
               
                if(cifra % 2 == 0)
                {
                    min = cifra;
                    obsahuje = true;
                 
                }
                i++;
            }
            i = 0;
            bool obsahujeMin = false;
            while (i < textBox1.Lines.Count())
            {
               

                int cifra = int.Parse(textBox1.Lines[i].ToString());
                if(cifra%2 == 0)
                {
                    if (cifra < min)
                    {
                        min = cifra;
                        obsahujeMin = true;
                    }
                    else obsahujeMin = false;
                }

                i++;
            }
            if(obsahujeMin)
            {
                MessageBox.Show("Minimum je: " + min);
            }
            else
            {
                MessageBox.Show("Neobsahuje minimum");
            }


        }
    }
}
