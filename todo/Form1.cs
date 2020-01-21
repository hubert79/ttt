using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int licznik = 1;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriptionRB.Text) == true
                || string.IsNullOrEmpty(prcb.Text) == true )
            {
                MessageBox.Show("uzupelnij wszystkie pola");
            }
            else
            {

            switch (licznik)
            {
                case 1:
                    tb1.Text = licznik.ToString();
                    p1.Text = prcb.Text;
                    d1.Text = descriptionRB.Text;
                    break;
                case 2:
                    id2.Text = licznik.ToString();
                    p2.Text = prcb.Text;
                    d2.Text = descriptionRB.Text;
                    break;
                case 3:
                    id3.Text = licznik.ToString();
                    p3.Text = prcb.Text;
                    d3.Text = descriptionRB.Text;
                    break;
                case 4:
                    id4.Text = licznik.ToString();
                    p4.Text = prcb.Text;
                    d4.Text = descriptionRB.Text;
                    break;
                case 5:
                    id5.Text = licznik.ToString();
                    p5.Text = prcb.Text;
                    d5.Text = descriptionRB.Text;
                    break;
                case 6:
                    id6.Text = licznik.ToString();
                    p6.Text = prcb.Text;
                    d6.Text = descriptionRB.Text;
                    break;
                case 7:
                    id7.Text = licznik.ToString();
                    p7.Text = prcb.Text;
                    d7.Text = descriptionRB.Text;
                    break;
                case 8:
                    id8.Text = licznik.ToString();
                    p8.Text = prcb.Text;
                    d8.Text = descriptionRB.Text;
                    break;
                case 9:
                    id9.Text = licznik.ToString();
                    p9.Text = prcb.Text;
                    d9.Text = descriptionRB.Text;
                    break;
                case 10:
                    id10.Text = licznik.ToString();
                    p10.Text = prcb.Text;
                    d10.Text = descriptionRB.Text;
                    break;
                case 11:
                    MessageBox.Show("Za duzo zadan");
                    break;
                }


            descriptionRB.Text = "";
            prcb.Text = "";
            
            if(licznik < 11)
            {
                licznik++;
            }
            }
        }

       

        public void cb(CheckBox c, TextBox id, TextBox p, TextBox d)
        {
            if (c.Checked == true)
            {
                id.Text = "";
                p.Text = "";
                d.Text = "";
                c.Checked = false;
                licznik--;
                
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
                cb(checkBox1, tb1, p1, d1);

            if (checkBox2.Checked == true)
                cb(checkBox2, id2, p2, d2);

            if (checkBox3.Checked == true)
                cb(checkBox3, id3, p3, d3);

            if (checkBox4.Checked == true)
                cb(checkBox4, id4, p4, d4);

            if (checkBox5.Checked == true)
                cb(checkBox5, id5, p5, d5);

            if (checkBox6.Checked == true)
                cb(checkBox6, id6, p6, d6);

            if (checkBox7.Checked == true)
                cb(checkBox7, id7, p7, d7);

            if (checkBox8.Checked == true)
                cb(checkBox8, id8, p8, d8);

            if (checkBox9.Checked == true)
                cb(checkBox9, id9, p9, d9);

            if (checkBox10.Checked == true)
                cb(checkBox10, id10, p10, d10);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
