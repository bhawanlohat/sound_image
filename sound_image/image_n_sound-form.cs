using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sound_image
{
    public partial class image_n_sound : Form
    {
        int reload, spin, luck = 0;

        public image_n_sound()
        {
            InitializeComponent();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            reload = 1;
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.reload1);
            Sound_Object.Play();
            Spin.Enabled = true;
            Reload.Enabled = false;

        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.shoot1);
            Sound_Object.Play();
            if (reload == spin)
            {
                MessageBox.Show("You LOOSE the GAME ");
            }
            else if (spin == 6)
            {
                spin = 1;
            }
            else
            {
                spin++;
            }
        }

        private void Shoot_Away_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.shoot1);
            Sound_Object.Play();

            if (luck < 1)
            {
                if (reload == spin)//
                {
                    MessageBox.Show("You won the GAME");
                }
                else if (spin == 6)
                {
                    spin = 1;
                }
                else
                {
                    spin++;
                }
                luck++;

            }
            else
            {
                Shoot_Away.Enabled = false;
                MessageBox.Show("you loose GAME");
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PLAY_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Reload.Enabled = true;
            Shoot_Away.Enabled = false;
            Shoot.Enabled = false;
            Spin.Enabled = false;
            Exit.Enabled = true;
        }

        private void Spin_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.reload1);
            Sound_Object.Play();
            Random rnd = new Random();
            //spin = rnd.Next(1, 7);
            spin = 3;
            MessageBox.Show(spin.ToString());
            Shoot_Away.Enabled = true;
            Shoot.Enabled = true;
        }

        private void image_n_sound_Load(object sender, EventArgs e)
        {
            Shoot_Away.Enabled = false;
            Shoot.Enabled = false;
            Spin.Enabled = false;
            Reload.Enabled = false;
            PLAY.Enabled = true;
            Exit.Enabled = true;
        }
    }
}
