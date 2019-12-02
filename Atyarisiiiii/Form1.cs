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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int at1, at2, at3, at4, at5, at6;
        string Ad;
        string Para;
        public int[] uret;
        public int sayi;
        public int sayac = 0;
        List<List<string>> kuponlar = new List<List<string>>();
        List<List<string>> kazananlar = new List<List<string>>();
        List<List<string>> kaybedenler = new List<List<string>>();
        List<string> galipliste = new List<string>();
       

        private void Form1_Load(object sender, EventArgs e)
        {
            at1 = pictureBox1.Left;
            at2 = pictureBox2.Left;
            at3 = pictureBox3.Left;
            at4 = pictureBox4.Left;
            at5 = pictureBox5.Left;
            at6 = pictureBox6.Left;

            
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            comboBox1.Items.Add("Oymapınar");
            comboBox1.Items.Add("BoldPilot");
            comboBox1.Items.Add("Erbatur");
            comboBox1.Items.Add("Şahcivan");
            comboBox1.Items.Add("Saffet");
            comboBox1.Items.Add("Arslanbey");
            comboBox2.Items.Add("Oymapınar");
            comboBox2.Items.Add("BoldPilot");
            comboBox2.Items.Add("Erbatur");
            comboBox2.Items.Add("Şahcivan");
            comboBox2.Items.Add("Saffet");
            comboBox2.Items.Add("Arslanbey");
            comboBox3.Items.Add("Oymapınar");
            comboBox3.Items.Add("BoldPilot");
            comboBox3.Items.Add("Erbatur");
            comboBox3.Items.Add("Şahcivan");
            comboBox3.Items.Add("Saffet");
            comboBox3.Items.Add("Arslanbey");
            comboBox4.Items.Add("Oymapınar");
            comboBox4.Items.Add("BoldPilot");
            comboBox4.Items.Add("Erbatur");
            comboBox4.Items.Add("Şahcivan");
            comboBox4.Items.Add("Saffet");
            comboBox4.Items.Add("Arslanbey");
            comboBox5.Items.Add("Oymapınar");
            comboBox5.Items.Add("BoldPilot");
            comboBox5.Items.Add("Erbatur");
            comboBox5.Items.Add("Şahcivan");
            comboBox5.Items.Add("Saffet");
            comboBox5.Items.Add("Arslanbey");
            comboBox6.Items.Add("Oymapınar");
            comboBox6.Items.Add("BoldPilot");
            comboBox6.Items.Add("Erbatur");
            comboBox6.Items.Add("Şahcivan");
            comboBox6.Items.Add("Saffet");
            comboBox6.Items.Add("Arslanbey");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciat = pictureBox1.Width;
            int bitis = label7.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(1, 16);
            if (birinciat + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                listBox1.Items.Add("Oymapınar");
                galipliste.Add("Oymapınar");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int ikinciat = pictureBox2.Width;
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(1, 16);
            int bitis = label7.Left;
            if (ikinciat + pictureBox2.Left >= bitis)
            {
                timer2.Enabled = false;
                listBox1.Items.Add("BoldPilot");
                galipliste.Add("BoldPilot");

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int ucuncuat = pictureBox3.Width;
            int bitis = label7.Left;
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(1, 16);
            if (ucuncuat + pictureBox3.Left >= bitis)
            {
                timer3.Enabled = false;
                listBox1.Items.Add("Erbatur");
                galipliste.Add("Erbatur");
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int dorduncuat = pictureBox4.Width;
            int bitis = label7.Left;
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(1, 16);
            if (dorduncuat + pictureBox4.Left >= bitis)
            {
                timer4.Enabled = false;
                listBox1.Items.Add("Şahcivan");
                galipliste.Add("Şahcivan");
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int besinciat = pictureBox5.Width;
            int bitis = label7.Left;
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(1, 16);
            if (besinciat + pictureBox5.Left >= bitis)
            {
                timer5.Enabled = false;
                listBox1.Items.Add("Saffet");
                galipliste.Add("Saffet");
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int altinciat = pictureBox6.Width;
            int bitis = label7.Left;
            pictureBox6.Left = pictureBox5.Left + rastgele.Next(1, 16);
            if (altinciat + pictureBox6.Left >= bitis)
            {
                timer6.Enabled = false;
                listBox1.Items.Add("Arslanbey");
                galipliste.Add("Arslanbey");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Ad = textBox1.Text;
            Para = textBox2.Text;
            string[] liste = new string[] { Ad, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, Para };
             dataGridView1.Rows.Add(liste);


            List<string> bahis= new List<string>();
            int kat;
            kat = 6 * Convert.ToInt32(textBox2.Text);
            bahis.Add(textBox1.Text);
            bahis.Add(comboBox1.SelectedItem.ToString());
            bahis.Add(comboBox2.SelectedItem.ToString());
            bahis.Add(comboBox3.SelectedItem.ToString());
            bahis.Add(comboBox4.SelectedItem.ToString());
            bahis.Add(comboBox5.SelectedItem.ToString());
            bahis.Add(comboBox6.SelectedItem.ToString());
            bahis.Add(textBox2.Text);
            bahis.Add(kat.ToString());
            kuponlar.Add(bahis);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            foreach (var item in kuponlar)
            {
                var ff = item.ToArray();
                dataGridView1.Rows.Add(ff);
            }
           
        }

        Random rastgele = new Random();

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var item in kuponlar)
            {
                List<string> kk = new List<string>();

                for (int i = 1; i < 7; i++)
                {
                    kk.Add(item[i]);

                }

                var galipliste = kazananlar.Except(kazananlar);
                if (galipliste.Count() >= 0)
                {
                    kazananlar.Add(item);
                }
                else if (galipliste.Count() <= 0)
                    {
                    kaybedenler.Add(item);
                }
                //if ((galipliste[0] == kk[0]) && (galipliste[1] == kk[1]) && (galipliste[2] == kk[2]) && (galipliste[3] == kk[3]) && (galipliste[4] == kk[4]) && (galipliste[5] == kk[5]) && (galipliste[6] == kk[6]))
                //{
                //    kazananlar.Add(item);
                //}
                //else if ((galipliste[0] != kk[0]) && (galipliste[1] != kk[1]) && (galipliste[2] != kk[2]) && (galipliste[3] != kk[3]) && (galipliste[4] != kk[4]) && (galipliste[5] != kk[5]) && (galipliste[6] != kk[6]))
                //{
                //    kaybedenler.Add(item);
                //}

                Form2 frm = new Form2(kazananlar, kaybedenler);
                frm.Show();


            }



            //foreach (var item in kuponlar)
            //{
            //    
            //    //List<string> kazananlar1 = new List<string>();
            //    var b = item.ToArray();
            //    for (int i = 1; i < 7; i++)
            //    {
            //        kazananlar1.Add(b[i]);
            //        kat = 100 / Convert.ToInt32(textBox2.Text);
            //    }
            //    var kuponyapan = kazananlar1.Except(kazananlar1);
            //    if (kuponyapan.Count() > 0)
            //    {
            //        data2.Add(item);
            //    }
            //    else
            //    {
            //        data1.Add(item);
            //    }


            //}
            //Form ff = new Form2(data2, data1);

            //ff.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            pictureBox1.Location = new Point(16, 2);
            pictureBox2.Location = new Point(16, 124);
            pictureBox3.Location = new Point(16, 245);
            pictureBox4.Location = new Point(16, 361);
            pictureBox5.Location = new Point(16, 476);
            pictureBox6.Location = new Point(16, 592);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox3.Text);
            uret = new int[sayi];
            Random rdn = new Random();
            List<string> İsimler = new List<string> { "Nagihan", "Neslihan", "Ebru", "Elif","Alper","Kerem","Selin","Belen","Oğuz","Buğra","Eyüpcan","Merve","Hakkı","Anıl","Hakan" };

            for (int i = 0; i < sayi; i++)
            {
                List<string> bahisler = new List<string>();
                bahisler.Add(İsimler[rdn.Next(0, 15)]);
                

                for (int n = 0; n <6; n++)
                {
                    int a = rdn.Next(0, 6);
                    switch (a)
                    {
                        case 0:
                            {
                                bahisler.Add(Atlar.Oymapınar.ToString());
                            }
                            break;
                        case 1:
                            {
                                bahisler.Add(Atlar.BoldPilot.ToString());
                            }
                            break;
                        case 2:
                            {
                                bahisler.Add(Atlar.Erbatur.ToString());
                                    }
                            break;
                            
                        case 3:
                            {
                                bahisler.Add(Atlar.Şahcivan.ToString());
                                }
                            break;
                            
                        case 4:
                            {
                                bahisler.Add(Atlar.Saffet.ToString());
                            }
                            break;
                            
                        case 5:
                            { bahisler.Add(Atlar.Arslanbey.ToString());
                            }
                            break;
                        default:
                            break;
                    }
                }
                bahisler.Add(rdn.Next(1, 100).ToString());
                bahisler.Add(rdn.Next(1, 500).ToString());
                kuponlar.Add(bahisler);

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form3 aa = new Form3();
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            if (radioButton2.Checked == true)
            {
                this.BackColor = Color.OliveDrab;
            }
            else
            {
                this.BackColor = Color.Khaki;
            }
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        enum Atlar
        {
            Oymapınar, BoldPilot, Erbatur, Şahcivan, Saffet, Arslanbey
        }
        
    }
}
