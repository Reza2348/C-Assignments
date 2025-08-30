using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_1
{
    
    public partial class Form1 : Form
    {
        string strConn = "Server=;" + "DataBase+MyTestDB" + "Integrated Security+True";
        SqlConnection sCon;
        SqlDataAdapter sda;
        DataSet dS;
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowRecords()
        {
            sCon = new SqlConnection();
            sCon.ConnectionString = strConn;
            sda = new SqlDataAdapter("Select * From Info", sCon);
            dS = new DataSet();
            sCon.Open();
            sda.Fill(dS, "table1");
            sCon.Close();
            dataGridView1.DataSource = dS;
            dataGridView1.DataMember = "table1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ShowRecords();
            dataGridView1.Columns[0].HeaderText = "شماره دانشجویی";
            dataGridView1.Columns[1].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[2].HeaderText = "نام";
            dataGridView1.Columns[3].HeaderText = "جنسیت";
            dataGridView1.Columns[4].HeaderText = "معدل";
            dataGridView1.Columns[5].HeaderText = "تعداد واحد";
        }
    }
}
