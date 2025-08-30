using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_4
{
    public partial class Form1 : Form
    {
        private float a;
        private float b;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userNam = textBox1.Text;
            string passWord = textBox2.Text;

            if (userNam == "Amier.reza" && passWord == "123456")
            {
                this.Hide();
                new Form2().Show();
                MessageBox.Show("Admin");
            }
            if (userNam == "Ali" && passWord == "156547")
            {
                this.Hide();
                new Form2().Show();
                MessageBox.Show("مدیر وارد شود");
            }
            if (userNam == "amin" && passWord == "156547")
            {
                this.Hide();
                new Form2().Show();
                MessageBox.Show("کارمند وارد شود");
            }
            if (userNam == "ami" && passWord == "156547")
            {
                this.Hide();
                new Form2().Show();
                MessageBox.Show("حسابدار وارد شود");
            }
            else
            {
                i++;
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.RightToLeft = true;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            this.Font = new Font("Tahoma", 10);
            this.Text = "فرم ورورد به برنامه";
            label1.RightToLeft = RightToLeft.Yes;
            label2.RightToLeft = RightToLeft.Yes;
            label1.Text = "نام کاربری";
            label2.Text = "رمز عبور";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Text = "ورورد به برنامه";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Text = "خروج از برنامه";
            textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("آیا مایل به خروج هستید ", "eror", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            Application.Exit();
        }
    }
}
