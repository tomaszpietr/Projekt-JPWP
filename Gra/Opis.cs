﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Opis : Form
    {
        public Opis()
        {
            InitializeComponent();
            przyciski.BackColor = Color.FromArgb(0, 0, 0, 0);
            this.Text = "Opis gry";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackgroundImage = Properties.Resources.opis1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}