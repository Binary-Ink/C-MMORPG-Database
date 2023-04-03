namespace MMORPG_Database
{
    partial class subscription_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.subscription_start_date_txt = new System.Windows.Forms.TextBox();
            this.subscription_end_date_txt = new System.Windows.Forms.TextBox();
            this.subscription_status_txt = new System.Windows.Forms.TextBox();
            this.subscription_customer_id_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insert_subscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer_ID";
            // 
            // subscription_start_date_txt
            // 
            this.subscription_start_date_txt.Location = new System.Drawing.Point(142, 76);
            this.subscription_start_date_txt.Name = "subscription_start_date_txt";
            this.subscription_start_date_txt.Size = new System.Drawing.Size(100, 20);
            this.subscription_start_date_txt.TabIndex = 2;
            // 
            // subscription_end_date_txt
            // 
            this.subscription_end_date_txt.Location = new System.Drawing.Point(142, 102);
            this.subscription_end_date_txt.Name = "subscription_end_date_txt";
            this.subscription_end_date_txt.Size = new System.Drawing.Size(100, 20);
            this.subscription_end_date_txt.TabIndex = 3;
            // 
            // subscription_status_txt
            // 
            this.subscription_status_txt.Location = new System.Drawing.Point(142, 128);
            this.subscription_status_txt.Name = "subscription_status_txt";
            this.subscription_status_txt.Size = new System.Drawing.Size(100, 20);
            this.subscription_status_txt.TabIndex = 4;
            // 
            // subscription_customer_id_cb
            // 
            this.subscription_customer_id_cb.FormattingEnabled = true;
            this.subscription_customer_id_cb.Location = new System.Drawing.Point(142, 50);
            this.subscription_customer_id_cb.Name = "subscription_customer_id_cb";
            this.subscription_customer_id_cb.Size = new System.Drawing.Size(121, 21);
            this.subscription_customer_id_cb.TabIndex = 5;
           // this.subscription_customer_id_cb.SelectedIndexChanged += new System.EventHandler(this.subscription_customer_id_cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subscription Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subscription End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subscription Status";
            // 
            // insert_subscription
            // 
            this.insert_subscription.Location = new System.Drawing.Point(55, 182);
            this.insert_subscription.Name = "insert_subscription";
            this.insert_subscription.Size = new System.Drawing.Size(187, 23);
            this.insert_subscription.TabIndex = 9;
            this.insert_subscription.Text = "Update/Insert Subscription";
            this.insert_subscription.UseVisualStyleBackColor = true;
            this.insert_subscription.Click += new System.EventHandler(this.insert_subscription_Click);
            // 
            // subscription_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.insert_subscription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subscription_customer_id_cb);
            this.Controls.Add(this.subscription_status_txt);
            this.Controls.Add(this.subscription_end_date_txt);
            this.Controls.Add(this.subscription_start_date_txt);
            this.Controls.Add(this.label1);
            this.Name = "subscription_form";
            this.Text = "subscription_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subscription_start_date_txt;
        private System.Windows.Forms.TextBox subscription_end_date_txt;
        private System.Windows.Forms.TextBox subscription_status_txt;
        private System.Windows.Forms.ComboBox subscription_customer_id_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insert_subscription;

    }
}