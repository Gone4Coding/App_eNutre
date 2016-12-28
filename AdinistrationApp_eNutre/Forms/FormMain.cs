using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Windows.Forms;
using AdinistrationApp_eNutre.ServiceAppNutre;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormMain : Form
    {
        private ServiceAppNutreClient client;
        private static string TOKEN;
        private MenuType menuType;

        private enum MenuType
        {
            Activities,
            Plates,
            Veggetables,
            Sugestions
        }

        public FormMain(string token)
        {
            InitializeComponent();
            client = new ServiceAppNutreClient();
            FormMain.TOKEN = token;

            //txt.carregarTXT(@"C:\Users\j17vi\Source\Repos\App_eNutre\AdinistrationApp_eNutre\Info\calorias_vegetais");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lb_title.Hide();
            panel_all.Hide();
        }

        //  MENUS 
        private void menu_activities_Click(object sender, EventArgs e)
        {
            FormatForMenu(MenuType.Activities);
            CreateListView();
            PopulateListView(MenuType.Activities);
        }

        private void menu_restaurants_Click(object sender, EventArgs e)
        {
            FormatForMenu(MenuType.Plates);
            CreateListView();
            PopulateListView(MenuType.Plates);
        }

        private void menu_foods_Click(object sender, EventArgs e)
        {
            FormatForMenu(MenuType.Veggetables);
            CreateListView();
            PopulateListView(MenuType.Veggetables);
        }

        private void menu_sugestions_Click(object sender, EventArgs e)
        {
            FormatForMenu(MenuType.Sugestions);
            CreateListView();
            PopulateListView(MenuType.Sugestions);
        }

        // END MENUS

        // FUNCTIONS

        private void FormatForMenu(MenuType menu)
        {
            lb_welcome.Hide();
            panel_all.Show();
            string menuString = "";
            switch (menu)
            {
                case MenuType.Activities:
                    menuString = "Atividades";
                    break;

                case MenuType.Plates:
                    menuString = "Pratos";
                    break;

                case MenuType.Veggetables:
                    menuString = "Vegetais";
                    break;

                case MenuType.Sugestions:
                    menuString = "Sugestõies";
                    break;
            }
            lb_title.Text = menuString;
            lb_title.Show();
            menuType = menu;
        }

        private void CreateListView()
        {
            lv_tables.View = View.Details;
            switch (menuType)
            {
                case MenuType.Activities:
                    AddColumns(new[] { "Id", "Atividade", "M.E.T.", "Consumo Calorico/h" }, 161);
                    break;

                case MenuType.Plates:
                    AddColumns(new[] { "Id", "Restaurante", "Item", "Calorias", "Quantidade" }, 121);
                    break;

                case MenuType.Veggetables:
                    AddColumns(new[] { "Id", "Vegetal", "Info", "Calorias", "Quantidade" }, 121);
                    break;

                case MenuType.Sugestions:
                    AddColumns(new[] { "Id", "Sugestão", "X", "X" }, 121);
                    break;
            }
        }

        private void PopulateListView(MenuType menu)
        {
            lv_tables.Items.Clear();
            switch (menu)
            {
                case MenuType.Activities:

                    Activity[] activities = client.getActivitiesList();

                    foreach (Activity act in activities)
                    {
                        string[] row = { act.Id.ToString(), act.Nome, act.Met, act.CaloriasValue.ToString() };
                        lv_tables.Items.Add(new ListViewItem(row));
                    }

                    break;

                case MenuType.Plates:

                    Plate[] plates = client.GetRestaurantsList();

                    foreach (Plate plate in plates)
                    {
                        string aux = plate.QuantityValue + " (" + plate.QuantityDosage + ")";
                        string[] row = { plate.Id.ToString(), plate.RestaurantName, plate.Name, plate.CaloriesValue.ToString(), aux };
                        lv_tables.Items.Add(new ListViewItem(row));
                    }

                    break;

                case MenuType.Veggetables:

                    Vegetable[] vegdies = client.getVegetablesList();

                    foreach (Vegetable vegetable in vegdies)
                    {
                        string info = "";
                        string aux = vegetable.QuantityValue + " (" + vegetable.UnityQuantity + ")";

                        if (vegetable.ExtraInfo != null)
                            foreach (string extrainfo in vegetable.ExtraInfo)
                            {
                                info = extrainfo;
                            }

                        string[] row = { vegetable.Id.ToString(), vegetable.Name, info, vegetable.CaloriesValue.ToString(), aux };
                        lv_tables.Items.Add(new ListViewItem(row));
                    }
                    break;

                case MenuType.Sugestions:
                    break;
            }
        }

        private void AddColumns(string[] colums, int size)
        {
            lv_tables.Clear();
            foreach (string column in colums)
            {
                lv_tables.Columns.Add(column, size, HorizontalAlignment.Left);
                lv_tables.Columns[0].Width = 0;
            }
        }

        // END FUNCTIONS

        // BUTTONS

        private void bt_new_Click(object sender, EventArgs e)
        {
            switch (menuType)
            {
                case MenuType.Activities:
                    FormActivity act = new FormActivity(TOKEN);
                    act.ShowDialog();
                    PopulateListView(MenuType.Activities);
                    break;

                case MenuType.Plates:
                    FormPlate plate = new FormPlate(TOKEN);
                    plate.ShowDialog();
                    PopulateListView(MenuType.Plates);
                    break;

                case MenuType.Veggetables:
                    FormVegetable veggie = new FormVegetable(TOKEN);
                    veggie.ShowDialog();
                    PopulateListView(MenuType.Veggetables);
                    break;

                case MenuType.Sugestions:
                    FormSugestion sug = new FormSugestion(/*TOKEN*/);
                    sug.ShowDialog();
                    break;
            }
        }

        private void bt_updade_Click(object sender, EventArgs e)
        {
            if (lv_tables.SelectedItems.Count == 1)
            {
                switch (menuType)
                {
                    case MenuType.Activities:
                        FormActivity act = new FormActivity(TOKEN);
                        act.ShowDialog();
                        PopulateListView(MenuType.Activities);
                        break;

                    case MenuType.Plates:
                        FormPlate plate = new FormPlate(TOKEN);
                        plate.ShowDialog();
                        PopulateListView(MenuType.Plates);
                        break;

                    case MenuType.Veggetables:
                        FormVegetable veggie = new FormVegetable(TOKEN);
                        veggie.ShowDialog();
                        PopulateListView(MenuType.Veggetables);
                        break;

                    case MenuType.Sugestions:
                        break;
                }
                return;
            }
            MessageBox.Show("Escolha só um item para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (lv_tables.SelectedItems.Count == 1)
            {
                int id = int.Parse(lv_tables.SelectedItems[0].SubItems[0].Text);
                bool res = false;
                switch (menuType)
                {
                    case MenuType.Activities:
                        res = client.removeActivity(id, TOKEN);
                        PopulateListView(MenuType.Activities);
                        break;

                    case MenuType.Plates:
                        res = client.removeActivity(id, TOKEN);
                        PopulateListView(MenuType.Plates);
                        break;

                    case MenuType.Veggetables:
                        res = client.removeActivity(id, TOKEN);
                        PopulateListView(MenuType.Veggetables);
                        break;

                    case MenuType.Sugestions:
                        break;
                }
                if (res)
                    MessageBox.Show("Item Eliminado com sucesso", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Escolha só um item para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void bt_adminstration_Click(object sender, EventArgs e)
        {
            FormAdministration formAdm = new FormAdministration(TOKEN);
            formAdm.ShowDialog();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lv_tables_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
                e.NewWidth = lv_tables.Columns[e.ColumnIndex].Width;
            }
        }

        // END BUTTONS
    }
}
