using GuestEaseHMS.adminusercontrol;
using System;
using System.Windows.Forms;

namespace GuestEaseHMS
{
    public partial class Receptionistdashboard : Form
    {
        public Receptionistdashboard()
        {
            InitializeComponent();
        }
        public void registercust(UserControl adcustomer)
        {
            adcustomer.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(adcustomer);
            adcustomer.BringToFront();
        }
        public void custdetails(UserControl custdetail)
        {
            custdetail.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(custdetail);
            custdetail.BringToFront();
        }
        public void reservdetails(UserControl reservdetail)
        {
            reservdetail.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(reservdetail);
            reservdetail.BringToFront();
        }
        public void billingdetails(UserControl billing)
        {
            billing.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(billing);
            billing.BringToFront();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            registercust(new adcustomer());
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            adcustomer adCustomer=new adcustomer();
            adCustomer.Dock = DockStyle.Fill;
            panel1.Controls.Add(adCustomer);
        }

        private void custdetailsbtn_Click(object sender, EventArgs e)
        {
            custdetails(new custdetail());
        }

        private void reservationdetbtn_Click(object sender, EventArgs e)
        {
            reservdetails(new reservdetail());
        }

        private void billingbtn_Click(object sender, EventArgs e)
        {
            billingdetails(new billing());
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            this.Hide();
            loginform.Show();
        }
    }
}
