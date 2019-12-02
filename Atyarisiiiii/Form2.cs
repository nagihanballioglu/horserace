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
    public partial class Form2 : Form
    {
        List<List<string>> kazananlisteform2 = new List<List<string>>();
        List<List<string>> kaybedenlisteform2 = new List<List<string>>();
        public Form2(List<List<string>> a, List<List<string>> b)
        {
            InitializeComponent();

            kazananlisteform2 = a;
            kaybedenlisteform2 = b;
            
                foreach (var item in a)
                {
                    dataGridView2.Rows.Add(item.ToArray());
                }
            foreach (var item in b)
            {
                dataGridView1.Rows.Add(item.ToArray());
            }
            

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
