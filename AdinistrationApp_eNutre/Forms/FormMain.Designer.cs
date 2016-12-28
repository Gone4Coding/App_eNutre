namespace AdinistrationApp_eNutre.Forms
{
    partial class FormMain
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menu_activities = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_nutrition = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_restaurants = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_foods = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sugestions = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_adminstration = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel_all = new System.Windows.Forms.Panel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_updade = new System.Windows.Forms.Button();
            this.bt_new = new System.Windows.Forms.Button();
            this.lv_tables = new System.Windows.Forms.ListView();
            this.bt_close = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.panel_all.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_activities,
            this.menu_nutrition,
            this.menu_sugestions});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(97, 365);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menu";
            // 
            // menu_activities
            // 
            this.menu_activities.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menu_activities.Name = "menu_activities";
            this.menu_activities.Size = new System.Drawing.Size(84, 24);
            this.menu_activities.Text = "Atividades";
            this.menu_activities.Click += new System.EventHandler(this.menu_activities_Click);
            // 
            // menu_nutrition
            // 
            this.menu_nutrition.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menu_nutrition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_restaurants,
            this.menu_foods});
            this.menu_nutrition.Name = "menu_nutrition";
            this.menu_nutrition.Size = new System.Drawing.Size(84, 24);
            this.menu_nutrition.Text = "Nutrição";
            // 
            // menu_restaurants
            // 
            this.menu_restaurants.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menu_restaurants.Name = "menu_restaurants";
            this.menu_restaurants.Size = new System.Drawing.Size(134, 24);
            this.menu_restaurants.Text = "Pratos";
            this.menu_restaurants.Click += new System.EventHandler(this.menu_restaurants_Click);
            // 
            // menu_foods
            // 
            this.menu_foods.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menu_foods.Name = "menu_foods";
            this.menu_foods.Size = new System.Drawing.Size(134, 24);
            this.menu_foods.Text = "Vegetais";
            this.menu_foods.Click += new System.EventHandler(this.menu_foods_Click);
            // 
            // menu_sugestions
            // 
            this.menu_sugestions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menu_sugestions.Name = "menu_sugestions";
            this.menu_sugestions.Size = new System.Drawing.Size(84, 24);
            this.menu_sugestions.Text = "Sugestões";
            this.menu_sugestions.Click += new System.EventHandler(this.menu_sugestions_Click);
            // 
            // bt_adminstration
            // 
            this.bt_adminstration.Location = new System.Drawing.Point(12, 301);
            this.bt_adminstration.Name = "bt_adminstration";
            this.bt_adminstration.Size = new System.Drawing.Size(83, 23);
            this.bt_adminstration.TabIndex = 1;
            this.bt_adminstration.Text = "Administração";
            this.bt_adminstration.UseVisualStyleBackColor = true;
            this.bt_adminstration.Click += new System.EventHandler(this.bt_adminstration_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("High Tower Text", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.Location = new System.Drawing.Point(181, 141);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(406, 75);
            this.lb_welcome.TabIndex = 2;
            this.lb_welcome.Text = "BEM VINDO";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(134, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(86, 32);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Título";
            // 
            // panel_all
            // 
            this.panel_all.Controls.Add(this.bt_delete);
            this.panel_all.Controls.Add(this.bt_updade);
            this.panel_all.Controls.Add(this.bt_new);
            this.panel_all.Controls.Add(this.lv_tables);
            this.panel_all.Location = new System.Drawing.Point(114, 40);
            this.panel_all.Name = "panel_all";
            this.panel_all.Size = new System.Drawing.Size(515, 313);
            this.panel_all.TabIndex = 4;
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(197, 264);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(83, 32);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "Apagar";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_updade
            // 
            this.bt_updade.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_updade.Location = new System.Drawing.Point(92, 264);
            this.bt_updade.Name = "bt_updade";
            this.bt_updade.Size = new System.Drawing.Size(99, 32);
            this.bt_updade.TabIndex = 1;
            this.bt_updade.Text = "Atualizar";
            this.bt_updade.UseVisualStyleBackColor = true;
            this.bt_updade.Click += new System.EventHandler(this.bt_updade_Click);
            // 
            // bt_new
            // 
            this.bt_new.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_new.Location = new System.Drawing.Point(11, 264);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(75, 32);
            this.bt_new.TabIndex = 1;
            this.bt_new.Text = "Novo";
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // lv_tables
            // 
            this.lv_tables.FullRowSelect = true;
            this.lv_tables.Location = new System.Drawing.Point(11, 21);
            this.lv_tables.Name = "lv_tables";
            this.lv_tables.Size = new System.Drawing.Size(484, 237);
            this.lv_tables.TabIndex = 0;
            this.lv_tables.UseCompatibleStateImageBehavior = false;
            this.lv_tables.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lv_tables_ColumnWidthChanging);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(12, 330);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(83, 23);
            this.bt_close.TabIndex = 1;
            this.bt_close.Text = "Fechar";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 365);
            this.ControlBox = false;
            this.Controls.Add(this.panel_all);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_adminstration);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "App de Administração";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panel_all.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menu_activities;
        private System.Windows.Forms.ToolStripMenuItem menu_nutrition;
        private System.Windows.Forms.ToolStripMenuItem menu_restaurants;
        private System.Windows.Forms.ToolStripMenuItem menu_foods;
        private System.Windows.Forms.ToolStripMenuItem menu_sugestions;
        private System.Windows.Forms.Button bt_adminstration;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel panel_all;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_updade;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.ListView lv_tables;
        private System.Windows.Forms.Button bt_close;
    }
}