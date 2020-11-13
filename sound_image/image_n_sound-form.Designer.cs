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
            this.target_picture = new System.Windows.Forms.PictureBox();
            this.Reload = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Shoot_Away = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.target_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // target_picture
            // 
            this.target_picture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.target_picture.BackgroundImage = global::sound_image.Properties.Resources.pointingun;
            this.target_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.target_picture.Location = new System.Drawing.Point(1, 5);
            this.target_picture.Name = "target_picture";
            this.target_picture.Size = new System.Drawing.Size(274, 318);
            this.target_picture.TabIndex = 0;
            this.target_picture.TabStop = false;
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.Black;
            this.Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reload.Location = new System.Drawing.Point(603, 120);
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
            this.Shoot.Location = new System.Drawing.Point(12, 343);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(108, 58);
            this.Shoot.TabIndex = 2;
            this.Shoot.Text = "Shoot on HEAD";
            this.Shoot.UseVisualStyleBackColor = false;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.Black;
            this.Spin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Spin.Location = new System.Drawing.Point(603, 223);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(108, 58);
            this.Spin.TabIndex = 5;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Shoot_Away
            // 
            this.Shoot_Away.BackColor = System.Drawing.Color.Black;
            this.Shoot_Away.BackgroundImage = global::sound_image.Properties.Resources.shoot;
            this.Shoot_Away.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Shoot_Away.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Shoot_Away.Location = new System.Drawing.Point(167, 343);
            this.Shoot_Away.Name = "Shoot_Away";
            this.Shoot_Away.Size = new System.Drawing.Size(108, 58);
            this.Shoot_Away.TabIndex = 3;
            this.Shoot_Away.Text = "Shoot Away";
            this.Shoot_Away.UseVisualStyleBackColor = false;
            this.Shoot_Away.Click += new System.EventHandler(this.Shoot_Away_Click);
            // 
            // image_n_sound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::sound_image.Properties.Resources.reload;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Shoot_Away);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.target_picture);
            this.Name = "image_n_sound";
            this.Text = "Images and Sound";
            this.Load += new System.EventHandler(this.image_n_sound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox target_picture;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Shoot_Away;
    }
}

