using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AdinistrationApp_eNutre.Classes;
using AdinistrationApp_eNutre.ServiceAppNutre;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormAdministration : Form
    {
        private ServiceAppNutreClient client;
        private string TOKEN;

        public FormAdministration(string Token)
        {
            InitializeComponent();
            this.TOKEN = Token;
            client = new ServiceAppNutreClient();
            rb_no.Checked = true;
        }

        private void FormAdministration_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        // TABING VEGETABLS
        private void bt_searchFileVeggie_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileVeggie = new OpenFileDialog();
            fileVeggie.Filter = "TXT files (*.txt)|*.txt";

            // ADD EXCEPTION
            if (fileVeggie.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tb_filePathVeggie.Text = fileVeggie.InitialDirectory + fileVeggie.FileName;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_addFileVeggie_Click(object sender, EventArgs e)
        {
            lb_validacao.Text = "";

            string path = tb_filePathVeggie.Text;

            if (!path.Equals(""))
            {
                try
                {
                    XmlDocument vegiDocument = TxtHandler.createXml(path);

                    string file = vegiDocument.OuterXml;

                    file = file.Replace(@"\", "");

                    client.addVegetableXML(file, TOKEN);

                    lb_validacao.Text = "Ficheiro Adicionado Com Sucesso";
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                catch (ProtocolException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Escolha um ficheiro primeiro");
            }
        }

        // END TABING VEGETABLS

        // TABING RESTAURANTS
        private void bt_searchFileRestaurant_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileRestaurant = new OpenFileDialog();
            fileRestaurant.Filter = "XLS files (*.xls)|*.xls";

            // ADD EXCEPTION
            if (fileRestaurant.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tb_filePathRestaurant.Text = fileRestaurant.InitialDirectory + fileRestaurant.FileName;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_addFileRestaurants_Click(object sender, EventArgs e)
        {
            lb_validacaoRestaurant.Text = "";
            string path = tb_filePathRestaurant.Text;

            if (!path.Equals(""))
            {
                lb_validacaoRestaurant.Text = "A processar...";

                try
                {
                    XmlDocument platesDoc = ExcelHandler.createXml(path);

                    string file = platesDoc.OuterXml;

                    file = file.Replace(@"\", "");

                    client.addRestaurantXML(file, TOKEN);

                    lb_validacao.Text = "Ficheiro Adicionado Com Sucesso";
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    lb_validacaoRestaurant.Text = "";
                }
                catch (ProtocolException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    lb_validacaoRestaurant.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Escolha um ficheiro primeiro");
            }
        }

        // END TABING RESTAURANTS

        // TABING ACTIVITIES
        private void bt_searchFileActivity_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileActivity = new OpenFileDialog();
            fileActivity.Filter = "Json files (*.js)|*.js";

            // ADD EXCEPTION
            if (fileActivity.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tb_filePathActivity.Text = fileActivity.InitialDirectory + fileActivity.FileName;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_addFileActivities_Click(object sender, EventArgs e)
        {
            lb_validacaoActivities.Text = "";
            string path = tb_filePathActivity.Text;

            if (!path.Equals(""))
            {
                try
                {
                    XmlDocument actsDoc = JsonHandler.createXml(path);

                    string file = actsDoc.OuterXml;

                    file = file.Replace(@"\", "");

                    client.addActivityXML(file, TOKEN);

                    lb_validacao.Text = "Ficheiro Adicionado Com Sucesso";
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                catch (ProtocolException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Escolha um ficheiro primeiro");
            }
        }


        // END TABING ACTIVITIES

        // TABING ACTIVITIES

        private void bt_addNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tb_username.Text.Trim();
                string password = tb_password.Text.Trim();
                string confirm = tb_confirm.Text.Trim();
                bool isAdmin = (!rb_no.Checked);

                if (!username.Equals("") || !password.Equals(""))
                {
                    if (confirm.Equals(password))
                    {
                        User user = new User();
                        user.Username = username;
                        user.Password = password;
                        user.Admin = isAdmin;

                        client.SignUp(user);

                        MessageBox.Show("Novo Utlizador inserido com sucesso", "Info", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("A confirmação de password e password não correspondem", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (username.Equals(""))
                    MessageBox.Show("Nome de Utilizador inválido", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                if(password.Equals(""))
                MessageBox.Show("Nome de Utilizador inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (FaultException ex)
            {

            }
            catch (ProtocolException ex)
            {
                
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            if (!tb_password.Text.Trim().Equals(""))
            {
                lb_confirm.Hide();
                tb_confirm.Hide();
            }
            else
            {
                lb_confirm.Show();
                tb_confirm.Show();
            }
        }
    }
}
