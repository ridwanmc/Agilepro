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
using System.Text.RegularExpressions;

namespace Agile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "insert into information values (@id, @name, @type, @dept,  @campany, @Age, @Gender, @category, @phone, @email, @date, @username, @password )";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@id", txtid.Text);
            obj.cmd.Parameters.AddWithValue("@name", txtname.Text);
            obj.cmd.Parameters.AddWithValue("@type", txttype.Text);
            obj.cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value.ToString());
            obj.cmd.Parameters.AddWithValue("@dept", txtdept.Text);
            obj.cmd.Parameters.AddWithValue("@email", txtemail.Text);
            obj.cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            obj.cmd.Parameters.AddWithValue("@Gender", txtcombo.Text);
            obj.cmd.Parameters.AddWithValue("@campany", txtcomname.Text);
            obj.cmd.Parameters.AddWithValue("@category", txtcat.Text);
            obj.cmd.Parameters.AddWithValue("@username", txtuser.Text);
            obj.cmd.Parameters.AddWithValue("@password", txtpass.Text);
            obj.cmd.Parameters.AddWithValue("@Age",      txtage.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("Data Saved Successfully");

            txtid.Text = " ";
            txtname.Text = " ";
            txttype.Text = " ";
            txtdept.Text = " ";
            txtemail.Text = " ";
            txtphone.Text = " ";
            txtcombo.Text = " ";
            txtcat.Text = " ";
            txtuser.Text = " ";
            txtpass.Text = " ";
            txtage.Text = " ";
            txtcomname.Text = " ";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
