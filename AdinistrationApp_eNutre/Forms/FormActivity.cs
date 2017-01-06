using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AdinistrationApp_eNutre.ServiceAppNutre;
using Activity = AdinistrationApp_eNutre.ServiceAppNutre.Activity;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormActivity : Form
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
            string name = tb_activityName.Text.Trim();
            string calorias = tb_calories.Text.Trim();
            string caloriasType = cb_caloriesType.Text.Trim();
            string met = tb_activityMet.Text.Trim();

            Regex caloriasPattern = new Regex("^[0-9]+$");
            Regex metPattern = new Regex("^([0-9]+).[0-9]$");

            if (!name.Equals("") && !calorias.Equals("") && !caloriasType.Equals("") && !met.Equals(""))
            {
                if (caloriasPattern.IsMatch(calorias))
                {
                    if (metPattern.IsMatch(met))
                    {
                        return true;
                    }
                    MessageBox.Show("O MET tem de ser um valor númerico\n(e.g. 123.1, 1.0)", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                MessageBox.Show("As Calorias tem de ser um valor númerico\nSem pontos ou vírgulas", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (name.Equals(""))
                MessageBox.Show("O Nome é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            if (calorias.Equals(""))
                MessageBox.Show("As Calorias são Obrigatórias", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);


            if (caloriasType.Equals(""))
                MessageBox.Show("O Tipo de Caloria é Obrigatório", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);


            if (met.Equals(""))
                MessageBox.Show("O MET é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        private void PreencheCampos()
        {
            if (funcao == Funcao.Abrir)
            {
                Activity act = client.GetActivityById(id);

                tb_activityName.Text = act.Nome;
                tb_calories.Text = act.CaloriasValue.ToString();
                tb_activityMet.Text = act.Met;
                cb_caloriesType.SelectedItem = act.CaloriasUnit;
            }
        }

        public FormActivity(string Token)
        {
            InitializeComponent();
            this.funcao = Funcao.Abrir;
            this.TOKEN = Token;
            client = new ServiceAppNutreClient();
        }

        public FormActivity(string Token, int id)
        {
            InitializeComponent();
            this.funcao = Funcao.Editar;
            this.id = id;
            this.TOKEN = Token;
            client = new ServiceAppNutreClient();
            PreencheCampos();
        }

        private void FormActivity_Load(object sender, EventArgs e)
        {
            CenterToParent();
            FillComboBox();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string name = tb_activityName.Text.Trim();
                string calorias = tb_calories.Text.Trim();
                string caloriasType = cb_caloriesType.Text.Trim();
                string met = tb_activityMet.Text.Trim();

                //TODO
                Activity activity = new Activity();
                activity.Nome = name;
                activity.CaloriasValue = int.Parse(calorias);
                activity.CaloriasUnit = caloriasType;
                activity.Met = met;
                activity.MetName = "Metabolic Equivalent";

                try
                {
                    client.addActivity(activity, TOKEN);
                    MessageBox.Show("Atividade Inserida com sucesso!", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Close();
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Erro Inserir a Atividaden\n" + ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
