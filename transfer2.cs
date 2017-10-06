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
    public partial class transfer2 : Form
    {
        public transfer2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Myconnection obj = new Myconnection();
            obj.con.Open();
            obj.qry = "insert into transfer values (@employeetransfer, @forward, @title, @date, @approval, @discription,@note )";
            obj.cmd = new SqlCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@employeetransfer", txttransfer.Text);
            obj.cmd.Parameters.AddWithValue("@forward", txtforwardtra.Text);
            obj.cmd.Parameters.AddWithValue("@title", txttitletra.Text);
            obj.cmd.Parameters.AddWithValue("@date", dateTimePicker1tra.Value.ToString());
            obj.cmd.Parameters.AddWithValue("@approval", txtapprovaltra.Text);
            obj.cmd.Parameters.AddWithValue("@note", txtnotetra.Text);
            obj.cmd.Parameters.AddWithValue("@discription",txtdisctra.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("Data Saved Successfully");
           
        }

        private void txttransfer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdisctra_TextChanged(object sender, EventArgs e)
        {

        }

        private void transfer2_Load(object sender, EventArgs e)
        {

        }
        public class Myconnection
        {
            public SqlConnection con = new SqlConnection("Data Source=DESKTOP-RSCOCVD;Initial Catalog=agile;Integrated Security=True");
            public SqlCommand cmd = new SqlCommand();
            public SqlDataReader dr;
            public string qry;


        }
    }
}
