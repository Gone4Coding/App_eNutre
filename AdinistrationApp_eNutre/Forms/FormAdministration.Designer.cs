namespace AdinistrationApp_eNutre.Forms
{
    partial class FormAdministration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_all = new System.Windows.Forms.TabControl();
            this.tabPage_vegetables = new System.Windows.Forms.TabPage();
            this.lb_validacao = new System.Windows.Forms.Label();
            this.lb_resultVegetable = new System.Windows.Forms.Label();
            this.bt_addFileVeggie = new System.Windows.Forms.Button();
            this.lb_infoVeggie = new System.Windows.Forms.Label();
            this.bt_searchFileVeggie = new System.Windows.Forms.Button();
            this.tb_filePathVeggie = new System.Windows.Forms.TextBox();
            this.lb_fileNameVeggie = new System.Windows.Forms.Label();
            this.tabPage_restaurants = new System.Windows.Forms.TabPage();
            this.lb_validacaoRestaurant = new System.Windows.Forms.Label();
            this.lb_resultRestaurants = new System.Windows.Forms.Label();
            this.tb_filePathRestaurant = new System.Windows.Forms.TextBox();
            this.bt_addFileRestaurants = new System.Windows.Forms.Button();
            this.bt_searchFileRestaurant = new System.Windows.Forms.Button();
            this.lb_fileNameResturant = new System.Windows.Forms.Label();
            this.lb_infoRestaurant = new System.Windows.Forms.Label();
            this.tabPage_activities = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_addSingleActivity = new System.Windows.Forms.Button();
            this.tb_activityMet = new System.Windows.Forms.TextBox();
            this.lb_activityMet = new System.Windows.Forms.Label();
            this.tb_calories = new System.Windows.Forms.TextBox();
            this.lb_activityCalories = new System.Windows.Forms.Label();
            this.tb_activityName = new System.Windows.Forms.TextBox();
            this.lb_activityName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_filePathActivity = new System.Windows.Forms.TextBox();
            this.lb_validacaoActivities = new System.Windows.Forms.Label();
            this.bt_addFileActivities = new System.Windows.Forms.Button();
            this.lb_resultActivities = new System.Windows.Forms.Label();
            this.bt_searchFileActivity = new System.Windows.Forms.Button();
            this.lb_infoActivities = new System.Windows.Forms.Label();
            this.lb_fileNameActivity = new System.Windows.Forms.Label();
            this.cb_caloriesType = new System.Windows.Forms.ComboBox();
            this.tab_all.SuspendLayout();
            this.tabPage_vegetables.SuspendLayout();
            this.tabPage_restaurants.SuspendLayout();
            this.tabPage_activities.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_all
            // 
            this.tab_all.Controls.Add(this.tabPage_vegetables);
            this.tab_all.Controls.Add(this.tabPage_restaurants);
            this.tab_all.Controls.Add(this.tabPage_activities);
            this.tab_all.Location = new System.Drawing.Point(12, 12);
            this.tab_all.Name = "tab_all";
            this.tab_all.SelectedIndex = 0;
            this.tab_all.Size = new System.Drawing.Size(600, 180);
            this.tab_all.TabIndex = 0;
            // 
            // tabPage_vegetables
            // 
            this.tabPage_vegetables.Controls.Add(this.lb_validacao);
            this.tabPage_vegetables.Controls.Add(this.lb_resultVegetable);
            this.tabPage_vegetables.Controls.Add(this.bt_addFileVeggie);
            this.tabPage_vegetables.Controls.Add(this.lb_infoVeggie);
            this.tabPage_vegetables.Controls.Add(this.bt_searchFileVeggie);
            this.tabPage_vegetables.Controls.Add(this.tb_filePathVeggie);
            this.tabPage_vegetables.Controls.Add(this.lb_fileNameVeggie);
            this.tabPage_vegetables.Location = new System.Drawing.Point(4, 22);
            this.tabPage_vegetables.Name = "tabPage_vegetables";
            this.tabPage_vegetables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_vegetables.Size = new System.Drawing.Size(839, 310);
            this.tabPage_vegetables.TabIndex = 0;
            this.tabPage_vegetables.Text = "Vegetables";
            this.tabPage_vegetables.UseVisualStyleBackColor = true;
            // 
            // lb_validacao
            // 
            this.lb_validacao.AutoSize = true;
            this.lb_validacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_validacao.ForeColor = System.Drawing.Color.Red;
            this.lb_validacao.Location = new System.Drawing.Point(181, 131);
            this.lb_validacao.Name = "lb_validacao";
            this.lb_validacao.Size = new System.Drawing.Size(0, 13);
            this.lb_validacao.TabIndex = 6;
            // 
            // lb_resultVegetable
            // 
            this.lb_resultVegetable.AutoSize = true;
            this.lb_resultVegetable.Location = new System.Drawing.Point(104, 156);
            this.lb_resultVegetable.Name = "lb_resultVegetable";
            this.lb_resultVegetable.Size = new System.Drawing.Size(0, 13);
            this.lb_resultVegetable.TabIndex = 5;
            // 
            // bt_addFileVeggie
            // 
            this.bt_addFileVeggie.Location = new System.Drawing.Point(14, 121);
            this.bt_addFileVeggie.Name = "bt_addFileVeggie";
            this.bt_addFileVeggie.Size = new System.Drawing.Size(75, 23);
            this.bt_addFileVeggie.TabIndex = 4;
            this.bt_addFileVeggie.Text = "Add File";
            this.bt_addFileVeggie.UseVisualStyleBackColor = true;
            this.bt_addFileVeggie.Click += new System.EventHandler(this.bt_addFileVeggie_Click);
            // 
            // lb_infoVeggie
            // 
            this.lb_infoVeggie.AutoSize = true;
            this.lb_infoVeggie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_infoVeggie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoVeggie.Location = new System.Drawing.Point(67, 38);
            this.lb_infoVeggie.Name = "lb_infoVeggie";
            this.lb_infoVeggie.Size = new System.Drawing.Size(186, 60);
            this.lb_infoVeggie.TabIndex = 3;
            this.lb_infoVeggie.Text = "Info:\r\nTo enter a file, it must be \r\nin Text file format (txt) ";
            // 
            // bt_searchFileVeggie
            // 
            this.bt_searchFileVeggie.Location = new System.Drawing.Point(297, 13);
            this.bt_searchFileVeggie.Name = "bt_searchFileVeggie";
            this.bt_searchFileVeggie.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileVeggie.TabIndex = 2;
            this.bt_searchFileVeggie.Text = "Search";
            this.bt_searchFileVeggie.UseVisualStyleBackColor = true;
            this.bt_searchFileVeggie.Click += new System.EventHandler(this.bt_searchFileVeggie_Click);
            // 
            // tb_filePathVeggie
            // 
            this.tb_filePathVeggie.Location = new System.Drawing.Point(71, 15);
            this.tb_filePathVeggie.Name = "tb_filePathVeggie";
            this.tb_filePathVeggie.Size = new System.Drawing.Size(220, 20);
            this.tb_filePathVeggie.TabIndex = 1;
            // 
            // lb_fileNameVeggie
            // 
            this.lb_fileNameVeggie.AutoSize = true;
            this.lb_fileNameVeggie.Location = new System.Drawing.Point(11, 18);
            this.lb_fileNameVeggie.Name = "lb_fileNameVeggie";
            this.lb_fileNameVeggie.Size = new System.Drawing.Size(54, 13);
            this.lb_fileNameVeggie.TabIndex = 0;
            this.lb_fileNameVeggie.Text = "File Name";
            // 
            // tabPage_restaurants
            // 
            this.tabPage_restaurants.Controls.Add(this.lb_validacaoRestaurant);
            this.tabPage_restaurants.Controls.Add(this.lb_resultRestaurants);
            this.tabPage_restaurants.Controls.Add(this.tb_filePathRestaurant);
            this.tabPage_restaurants.Controls.Add(this.bt_addFileRestaurants);
            this.tabPage_restaurants.Controls.Add(this.bt_searchFileRestaurant);
            this.tabPage_restaurants.Controls.Add(this.lb_fileNameResturant);
            this.tabPage_restaurants.Controls.Add(this.lb_infoRestaurant);
            this.tabPage_restaurants.Location = new System.Drawing.Point(4, 22);
            this.tabPage_restaurants.Name = "tabPage_restaurants";
            this.tabPage_restaurants.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_restaurants.Size = new System.Drawing.Size(706, 154);
            this.tabPage_restaurants.TabIndex = 1;
            this.tabPage_restaurants.Text = "Restaurants";
            this.tabPage_restaurants.UseVisualStyleBackColor = true;
            // 
            // lb_validacaoRestaurant
            // 
            this.lb_validacaoRestaurant.AutoSize = true;
            this.lb_validacaoRestaurant.ForeColor = System.Drawing.Color.Red;
            this.lb_validacaoRestaurant.Location = new System.Drawing.Point(215, 127);
            this.lb_validacaoRestaurant.Name = "lb_validacaoRestaurant";
            this.lb_validacaoRestaurant.Size = new System.Drawing.Size(0, 13);
            this.lb_validacaoRestaurant.TabIndex = 6;
            // 
            // lb_resultRestaurants
            // 
            this.lb_resultRestaurants.AutoSize = true;
            this.lb_resultRestaurants.Location = new System.Drawing.Point(104, 156);
            this.lb_resultRestaurants.Name = "lb_resultRestaurants";
            this.lb_resultRestaurants.Size = new System.Drawing.Size(0, 13);
            this.lb_resultRestaurants.TabIndex = 5;
            // 
            // tb_filePathRestaurant
            // 
            this.tb_filePathRestaurant.Location = new System.Drawing.Point(71, 28);
            this.tb_filePathRestaurant.Name = "tb_filePathRestaurant";
            this.tb_filePathRestaurant.Size = new System.Drawing.Size(220, 20);
            this.tb_filePathRestaurant.TabIndex = 1;
            // 
            // bt_addFileRestaurants
            // 
            this.bt_addFileRestaurants.Location = new System.Drawing.Point(23, 151);
            this.bt_addFileRestaurants.Name = "bt_addFileRestaurants";
            this.bt_addFileRestaurants.Size = new System.Drawing.Size(75, 23);
            this.bt_addFileRestaurants.TabIndex = 4;
            this.bt_addFileRestaurants.Text = "Add File";
            this.bt_addFileRestaurants.UseVisualStyleBackColor = true;
            this.bt_addFileRestaurants.Click += new System.EventHandler(this.bt_addFileRestaurants_Click);
            // 
            // bt_searchFileRestaurant
            // 
            this.bt_searchFileRestaurant.Location = new System.Drawing.Point(297, 26);
            this.bt_searchFileRestaurant.Name = "bt_searchFileRestaurant";
            this.bt_searchFileRestaurant.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileRestaurant.TabIndex = 2;
            this.bt_searchFileRestaurant.Text = "Search";
            this.bt_searchFileRestaurant.UseVisualStyleBackColor = true;
            this.bt_searchFileRestaurant.Click += new System.EventHandler(this.bt_searchFileRestaurant_Click);
            // 
            // lb_fileNameResturant
            // 
            this.lb_fileNameResturant.AutoSize = true;
            this.lb_fileNameResturant.Location = new System.Drawing.Point(11, 31);
            this.lb_fileNameResturant.Name = "lb_fileNameResturant";
            this.lb_fileNameResturant.Size = new System.Drawing.Size(54, 13);
            this.lb_fileNameResturant.TabIndex = 0;
            this.lb_fileNameResturant.Text = "File Name";
            // 
            // lb_infoRestaurant
            // 
            this.lb_infoRestaurant.AutoSize = true;
            this.lb_infoRestaurant.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_infoRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoRestaurant.Location = new System.Drawing.Point(83, 51);
            this.lb_infoRestaurant.Name = "lb_infoRestaurant";
            this.lb_infoRestaurant.Size = new System.Drawing.Size(186, 60);
            this.lb_infoRestaurant.TabIndex = 3;
            this.lb_infoRestaurant.Text = "Info:\r\nTo enter a file, it must be \r\nin Excel file format (xlsx) ";
            // 
            // tabPage_activities
            // 
            this.tabPage_activities.Controls.Add(this.panel2);
            this.tabPage_activities.Controls.Add(this.panel1);
            this.tabPage_activities.Location = new System.Drawing.Point(4, 22);
            this.tabPage_activities.Name = "tabPage_activities";
            this.tabPage_activities.Size = new System.Drawing.Size(592, 154);
            this.tabPage_activities.TabIndex = 2;
            this.tabPage_activities.Text = "Activities";
            this.tabPage_activities.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_caloriesType);
            this.panel2.Controls.Add(this.bt_addSingleActivity);
            this.panel2.Controls.Add(this.tb_activityMet);
            this.panel2.Controls.Add(this.lb_activityMet);
            this.panel2.Controls.Add(this.tb_calories);
            this.panel2.Controls.Add(this.lb_activityCalories);
            this.panel2.Controls.Add(this.tb_activityName);
            this.panel2.Controls.Add(this.lb_activityName);
            this.panel2.Location = new System.Drawing.Point(396, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 143);
            this.panel2.TabIndex = 8;
            // 
            // bt_addSingleActivity
            // 
            this.bt_addSingleActivity.Location = new System.Drawing.Point(23, 110);
            this.bt_addSingleActivity.Name = "bt_addSingleActivity";
            this.bt_addSingleActivity.Size = new System.Drawing.Size(75, 23);
            this.bt_addSingleActivity.TabIndex = 2;
            this.bt_addSingleActivity.Text = "Add Single";
            this.bt_addSingleActivity.UseVisualStyleBackColor = true;
            // 
            // tb_activityMet
            // 
            this.tb_activityMet.Location = new System.Drawing.Point(70, 63);
            this.tb_activityMet.Name = "tb_activityMet";
            this.tb_activityMet.Size = new System.Drawing.Size(39, 20);
            this.tb_activityMet.TabIndex = 1;
            this.tb_activityMet.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lb_activityMet
            // 
            this.lb_activityMet.AutoSize = true;
            this.lb_activityMet.Location = new System.Drawing.Point(20, 66);
            this.lb_activityMet.Name = "lb_activityMet";
            this.lb_activityMet.Size = new System.Drawing.Size(30, 13);
            this.lb_activityMet.TabIndex = 0;
            this.lb_activityMet.Text = "MET";
            // 
            // tb_calories
            // 
            this.tb_calories.Location = new System.Drawing.Point(70, 37);
            this.tb_calories.Name = "tb_calories";
            this.tb_calories.Size = new System.Drawing.Size(39, 20);
            this.tb_calories.TabIndex = 1;
            // 
            // lb_activityCalories
            // 
            this.lb_activityCalories.AutoSize = true;
            this.lb_activityCalories.Location = new System.Drawing.Point(20, 40);
            this.lb_activityCalories.Name = "lb_activityCalories";
            this.lb_activityCalories.Size = new System.Drawing.Size(44, 13);
            this.lb_activityCalories.TabIndex = 0;
            this.lb_activityCalories.Text = "Calories";
            // 
            // tb_activityName
            // 
            this.tb_activityName.Location = new System.Drawing.Point(70, 12);
            this.tb_activityName.Name = "tb_activityName";
            this.tb_activityName.Size = new System.Drawing.Size(100, 20);
            this.tb_activityName.TabIndex = 1;
            this.tb_activityName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_activityName
            // 
            this.lb_activityName.AutoSize = true;
            this.lb_activityName.Location = new System.Drawing.Point(20, 15);
            this.lb_activityName.Name = "lb_activityName";
            this.lb_activityName.Size = new System.Drawing.Size(35, 13);
            this.lb_activityName.TabIndex = 0;
            this.lb_activityName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_filePathActivity);
            this.panel1.Controls.Add(this.lb_validacaoActivities);
            this.panel1.Controls.Add(this.bt_addFileActivities);
            this.panel1.Controls.Add(this.lb_resultActivities);
            this.panel1.Controls.Add(this.bt_searchFileActivity);
            this.panel1.Controls.Add(this.lb_infoActivities);
            this.panel1.Controls.Add(this.lb_fileNameActivity);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 143);
            this.panel1.TabIndex = 7;
            // 
            // tb_filePathActivity
            // 
            this.tb_filePathActivity.Location = new System.Drawing.Point(72, 15);
            this.tb_filePathActivity.Name = "tb_filePathActivity";
            this.tb_filePathActivity.Size = new System.Drawing.Size(220, 20);
            this.tb_filePathActivity.TabIndex = 1;
            // 
            // lb_validacaoActivities
            // 
            this.lb_validacaoActivities.AutoSize = true;
            this.lb_validacaoActivities.ForeColor = System.Drawing.Color.Red;
            this.lb_validacaoActivities.Location = new System.Drawing.Point(233, 140);
            this.lb_validacaoActivities.Name = "lb_validacaoActivities";
            this.lb_validacaoActivities.Size = new System.Drawing.Size(0, 13);
            this.lb_validacaoActivities.TabIndex = 6;
            // 
            // bt_addFileActivities
            // 
            this.bt_addFileActivities.Location = new System.Drawing.Point(15, 110);
            this.bt_addFileActivities.Name = "bt_addFileActivities";
            this.bt_addFileActivities.Size = new System.Drawing.Size(75, 23);
            this.bt_addFileActivities.TabIndex = 4;
            this.bt_addFileActivities.Text = "Add File";
            this.bt_addFileActivities.UseVisualStyleBackColor = true;
            this.bt_addFileActivities.Click += new System.EventHandler(this.bt_addFileActivities_Click);
            // 
            // lb_resultActivities
            // 
            this.lb_resultActivities.AutoSize = true;
            this.lb_resultActivities.Location = new System.Drawing.Point(125, 164);
            this.lb_resultActivities.Name = "lb_resultActivities";
            this.lb_resultActivities.Size = new System.Drawing.Size(0, 13);
            this.lb_resultActivities.TabIndex = 5;
            // 
            // bt_searchFileActivity
            // 
            this.bt_searchFileActivity.Location = new System.Drawing.Point(298, 13);
            this.bt_searchFileActivity.Name = "bt_searchFileActivity";
            this.bt_searchFileActivity.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileActivity.TabIndex = 2;
            this.bt_searchFileActivity.Text = "Search";
            this.bt_searchFileActivity.UseVisualStyleBackColor = true;
            this.bt_searchFileActivity.Click += new System.EventHandler(this.bt_searchFileActivity_Click);
            // 
            // lb_infoActivities
            // 
            this.lb_infoActivities.AutoSize = true;
            this.lb_infoActivities.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_infoActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoActivities.Location = new System.Drawing.Point(68, 38);
            this.lb_infoActivities.Name = "lb_infoActivities";
            this.lb_infoActivities.Size = new System.Drawing.Size(186, 60);
            this.lb_infoActivities.TabIndex = 3;
            this.lb_infoActivities.Text = "Info:\r\nTo enter a file, it must be \r\nin Json file format (js) ";
            // 
            // lb_fileNameActivity
            // 
            this.lb_fileNameActivity.AutoSize = true;
            this.lb_fileNameActivity.Location = new System.Drawing.Point(12, 18);
            this.lb_fileNameActivity.Name = "lb_fileNameActivity";
            this.lb_fileNameActivity.Size = new System.Drawing.Size(54, 13);
            this.lb_fileNameActivity.TabIndex = 0;
            this.lb_fileNameActivity.Text = "File Name";
            // 
            // cb_caloriesType
            // 
            this.cb_caloriesType.FormattingEnabled = true;
            this.cb_caloriesType.Items.AddRange(new object[] {
            "kcal",
            "cal"});
            this.cb_caloriesType.Location = new System.Drawing.Point(116, 36);
            this.cb_caloriesType.Name = "cb_caloriesType";
            this.cb_caloriesType.Size = new System.Drawing.Size(54, 21);
            this.cb_caloriesType.TabIndex = 3;
            // 
            // FormAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 197);
            this.Controls.Add(this.tab_all);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdministration";
            this.Text = "FormAdministration";
            this.Load += new System.EventHandler(this.FormAdministration_Load);
            this.tab_all.ResumeLayout(false);
            this.tabPage_vegetables.ResumeLayout(false);
            this.tabPage_vegetables.PerformLayout();
            this.tabPage_restaurants.ResumeLayout(false);
            this.tabPage_restaurants.PerformLayout();
            this.tabPage_activities.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_all;
        private System.Windows.Forms.TabPage tabPage_vegetables;
        private System.Windows.Forms.TabPage tabPage_restaurants;
        private System.Windows.Forms.Label lb_resultVegetable;
        private System.Windows.Forms.Button bt_addFileVeggie;
        private System.Windows.Forms.Label lb_infoVeggie;
        private System.Windows.Forms.Button bt_searchFileVeggie;
        private System.Windows.Forms.TextBox tb_filePathVeggie;
        private System.Windows.Forms.Label lb_fileNameVeggie;
        private System.Windows.Forms.TabPage tabPage_activities;
        private System.Windows.Forms.Label lb_resultRestaurants;
        private System.Windows.Forms.TextBox tb_filePathRestaurant;
        private System.Windows.Forms.Button bt_addFileRestaurants;
        private System.Windows.Forms.Button bt_searchFileRestaurant;
        private System.Windows.Forms.Label lb_fileNameResturant;
        private System.Windows.Forms.Label lb_infoRestaurant;
        private System.Windows.Forms.Label lb_resultActivities;
        private System.Windows.Forms.Label lb_infoActivities;
        private System.Windows.Forms.TextBox tb_filePathActivity;
        private System.Windows.Forms.Label lb_fileNameActivity;
        private System.Windows.Forms.Button bt_searchFileActivity;
        private System.Windows.Forms.Button bt_addFileActivities;
        private System.Windows.Forms.Label lb_validacao;
        private System.Windows.Forms.Label lb_validacaoRestaurant;
        private System.Windows.Forms.Label lb_validacaoActivities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_addSingleActivity;
        private System.Windows.Forms.TextBox tb_activityMet;
        private System.Windows.Forms.Label lb_activityMet;
        private System.Windows.Forms.TextBox tb_calories;
        private System.Windows.Forms.Label lb_activityCalories;
        private System.Windows.Forms.TextBox tb_activityName;
        private System.Windows.Forms.Label lb_activityName;
        private System.Windows.Forms.ComboBox cb_caloriesType;
    }
}