﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp3G
{
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KreiranjeKorisnika form = new KreiranjeKorisnika();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrikazRazgovora form = new PrikazRazgovora();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
