using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signin_signup_form_sliding_up_down
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guna2TextBox1_Enter(object sender, EventArgs e)
        {
            guna2TextBox1.IconLeft = Properties.Resources.icons8_person_128px;
        }

        private void Guna2TextBox1_Leave(object sender, EventArgs e)
        {
            guna2TextBox1.IconLeft = Properties.Resources.icons8_person_128px_1;
        }

        private void Guna2TextBox2_Enter(object sender, EventArgs e)
        {
            guna2TextBox2.IconLeft = Properties.Resources.icons8_key_32px_1;
        }

        private void Guna2TextBox2_Leave(object sender, EventArgs e)
        {
            guna2TextBox2.IconLeft = Properties.Resources.icons8_key_32px;

        }
        int waiter = 0, panel_y = 382;

        private void Form1_Load(object sender, EventArgs e)
        {
            loginpanel.Size = new Size(loginpanel.Size.Width, panel_y);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            waiter++;
            if(waiter>50)
            {
                panel_y -= 10;
                loginpanel.Size = new Size(loginpanel.Size.Width, panel_y);
                if(panel_y<10)
                {
                    timer1.Enabled = false;
                    waiter = 0;
                    lblLogin.Visible = true;
                }
            }
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 50)
            {
                panel_y += 10;
                loginpanel.Size = new Size(loginpanel.Size.Width, panel_y);
                if (panel_y > 380)
                {
                    timer2.Enabled = false;
                    waiter = 0;
                    lblLogin.Visible = false;
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
