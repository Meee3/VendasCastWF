using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAula23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> produto = new List<string>();
        List<double> preco = new List<double>();
       

        private void button1_Click(object sender, EventArgs e)
        {
            string produto = textBox1.Text;
            double preco = double.Parse(textBox2.Text);

            listBox1.Items.Add(produto);
            listBox2.Items.Add(preco);

            somar();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        public void somar()
        {
            double soma = 0;
            foreach (double preco2 in listBox2.Items)
            {
                soma += preco2;
                
            }
            lblTotalVenda.Text = $"Total da venda: {soma}";

        }
        private void label3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            listBox2.Items.RemoveAt(listBox2.Items.Count - 1);

            if(listBox2.Items.Count < 0)
            {
                MessageBox.Show("Chega né");
            }
            else
            {
            somar();
            }
        }

        internal void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
