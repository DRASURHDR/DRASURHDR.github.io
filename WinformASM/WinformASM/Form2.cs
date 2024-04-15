using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformASM
{
    public partial class Form2 : Form
    {
        private class Customer
        {
            public double Serial {  get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public double LastMR { get; set; }
            public double ThisMR { get; set; }
            public double Consumption { get; set; }
            public double TotalBill { get; set; }
            public double WaterRate { get; set; }
            
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txb_S_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_N_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_ToC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_ThisMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_LastMR_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txb_N.Text;
            customer.Type = cb_Type.Text;
            customer.LastMR = double.Parse(txb_LastMR.Text);
            customer.ThisMR = double.Parse(txb_LastMR.Text);
            customer.Serial = double.Parse(txb_S.Text);
            double TotalBill = customer.TotalBill;
            double waterRate = customer.WaterRate;
            //combo box
            string CustomerType = cb_Type.Text;
            switch (CustomerType)
            {
                case "HouseHold":
                    // Household
                    MessageBox.Show("Below is the price list for Household");
                    MessageBox.Show("To 10 m3/people/month is 5.973 VND/m3 and fees is 10%");
                    MessageBox.Show("From 10-20 m3/people/month is 7.052 VND/m3 and fees is 10%");
                    MessageBox.Show("From 20-30 m3/people/month is 8.699 VND/m3 and fees is 10%");
                    MessageBox.Show("Over 30 m3/people/month is 15.929 VND/m3 and fees is 10%");
                    waterRate = 0.0;
                    break;
                case "Admin":
                    // Administrative agency or public services
                    MessageBox.Show("Below is the price list for Administrative agency or public services");
                    MessageBox.Show("9.955 VND/m3 and fees is 10%");
                    waterRate = 9.955;
                    break;
                case "Product":
                    // Production units
                    MessageBox.Show("Below is the price list for Production units");
                    MessageBox.Show("11.615 VND/m3 and fees is 10%");
                    waterRate = 11.615;
                    break;
                case "Business":
                    // Business
                    MessageBox.Show("Below is the price list for Business");
                    MessageBox.Show("22.068 VND/m3 and fees is 10%");
                    waterRate = 22.068;
                    break;
            }
            

            customer.Consumption = customer.ThisMR - customer.LastMR;

            double Consumption = customer.Consumption;
            // Method to calculate water bill according to steps
            double rate1 = 5.073;
            double rate2 = 7.052;
            double rate3 = 8.699;
            double rate4 = 15.929;
            if (cb_Type.Text == "HouseHold")
            {
                if (Consumption> 0 && Consumption <= 10)

                {
                    TotalBill = Consumption * rate1 + Consumption * rate1 * 0.1;
                }
                else if (Consumption <= 20)
                {
                    TotalBill = Consumption * rate2 + Consumption * rate2 * 0.1;
                }
                else if (Consumption <= 30)
                {
                    TotalBill = Consumption * rate3 + Consumption * rate3 * 0.1;
                }
                else
                {
                    TotalBill = Consumption * rate4 + Consumption * rate4 * 0.1;
                }
            }
            else
            {
                TotalBill = Consumption * customer.WaterRate + Consumption * customer.WaterRate * 0.1;
            }
            double Bill = TotalBill;
            ListViewItem item = new ListViewItem();
            item.Text = customer.Name;
            //add the new customer to the list
            item.SubItems.Add(customer.Serial + "");
            item.SubItems.Add(customer.Name);
            item.SubItems.Add(customer.Type);
            item.SubItems.Add(customer.ThisMR + "");
            item.SubItems.Add(customer.LastMR + "");
            item.SubItems.Add(customer.TotalBill + "");
            //test case
            MessageBox.Show($"{Bill}");
            
        }

        private void cb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lsv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
