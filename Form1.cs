﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            int age = int.Parse(tbxAge.Text);
            if (age >= 20)
                lblResult.Text = "成人です";
            else if (age < 20)
                lblResult.Text = "未成年です";
            if (age == 20)
                lblResult.Text = "還暦です";

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
