namespace AdinistrationApp_eNutre.Forms
{
    partial class FormVegetable
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
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_caloriesType = new System.Windows.Forms.ComboBox();
            this.tb_calories = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox_extraInfo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_unity = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(12, 126);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionar.TabIndex = 55;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "*";
            // 
            // cb_caloriesType
            // 
            this.cb_caloriesType.FormattingEnabled = true;
            this.cb_caloriesType.Location = new System.Drawing.Point(151, 38);
            this.cb_caloriesType.Name = "cb_caloriesType";
            this.cb_caloriesType.Size = new System.Drawing.Size(58, 21);
            this.cb_caloriesType.TabIndex = 53;
            // 
            // tb_calories
            // 
            this.tb_calories.Location = new System.Drawing.Point(68, 38);
            this.tb_calories.Name = "tb_calories";
            this.tb_calories.Size = new System.Drawing.Size(77, 20);
            this.tb_calories.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Calorias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "*(ex: chavena, médio, grande, kg, gr)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "*";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(69, 64);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(78, 20);
            this.tb_quantity.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Unidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(305, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "(Divida campos por vírgula)";
            // 
            // richTextBox_extraInfo
            // 
            this.richTextBox_extraInfo.Location = new System.Drawing.Point(308, 9);
            this.richTextBox_extraInfo.Name = "richTextBox_extraInfo";
            this.richTextBox_extraInfo.Size = new System.Drawing.Size(171, 64);
            this.richTextBox_extraInfo.TabIndex = 39;
            this.richTextBox_extraInfo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Info. Extra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "*";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(69, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(120, 20);
            this.tb_name.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Quantidade";
            // 
            // tb_unity
            // 
            this.tb_unity.Location = new System.Drawing.Point(69, 90);
            this.tb_unity.Name = "tb_unity";
            this.tb_unity.Size = new System.Drawing.Size(76, 20);
            this.tb_unity.TabIndex = 57;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(413, 126);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 58;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // FormVegetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 160);
            this.ControlBox = false;
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.tb_unity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_caloriesType);
            this.Controls.Add(this.tb_calories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.richTextBox_extraInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Name = "FormVegetable";
            this.Text = "Novo Vegetal";
            this.Load += new System.EventHandler(this.FormVegetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_caloriesType;
        private System.Windows.Forms.TextBox tb_calories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox_extraInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_unity;
        private System.Windows.Forms.Button bt_cancelar;
    }
}