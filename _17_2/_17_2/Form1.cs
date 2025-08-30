using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strConn = "Server =.;" + "DataBase = MyTestDB;" + "Intgrated Security = true";
        string strDA = "Select* Form Info";
        SqlConnection sCon;
        SqlDataAdapter sda;
        DataSet ds;
        DataView dv;
        CurrencyManager Cm;
        private void FillDataSet()
        {
            sCon = new SqlConnection();
            sCon.ConnectionString = strConn;
            sda = new SqlDataAdapter(strDA, sCon);
            ds = new DataSet();
            sCon.Open();
            sda.Fill(ds, "table1");
            sCon.Close();
            dv = new DataView();
            dv.Table = ds.Tables["table1"];
            Cm = (CurrencyManager)this.BindingContext[dv];
        }
        private void BindFields()
        {
            textBox1.DataBindings.Add(new Binding("Text", dv, "Student_Number"));
            textBox2.DataBindings.Add(new Binding("Text", dv, "Last_Name"));
            textBox3.DataBindings.Add(new Binding("Text", dv, "First_Name"));
            checkBox1.DataBindings.Add(new Binding("Checked", dv, "Sex"));
            textBox4.DataBindings.Add(new Binding("Text", dv, "Average"));
            textBox5.DataBindings.Add(new Binding("Text", dv, "Number_of_Unit"));
        }
        private void ShowPosition()
        {
            if (Cm.Count == 0)
                label8.Text = "No Record";
            else
                label8.Text = (Cm.Position + 1) + "of" + Cm.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cm.Position = 0;
            ShowPosition();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cm.Position += 1;
            ShowPosition();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cm.Position -= 1;
            ShowPosition();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cm.Position = Cm.Count - 1;
            ShowPosition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataSet();
            BindFields();
            ShowPosition();
        }
        

    }
}
