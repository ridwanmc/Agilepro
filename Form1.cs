using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;
using System.Data.SqlClient;
namespace Agile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet5.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter5.Fill(this.dashboardDataSet5.information);
            // TODO: This line of code loads data into the 'dashboardDataSet4.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter4.Fill(this.dashboardDataSet4.information);
            // TODO: This line of code loads data into the 'dashboardDataSet3.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter3.Fill(this.dashboardDataSet3.information);
            // TODO: This line of code loads data into the 'dashboardDataSet2.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter2.Fill(this.dashboardDataSet2.information);
            // TODO: This line of code loads data into the 'dashboardDataSet1.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter1.Fill(this.dashboardDataSet1.information);
            // TODO: This line of code loads data into the 'dashboardDataSet.information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.dashboardDataSet.information);

        }
    }
    public class Myconnection
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-RSCOCVD;Initial Catalog=agile;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public string qry;


    }
}
