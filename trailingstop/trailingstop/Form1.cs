using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trailingstop
{
    public partial class Form1 : Form
    {
        float act;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Hesap(float a)

        {
            float deger;
            for (float i = 0.0f; i <= 5.0f; i = i + 0.1f)
            {
                deger = (a / 100.0f) * i;
                deger = a - deger;
                dataGridView1.Rows.Add(i, deger);
              
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Fiyat Giriniz");
            }
            else
            {
                dataGridView1.Rows.Clear();

                act = float.Parse(InnerTrim2(textBox1.Text));
                Hesap(act);
            }
           
        }
        public string InnerTrim2(string input)
        {
            string a = input.Trim().Replace(".", ",");
            return a;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
