using System;
using System.Windows.Forms;

namespace AdinistrationApp_eNutre.Forms
{
    public partial class FormMain : Form
    {
        private static string TOKEN;
        private MenuType menuType;

        private enum MenuType
        {
            Activities,
            Plates,
            Veggetables,
            Sugestions
        }

        public FormMain(/*string token*/)
        {
            InitializeComponent();
            //FormMain.TOKEN = token;

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
            formatForMenu(MenuType.Activities);
            createListView();
            
        }

        private void menu_restaurants_Click(object sender, EventArgs e)
        {
            formatForMenu(MenuType.Plates);
            createListView();
        }

        private void menu_foods_Click(object sender, EventArgs e)
        {
            formatForMenu(MenuType.Veggetables);
            createListView();
            
        }

        private void menu_sugestions_Click(object sender, EventArgs e)
        {
            formatForMenu(MenuType.Sugestions);
            createListView();
        }

        // END MENUS

        // FUNCTIONS

        private void formatForMenu(MenuType menu)
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

        private void createListView()
        {
            lv_tables.View = View.Details;
            switch (menuType)
            {
                case MenuType.Activities:
                    addColumns(new string[] { "Atividade", "M.E.T." , "Consumo Calorico/h" }, 161);    
                    break;

                case MenuType.Plates:
                    addColumns(new string[] { "Restaurante", "Item", "Calorias/Quantidade" }, 161);
                    break;
                    
                case MenuType.Veggetables:
                    addColumns(new string[] { "Vegetal", "Info", "Calorias/Quantidade" }, 161);
                    break;

                case MenuType.Sugestions:
                    addColumns(new string[] { "Sugestion", "X", "X", "X" }, 121);
                    break;
            }
        }

        private void addColumns(string[] colums, int size)
        {
            lv_tables.Clear();
            foreach (string column in colums)
            {
                lv_tables.Columns.Add(column, size, HorizontalAlignment.Left);
            }
        }

        public string getToken()
        {
            return TOKEN;
        }
           
        // END FUNCTIONS

        // BUTTONS
        
        private void bt_new_Click(object sender, EventArgs e)
        {
            switch (menuType)
            {
                case MenuType.Activities:
                    FormActivity act = new FormActivity();
                    act.Show();
                    break;

                case MenuType.Plates:
                    FormPlate plate = new FormPlate();
                    plate.Show();
                    break;

                case MenuType.Veggetables:
                    FormVegetable veggie = new FormVegetable();
                    veggie.Show();
                    break;

                case MenuType.Sugestions:
                    FormSugestion sug = new FormSugestion();
                    sug.Show();
                    break;
            }
        }

        private void bt_updade_Click(object sender, EventArgs e)
        {
            switch (menuType)
            {
                case MenuType.Activities:
                    break;

                case MenuType.Plates:
                    break;

                case MenuType.Veggetables:
                    break;

                case MenuType.Sugestions:
                    break;
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            switch (menuType)
            {
                case MenuType.Activities:
                    break;

                case MenuType.Plates:
                    break;

                case MenuType.Veggetables:
                    break;

                case MenuType.Sugestions:
                    break;
            }
        }

        private void bt_adminstration_Click(object sender, EventArgs e)
        {
            FormAdministration formAdm = new FormAdministration();
            formAdm.ShowDialog();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // END BUTTONS
    }
}
