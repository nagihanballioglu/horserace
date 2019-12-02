using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atyarisiiiii
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AtSec atsecimi = new AtSec();
            atsecimi.isim = textBox1.Text;
            atsecimi.cinsiyet = radioButton1.Text;
            atsecimi.ırk = comboBox1.Text;
            atsecimi.yas = textBox2.Text;
            atsecimi.fiyat = textBox3.Text;

            listBox1.Items.Add($"{atsecimi.isim}");
            listBox1.Items.Add($"{atsecimi.cinsiyet}");
            listBox1.Items.Add($"{atsecimi.ırk}");
            listBox1.Items.Add($"{atsecimi.yas}");
            listBox1.Items.Add($"{atsecimi.fiyat}");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
