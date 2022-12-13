using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TugmaProject
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("bgMusic.wav");
            soundPlayer.PlayLooping();
            //remove windows border
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
            if (WindowState == FormWindowState.Normal)
            {
                pic_Loonie.Visible = false;
            }
        }

        //automatically click rhyme button
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.btn_rhyme_Click(null, null);
        }
        //for opening forms
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if ( activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
        }

        private void btn_rhyme_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRhyme(), sender);
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormWrite(), sender);
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRandom(), sender);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                pic_Loonie.Visible = true;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                pic_Loonie.Visible = false;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
