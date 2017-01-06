using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AdinistrationApp_eNutre.ServiceAppNutre;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormPlate : Form
    {
        private static string NEW_RESTAURANT = "...";
        private ServiceAppNutreClient client;
        private string TOKEN;
        private int id;
        private Funcao funcao;

        public enum Funcao
        {
            Abrir,
            Editar
        }

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

            Regex caloriasPattern = new Regex("^[0-9]+$");

            if (!item.Equals("") && !calorias.Equals("") && !caloriasType.Equals("") && !quantity.Equals("")
                && !dosage.Equals("") && !restaurant.Equals(""))
            {
                if (caloriasPattern.IsMatch(calorias))
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

        public FormPlate(string Token)
        {
            InitializeComponent();
            this.funcao = Funcao.Abrir;
            this.TOKEN = Token;
            client = new ServiceAppNutreClient();
        }
        public FormPlate(string Token, int id)
        {
            InitializeComponent();
            this.funcao = Funcao.Editar;
            this.id = id;
            this.TOKEN = Token;
            client = new ServiceAppNutreClient();
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

                Plate plate = new Plate();
                plate.Name = item;
                plate.QuantityValue = quantity;
                plate.QuantityDosage = dosage;
                plate.QuantityExtraDosage = extraDosage;
                plate.CaloriesValue = int.Parse(calorias);
                plate.CaloriasUnit = caloriasType;
                plate.RestaurantName = restaurant;

                try
                {
                    client.addRestaurant(plate, TOKEN);
                    MessageBox.Show("Prato Inserido com sucesso!", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Erro Inserir o Prato\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
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
