using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdinistrationApp_eNutre.Classes;
using AdinistrationApp_eNutre.Forms;
using AdministrationApp_eNutre.Classes;

namespace AdministrationApp_eNutre.Forms
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

        public FormMain(string token)
        {
            InitializeComponent();
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
                    addColumns(new string[] { "Activity", "M.E.T." , "Calorie Consumption/h" },161);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Activities";
                    break;

                case MenuType.Plates:
                    addColumns(new string[] { "Plate", "Item", "Quantity", "Calories" }, 121);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Restaurants";
                    break;
                    
                case MenuType.Veggetables:
                    addColumns(new string[] { "Vegetable", "Extra Info", "Quantity", "Calories" }, 121);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Foods";
                    break;

                case MenuType.Sugestions:
                    addColumns(new string[] { "Sugestion", "X", "X", "X" }, 121);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Sugestions";
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
                    /*FormAddActivity formAddActivity = new FormAddActivity();
                    formAddActivity.ShowDialog();*/
                    break;

                case MenuType.Plates:
                   /* FormAddRestaurant formAddRestaurant = new FormAddRestaurant();
                    formAddRestaurant.ShowDialog();    */               
                    break;

                case MenuType.Veggetables:
                    /*FormAddVegetable formAddVegetable = new FormAddVegetable();
                    formAddVegetable.ShowDialog();*/
                    break;

                case MenuType.Sugestions:
                    break;
            }
        }

        private void bt_updade_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void bt_adminstration_Click(object sender, EventArgs e)
        {
            FormAdministration formAdm = new FormAdministration();
            formAdm.ShowDialog();
        }

        // END BUTTONS
    }
}
