using System;
using System.Linq;
using System.Windows.Forms;

namespace GuestEaseHMS
{
    public partial class loginform : Form
    {
        private guesteaseEntities15 db;
        public loginform()
        {
            InitializeComponent();
            db= new guesteaseEntities15();

            usertypebox.Items.AddRange(new string[] { "Admin", "Receptionist" });
            usertypebox.SelectedIndex = 0;
            passwordtxt.UseSystemPasswordChar = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
           
            var username = usernametxt.Text;
            var password = passwordtxt.Text;
            var userType = usertypebox.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (userType == "Admin")
            {
                var datas = db.admins.FirstOrDefault(admin => admin.username == username && admin.password == password);
                if (datas != null)
                { 
                    this.Hide();
                    AdminDashboard admindash = new AdminDashboard();
                    admindash.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
                }
            }
            else if (userType == "Receptionist")
            {
                var datas = db.receptionistdetls.FirstOrDefault(receptionistdetl => receptionistdetl.r_username == username && receptionistdetl.r_password == password);
                if (datas != null)
                {
                   
                    this.Hide();
                   Receptionistdashboard receptiondash = new Receptionistdashboard();  
                    receptiondash.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
                }
            }
            else
            {
                MessageBox.Show("Invalid user type");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}