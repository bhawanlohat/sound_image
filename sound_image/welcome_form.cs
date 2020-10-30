using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sound_image
{
    public partial class welcome_form : Form
    {
        public welcome_form()
        {
            InitializeComponent();
        }

        private void PLAY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            image_n_sound img_obj = new image_n_sound();
            img_obj.Show();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
