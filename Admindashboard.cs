using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestEaseHMS.adminusercontrol;
namespace GuestEaseHMS
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void addUser(UserControl Adreceptionist)
        {
            Adreceptionist.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(Adreceptionist);
            Adreceptionist.BringToFront();
        }
        private void addRooms(UserControl Adroom)
        {
            Adroom.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(Adroom);
            Adroom.BringToFront();
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Adreceptionist adreceptionist   = new Adreceptionist();
           adreceptionist.Dock = DockStyle.Fill;
            panel1.Controls.Add(adreceptionist);


        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Adroom adroom = new Adroom();
            adroom.Dock = DockStyle.Fill;
            panel1.Controls.Add(adroom);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Adreceptionist res2 = new Adreceptionist();
            res2.Dock = DockStyle.Fill;
            panel1.Controls.Add(res2);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform login = new loginform();
            login.Show();
        }
    }
}
