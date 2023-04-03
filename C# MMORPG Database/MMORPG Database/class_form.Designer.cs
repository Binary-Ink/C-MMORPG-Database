namespace MMORPG_Database
{
    partial class class_form
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
            this.class_name_txt = new System.Windows.Forms.TextBox();
            this.class_health_txt = new System.Windows.Forms.TextBox();
            this.class_mana_txt = new System.Windows.Forms.TextBox();
            this.class_attack_txt = new System.Windows.Forms.TextBox();
            this.class_defence_txt = new System.Windows.Forms.TextBox();
            this.class_ability_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.insert_class_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // class_name_txt
            // 
            this.class_name_txt.Location = new System.Drawing.Point(89, 34);
            this.class_name_txt.Name = "class_name_txt";
            this.class_name_txt.Size = new System.Drawing.Size(159, 20);
            this.class_name_txt.TabIndex = 0;
            // 
            // class_health_txt
            // 
            this.class_health_txt.Location = new System.Drawing.Point(89, 60);
            this.class_health_txt.Name = "class_health_txt";
            this.class_health_txt.Size = new System.Drawing.Size(159, 20);
            this.class_health_txt.TabIndex = 1;
            // 
            // class_mana_txt
            // 
            this.class_mana_txt.Location = new System.Drawing.Point(89, 86);
            this.class_mana_txt.Name = "class_mana_txt";
            this.class_mana_txt.Size = new System.Drawing.Size(159, 20);
            this.class_mana_txt.TabIndex = 2;
            // 
            // class_attack_txt
            // 
            this.class_attack_txt.Location = new System.Drawing.Point(89, 112);
            this.class_attack_txt.Name = "class_attack_txt";
            this.class_attack_txt.Size = new System.Drawing.Size(159, 20);
            this.class_attack_txt.TabIndex = 3;
            // 
            // class_defence_txt
            // 
            this.class_defence_txt.Location = new System.Drawing.Point(89, 138);
            this.class_defence_txt.Name = "class_defence_txt";
            this.class_defence_txt.Size = new System.Drawing.Size(159, 20);
            this.class_defence_txt.TabIndex = 4;
            // 
            // class_ability_txt
            // 
            this.class_ability_txt.Location = new System.Drawing.Point(89, 164);
            this.class_ability_txt.Name = "class_ability_txt";
            this.class_ability_txt.Size = new System.Drawing.Size(159, 20);
            this.class_ability_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Attack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Defence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ability";
            // 
            // insert_class_button
            // 
            this.insert_class_button.Location = new System.Drawing.Point(89, 190);
            this.insert_class_button.Name = "insert_class_button";
            this.insert_class_button.Size = new System.Drawing.Size(159, 23);
            this.insert_class_button.TabIndex = 12;
            this.insert_class_button.Text = "Insert / Update ";
            this.insert_class_button.UseVisualStyleBackColor = true;
            this.insert_class_button.Click += new System.EventHandler(this.insert_class_button_Click);

            // 
            // class_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.insert_class_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.class_ability_txt);
            this.Controls.Add(this.class_defence_txt);
            this.Controls.Add(this.class_attack_txt);
            this.Controls.Add(this.class_mana_txt);
            this.Controls.Add(this.class_health_txt);
            this.Controls.Add(this.class_name_txt);
            this.Name = "class_form";
            this.Text = "class_form";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.
                FormClosingEventHandler(this.class_form_FormClosing);

        }

        #endregion

        private System.Windows.Forms.TextBox class_name_txt;
        private System.Windows.Forms.TextBox class_health_txt;
        private System.Windows.Forms.TextBox class_mana_txt;
        private System.Windows.Forms.TextBox class_attack_txt;
        private System.Windows.Forms.TextBox class_defence_txt;
        private System.Windows.Forms.TextBox class_ability_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insert_class_button;
    }
}