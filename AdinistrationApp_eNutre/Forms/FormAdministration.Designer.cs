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
            this.tabPage_restaurants = new System.Windows.Forms.TabPage();
            this.tabPage_activities = new System.Windows.Forms.TabPage();
            this.lb_addFileVeggie = new System.Windows.Forms.Label();
            this.tb_filePathVeggie = new System.Windows.Forms.TextBox();
            this.bt_searchFileVeggie = new System.Windows.Forms.Button();
            this.lb_infoVeggie = new System.Windows.Forms.Label();
            this.bt_addFileVeggie = new System.Windows.Forms.Button();
            this.lb_resultVegetable = new System.Windows.Forms.Label();
            this.lb_addFileResturant = new System.Windows.Forms.Label();
            this.tb_filePathRestaurant = new System.Windows.Forms.TextBox();
            this.bt_searchFileRestaurant = new System.Windows.Forms.Button();
            this.lb_infoRestaurant = new System.Windows.Forms.Label();
            this.bt_addFileRestaurants = new System.Windows.Forms.Button();
            this.lb_resultRestaurants = new System.Windows.Forms.Label();
            this.lb_addFileActivity = new System.Windows.Forms.Label();
            this.bt_searchFileActivity = new System.Windows.Forms.Button();
            this.lb_infoActivities = new System.Windows.Forms.Label();
            this.bt_addFileActivities = new System.Windows.Forms.Button();
            this.tb_filePathActivity = new System.Windows.Forms.TextBox();
            this.lb_resultActivities = new System.Windows.Forms.Label();
            this.tab_all.SuspendLayout();
            this.tabPage_vegetables.SuspendLayout();
            this.tabPage_restaurants.SuspendLayout();
            this.tabPage_activities.SuspendLayout();
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
            this.tab_all.Size = new System.Drawing.Size(417, 220);
            this.tab_all.TabIndex = 0;
            // 
            // tabPage_vegetables
            // 
            this.tabPage_vegetables.Controls.Add(this.lb_resultVegetable);
            this.tabPage_vegetables.Controls.Add(this.bt_addFileVeggie);
            this.tabPage_vegetables.Controls.Add(this.lb_infoVeggie);
            this.tabPage_vegetables.Controls.Add(this.bt_searchFileVeggie);
            this.tabPage_vegetables.Controls.Add(this.tb_filePathVeggie);
            this.tabPage_vegetables.Controls.Add(this.lb_addFileVeggie);
            this.tabPage_vegetables.Location = new System.Drawing.Point(4, 22);
            this.tabPage_vegetables.Name = "tabPage_vegetables";
            this.tabPage_vegetables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_vegetables.Size = new System.Drawing.Size(409, 194);
            this.tabPage_vegetables.TabIndex = 0;
            this.tabPage_vegetables.Text = "Vegetables";
            this.tabPage_vegetables.UseVisualStyleBackColor = true;
            // 
            // tabPage_restaurants
            // 
            this.tabPage_restaurants.Controls.Add(this.lb_resultRestaurants);
            this.tabPage_restaurants.Controls.Add(this.tb_filePathRestaurant);
            this.tabPage_restaurants.Controls.Add(this.bt_addFileRestaurants);
            this.tabPage_restaurants.Controls.Add(this.bt_searchFileRestaurant);
            this.tabPage_restaurants.Controls.Add(this.lb_addFileResturant);
            this.tabPage_restaurants.Controls.Add(this.lb_infoRestaurant);
            this.tabPage_restaurants.Location = new System.Drawing.Point(4, 22);
            this.tabPage_restaurants.Name = "tabPage_restaurants";
            this.tabPage_restaurants.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_restaurants.Size = new System.Drawing.Size(409, 194);
            this.tabPage_restaurants.TabIndex = 1;
            this.tabPage_restaurants.Text = "Restaurants";
            this.tabPage_restaurants.UseVisualStyleBackColor = true;
            // 
            // tabPage_activities
            // 
            this.tabPage_activities.Controls.Add(this.lb_resultActivities);
            this.tabPage_activities.Controls.Add(this.lb_infoActivities);
            this.tabPage_activities.Controls.Add(this.tb_filePathActivity);
            this.tabPage_activities.Controls.Add(this.lb_addFileActivity);
            this.tabPage_activities.Controls.Add(this.bt_searchFileActivity);
            this.tabPage_activities.Controls.Add(this.bt_addFileActivities);
            this.tabPage_activities.Location = new System.Drawing.Point(4, 22);
            this.tabPage_activities.Name = "tabPage_activities";
            this.tabPage_activities.Size = new System.Drawing.Size(409, 194);
            this.tabPage_activities.TabIndex = 2;
            this.tabPage_activities.Text = "Activities";
            this.tabPage_activities.UseVisualStyleBackColor = true;
            // 
            // lb_addFileVeggie
            // 
            this.lb_addFileVeggie.AutoSize = true;
            this.lb_addFileVeggie.Location = new System.Drawing.Point(20, 31);
            this.lb_addFileVeggie.Name = "lb_addFileVeggie";
            this.lb_addFileVeggie.Size = new System.Drawing.Size(45, 13);
            this.lb_addFileVeggie.TabIndex = 0;
            this.lb_addFileVeggie.Text = "Add File";
            // 
            // tb_filePathVeggie
            // 
            this.tb_filePathVeggie.Location = new System.Drawing.Point(71, 28);
            this.tb_filePathVeggie.Name = "tb_filePathVeggie";
            this.tb_filePathVeggie.Size = new System.Drawing.Size(211, 20);
            this.tb_filePathVeggie.TabIndex = 1;
            // 
            // bt_searchFileVeggie
            // 
            this.bt_searchFileVeggie.Location = new System.Drawing.Point(288, 26);
            this.bt_searchFileVeggie.Name = "bt_searchFileVeggie";
            this.bt_searchFileVeggie.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileVeggie.TabIndex = 2;
            this.bt_searchFileVeggie.Text = "Search";
            this.bt_searchFileVeggie.UseVisualStyleBackColor = true;
            this.bt_searchFileVeggie.Click += new System.EventHandler(this.bt_searchFileVeggie_Click);
            // 
            // lb_infoVeggie
            // 
            this.lb_infoVeggie.AutoSize = true;
            this.lb_infoVeggie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_infoVeggie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoVeggie.Location = new System.Drawing.Point(83, 51);
            this.lb_infoVeggie.Name = "lb_infoVeggie";
            this.lb_infoVeggie.Size = new System.Drawing.Size(186, 60);
            this.lb_infoVeggie.TabIndex = 3;
            this.lb_infoVeggie.Text = "Info:\r\nTo enter a file, it must be \r\nin Text file format (txt) ";
            // 
            // bt_addFileVeggie
            // 
            this.bt_addFileVeggie.Location = new System.Drawing.Point(23, 151);
            this.bt_addFileVeggie.Name = "bt_addFileVeggie";
            this.bt_addFileVeggie.Size = new System.Drawing.Size(75, 23);
            this.bt_addFileVeggie.TabIndex = 4;
            this.bt_addFileVeggie.Text = "Add File";
            this.bt_addFileVeggie.UseVisualStyleBackColor = true;
            this.bt_addFileVeggie.Click += new System.EventHandler(this.bt_addFileVeggie_Click);
            // 
            // lb_resultVegetable
            // 
            this.lb_resultVegetable.AutoSize = true;
            this.lb_resultVegetable.Location = new System.Drawing.Point(104, 156);
            this.lb_resultVegetable.Name = "lb_resultVegetable";
            this.lb_resultVegetable.Size = new System.Drawing.Size(56, 13);
            this.lb_resultVegetable.TabIndex = 5;
            this.lb_resultVegetable.Text = "(RESULT)";
            // 
            // lb_addFileResturant
            // 
            this.lb_addFileResturant.AutoSize = true;
            this.lb_addFileResturant.Location = new System.Drawing.Point(20, 31);
            this.lb_addFileResturant.Name = "lb_addFileResturant";
            this.lb_addFileResturant.Size = new System.Drawing.Size(45, 13);
            this.lb_addFileResturant.TabIndex = 0;
            this.lb_addFileResturant.Text = "Add File";
            // 
            // tb_filePathRestaurant
            // 
            this.tb_filePathRestaurant.Location = new System.Drawing.Point(71, 28);
            this.tb_filePathRestaurant.Name = "tb_filePathRestaurant";
            this.tb_filePathRestaurant.Size = new System.Drawing.Size(211, 20);
            this.tb_filePathRestaurant.TabIndex = 1;
            // 
            // bt_searchFileRestaurant
            // 
            this.bt_searchFileRestaurant.Location = new System.Drawing.Point(288, 26);
            this.bt_searchFileRestaurant.Name = "bt_searchFileRestaurant";
            this.bt_searchFileRestaurant.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileRestaurant.TabIndex = 2;
            this.bt_searchFileRestaurant.Text = "Search";
            this.bt_searchFileRestaurant.UseVisualStyleBackColor = true;
            this.bt_searchFileRestaurant.Click += new System.EventHandler(this.bt_searchFileRestaurant_Click);
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
            // lb_resultRestaurants
            // 
            this.lb_resultRestaurants.AutoSize = true;
            this.lb_resultRestaurants.Location = new System.Drawing.Point(104, 156);
            this.lb_resultRestaurants.Name = "lb_resultRestaurants";
            this.lb_resultRestaurants.Size = new System.Drawing.Size(56, 13);
            this.lb_resultRestaurants.TabIndex = 5;
            this.lb_resultRestaurants.Text = "(RESULT)";
            // 
            // lb_addFileActivity
            // 
            this.lb_addFileActivity.AutoSize = true;
            this.lb_addFileActivity.Location = new System.Drawing.Point(20, 31);
            this.lb_addFileActivity.Name = "lb_addFileActivity";
            this.lb_addFileActivity.Size = new System.Drawing.Size(45, 13);
            this.lb_addFileActivity.TabIndex = 0;
            this.lb_addFileActivity.Text = "Add File";
            // 
            // bt_searchFileActivity
            // 
            this.bt_searchFileActivity.Location = new System.Drawing.Point(288, 26);
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
            this.lb_infoActivities.Location = new System.Drawing.Point(83, 51);
            this.lb_infoActivities.Name = "lb_infoActivities";
            this.lb_infoActivities.Size = new System.Drawing.Size(186, 60);
            this.lb_infoActivities.TabIndex = 3;
            this.lb_infoActivities.Text = "Info:\r\nTo enter a file, it must be \r\nin Json file format (js) ";
            // 
            // bt_addFileActivities
            // 
            this.bt_addFileActivities.Location = new System.Drawing.Point(23, 151);
            this.bt_addFileActivities.Name = "bt_addFileActivities";
            this.bt_addFileActivities.Size = new System.Drawing.Size(75, 23);
            this.bt_addFileActivities.TabIndex = 4;
            this.bt_addFileActivities.Text = "Add File";
            this.bt_addFileActivities.UseVisualStyleBackColor = true;
            this.bt_addFileActivities.Click += new System.EventHandler(this.bt_addFileActivities_Click);
            // 
            // tb_filePathActivity
            // 
            this.tb_filePathActivity.Location = new System.Drawing.Point(71, 28);
            this.tb_filePathActivity.Name = "tb_filePathActivity";
            this.tb_filePathActivity.Size = new System.Drawing.Size(211, 20);
            this.tb_filePathActivity.TabIndex = 1;
            // 
            // lb_resultActivities
            // 
            this.lb_resultActivities.AutoSize = true;
            this.lb_resultActivities.Location = new System.Drawing.Point(104, 156);
            this.lb_resultActivities.Name = "lb_resultActivities";
            this.lb_resultActivities.Size = new System.Drawing.Size(56, 13);
            this.lb_resultActivities.TabIndex = 5;
            this.lb_resultActivities.Text = "(RESULT)";
            // 
            // FormAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 241);
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
            this.tabPage_activities.PerformLayout();
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
        private System.Windows.Forms.Label lb_addFileVeggie;
        private System.Windows.Forms.TabPage tabPage_activities;
        private System.Windows.Forms.Label lb_resultRestaurants;
        private System.Windows.Forms.TextBox tb_filePathRestaurant;
        private System.Windows.Forms.Button bt_addFileRestaurants;
        private System.Windows.Forms.Button bt_searchFileRestaurant;
        private System.Windows.Forms.Label lb_addFileResturant;
        private System.Windows.Forms.Label lb_infoRestaurant;
        private System.Windows.Forms.Label lb_resultActivities;
        private System.Windows.Forms.Label lb_infoActivities;
        private System.Windows.Forms.TextBox tb_filePathActivity;
        private System.Windows.Forms.Label lb_addFileActivity;
        private System.Windows.Forms.Button bt_searchFileActivity;
        private System.Windows.Forms.Button bt_addFileActivities;
    }
}