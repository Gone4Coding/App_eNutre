namespace AdinistrationApp_eNutre.Forms
{
    partial class FormActivity
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
            this.cb_caloriesType = new System.Windows.Forms.ComboBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.tb_activityMet = new System.Windows.Forms.TextBox();
            this.lb_activityMet = new System.Windows.Forms.Label();
            this.tb_calories = new System.Windows.Forms.TextBox();
            this.lb_activityCalories = new System.Windows.Forms.Label();
            this.tb_activityName = new System.Windows.Forms.TextBox();
            this.lb_activityName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_caloriesType
            // 
            this.cb_caloriesType.FormattingEnabled = true;
            this.cb_caloriesType.Location = new System.Drawing.Point(136, 37);
            this.cb_caloriesType.Name = "cb_caloriesType";
            this.cb_caloriesType.Size = new System.Drawing.Size(68, 21);
            this.cb_caloriesType.TabIndex = 11;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(12, 98);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionar.TabIndex = 10;
            this.bt_adicionar.Text = "Adicionar\r";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // tb_activityMet
            // 
            this.tb_activityMet.Location = new System.Drawing.Point(60, 63);
            this.tb_activityMet.Name = "tb_activityMet";
            this.tb_activityMet.Size = new System.Drawing.Size(70, 20);
            this.tb_activityMet.TabIndex = 7;
            // 
            // lb_activityMet
            // 
            this.lb_activityMet.AutoSize = true;
            this.lb_activityMet.Location = new System.Drawing.Point(10, 66);
            this.lb_activityMet.Name = "lb_activityMet";
            this.lb_activityMet.Size = new System.Drawing.Size(30, 13);
            this.lb_activityMet.TabIndex = 4;
            this.lb_activityMet.Text = "MET";
            // 
            // tb_calories
            // 
            this.tb_calories.Location = new System.Drawing.Point(60, 37);
            this.tb_calories.Name = "tb_calories";
            this.tb_calories.Size = new System.Drawing.Size(70, 20);
            this.tb_calories.TabIndex = 8;
            // 
            // lb_activityCalories
            // 
            this.lb_activityCalories.AutoSize = true;
            this.lb_activityCalories.Location = new System.Drawing.Point(10, 40);
            this.lb_activityCalories.Name = "lb_activityCalories";
            this.lb_activityCalories.Size = new System.Drawing.Size(44, 13);
            this.lb_activityCalories.TabIndex = 5;
            this.lb_activityCalories.Text = "Calorias";
            // 
            // tb_activityName
            // 
            this.tb_activityName.Location = new System.Drawing.Point(60, 12);
            this.tb_activityName.Name = "tb_activityName";
            this.tb_activityName.Size = new System.Drawing.Size(184, 20);
            this.tb_activityName.TabIndex = 9;
            // 
            // lb_activityName
            // 
            this.lb_activityName.AutoSize = true;
            this.lb_activityName.Location = new System.Drawing.Point(10, 15);
            this.lb_activityName.Name = "lb_activityName";
            this.lb_activityName.Size = new System.Drawing.Size(35, 13);
            this.lb_activityName.TabIndex = 6;
            this.lb_activityName.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "*";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(189, 98);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 39;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // FormActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 134);
            this.ControlBox = false;
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_caloriesType);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.tb_activityMet);
            this.Controls.Add(this.lb_activityMet);
            this.Controls.Add(this.tb_calories);
            this.Controls.Add(this.lb_activityCalories);
            this.Controls.Add(this.tb_activityName);
            this.Controls.Add(this.lb_activityName);
            this.Name = "FormActivity";
            this.Text = "Nova Atividade";
            this.Load += new System.EventHandler(this.FormActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_caloriesType;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.TextBox tb_activityMet;
        private System.Windows.Forms.Label lb_activityMet;
        private System.Windows.Forms.TextBox tb_calories;
        private System.Windows.Forms.Label lb_activityCalories;
        private System.Windows.Forms.TextBox tb_activityName;
        private System.Windows.Forms.Label lb_activityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_cancelar;
    }
}