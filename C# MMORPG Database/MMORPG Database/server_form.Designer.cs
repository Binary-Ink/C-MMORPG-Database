namespace MMORPG_Database
{
    partial class server_form
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
            this.server_region_id_cb = new System.Windows.Forms.ComboBox();
            this.server_name_txt = new System.Windows.Forms.TextBox();
            this.server_capacity_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insert_server_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server_region_id_cb
            // 
            this.server_region_id_cb.FormattingEnabled = true;
            this.server_region_id_cb.Location = new System.Drawing.Point(125, 45);
            this.server_region_id_cb.Name = "server_region_id_cb";
            this.server_region_id_cb.Size = new System.Drawing.Size(121, 21);
            this.server_region_id_cb.TabIndex = 0;
            // 
            // server_name_txt
            // 
            this.server_name_txt.Location = new System.Drawing.Point(125, 72);
            this.server_name_txt.Name = "server_name_txt";
            this.server_name_txt.Size = new System.Drawing.Size(100, 20);
            this.server_name_txt.TabIndex = 1;
            // 
            // server_capacity_txt
            // 
            this.server_capacity_txt.Location = new System.Drawing.Point(125, 98);
            this.server_capacity_txt.Name = "server_capacity_txt";
            this.server_capacity_txt.Size = new System.Drawing.Size(100, 20);
            this.server_capacity_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server Capacity";
            // 
            // insert_server_button
            // 
            this.insert_server_button.Location = new System.Drawing.Point(40, 160);
            this.insert_server_button.Name = "insert_server_button";
            this.insert_server_button.Size = new System.Drawing.Size(185, 23);
            this.insert_server_button.TabIndex = 6;
            this.insert_server_button.Text = "Update/Insert";
            this.insert_server_button.UseVisualStyleBackColor = true;
            this.insert_server_button.Click += new System.EventHandler(this.insert_server_button_Click);
            // 
            // server_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.insert_server_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server_capacity_txt);
            this.Controls.Add(this.server_name_txt);
            this.Controls.Add(this.server_region_id_cb);
            this.Name = "server_form";
            this.Text = "server_form";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.
                FormClosingEventHandler(this.server_form_FormClosing);

        }

        #endregion

        private System.Windows.Forms.ComboBox server_region_id_cb;
        private System.Windows.Forms.TextBox server_name_txt;
        private System.Windows.Forms.TextBox server_capacity_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insert_server_button;
    }
}