﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonNombre_Click(object sender, EventArgs e)
        {
            buttonNombre.Text = textNombre.Text;
        }

        private void listBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonNombre.Text = listBoxDias.SelectedItem.ToString();
        }
    }
}
