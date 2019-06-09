using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NavdurgaHospital
{
    public partial class LoginPage : MaterialForm
    {
        bool isloginSuccessfull = false;
        public LoginPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this. = 0x200;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string sUsername, sPassword, Right;
            DataTable sRights;
            
            sUsername = textBox1.Text;
            sPassword = textBox2.Text;
            sRights = BLNavdurga.BLAddLoginDetails.CheckLoginType(sUsername, sPassword);


            if (textBox1.Text != String.Empty || textBox2.Text != String.Empty)
            {

                try
                {
                    if ("Doctor" == sRights.Rows[0]["Rights"].ToString())
                    {
                        DoctorsScreen doctScreen = new DoctorsScreen();
                        doctScreen.MdiParent = this.Owner;
                        doctScreen.Show();
                        isloginSuccessfull = true;
                        doctScreen.WindowState = FormWindowState.Maximized;
                        this.Close();
                    }

                    else if ("Staff" == sRights.Rows[0]["Rights"].ToString())
                    {
                        Staff_Screen staffScreen = new Staff_Screen();
                        staffScreen.MdiParent = this.Owner;
                        staffScreen.Show();
                        isloginSuccessfull = true;
                        staffScreen.WindowState = FormWindowState.Maximized;
                        this.Close();
                    }

                    else if ("Admin" == sRights.Rows[0]["Rights"].ToString())
                    {
                        Administrator adminScreen = new Administrator();
                        adminScreen.MdiParent = this.Owner;
                        adminScreen.Show();
                        isloginSuccessfull = true;
                        adminScreen.WindowState = FormWindowState.Maximized;
                        this.Close();
                    }
                    else if ("XRayRoom" == sRights.Rows[0]["Rights"].ToString())
                    {
                        XRayRoom xrayroom = new XRayRoom();
                        xrayroom.MdiParent = this.Owner;
                        xrayroom.Show();
                        isloginSuccessfull = true;
                        xrayroom.WindowState = FormWindowState.Maximized;
                        this.Close();
                    }


                }
                catch (Exception ex)
                {
                    var result = MessageBox.Show("Username Or Password is Wrong", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        textBox1.Text = String.Empty;
                        textBox2.Text = String.Empty;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                var result = MessageBox.Show("Username & Password Canot be Empty", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }


            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isloginSuccessfull == false)
                Application.Exit();
        }
    }
}
