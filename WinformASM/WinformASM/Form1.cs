using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformASM
{
    public partial class Form1 : Form
    {
        string ID = "Admin";
        string MK = "Admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_Password_Click(object sender, EventArgs e)
        {

        }

        private void d_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void d_Login_Click(object sender, EventArgs e)
        {
            if (ID == tb_ID.Text && MK == tb_MK.Text)
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai ID hoac MK");
            }
            
        }

        private void fc_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lb_ID_Click(object sender, EventArgs e)
        {

        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_MK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
