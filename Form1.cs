﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Close(object sender, EventArgs e)
        {
            Form1.ActiveForm.Enabled = false;
            Application.Run(new exit());
            //exit.;
            //MessageBox.Show(" ");
        }
    }
}
