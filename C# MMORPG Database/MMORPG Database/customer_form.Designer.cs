namespace MMORPG_Database
{
    partial class customer_form
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
            this.customer_fname_txt = new System.Windows.Forms.TextBox();
            this.customer_sname_txt = new System.Windows.Forms.TextBox();
            this.customer_account_creation_date_txt = new System.Windows.Forms.TextBox();
            this.customer_region_txt = new System.Windows.Forms.TextBox();
            this.customer_date_of_birth_txt = new System.Windows.Forms.TextBox();
            this.customer_password_txt = new System.Windows.Forms.TextBox();
            this.customer_billing_address_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.insert_customer_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_fname_txt
            // 
            this.customer_fname_txt.Location = new System.Drawing.Point(155, 56);
            this.customer_fname_txt.Name = "customer_fname_txt";
            this.customer_fname_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_fname_txt.TabIndex = 0;
            // 
            // customer_sname_txt
            // 
            this.customer_sname_txt.Location = new System.Drawing.Point(155, 82);
            this.customer_sname_txt.Name = "customer_sname_txt";
            this.customer_sname_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_sname_txt.TabIndex = 1;
            // 
            // customer_account_creation_date_txt
            // 
            this.customer_account_creation_date_txt.Location = new System.Drawing.Point(155, 111);
            this.customer_account_creation_date_txt.Name = "customer_account_creation_date_txt";
            this.customer_account_creation_date_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_account_creation_date_txt.TabIndex = 2;
            // 
            // customer_region_txt
            // 
            this.customer_region_txt.Location = new System.Drawing.Point(155, 137);
            this.customer_region_txt.Name = "customer_region_txt";
            this.customer_region_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_region_txt.TabIndex = 3;
            // 
            // customer_date_of_birth_txt
            // 
            this.customer_date_of_birth_txt.Location = new System.Drawing.Point(155, 161);
            this.customer_date_of_birth_txt.Name = "customer_date_of_birth_txt";
            this.customer_date_of_birth_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_date_of_birth_txt.TabIndex = 4;
            // 
            // customer_password_txt
            // 
            this.customer_password_txt.Location = new System.Drawing.Point(155, 187);
            this.customer_password_txt.Name = "customer_password_txt";
            this.customer_password_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_password_txt.TabIndex = 5;
            // 
            // customer_billing_address_txt
            // 
            this.customer_billing_address_txt.Location = new System.Drawing.Point(155, 213);
            this.customer_billing_address_txt.Name = "customer_billing_address_txt";
            this.customer_billing_address_txt.Size = new System.Drawing.Size(100, 20);
            this.customer_billing_address_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Account Creation Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Region";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Billing Address";
            // 
            // insert_customer_button
            // 
            this.insert_customer_button.Location = new System.Drawing.Point(86, 12);
            this.insert_customer_button.Name = "insert_customer_button";
            this.insert_customer_button.Size = new System.Drawing.Size(158, 23);
            this.insert_customer_button.TabIndex = 15;
            this.insert_customer_button.Text = "Update/Insert";
            this.insert_customer_button.UseVisualStyleBackColor = true;
            this.insert_customer_button.Click += new System.EventHandler(this.insert_customer_button_Click);
            // 
            // customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.insert_customer_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_billing_address_txt);
            this.Controls.Add(this.customer_password_txt);
            this.Controls.Add(this.customer_date_of_birth_txt);
            this.Controls.Add(this.customer_region_txt);
            this.Controls.Add(this.customer_account_creation_date_txt);
            this.Controls.Add(this.customer_sname_txt);
            this.Controls.Add(this.customer_fname_txt);
            this.Name = "customer_form";
            this.Text = "customer_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.customer_form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customer_fname_txt;
        private System.Windows.Forms.TextBox customer_sname_txt;
        private System.Windows.Forms.TextBox customer_account_creation_date_txt;
        private System.Windows.Forms.TextBox customer_region_txt;
        private System.Windows.Forms.TextBox customer_date_of_birth_txt;
        private System.Windows.Forms.TextBox customer_password_txt;
        private System.Windows.Forms.TextBox customer_billing_address_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insert_customer_button;
    }
}