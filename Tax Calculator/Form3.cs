﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {    // hide setting form window
                //Close();
                this.Hide();
            }
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = false;
            }
        }

        private void Form3_Deactivate(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Enabled = true;
            }
        }
    }
}
