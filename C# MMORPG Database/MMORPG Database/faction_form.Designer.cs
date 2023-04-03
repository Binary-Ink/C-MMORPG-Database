namespace MMORPG_Database
{
    partial class faction_form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.faction_level_txt = new System.Windows.Forms.TextBox();
            this.faction_rank_txt = new System.Windows.Forms.TextBox();
            this.faction_perk_txt = new System.Windows.Forms.TextBox();
            this.faction_name_txt = new System.Windows.Forms.TextBox();
            this.insert_faction_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Faction Perk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Faction Rank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Faction Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Faction Name";
            // 
            // faction_level_txt
            // 
            this.faction_level_txt.Location = new System.Drawing.Point(127, 69);
            this.faction_level_txt.Name = "faction_level_txt";
            this.faction_level_txt.Size = new System.Drawing.Size(100, 20);
            this.faction_level_txt.TabIndex = 13;
            // 
            // faction_rank_txt
            // 
            this.faction_rank_txt.Location = new System.Drawing.Point(127, 95);
            this.faction_rank_txt.Name = "faction_rank_txt";
            this.faction_rank_txt.Size = new System.Drawing.Size(100, 20);
            this.faction_rank_txt.TabIndex = 12;
            // 
            // faction_perk_txt
            // 
            this.faction_perk_txt.Location = new System.Drawing.Point(127, 121);
            this.faction_perk_txt.Name = "faction_perk_txt";
            this.faction_perk_txt.Size = new System.Drawing.Size(100, 20);
            this.faction_perk_txt.TabIndex = 11;
            // 
            // faction_name_txt
            // 
            this.faction_name_txt.Location = new System.Drawing.Point(127, 43);
            this.faction_name_txt.Name = "faction_name_txt";
            this.faction_name_txt.Size = new System.Drawing.Size(100, 20);
            this.faction_name_txt.TabIndex = 10;
            // 
            // insert_faction_button
            // 
            this.insert_faction_button.Location = new System.Drawing.Point(37, 197);
            this.insert_faction_button.Name = "insert_faction_button";
            this.insert_faction_button.Size = new System.Drawing.Size(211, 23);
            this.insert_faction_button.TabIndex = 9;
            this.insert_faction_button.Text = "Insert/Update";
            this.insert_faction_button.UseVisualStyleBackColor = true;
            this.insert_faction_button.Click += new System.EventHandler(this.insert_faction_button_Click);
            // 
            // faction_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faction_level_txt);
            this.Controls.Add(this.faction_rank_txt);
            this.Controls.Add(this.faction_perk_txt);
            this.Controls.Add(this.faction_name_txt);
            this.Controls.Add(this.insert_faction_button);
            this.Name = "faction_form";
            this.Text = "faction_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox faction_level_txt;
        private System.Windows.Forms.TextBox faction_rank_txt;
        private System.Windows.Forms.TextBox faction_perk_txt;
        private System.Windows.Forms.TextBox faction_name_txt;
        private System.Windows.Forms.Button insert_faction_button;
    }
}