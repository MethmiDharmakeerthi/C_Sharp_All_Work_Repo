﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAP_L7_ict20832
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpRegForm f1 = new EmpRegForm();
            f1.MdiParent = this;
            f1.Show();
         
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableView f2 = new TableView();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
