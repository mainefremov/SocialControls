namespace SocialControls
{
    partial class UserInfoButton
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.onlineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.ErrorImage = global::SocialControls.Properties.Resources.camera_150;
            this.avatarPictureBox.Image = global::SocialControls.Properties.Resources.camera_150;
            this.avatarPictureBox.InitialImage = global::SocialControls.Properties.Resources.camera_150;
            this.avatarPictureBox.Location = new System.Drawing.Point(4, 4);
            this.avatarPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(150, 150);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // ageLabel
            // 
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ageLabel.Location = new System.Drawing.Point(4, 4);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ageLabel.MaximumSize = new System.Drawing.Size(150, 27);
            this.ageLabel.MinimumSize = new System.Drawing.Size(150, 27);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(150, 27);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fullNameLabel.Location = new System.Drawing.Point(158, 4);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.fullNameLabel.MaximumSize = new System.Drawing.Size(1000, 27);
            this.fullNameLabel.MinimumSize = new System.Drawing.Size(0, 27);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(191, 27);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "Светлана Гончарова";
            // 
            // onlineLabel
            // 
            this.onlineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlineLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.onlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.onlineLabel.Location = new System.Drawing.Point(353, 4);
            this.onlineLabel.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.onlineLabel.MaximumSize = new System.Drawing.Size(200, 27);
            this.onlineLabel.MinimumSize = new System.Drawing.Size(200, 27);
            this.onlineLabel.Name = "onlineLabel";
            this.onlineLabel.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.onlineLabel.Size = new System.Drawing.Size(200, 27);
            this.onlineLabel.TabIndex = 3;
            this.onlineLabel.Text = "заходила 29 сентября в 23:16";
            this.onlineLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserInfoButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.onlineLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.avatarPictureBox);
            this.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(1000, 158);
            this.MinimumSize = new System.Drawing.Size(492, 158);
            this.Name = "UserInfoButton";
            this.Size = new System.Drawing.Size(557, 158);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label onlineLabel;
    }
}
