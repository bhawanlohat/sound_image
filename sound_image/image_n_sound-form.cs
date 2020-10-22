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
    public partial class image_n_sound : Form
    {
        public image_n_sound()
        {
            InitializeComponent();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.reload1);
            Sound_Object.Play();
            Spin.Enabled = true;
            Reload.Enabled = false;

        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.shoot1);
            Sound_Object.Play();
        }

        private void Shoot_Away_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.shoot1);
            Sound_Object.Play();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.reload1);
            Sound_Object.Play();
        }

        private void image_n_sound_Load(object sender, EventArgs e)
        {

        }
    }
}
