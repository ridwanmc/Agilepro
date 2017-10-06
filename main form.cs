using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            employedash empdash = new employedash();
            empdash.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         //his.Hide();
            transfer2 trans = new transfer2();
           trans.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            achiev achie = new achiev();
            achie.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            promo pro = new promo();




            pro.Show();
        }


    }
}
