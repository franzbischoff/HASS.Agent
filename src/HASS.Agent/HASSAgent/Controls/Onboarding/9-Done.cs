﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HASSAgent.Functions;

namespace HASSAgent.Controls.Onboarding
{
    public partial class Done : UserControl
    {
        public Done()
        {
            InitializeComponent();
        }

        private void Done_Load(object sender, EventArgs e)
        {
            //
        }

        private void LblGitHub_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/LAB02-Research/HASS.Agent");
    }
}
