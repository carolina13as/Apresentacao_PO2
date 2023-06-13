using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_de_Po2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(NotRobo.Checked == false)
            {
                Button_Save.Enabled = false;
            }
            else if(NotRobo.Checked == true)
            {
               NotRobo.Enabled = false;
                Button_Save.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo");

            /*
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Obrigatorio");
            }
            else if(textBox1.Text != "")
            {
                errorProvider1.Clear();
            }
            */
        }
    }
}
