using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AdinistrationApp_eNutre.ServiceAppNutre;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormVegetable : Form
    {
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
        }

        private bool Validar()
        {
            string name = tb_name.Text.Trim();
            string infoExtra = richTextBox_extraInfo.Text.Trim();
            string quantity = tb_quantity.Text.Trim();
            string unit = tb_unity.Text.Trim();
            string calorias = tb_calories.Text.Trim();
            string caloriasType = cb_caloriesType.Text.Trim();

            Regex valuesPatteen = new Regex("^[0-9]+$");
            Regex extraInfoPatterm = new Regex("^[A-Za-zÁáÀàÉéÍíÓóÚú]+(,[A-Za-zÁáÀàÉéÍíÓóÚú]+)*$");

            if (!name.Equals("") && !calorias.Equals("") && !quantity.Equals("") 
                && !unit.Equals("") && !caloriasType.Equals(""))
            {
                if (valuesPatteen.IsMatch(calorias))
                {
                    if (valuesPatteen.IsMatch(quantity))
                    {
                        if (!infoExtra.Equals(""))
                        {
                            if (extraInfoPatterm.IsMatch(infoExtra))
                            {
                                return true;
                            }
                            MessageBox.Show("A Informação extra tem de ser\n" +
                                            "separadara por vírgulas e não pode conter números\n" +
                                            "(e.g. cozida, assada)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        return true;
                    }
                    MessageBox.Show("A quantidade tem de ser um valor númerico\n" +
                                    "Sem pontos ou vírgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                MessageBox.Show("As Calorias tem de ser um valor númerico\n" +
                                "Sem pontos ou vírgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (name.Equals(""))
                MessageBox.Show("O Nome é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (calorias.Equals(""))
                MessageBox.Show("As Calorias são Obrigatórias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (caloriasType.Equals(""))
                MessageBox.Show("O Tipo de Caloria é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            if (quantity.Equals(""))
                MessageBox.Show("A Quantidade é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (unit.Equals(""))
                MessageBox.Show("As Unidades são Obrigatórias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        public FormVegetable(string Token)
        {
            InitializeComponent();
            this.funcao = Funcao.Abrir;
            this.TOKEN = Token;
            client = new ServiceAppNutreClient();
        }
        public FormVegetable(string Token, int id)
        {
            InitializeComponent();
            this.funcao = Funcao.Editar;
            this.id = id;
            this.TOKEN = Token;
            client = new ServiceAppNutreClient();
        }

        private void FormVegetable_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FillComboBox();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string name = tb_name.Text.Trim();
                string infoExtra = richTextBox_extraInfo.Text.Trim();
                string quantity = tb_quantity.Text.Trim();
                string unit = tb_unity.Text.Trim();
                string calorias = tb_calories.Text.Trim();
                string caloriasType = cb_caloriesType.Text.Trim();
                string[] extrasInfos = null;

                if (!infoExtra.Equals(""))
                {
                    extrasInfos = infoExtra.Split(',');
                }

                //TODO
                Vegetable veggie = new Vegetable();
                veggie.Name = name;
                veggie.ExtraInfo = extrasInfos;
                veggie.QuantityValue = quantity;
                veggie.UnityQuantity = unit;
                veggie.CaloriesValue = int.Parse(calorias);
                veggie.UnityCal = caloriasType;

                bool res = client.addVegetable(veggie, TOKEN);
                if (res)
                    MessageBox.Show("Vegetal inserido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // MESSAGEBOX

                Close();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
