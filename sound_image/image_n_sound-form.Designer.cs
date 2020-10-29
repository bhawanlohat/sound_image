namespace sound_image
{
    partial class image_n_sound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(image_n_sound));
            this.target_picture = new System.Windows.Forms.PictureBox();
            this.Reload = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Spin = new System.Windows.Forms.Button();
            this.PLAY = new System.Windows.Forms.Button();
            this.Shoot_Away = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.target_picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // target_picture
            // 
            this.target_picture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.target_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("target_picture.BackgroundImage")));
            this.target_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.target_picture.Location = new System.Drawing.Point(0, -1);
            this.target_picture.Name = "target_picture";
            this.target_picture.Size = new System.Drawing.Size(463, 342);
            this.target_picture.TabIndex = 0;
            this.target_picture.TabStop = false;
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.Black;
            this.Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reload.Location = new System.Drawing.Point(12, 33);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(108, 58);
            this.Reload.TabIndex = 1;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Shoot
            // 
            this.Shoot.BackColor = System.Drawing.Color.Black;
            this.Shoot.BackgroundImage = global::sound_image.Properties.Resources.shoot;
            this.Shoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Shoot.ForeColor = System.Drawing.Color.White;
            this.Shoot.Location = new System.Drawing.Point(141, 33);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(115, 58);
            this.Shoot.TabIndex = 2;
            this.Shoot.Text = "Shoot";
            this.Shoot.UseVisualStyleBackColor = false;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = global::sound_image.Properties.Resources.halloween;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Spin);
            this.panel1.Controls.Add(this.Shoot_Away);
            this.panel1.Controls.Add(this.Shoot);
            this.panel1.Controls.Add(this.Reload);
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 105);
            this.panel1.TabIndex = 3;
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.Black;
            this.Spin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Spin.Location = new System.Drawing.Point(414, 33);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(140, 58);
            this.Spin.TabIndex = 5;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // PLAY
            // 
            this.PLAY.BackgroundImage = global::sound_image.Properties.Resources.reload;
            this.PLAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PLAY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PLAY.Location = new System.Drawing.Point(534, 42);
            this.PLAY.Name = "PLAY";
            this.PLAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PLAY.Size = new System.Drawing.Size(228, 105);
            this.PLAY.TabIndex = 4;
            this.PLAY.Text = "PLAY";
            this.PLAY.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PLAY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PLAY.UseVisualStyleBackColor = true;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click);
            // 
            // Shoot_Away
            // 
            this.Shoot_Away.BackColor = System.Drawing.Color.Black;
            this.Shoot_Away.BackgroundImage = global::sound_image.Properties.Resources.shoot;
            this.Shoot_Away.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shoot_Away.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Shoot_Away.Location = new System.Drawing.Point(272, 33);
            this.Shoot_Away.Name = "Shoot_Away";
            this.Shoot_Away.Size = new System.Drawing.Size(114, 58);
            this.Shoot_Away.TabIndex = 3;
            this.Shoot_Away.Text = "Shoot Away";
            this.Shoot_Away.UseVisualStyleBackColor = false;
            this.Shoot_Away.Click += new System.EventHandler(this.Shoot_Away_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(587, 37);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(140, 54);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // image_n_sound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PLAY);
            this.Controls.Add(this.target_picture);
            this.Name = "image_n_sound";
            this.Text = "Images and Sound";
            this.Load += new System.EventHandler(this.image_n_sound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox target_picture;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.Button Shoot_Away;
        private System.Windows.Forms.Button Exit;
    }
}

