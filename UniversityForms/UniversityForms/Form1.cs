using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityForms
{
    public partial class Form1 : Form
    {
        public string item1, item2, item3, item4, item5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "University";
            Height = 600;
            Width = 600;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void calc_button_Click(object sender, EventArgs e)
        {
            CoutingClass cc = new CoutingClass();
            label4.Text = cc.Mean(item1, item2, item3, item4, item5).ToString();
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            item1 = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            item2 = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            item3 = comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            item4 = comboBox4.Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            item5 = comboBox5.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
