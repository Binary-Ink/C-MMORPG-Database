namespace MMORPG_Database
{
    partial class character_form
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
            this.character_level_txt = new System.Windows.Forms.TextBox();
            this.character_play_time_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insert_character_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // character_level_txt
            // 
            this.character_level_txt.Location = new System.Drawing.Point(146, 49);
            this.character_level_txt.Name = "character_level_txt";
            this.character_level_txt.Size = new System.Drawing.Size(100, 20);
            this.character_level_txt.TabIndex = 0;
            // 
            // character_play_time_txt
            // 
            this.character_play_time_txt.Location = new System.Drawing.Point(146, 75);
            this.character_play_time_txt.Name = "character_play_time_txt";
            this.character_play_time_txt.Size = new System.Drawing.Size(100, 20);
            this.character_play_time_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Character Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Character Play Time";
            // 
            // insert_character_button
            // 
            this.insert_character_button.Location = new System.Drawing.Point(48, 165);
            this.insert_character_button.Name = "insert_character_button";
            this.insert_character_button.Size = new System.Drawing.Size(198, 23);
            this.insert_character_button.TabIndex = 6;
            this.insert_character_button.Text = "Insert/Update Character";
            this.insert_character_button.UseVisualStyleBackColor = true;
            this.insert_character_button.Click += new System.EventHandler(this.insert_character_button_Click);
            // 
            // character_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.insert_character_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.character_play_time_txt);
            this.Controls.Add(this.character_level_txt);
            this.Name = "character_form";
            this.Text = "character_form";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.
                FormClosingEventHandler(this.character_form_FormClosing);

        }

        #endregion

        private System.Windows.Forms.TextBox character_level_txt;
        private System.Windows.Forms.TextBox character_play_time_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insert_character_button;
    }
}