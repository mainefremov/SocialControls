﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialControls
{
    public partial class UserInfoButton: UserControl
    {
        public UserInfoButton()
        {
            InitializeComponent();
            this.ageLabel.Parent = this.avatarPictureBox;
        }
    }
}
