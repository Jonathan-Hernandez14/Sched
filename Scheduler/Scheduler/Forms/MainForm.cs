﻿using Scheduler.Common;
using Scheduler.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DbOperations.GenOrRead();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MainFormTLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            PersonInfoForm addPersonForm = new PersonInfoForm();
            addPersonForm.ShowDialog();
        }
    }
}
