﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openChildForm(new Form2());
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
        }
    }
}
