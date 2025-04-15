using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) 
                listBox1.Items.Add((textBox1.Text) + "/" + (dateTimePicker1.Value) + "/" + comboBox1.Text + "/" + "hourly");
            if (radioButton2.Checked == true)
                listBox1.Items.Add((textBox1.Text) + "/" + (dateTimePicker1.Value) + "/" + comboBox1.Text + "/" + "daily");
            if (radioButton3.Checked == true)
                listBox1.Items.Add((textBox1.Text) + "/" + (dateTimePicker1.Value) + "/" + comboBox1.Text + "/" + "weekly");
            if (radioButton4.Checked == true)
                listBox1.Items.Add((textBox1.Text) + "/" + (dateTimePicker1.Value) + "/" + comboBox1.Text + "/" + "monthly");

            comboBox1.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
