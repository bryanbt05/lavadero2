﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lavadero2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }

        private void login_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(140, 0, 0, 0);
        }
    }
}
