using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2_1_12_2020sm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankOps b = new BankOps();
            b.NetBalance = Convert.ToInt32(textBox1.Text);



            if (b.NetBalance >= 100000)
            {
                b.Overbalance(b.NetBalance);
            }
            else if (b.NetBalance <= 5000)
            {
                b.Underblance();
            }
            else
            {
                MessageBox.Show("The amount is exempted from tax");
            }
        }
    }
}
