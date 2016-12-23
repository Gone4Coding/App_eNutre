using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministrationApp_eNutre.Forms;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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
            string username = tb_username.Text.Trim();
            string pass = tb_passwod.Text.Trim();

            if (!username.Equals("") && !pass.Equals(""))
            {
                //string token = LogIn(username, pass);
                string token = "";
                if (token != null || !token.Equals(""))
                {
                    FormMain main = new FormMain(token);
                    main.Show();
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
    }
}
