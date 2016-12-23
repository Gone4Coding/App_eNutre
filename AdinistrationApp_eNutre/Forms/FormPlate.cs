using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormPlate : Form
    {
        private static string NEW_RESTAURANT = "...";


        private void FillComboBox()
        {
            cb_caloriesType.Items.Add("cal");
            cb_caloriesType.Items.Add("kcal");

            //TODO: getAllRestaurants
            List<String> allRestaurants = new List<string>();

            foreach (string restaurant in allRestaurants)
            {
                cb_restaurant.Items.Add(restaurant);
            }

            cb_restaurant.Items.Add(NEW_RESTAURANT);
        }

        private bool Validar()
        {
            string item = tb_item.Text.Trim();
            string quantity = tb_quantity.Text.Trim();
            string dosage = tb_dosage.Text.Trim();
            string calorias = tb_calories.Text.Trim();
            string caloriasType = cb_caloriesType.Text.Trim();
            string restaurant = cb_restaurant.Text.Trim();

            Regex caloriasPattern = new Regex("^[0-9]$");

            if (!item.Equals("") && !calorias.Equals("") && caloriasType.Equals("") && !quantity.Equals("")
                && !dosage.Equals("") && !restaurant.Equals(""))
            {
                if (!caloriasPattern.IsMatch(calorias))
                {
                    if (!restaurant.Equals("..."))
                    {
                        return true;
                    }
                    MessageBox.Show("Selecione um Restaurant\n" +
                                    "Se adicionou um novo, ele está na listagem", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
                MessageBox.Show("As Calorias tem de ser um valor númerico\nSem pontos ou vírgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (item.Equals(""))
                MessageBox.Show("O Nome é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (quantity.Equals(""))
                MessageBox.Show("A Quantidade é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (dosage.Equals(""))
                MessageBox.Show("A Dosagem é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (calorias.Equals(""))
                MessageBox.Show("As Calorias são Obrigatórias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (caloriasType.Equals(""))
                MessageBox.Show("O Tipo de Caloria é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (restaurant.Equals(""))
                MessageBox.Show("O Restaurante é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        private void EnableNewRestaurant(bool res)
        {
            if (res)
            {
                lb_newRestaurant.Show();
                tb_newRestaurant.Show();
                bt_addRestaurant.Show();
            }
            else
            {
                lb_newRestaurant.Hide();
                tb_newRestaurant.Hide();
                bt_addRestaurant.Hide();
            }
        }

        public FormPlate()
        {
            InitializeComponent();
        }

        private void FormPlate_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FillComboBox();
            EnableNewRestaurant(false);
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string item = tb_item.Text.Trim();
                string quantity = tb_quantity.Text.Trim();
                string dosage = tb_dosage.Text.Trim();
                string extraDosage = tb_extraDosage.Text.Trim();
                string calorias = tb_calories.Text.Trim();
                string caloriasType = cb_caloriesType.Text.Trim();
                string restaurant = cb_restaurant.Text.Trim();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_addRestaurant_Click(object sender, EventArgs e)
        {
            if (cb_restaurant.Text.Equals(NEW_RESTAURANT))
            {
                cb_restaurant.Items.Add(tb_newRestaurant.Text.Trim());
                EnableNewRestaurant(false);
                bt_adicionar.Enabled = true;
            }
        }

        private void cb_restaurant_TextChanged(object sender, EventArgs e)
        {
            if (cb_restaurant.Text.Equals(NEW_RESTAURANT))
            {
                bt_adicionar.Enabled = false;
                EnableNewRestaurant(true);
            }
        }
    }
}
