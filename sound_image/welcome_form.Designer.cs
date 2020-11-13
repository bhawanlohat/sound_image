namespace sound_image
{
    partial class welcome_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.PLAY = new System.Windows.Forms.LinkLabel();
            this.EXIT = new System.Windows.Forms.Button();
            this.head_shot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.head_shot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Try your LUCK";
            // 
            // PLAY
            // 
            this.PLAY.AutoSize = true;
            this.PLAY.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY.LinkColor = System.Drawing.Color.White;
            this.PLAY.Location = new System.Drawing.Point(432, 257);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(63, 25);
            this.PLAY.TabIndex = 1;
            this.PLAY.TabStop = true;
            this.PLAY.Text = "PLAY";
            this.PLAY.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PLAY_LinkClicked);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EXIT.Location = new System.Drawing.Point(691, 404);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(97, 34);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // head_shot
            // 
            this.head_shot.BackgroundImage = global::sound_image.Properties.Resources.headshot;
            this.head_shot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.head_shot.Location = new System.Drawing.Point(-1, 53);
            this.head_shot.Name = "head_shot";
            this.head_shot.Size = new System.Drawing.Size(280, 412);
            this.head_shot.TabIndex = 3;
            this.head_shot.TabStop = false;
            // 
            // welcome_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::sound_image.Properties.Resources.oneround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.head_shot);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.PLAY);
            this.Controls.Add(this.label1);
            this.Name = "welcome_form";
            this.Text = "welcome_form";
            ((System.ComponentModel.ISupportInitialize)(this.head_shot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel PLAY;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.PictureBox head_shot;
    }
}