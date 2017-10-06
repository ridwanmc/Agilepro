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
    public partial class achiev : Form
    {
        public achiev()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "insert into achievements values (@employee, @forward, @title, @date, @approval, @discription,@note )";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@employee", txtemployeeach.Text);
            obj.cmd.Parameters.AddWithValue("@forward", txtforwardach.Text);
            obj.cmd.Parameters.AddWithValue("@title", txttitleach.Text);
            obj.cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
            obj.cmd.Parameters.AddWithValue("@approval", txtapprovalach.Text);
            obj.cmd.Parameters.AddWithValue("@note", txtnoteach.Text);
            obj.cmd.Parameters.AddWithValue("@discription", richboxach.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("Data Saved Successfully");
           


        }

        private void achiev_Load(object sender, EventArgs e)
        {

        }
    }
}
