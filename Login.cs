using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Color curColour { get; set; }
        int r = 255, g=0, b=0;
        bool registerTab = false;
        bool loginTab = true;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RegisterTab_Click(object sender, EventArgs e)
        {
            registerTab = true;
            loginTab = false;
        }

        private void LoginTab_Click(object sender, EventArgs e)
        {
            registerTab = false;
            loginTab = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            curColour = Color.FromArgb(r, g, b);
            guna2Panel1.BorderColor = curColour;
            if (registerTab)
            {
                RegisterButtonBar.BackColor = curColour;
                RegisterTab.ForeColor = curColour;
            }
            else
            {
                RegisterButtonBar.BackColor = Color.FromArgb(15, 15, 15);
                RegisterTab.ForeColor = Color.White;
            }
            if (loginTab)
            {
                LoginButtonBar.BackColor = curColour;
                LoginTab.ForeColor = curColour;
            }
            else
            {
                LoginButtonBar.BackColor = Color.FromArgb(15, 15, 15);
                LoginTab.ForeColor = Color.White;
            }
            if(r > 0 && b == 0)
            {
                r -= 5;
                g += 5;
            }
            if (g > 0 && r == 0)
            {
                g -= 5;
                b += 5;
            }
            if (b > 0 && g == 0)
            {
                b -= 5;
                r += 5;
            }
        }
    }
}
