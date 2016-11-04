using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdinistrationApp_eNutre.Classes;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormAdministration : Form
    {
        public FormAdministration()
        {
            InitializeComponent();
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

            if (!tb_filePathVeggie.Text.Equals(""))
            {
                string path = tb_filePathVeggie.Text;

                string msg = TxtHandler.createXml(path);

                if (msg.Equals(""))
                {
                    lb_resultVegetable.Text = "Error in File. Check Format";
                }
                else
                {
                    lb_resultVegetable.Text = "File Added";

                    lb_validacao.Text = msg;
                }
            }
            else
            {
                MessageBox.Show("Choose a file first");
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
            if (!tb_filePathRestaurant.Text.Equals(""))
            {
                string path = tb_filePathRestaurant.Text;
                ExcelHandler.createXml(path);
            }
            else
            {
                MessageBox.Show("Choose a file first");
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
            if (!tb_filePathActivity.Text.Equals(""))
            {
                string path = tb_filePathActivity.Text;
                string msg = JsonHandler.createXml(path);

                if (msg.Equals(""))
                {
                    lb_resultActivities.Text = "Error in File. Check Format";
                }
                else
                {
                    lb_resultActivities.Text = "File Added";

                    lb_validacaoActivities.Text = msg;
                }
            }
            else
            {
                MessageBox.Show("Choose a file first");
            }
        }
        // END TABING ACTIVITIES
    }
}
