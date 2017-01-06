using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

                    string data = vegiDocument.ToString();
                    object[] dataToSend = new[] { Encoding.UTF8.GetBytes(data) };

                    client.addVegetableXML(dataToSend, TOKEN);

                    lb_validacao.Text = "Ficheiro Adicionado Com Sucesso";
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                try
                {
                    XmlDocument platesDoc = ExcelHandler.createXml(path);

                    string data = platesDoc.ToString();
                    object[] dataToSend = new[] { Encoding.UTF8.GetBytes(data) };

                    client.addRestaurantXML(dataToSend, TOKEN);

                    lb_validacao.Text = "Ficheiro Adicionado Com Sucesso";
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

                    string data = actsDoc.ToString();
                    object[] dataToSend = new[] { Encoding.UTF8.GetBytes(data) };

                    client.addActivityXML(dataToSend, TOKEN);

                    lb_validacao.Text = "Ficheiro Adicionado Com Sucesso";
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Erro ao Adicionar o Ficheiro\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Escolha um ficheiro primeiro");
            }
        }

        private void backgroundWorker_DoWork(DoWorkEventArgs e)
        {
            ExcelHandler.createXml(e.Argument.ToString());
        }

        // END TABING ACTIVITIES
    }
}
