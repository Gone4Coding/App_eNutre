using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private String menuType;
        private TxtHandler txt = new TxtHandler();
        

        public FormMain()
        {
            InitializeComponent();
            //txt.carregarTXT();
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
            formatForMenu("Activities");
            createListView();
        }

        private void menu_restaurants_Click(object sender, EventArgs e)
        {
            formatForMenu("Restaurants");
            createListView();
        }

        private void menu_foods_Click(object sender, EventArgs e)
        {
            formatForMenu("Foods");
            createListView();
            
        }

        private void menu_plans_Click(object sender, EventArgs e)
        {
            formatForMenu("Plans");
            createListView();
        }

        private void menu_sugestions_Click(object sender, EventArgs e)
        {
            formatForMenu("Sugestions");
            createListView();
        }

        // END MENUS

        // FUNCTIONS

        private void formatForMenu(string menu)
        {
            lb_welcome.Hide();
            panel_all.Show();
            lb_title.Text = menu;
            lb_title.Show();
            menuType = menu;
        }

        private void createListView()
        {
            lv_tables.View = View.Details;
            switch (menuType)
            {
                case "Activities":
                    addColumns(new string[] { "Activity", "M.E.T." , "Calorie Consumption/h" },161);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Activities";
                    break;

                case "Restaurants":
                    addColumns(new string[] { "Restaurant", "Item", "Quantity", "Calories" }, 121);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Restaurants";
                    break;
                    
                case "Foods":
                    addColumns(new string[] { "Vegetable", "Extra Info", "Quantity", "Calories" }, 121);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Foods";
                    break;

                case "Plans":
                    addColumns(new string[] { "Plan", "X", "X", "X" }, 121);
                    AdministrationApp_eNutre.Properties.Settings.Default.GLOBAL_MENU_TYPE = "Plans";
                    break;

                case "Sugestions":
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
           
        // END FUNCTIONS

        // BUTTONS
        
        private void bt_new_Click(object sender, EventArgs e)
        {

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
            formAdm.Show();
        }

        // END BUTTONS
    }
}
