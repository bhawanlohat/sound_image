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

namespace sound_image//project name
{
    public partial class image_n_sound : Form// from name 
    {
        logicalclass logical_obj = new logicalclass();// creating object
        private object logic_obj;

        public image_n_sound()
        {
            InitializeComponent();
        }

        private void Reload_Click(object sender, EventArgs e)//code when user click the button reload
        {
            logical_obj.Reload_chamber();
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.reload1);
            Sound_Object.Play();//this code is to add sound & images 
            Spin.Enabled = true;//user able to access this button
            Reload.Enabled = false;//user not able to access this button

        }

        private void Shoot_Click(object sender, EventArgs e)//when user will click the shoot button
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.shoot1);
            Sound_Object.Play();// this code is to upload images and sound
            if (logical_obj.shoot_bullet() == 0) // shoot_bullet will check the object of logical class  value and then give the out put
            {
                MessageBox.Show("TRY your LUCK next time");//when the value is equal to zero then this message shown on screen
            }
            else
            {
                MessageBox.Show("empty fire");// when the value of object is not equal to zero
            }
        }

        private void Shoot_Away_Click(object sender, EventArgs e)//action when button will click
        {
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.shoot1);
            Sound_Object.Play();//code for images and sound upload
            if (logical_obj.luck < 2)// user can shoot away two times only
            {
                if (logical_obj.shoot == 0)//check value of logical object shoot 
                {
                    MessageBox.Show("You won the game");//when equal to zero  then user will won the game
                    Shoot.Enabled = false;//user not able to access this button
                    Shoot_Away.Enabled = false; //user not able to access this button
                }
                else
                {
                    logical_obj.luck++;// increment the value of luck by 1
                    if (logical_obj.luck == 2)
                    {
                        MessageBox.Show("TRY your LUCK one more time");//show the message as a string 
                        Shoot.Enabled = false;//user not able to access this button
                        Shoot_Away.Enabled = false;//user not able to access this button
                    }
                    else
                    {
                        MessageBox.Show("miss fire");//show the message on screen as a string
                    }
                }
            }


        }

        private void Exit_Click(object sender, EventArgs e)// code when click exit button
        {
            Application.Exit();//this code will help user to close the application
        }

        private void PLAY_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Reload.Enabled = true;//user able to access this button
            Shoot_Away.Enabled = false;//user not able to access this button
            Shoot.Enabled = false;//user not able to access this button
            Spin.Enabled = false;//user not able to access this button

        }

        private void Spin_Click(object sender, EventArgs e)//code when button  click
        {

            MessageBox.Show(logical_obj.spin_chamber().ToString());//this code will show the spin number on screen with the help string function
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(sound_image.Properties.Resources.reload1);
            Sound_Object.Play();//code to upload images and sound
            Shoot_Away.Enabled = true;//user able to access this button
            Shoot.Enabled = true;//user  able to access this button
        }

        private void image_n_sound_Load(object sender, EventArgs e)
        {
            Shoot_Away.Enabled = false;//user not able to access this button
            Shoot.Enabled = false;//user not able to access this button
            Spin.Enabled = false;//user not able to access this button
            Reload.Enabled = true;//user able to access this button
        }
    }
}
