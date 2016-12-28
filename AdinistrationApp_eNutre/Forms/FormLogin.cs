﻿using System;
using System.Windows.Forms;
using AdinistrationApp_eNutre.ServiceAppNutre;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormLogin : Form
    {
        private ServiceAppNutreClient client;

        private void login()
        {
            string username = tb_username.Text.Trim();
            string pass = tb_passwod.Text.Trim();

            if (!username.Equals("") && !pass.Equals(""))
            {
                string token = client.LogIn(username, pass);
                if (token != null)
                {
                    FormMain main = new FormMain(token);
                    Hide();
                    main.ShowDialog();
                    Close();
                }
                MessageBox.Show("Combinação Nome de Uilizador/Password incorreta", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;

            }
            if (username.Equals(""))
            {
                MessageBox.Show("O Nome de Utilizador tem \nde ser preenchedo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (pass.Equals(""))
            {

                MessageBox.Show("A Password tem \nde ser preencheda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        
        public FormLogin()
        {
            InitializeComponent();
            client = new ServiceAppNutreClient();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void tb_passwod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
