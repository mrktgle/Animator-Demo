using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animator_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 60)
            {
                //EXPAND
                // 1. Expand panel , w = 260
                // 2. Show logo
                sidemenu.Visible = false;
                btnMenu.Location = new Point(209, 18);
                sidemenu.Width = 260;
                PanelAnimator.ShowSync(sidemenu);
                LogoAnimator.ShowSync(logo);
            }

            else {
                //MINIMIZE
                // 1. Hide Logo
                // 2. Slide the panel , w = 50
                LogoAnimator.Hide(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 60;
                PanelAnimator.ShowSync(sidemenu);
                btnMenu.Location = new Point(7, 18);
            }

        }

        private void mouseHoverEnterBtnMenu(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            btnMenu.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void mouseHoverExitBtnMenu(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            btnMenu.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void mouseHoverEnterHome(object sender, EventArgs e) {
            Cursor.Current = Cursors.Hand;
            btnHome.BackColor = Color.FromArgb(0, 102, 204);
            PicHome.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void mouseHoverExitHome(object sender, EventArgs e) {
            Cursor.Current = Cursors.Hand;
            btnHome.BackColor = Color.FromArgb(26, 32, 40);
            PicHome.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void mouseHoverEnterSettings(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            btnSettings.BackColor = Color.FromArgb(0, 102, 204);
            PicSettings.BackColor = Color.FromArgb(0, 102, 204);
        }

        private void mouseHoverExitSettings(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            btnSettings.BackColor = Color.FromArgb(26, 32, 40);
            PicSettings.BackColor = Color.FromArgb(26, 32, 40);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
