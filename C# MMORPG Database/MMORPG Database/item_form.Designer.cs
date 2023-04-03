namespace MMORPG_Database
{
    partial class item_form
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
            this.insert_item_button = new System.Windows.Forms.Button();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.item_description_txt = new System.Windows.Forms.TextBox();
            this.item_type_txt = new System.Windows.Forms.TextBox();
            this.item_weight_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.item_cost_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insert_item_button
            // 
            this.insert_item_button.Location = new System.Drawing.Point(59, 195);
            this.insert_item_button.Name = "insert_item_button";
            this.insert_item_button.Size = new System.Drawing.Size(161, 23);
            this.insert_item_button.TabIndex = 0;
            this.insert_item_button.Text = "Insert/Update";
            this.insert_item_button.UseVisualStyleBackColor = true;
            this.insert_item_button.Click += new System.EventHandler(this.insert_item_button_Click);
            // 
            // item_name_txt
            // 
            this.item_name_txt.Location = new System.Drawing.Point(120, 44);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.Size = new System.Drawing.Size(100, 20);
            this.item_name_txt.TabIndex = 1;
            // 
            // item_description_txt
            // 
            this.item_description_txt.Location = new System.Drawing.Point(120, 70);
            this.item_description_txt.Name = "item_description_txt";
            this.item_description_txt.Size = new System.Drawing.Size(100, 20);
            this.item_description_txt.TabIndex = 2;
            // 
            // item_type_txt
            // 
            this.item_type_txt.Location = new System.Drawing.Point(120, 96);
            this.item_type_txt.Name = "item_type_txt";
            this.item_type_txt.Size = new System.Drawing.Size(100, 20);
            this.item_type_txt.TabIndex = 3;
            // 
            // item_weight_txt
            // 
            this.item_weight_txt.Location = new System.Drawing.Point(120, 122);
            this.item_weight_txt.Name = "item_weight_txt";
            this.item_weight_txt.Size = new System.Drawing.Size(100, 20);
            this.item_weight_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Weight";
            // 
            // item_cost_txt
            // 
            this.item_cost_txt.Location = new System.Drawing.Point(120, 148);
            this.item_cost_txt.Name = "item_cost_txt";
            this.item_cost_txt.Size = new System.Drawing.Size(100, 20);
            this.item_cost_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item Cost";
            // 
            // item_form
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.item_cost_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_weight_txt);
            this.Controls.Add(this.item_type_txt);
            this.Controls.Add(this.item_description_txt);
            this.Controls.Add(this.item_name_txt);
            this.Controls.Add(this.insert_item_button);
            this.Name = "item_form";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.
                FormClosingEventHandler(this.item_form_FormClosing);


        }
        #endregion


        private System.Windows.Forms.Button insert_item_button;
        private System.Windows.Forms.TextBox item_name_txt;
        private System.Windows.Forms.TextBox item_description_txt;
        private System.Windows.Forms.TextBox item_type_txt;
        private System.Windows.Forms.TextBox item_weight_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox item_cost_txt;
        private System.Windows.Forms.Label label5;
    }
}