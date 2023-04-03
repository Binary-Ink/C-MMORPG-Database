namespace MMORPG_Database
{
    partial class region_form
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
            this.region_name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_region_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // region_name_txt
            // 
            this.region_name_txt.Location = new System.Drawing.Point(99, 74);
            this.region_name_txt.Name = "region_name_txt";
            this.region_name_txt.Size = new System.Drawing.Size(159, 20);
            this.region_name_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Region Name";
            // 
            // insert_region_button
            // 
            this.insert_region_button.Location = new System.Drawing.Point(56, 161);
            this.insert_region_button.Name = "insert_region_button";
            this.insert_region_button.Size = new System.Drawing.Size(169, 23);
            this.insert_region_button.TabIndex = 2;
            this.insert_region_button.Text = "Insert / Update Region";
            this.insert_region_button.UseVisualStyleBackColor = true;
            this.insert_region_button.Click += new System.EventHandler(this.insert_region_button_Click);
            // 
            // region_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.insert_region_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.region_name_txt);
            this.Name = "region_form";
            this.Text = "region_form";
            this.ResumeLayout(false);
            this.PerformLayout(); this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.region_form_FormClosing);
        }

        #endregion

        private System.Windows.Forms.TextBox region_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_region_button;
    }
}