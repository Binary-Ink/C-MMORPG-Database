namespace MMORPG_Database
{
    partial class race_form
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
            this.insert_race_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.race_ability_txt = new System.Windows.Forms.TextBox();
            this.race_name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insert_race_button
            // 
            this.insert_race_button.Location = new System.Drawing.Point(40, 155);
            this.insert_race_button.Name = "insert_race_button";
            this.insert_race_button.Size = new System.Drawing.Size(187, 23);
            this.insert_race_button.TabIndex = 0;
            this.insert_race_button.Text = "Insert/Update Race";
            this.insert_race_button.UseVisualStyleBackColor = true;
            this.insert_race_button.Click += new System.EventHandler(this.insert_race_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Race Name";
            // 
            // race_ability_txt
            // 
            this.race_ability_txt.Location = new System.Drawing.Point(121, 87);
            this.race_ability_txt.Name = "race_ability_txt";
            this.race_ability_txt.Size = new System.Drawing.Size(100, 20);
            this.race_ability_txt.TabIndex = 3;
            // 
            // race_name_txt
            // 
            this.race_name_txt.Location = new System.Drawing.Point(121, 58);
            this.race_name_txt.Name = "race_name_txt";
            this.race_name_txt.Size = new System.Drawing.Size(100, 20);
            this.race_name_txt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Race Ability";
            // 
            // race_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.race_name_txt);
            this.Controls.Add(this.race_ability_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_race_button);
            this.Name = "race_form";
            this.Text = "race_form";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.
                FormClosingEventHandler(this.race_form_FormClosing);

        }

        #endregion

        private System.Windows.Forms.Button insert_race_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox race_ability_txt;
        private System.Windows.Forms.TextBox race_name_txt;
        private System.Windows.Forms.Label label3;
    }
}