using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ass_4_1_12_20xml
{
    public partial class Form1 : Form
    {
        FileStream f;
        StreamReader r;
        StreamWriter w;


        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = (textBox2.Text);
            int age = Convert.ToInt32(textBox3.Text);



            f = new FileStream(@"D:\assignment.txt", FileMode.Append, FileAccess.Write);



            w = new StreamWriter(f);



            w.Write(id + " " + name + "" + age + "\n");



            MessageBox.Show("employee details inserted successfully");



            w.Close();
            f.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new FileStream(@"D:\assignment.txt", FileMode.Open, FileAccess.Read);
            r = new StreamReader(f);
            richTextBox1.Text = r.ReadToEnd();
            r.Close();
            f.Close();
        }
    }
}
