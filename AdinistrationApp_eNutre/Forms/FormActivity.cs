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
using AdministrationApp_eNutre.Forms;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormActivity : Form
    {

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

            Regex caloriasPattern = new Regex("^[0-9]$");
            Regex metPattern = new Regex("^([0-9]+).[0-9]$");

            if (!name.Equals("") && !calorias.Equals("") && caloriasType.Equals("") && !met.Equals(""))
            {
                if (!caloriasPattern.IsMatch(calorias))
                {
                    if (!metPattern.IsMatch(met))
                    {
                        return true;
                    }
                    MessageBox.Show("O MET tem de ser um valor númerico\n(e.g. 123.1, 1.0)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                MessageBox.Show("As Calorias tem de ser um valor númerico\nSem pontos ou vírgulas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (name.Equals(""))
                MessageBox.Show("O Nome é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              

            if (calorias.Equals(""))
                MessageBox.Show("As Calorias são Obrigatórias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             

            if (caloriasType.Equals(""))
                MessageBox.Show("O Tipo de Caloria é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            

            if (met.Equals(""))
                MessageBox.Show("O MET é Obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return false;
        }

        public FormActivity()
        {
            InitializeComponent();
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
                // CRIAR OBEJTO TIPO ACTIVITY
                // ENVIAR PARA CIMA

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
