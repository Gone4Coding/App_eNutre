﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormAddRestaurant : Form
    {
        public FormAddRestaurant()
        {
            InitializeComponent();
        }

        private void FormAddRestaurant_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}