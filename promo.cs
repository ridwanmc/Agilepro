using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agile
{
    public partial class promo : Form
    {
        public promo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "insert into promotions values (@promotion, @forward, @title, @date, @approval, @discription,@note )";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@promotion", txtpromotion.Text);
            obj.cmd.Parameters.AddWithValue("@forward", txtforwardpro.Text);
            obj.cmd.Parameters.AddWithValue("@title", txttitlepro.Text);
            obj.cmd.Parameters.AddWithValue("@date", dateTimePicker1pro.Value.ToString());
            obj.cmd.Parameters.AddWithValue("@approval", txtapppro.Text);
            obj.cmd.Parameters.AddWithValue("@note", txtnotepro.Text);
            obj.cmd.Parameters.AddWithValue("@discription", txtrichpro.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("Data Saved Successfully");
           
        }

        private void promo_Load(object sender, EventArgs e)
        {

        }
    }
}
