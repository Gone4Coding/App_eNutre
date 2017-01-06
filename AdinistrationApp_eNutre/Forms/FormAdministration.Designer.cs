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
            this.panel_vegetablesFullFile = new System.Windows.Forms.Panel();
            this.lb_infoVeggie = new System.Windows.Forms.Label();
            this.lb_fileNameVeggie = new System.Windows.Forms.Label();
            this.lb_validacao = new System.Windows.Forms.Label();
            this.tb_filePathVeggie = new System.Windows.Forms.TextBox();
            this.bt_addFileVeggie = new System.Windows.Forms.Button();
            this.bt_searchFileVeggie = new System.Windows.Forms.Button();
            this.lb_resultVegetable = new System.Windows.Forms.Label();
            this.tabPage_plates = new System.Windows.Forms.TabPage();
            this.panel_platesFullFile = new System.Windows.Forms.Panel();
            this.tb_filePathRestaurant = new System.Windows.Forms.TextBox();
            this.lb_infoRestaurant = new System.Windows.Forms.Label();
            this.lb_fileNameResturant = new System.Windows.Forms.Label();
            this.lb_resultRestaurants = new System.Windows.Forms.Label();
            this.bt_addFileRestaurants = new System.Windows.Forms.Button();
            this.bt_searchFileRestaurant = new System.Windows.Forms.Button();
            this.lb_validacaoRestaurant = new System.Windows.Forms.Label();
            this.tabPage_activities = new System.Windows.Forms.TabPage();
            this.panel_activitiesFullFile = new System.Windows.Forms.Panel();
            this.tb_filePathActivity = new System.Windows.Forms.TextBox();
            this.lb_validacaoActivities = new System.Windows.Forms.Label();
            this.bt_addFileActivities = new System.Windows.Forms.Button();
            this.lb_resultActivities = new System.Windows.Forms.Label();
            this.bt_searchFileActivity = new System.Windows.Forms.Button();
            this.lb_infoActivities = new System.Windows.Forms.Label();
            this.lb_fileNameActivity = new System.Windows.Forms.Label();
            this.tab_all.SuspendLayout();
            this.tabPage_vegetables.SuspendLayout();
            this.panel_vegetablesFullFile.SuspendLayout();
            this.tabPage_plates.SuspendLayout();
            this.panel_platesFullFile.SuspendLayout();
            this.tabPage_activities.SuspendLayout();
            this.panel_activitiesFullFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_all
            // 
            this.tab_all.Controls.Add(this.tabPage_vegetables);
            this.tab_all.Controls.Add(this.tabPage_plates);
            this.tab_all.Controls.Add(this.tabPage_activities);
            this.tab_all.Location = new System.Drawing.Point(12, 12);
            this.tab_all.Name = "tab_all";
            this.tab_all.SelectedIndex = 0;
            this.tab_all.Size = new System.Drawing.Size(600, 195);
            this.tab_all.TabIndex = 0;
            // 
            // tabPage_vegetables
            // 
            this.tabPage_vegetables.Controls.Add(this.panel_vegetablesFullFile);
            this.tabPage_vegetables.Controls.Add(this.lb_resultVegetable);
            this.tabPage_vegetables.Location = new System.Drawing.Point(4, 22);
            this.tabPage_vegetables.Name = "tabPage_vegetables";
            this.tabPage_vegetables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_vegetables.Size = new System.Drawing.Size(592, 169);
            this.tabPage_vegetables.TabIndex = 0;
            this.tabPage_vegetables.Text = "Vegetais";
            this.tabPage_vegetables.UseVisualStyleBackColor = true;
            // 
            // panel_vegetablesFullFile
            // 
            this.panel_vegetablesFullFile.Controls.Add(this.lb_infoVeggie);
            this.panel_vegetablesFullFile.Controls.Add(this.lb_fileNameVeggie);
            this.panel_vegetablesFullFile.Controls.Add(this.lb_validacao);
            this.panel_vegetablesFullFile.Controls.Add(this.tb_filePathVeggie);
            this.panel_vegetablesFullFile.Controls.Add(this.bt_addFileVeggie);
            this.panel_vegetablesFullFile.Controls.Add(this.bt_searchFileVeggie);
            this.panel_vegetablesFullFile.Location = new System.Drawing.Point(3, 3);
            this.panel_vegetablesFullFile.Name = "panel_vegetablesFullFile";
            this.panel_vegetablesFullFile.Size = new System.Drawing.Size(586, 158);
            this.panel_vegetablesFullFile.TabIndex = 7;
            // 
            // lb_infoVeggie
            // 
            this.lb_infoVeggie.AutoSize = true;
            this.lb_infoVeggie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_infoVeggie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoVeggie.Location = new System.Drawing.Point(68, 38);
            this.lb_infoVeggie.Name = "lb_infoVeggie";
            this.lb_infoVeggie.Size = new System.Drawing.Size(199, 60);
            this.lb_infoVeggie.TabIndex = 3;
            this.lb_infoVeggie.Text = "Info:\r\nPara adicionar um ficheiro, \r\tem de estar em TXT (.txt) ";
            // 
            // lb_fileNameVeggie
            // 
            this.lb_fileNameVeggie.AutoSize = true;
            this.lb_fileNameVeggie.Location = new System.Drawing.Point(12, 18);
            this.lb_fileNameVeggie.Name = "lb_fileNameVeggie";
            this.lb_fileNameVeggie.Size = new System.Drawing.Size(53, 26);
            this.lb_fileNameVeggie.TabIndex = 0;
            this.lb_fileNameVeggie.Text = "Nome do \r\nficheiro";
            // 
            // lb_validacao
            // 
            this.lb_validacao.AutoSize = true;
            this.lb_validacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_validacao.ForeColor = System.Drawing.Color.Red;
            this.lb_validacao.Location = new System.Drawing.Point(101, 125);
            this.lb_validacao.Name = "lb_validacao";
            this.lb_validacao.Size = new System.Drawing.Size(0, 13);
            this.lb_validacao.TabIndex = 6;
            // 
            // tb_filePathVeggie
            // 
            this.tb_filePathVeggie.Location = new System.Drawing.Point(72, 15);
            this.tb_filePathVeggie.Name = "tb_filePathVeggie";
            this.tb_filePathVeggie.Size = new System.Drawing.Size(430, 20);
            this.tb_filePathVeggie.TabIndex = 1;
            // 
            // bt_addFileVeggie
            // 
            this.bt_addFileVeggie.Location = new System.Drawing.Point(15, 107);
            this.bt_addFileVeggie.Name = "bt_addFileVeggie";
            this.bt_addFileVeggie.Size = new System.Drawing.Size(75, 48);
            this.bt_addFileVeggie.TabIndex = 4;
            this.bt_addFileVeggie.Text = "Adicionar\r\nFicheiro";
            this.bt_addFileVeggie.UseVisualStyleBackColor = true;
            this.bt_addFileVeggie.Click += new System.EventHandler(this.bt_addFileVeggie_Click);
            // 
            // bt_searchFileVeggie
            // 
            this.bt_searchFileVeggie.Location = new System.Drawing.Point(508, 13);
            this.bt_searchFileVeggie.Name = "bt_searchFileVeggie";
            this.bt_searchFileVeggie.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileVeggie.TabIndex = 2;
            this.bt_searchFileVeggie.Text = "Procurar";
            this.bt_searchFileVeggie.UseVisualStyleBackColor = true;
            this.bt_searchFileVeggie.Click += new System.EventHandler(this.bt_searchFileVeggie_Click);
            // 
            // lb_resultVegetable
            // 
            this.lb_resultVegetable.AutoSize = true;
            this.lb_resultVegetable.Location = new System.Drawing.Point(104, 156);
            this.lb_resultVegetable.Name = "lb_resultVegetable";
            this.lb_resultVegetable.Size = new System.Drawing.Size(0, 13);
            this.lb_resultVegetable.TabIndex = 5;
            // 
            // tabPage_plates
            // 
            this.tabPage_plates.Controls.Add(this.panel_platesFullFile);
            this.tabPage_plates.Controls.Add(this.lb_validacaoRestaurant);
            this.tabPage_plates.Location = new System.Drawing.Point(4, 22);
            this.tabPage_plates.Name = "tabPage_plates";
            this.tabPage_plates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_plates.Size = new System.Drawing.Size(592, 169);
            this.tabPage_plates.TabIndex = 1;
            this.tabPage_plates.Text = "Pratos";
            this.tabPage_plates.UseVisualStyleBackColor = true;
            // 
            // panel_platesFullFile
            // 
            this.panel_platesFullFile.Controls.Add(this.tb_filePathRestaurant);
            this.panel_platesFullFile.Controls.Add(this.lb_infoRestaurant);
            this.panel_platesFullFile.Controls.Add(this.lb_fileNameResturant);
            this.panel_platesFullFile.Controls.Add(this.lb_resultRestaurants);
            this.panel_platesFullFile.Controls.Add(this.bt_addFileRestaurants);
            this.panel_platesFullFile.Controls.Add(this.bt_searchFileRestaurant);
            this.panel_platesFullFile.Location = new System.Drawing.Point(3, 3);
            this.panel_platesFullFile.Name = "panel_platesFullFile";
            this.panel_platesFullFile.Size = new System.Drawing.Size(586, 158);
            this.panel_platesFullFile.TabIndex = 7;
            // 
            // tb_filePathRestaurant
            // 
            this.tb_filePathRestaurant.Location = new System.Drawing.Point(72, 15);
            this.tb_filePathRestaurant.Name = "tb_filePathRestaurant";
            this.tb_filePathRestaurant.Size = new System.Drawing.Size(430, 20);
            this.tb_filePathRestaurant.TabIndex = 1;
            // 
            // lb_infoRestaurant
            // 
            this.lb_infoRestaurant.AutoSize = true;
            this.lb_infoRestaurant.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_infoRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoRestaurant.Location = new System.Drawing.Point(68, 38);
            this.lb_infoRestaurant.Name = "lb_infoRestaurant";
            this.lb_infoRestaurant.Size = new System.Drawing.Size(208, 60);
            this.lb_infoRestaurant.TabIndex = 3;
            this.lb_infoRestaurant.Text = "Info:\r\nPara adicionar um ficheiro, \r\tem de estar em Excel (.xlsx) ";
            // 
            // lb_fileNameResturant
            // 
            this.lb_fileNameResturant.AutoSize = true;
            this.lb_fileNameResturant.Location = new System.Drawing.Point(12, 18);
            this.lb_fileNameResturant.Name = "lb_fileNameResturant";
            this.lb_fileNameResturant.Size = new System.Drawing.Size(53, 26);
            this.lb_fileNameResturant.TabIndex = 0;
            this.lb_fileNameResturant.Text = "Nome do \r\nficheiro";
            // 
            // lb_resultRestaurants
            // 
            this.lb_resultRestaurants.AutoSize = true;
            this.lb_resultRestaurants.Location = new System.Drawing.Point(101, 125);
            this.lb_resultRestaurants.Name = "lb_resultRestaurants";
            this.lb_resultRestaurants.Size = new System.Drawing.Size(0, 13);
            this.lb_resultRestaurants.TabIndex = 5;
            // 
            // bt_addFileRestaurants
            // 
            this.bt_addFileRestaurants.Location = new System.Drawing.Point(15, 107);
            this.bt_addFileRestaurants.Name = "bt_addFileRestaurants";
            this.bt_addFileRestaurants.Size = new System.Drawing.Size(75, 48);
            this.bt_addFileRestaurants.TabIndex = 4;
            this.bt_addFileRestaurants.Text = "Adicionar\r\nFicheiro";
            this.bt_addFileRestaurants.UseVisualStyleBackColor = true;
            this.bt_addFileRestaurants.Click += new System.EventHandler(this.bt_addFileRestaurants_Click);
            // 
            // bt_searchFileRestaurant
            // 
            this.bt_searchFileRestaurant.Location = new System.Drawing.Point(508, 13);
            this.bt_searchFileRestaurant.Name = "bt_searchFileRestaurant";
            this.bt_searchFileRestaurant.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileRestaurant.TabIndex = 2;
            this.bt_searchFileRestaurant.Text = "Procurar";
            this.bt_searchFileRestaurant.UseVisualStyleBackColor = true;
            this.bt_searchFileRestaurant.Click += new System.EventHandler(this.bt_searchFileRestaurant_Click);
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
            // tabPage_activities
            // 
            this.tabPage_activities.Controls.Add(this.panel_activitiesFullFile);
            this.tabPage_activities.Location = new System.Drawing.Point(4, 22);
            this.tabPage_activities.Name = "tabPage_activities";
            this.tabPage_activities.Size = new System.Drawing.Size(592, 169);
            this.tabPage_activities.TabIndex = 2;
            this.tabPage_activities.Text = "Atividades";
            this.tabPage_activities.UseVisualStyleBackColor = true;
            // 
            // panel_activitiesFullFile
            // 
            this.panel_activitiesFullFile.Controls.Add(this.tb_filePathActivity);
            this.panel_activitiesFullFile.Controls.Add(this.lb_validacaoActivities);
            this.panel_activitiesFullFile.Controls.Add(this.bt_addFileActivities);
            this.panel_activitiesFullFile.Controls.Add(this.lb_resultActivities);
            this.panel_activitiesFullFile.Controls.Add(this.bt_searchFileActivity);
            this.panel_activitiesFullFile.Controls.Add(this.lb_infoActivities);
            this.panel_activitiesFullFile.Controls.Add(this.lb_fileNameActivity);
            this.panel_activitiesFullFile.Location = new System.Drawing.Point(3, 3);
            this.panel_activitiesFullFile.Name = "panel_activitiesFullFile";
            this.panel_activitiesFullFile.Size = new System.Drawing.Size(586, 158);
            this.panel_activitiesFullFile.TabIndex = 7;
            // 
            // tb_filePathActivity
            // 
            this.tb_filePathActivity.Location = new System.Drawing.Point(72, 15);
            this.tb_filePathActivity.Name = "tb_filePathActivity";
            this.tb_filePathActivity.Size = new System.Drawing.Size(430, 20);
            this.tb_filePathActivity.TabIndex = 1;
            // 
            // lb_validacaoActivities
            // 
            this.lb_validacaoActivities.AutoSize = true;
            this.lb_validacaoActivities.ForeColor = System.Drawing.Color.Red;
            this.lb_validacaoActivities.Location = new System.Drawing.Point(101, 125);
            this.lb_validacaoActivities.Name = "lb_validacaoActivities";
            this.lb_validacaoActivities.Size = new System.Drawing.Size(0, 13);
            this.lb_validacaoActivities.TabIndex = 6;
            // 
            // bt_addFileActivities
            // 
            this.bt_addFileActivities.Location = new System.Drawing.Point(15, 107);
            this.bt_addFileActivities.Name = "bt_addFileActivities";
            this.bt_addFileActivities.Size = new System.Drawing.Size(75, 48);
            this.bt_addFileActivities.TabIndex = 4;
            this.bt_addFileActivities.Text = "Adicionar\r\nFicheiro";
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
            this.bt_searchFileActivity.Location = new System.Drawing.Point(508, 13);
            this.bt_searchFileActivity.Name = "bt_searchFileActivity";
            this.bt_searchFileActivity.Size = new System.Drawing.Size(75, 23);
            this.bt_searchFileActivity.TabIndex = 2;
            this.bt_searchFileActivity.Text = "Procurar";
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
            this.lb_infoActivities.Size = new System.Drawing.Size(199, 60);
            this.lb_infoActivities.TabIndex = 3;
            this.lb_infoActivities.Text = "Info:\r\nPara adicionar um ficheiro, \r\tem de estar em JSON (.js) ";
            // 
            // lb_fileNameActivity
            // 
            this.lb_fileNameActivity.AutoSize = true;
            this.lb_fileNameActivity.Location = new System.Drawing.Point(12, 18);
            this.lb_fileNameActivity.Name = "lb_fileNameActivity";
            this.lb_fileNameActivity.Size = new System.Drawing.Size(53, 26);
            this.lb_fileNameActivity.TabIndex = 0;
            this.lb_fileNameActivity.Text = "Nome do \r\nficheiro";
            // 
            // FormAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 214);
            this.Controls.Add(this.tab_all);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdministration";
            this.Text = "Administração";
            this.Load += new System.EventHandler(this.FormAdministration_Load);
            this.tab_all.ResumeLayout(false);
            this.tabPage_vegetables.ResumeLayout(false);
            this.tabPage_vegetables.PerformLayout();
            this.panel_vegetablesFullFile.ResumeLayout(false);
            this.panel_vegetablesFullFile.PerformLayout();
            this.tabPage_plates.ResumeLayout(false);
            this.tabPage_plates.PerformLayout();
            this.panel_platesFullFile.ResumeLayout(false);
            this.panel_platesFullFile.PerformLayout();
            this.tabPage_activities.ResumeLayout(false);
            this.panel_activitiesFullFile.ResumeLayout(false);
            this.panel_activitiesFullFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_all;
        private System.Windows.Forms.TabPage tabPage_vegetables;
        private System.Windows.Forms.TabPage tabPage_plates;
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
        private System.Windows.Forms.Panel panel_activitiesFullFile;
        private System.Windows.Forms.Panel panel_platesFullFile;
        private System.Windows.Forms.Panel panel_vegetablesFullFile;
    }
}