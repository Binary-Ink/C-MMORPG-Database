namespace MMORPG_Database
{
    partial class Form1
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
            this.form = new System.Windows.Forms.TabControl();
            this.class_tab = new System.Windows.Forms.TabPage();
            this.update_class_button = new System.Windows.Forms.Button();
            this.insert_class_button = new System.Windows.Forms.Button();
            this.delete_class_button = new System.Windows.Forms.Button();
            this.class_select_button = new System.Windows.Forms.Button();
            this.class_dg = new System.Windows.Forms.DataGridView();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_health = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_mana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_attack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_defense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region_tab = new System.Windows.Forms.TabPage();
            this.region_update_button = new System.Windows.Forms.Button();
            this.region_insert_button = new System.Windows.Forms.Button();
            this.region_delete_button = new System.Windows.Forms.Button();
            this.region_select_button = new System.Windows.Forms.Button();
            this.region_dg = new System.Windows.Forms.DataGridView();
            this.region_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.character_tab = new System.Windows.Forms.TabPage();
            this.character_update_button = new System.Windows.Forms.Button();
            this.character_insert_button = new System.Windows.Forms.Button();
            this.character_delete_button = new System.Windows.Forms.Button();
            this.character_select_button = new System.Windows.Forms.Button();
            this.character_dg = new System.Windows.Forms.DataGridView();
            this.character_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.character_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.character_play_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_tab = new System.Windows.Forms.TabPage();
            this.customer_update_button = new System.Windows.Forms.Button();
            this.customer_insert_button = new System.Windows.Forms.Button();
            this.customer_delete_button = new System.Windows.Forms.Button();
            this.customer_select_button = new System.Windows.Forms.Button();
            this.customer_dg = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_account_creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_billing_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faction_tab = new System.Windows.Forms.TabPage();
            this.insert_faction_button = new System.Windows.Forms.Button();
            this.update_faction_button = new System.Windows.Forms.Button();
            this.delete_faction_button = new System.Windows.Forms.Button();
            this.select_faction_button = new System.Windows.Forms.Button();
            this.faction_dg = new System.Windows.Forms.DataGridView();
            this.faction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faction_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faction_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faction_rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faction_perk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_tab = new System.Windows.Forms.TabPage();
            this.item_insert_button = new System.Windows.Forms.Button();
            this.item_update_button = new System.Windows.Forms.Button();
            this.item_delete_button = new System.Windows.Forms.Button();
            this.item_select_button = new System.Windows.Forms.Button();
            this.item_dg = new System.Windows.Forms.DataGridView();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.race_tab = new System.Windows.Forms.TabPage();
            this.race_dg = new System.Windows.Forms.DataGridView();
            this.race_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.race_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.race_ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.race_insert_button = new System.Windows.Forms.Button();
            this.race_update_button = new System.Windows.Forms.Button();
            this.race_delete_button = new System.Windows.Forms.Button();
            this.race_select_button = new System.Windows.Forms.Button();
            this.server_tab = new System.Windows.Forms.TabPage();
            this.server_insert_button = new System.Windows.Forms.Button();
            this.server_update_button = new System.Windows.Forms.Button();
            this.server_delete_button = new System.Windows.Forms.Button();
            this.select_server_button = new System.Windows.Forms.Button();
            this.server_dg = new System.Windows.Forms.DataGridView();
            this.server_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_region_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_by_region_query_tab = new System.Windows.Forms.TabPage();
            this.server_select_cb = new System.Windows.Forms.ComboBox();
            this.server_query_dg = new System.Windows.Forms.DataGridView();
            this.region_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server_capacity_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscription_tab = new System.Windows.Forms.TabPage();
            this.subscription_insert_button = new System.Windows.Forms.Button();
            this.subscription_select_button = new System.Windows.Forms.Button();
            this.subscription_delete_button = new System.Windows.Forms.Button();
            this.subscription_update_button = new System.Windows.Forms.Button();
            this.subscription_dg = new System.Windows.Forms.DataGridView();
            this.subscription_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscription_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscription_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscription_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscription_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_by_subscription_tab = new System.Windows.Forms.TabPage();
            this.customer_by_subscription_cb = new System.Windows.Forms.ComboBox();
            this.customer_by_subscription_dg = new System.Windows.Forms.DataGridView();
            this.customer_subscription_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_subscription_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form.SuspendLayout();
            this.class_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_dg)).BeginInit();
            this.region_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.region_dg)).BeginInit();
            this.character_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character_dg)).BeginInit();
            this.customer_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_dg)).BeginInit();
            this.faction_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faction_dg)).BeginInit();
            this.item_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_dg)).BeginInit();
            this.race_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.race_dg)).BeginInit();
            this.server_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_dg)).BeginInit();
            this.server_by_region_query_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_query_dg)).BeginInit();
            this.subscription_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscription_dg)).BeginInit();
            this.customer_by_subscription_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_by_subscription_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.Controls.Add(this.class_tab);
            this.form.Controls.Add(this.region_tab);
            this.form.Controls.Add(this.character_tab);
            this.form.Controls.Add(this.customer_tab);
            this.form.Controls.Add(this.faction_tab);
            this.form.Controls.Add(this.item_tab);
            this.form.Controls.Add(this.race_tab);
            this.form.Controls.Add(this.server_tab);
            this.form.Controls.Add(this.server_by_region_query_tab);
            this.form.Controls.Add(this.subscription_tab);
            this.form.Controls.Add(this.customer_by_subscription_tab);
            this.form.Location = new System.Drawing.Point(12, 12);
            this.form.Name = "form";
            this.form.SelectedIndex = 0;
            this.form.Size = new System.Drawing.Size(974, 365);
            this.form.TabIndex = 1;
            // 
            // class_tab
            // 
            this.class_tab.Controls.Add(this.update_class_button);
            this.class_tab.Controls.Add(this.insert_class_button);
            this.class_tab.Controls.Add(this.delete_class_button);
            this.class_tab.Controls.Add(this.class_select_button);
            this.class_tab.Controls.Add(this.class_dg);
            this.class_tab.Location = new System.Drawing.Point(4, 22);
            this.class_tab.Name = "class_tab";
            this.class_tab.Padding = new System.Windows.Forms.Padding(3);
            this.class_tab.Size = new System.Drawing.Size(966, 339);
            this.class_tab.TabIndex = 0;
            this.class_tab.Text = "CLASS";
            this.class_tab.UseVisualStyleBackColor = true;
            // 
            // update_class_button
            // 
            this.update_class_button.Location = new System.Drawing.Point(250, 5);
            this.update_class_button.Name = "update_class_button";
            this.update_class_button.Size = new System.Drawing.Size(75, 23);
            this.update_class_button.TabIndex = 4;
            this.update_class_button.Text = "Update";
            this.update_class_button.UseVisualStyleBackColor = true;
            this.update_class_button.Click += new System.EventHandler(this.update_class_button_Click);
            // 
            // insert_class_button
            // 
            this.insert_class_button.Location = new System.Drawing.Point(169, 5);
            this.insert_class_button.Name = "insert_class_button";
            this.insert_class_button.Size = new System.Drawing.Size(75, 23);
            this.insert_class_button.TabIndex = 3;
            this.insert_class_button.Text = "Insert";
            this.insert_class_button.UseVisualStyleBackColor = true;
            this.insert_class_button.Click += new System.EventHandler(this.insert_class_button_Click);
            // 
            // delete_class_button
            // 
            this.delete_class_button.Location = new System.Drawing.Point(87, 6);
            this.delete_class_button.Name = "delete_class_button";
            this.delete_class_button.Size = new System.Drawing.Size(75, 23);
            this.delete_class_button.TabIndex = 2;
            this.delete_class_button.Text = "Delete Class";
            this.delete_class_button.UseVisualStyleBackColor = true;
            this.delete_class_button.Click += new System.EventHandler(this.delete_class_button_Click);
            // 
            // class_select_button
            // 
            this.class_select_button.Location = new System.Drawing.Point(6, 6);
            this.class_select_button.Name = "class_select_button";
            this.class_select_button.Size = new System.Drawing.Size(75, 23);
            this.class_select_button.TabIndex = 1;
            this.class_select_button.Text = "Select Class";
            this.class_select_button.UseVisualStyleBackColor = true;
            this.class_select_button.Click += new System.EventHandler(this.class_select_button_Click);
            // 
            // class_dg
            // 
            this.class_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.class_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_id,
            this.class_name,
            this.class_health,
            this.class_mana,
            this.class_attack,
            this.class_defense,
            this.class_ability});
            this.class_dg.Location = new System.Drawing.Point(6, 35);
            this.class_dg.Name = "class_dg";
            this.class_dg.Size = new System.Drawing.Size(499, 298);
            this.class_dg.TabIndex = 0;
            // 
            // class_id
            // 
            this.class_id.HeaderText = "CLASS ID";
            this.class_id.Name = "class_id";
            // 
            // class_name
            // 
            this.class_name.HeaderText = "Name";
            this.class_name.Name = "class_name";
            // 
            // class_health
            // 
            this.class_health.HeaderText = "Health";
            this.class_health.Name = "class_health";
            // 
            // class_mana
            // 
            this.class_mana.HeaderText = "Mana";
            this.class_mana.Name = "class_mana";
            // 
            // class_attack
            // 
            this.class_attack.HeaderText = "Attack";
            this.class_attack.Name = "class_attack";
            // 
            // class_defense
            // 
            this.class_defense.HeaderText = "Defense";
            this.class_defense.Name = "class_defense";
            // 
            // class_ability
            // 
            this.class_ability.HeaderText = "Ability";
            this.class_ability.Name = "class_ability";
            // 
            // region_tab
            // 
            this.region_tab.Controls.Add(this.region_update_button);
            this.region_tab.Controls.Add(this.region_insert_button);
            this.region_tab.Controls.Add(this.region_delete_button);
            this.region_tab.Controls.Add(this.region_select_button);
            this.region_tab.Controls.Add(this.region_dg);
            this.region_tab.Location = new System.Drawing.Point(4, 22);
            this.region_tab.Name = "region_tab";
            this.region_tab.Padding = new System.Windows.Forms.Padding(3);
            this.region_tab.Size = new System.Drawing.Size(966, 339);
            this.region_tab.TabIndex = 1;
            this.region_tab.Text = "REGION";
            this.region_tab.UseVisualStyleBackColor = true;
            // 
            // region_update_button
            // 
            this.region_update_button.Location = new System.Drawing.Point(314, 3);
            this.region_update_button.Name = "region_update_button";
            this.region_update_button.Size = new System.Drawing.Size(95, 23);
            this.region_update_button.TabIndex = 4;
            this.region_update_button.Text = "Update Region";
            this.region_update_button.UseVisualStyleBackColor = true;
            this.region_update_button.Click += new System.EventHandler(this.region_update_button_Click);
            // 
            // region_insert_button
            // 
            this.region_insert_button.Location = new System.Drawing.Point(210, 3);
            this.region_insert_button.Name = "region_insert_button";
            this.region_insert_button.Size = new System.Drawing.Size(98, 23);
            this.region_insert_button.TabIndex = 3;
            this.region_insert_button.Text = "Insert Region";
            this.region_insert_button.UseVisualStyleBackColor = true;
            this.region_insert_button.Click += new System.EventHandler(this.region_insert_button_Click);
            // 
            // region_delete_button
            // 
            this.region_delete_button.Location = new System.Drawing.Point(115, 3);
            this.region_delete_button.Name = "region_delete_button";
            this.region_delete_button.Size = new System.Drawing.Size(89, 23);
            this.region_delete_button.TabIndex = 2;
            this.region_delete_button.Text = "Delete Region";
            this.region_delete_button.UseVisualStyleBackColor = true;
            this.region_delete_button.Click += new System.EventHandler(this.region_delete_button_Click);
            // 
            // region_select_button
            // 
            this.region_select_button.Location = new System.Drawing.Point(6, 3);
            this.region_select_button.Name = "region_select_button";
            this.region_select_button.Size = new System.Drawing.Size(103, 23);
            this.region_select_button.TabIndex = 1;
            this.region_select_button.Text = "Select Regions";
            this.region_select_button.UseVisualStyleBackColor = true;
            this.region_select_button.Click += new System.EventHandler(this.region_select_button_Click);
            // 
            // region_dg
            // 
            this.region_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.region_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.region_id,
            this.region_name});
            this.region_dg.Location = new System.Drawing.Point(6, 29);
            this.region_dg.Name = "region_dg";
            this.region_dg.Size = new System.Drawing.Size(499, 304);
            this.region_dg.TabIndex = 0;
            // 
            // region_id
            // 
            this.region_id.HeaderText = "REGION ID";
            this.region_id.Name = "region_id";
            // 
            // region_name
            // 
            this.region_name.HeaderText = "Region Name";
            this.region_name.Name = "region_name";
            // 
            // character_tab
            // 
            this.character_tab.Controls.Add(this.character_update_button);
            this.character_tab.Controls.Add(this.character_insert_button);
            this.character_tab.Controls.Add(this.character_delete_button);
            this.character_tab.Controls.Add(this.character_select_button);
            this.character_tab.Controls.Add(this.character_dg);
            this.character_tab.Location = new System.Drawing.Point(4, 22);
            this.character_tab.Name = "character_tab";
            this.character_tab.Padding = new System.Windows.Forms.Padding(3);
            this.character_tab.Size = new System.Drawing.Size(966, 339);
            this.character_tab.TabIndex = 2;
            this.character_tab.Text = "CHARACTER";
            this.character_tab.UseVisualStyleBackColor = true;
            // 
            // character_update_button
            // 
            this.character_update_button.Location = new System.Drawing.Point(327, 3);
            this.character_update_button.Name = "character_update_button";
            this.character_update_button.Size = new System.Drawing.Size(118, 23);
            this.character_update_button.TabIndex = 4;
            this.character_update_button.Text = "Update Character";
            this.character_update_button.UseVisualStyleBackColor = true;
            this.character_update_button.Click += new System.EventHandler(this.character_update_button_Click);
            // 
            // character_insert_button
            // 
            this.character_insert_button.Location = new System.Drawing.Point(224, 3);
            this.character_insert_button.Name = "character_insert_button";
            this.character_insert_button.Size = new System.Drawing.Size(97, 23);
            this.character_insert_button.TabIndex = 3;
            this.character_insert_button.Text = "Insert Character";
            this.character_insert_button.UseVisualStyleBackColor = true;
            this.character_insert_button.Click += new System.EventHandler(this.character_insert_button_Click);
            // 
            // character_delete_button
            // 
            this.character_delete_button.Location = new System.Drawing.Point(113, 3);
            this.character_delete_button.Name = "character_delete_button";
            this.character_delete_button.Size = new System.Drawing.Size(105, 23);
            this.character_delete_button.TabIndex = 2;
            this.character_delete_button.Text = "Delete Character";
            this.character_delete_button.UseVisualStyleBackColor = true;
            this.character_delete_button.Click += new System.EventHandler(this.character_delete_button_Click);
            // 
            // character_select_button
            // 
            this.character_select_button.Location = new System.Drawing.Point(6, 3);
            this.character_select_button.Name = "character_select_button";
            this.character_select_button.Size = new System.Drawing.Size(101, 23);
            this.character_select_button.TabIndex = 1;
            this.character_select_button.Text = "Select Character";
            this.character_select_button.UseVisualStyleBackColor = true;
            this.character_select_button.Click += new System.EventHandler(this.character_select_button_Click);
            // 
            // character_dg
            // 
            this.character_dg.AllowUserToAddRows = false;
            this.character_dg.AllowUserToDeleteRows = false;
            this.character_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.character_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.character_id,
            this.character_level,
            this.character_play_time});
            this.character_dg.Location = new System.Drawing.Point(6, 28);
            this.character_dg.Name = "character_dg";
            this.character_dg.ReadOnly = true;
            this.character_dg.Size = new System.Drawing.Size(499, 305);
            this.character_dg.TabIndex = 0;
            // 
            // character_id
            // 
            this.character_id.HeaderText = "Character ID";
            this.character_id.Name = "character_id";
            this.character_id.ReadOnly = true;
            // 
            // character_level
            // 
            this.character_level.HeaderText = "Character Level";
            this.character_level.Name = "character_level";
            this.character_level.ReadOnly = true;
            // 
            // character_play_time
            // 
            this.character_play_time.HeaderText = "Character  Play Time";
            this.character_play_time.Name = "character_play_time";
            this.character_play_time.ReadOnly = true;
            // 
            // customer_tab
            // 
            this.customer_tab.Controls.Add(this.customer_update_button);
            this.customer_tab.Controls.Add(this.customer_insert_button);
            this.customer_tab.Controls.Add(this.customer_delete_button);
            this.customer_tab.Controls.Add(this.customer_select_button);
            this.customer_tab.Controls.Add(this.customer_dg);
            this.customer_tab.Location = new System.Drawing.Point(4, 22);
            this.customer_tab.Name = "customer_tab";
            this.customer_tab.Padding = new System.Windows.Forms.Padding(3);
            this.customer_tab.Size = new System.Drawing.Size(966, 339);
            this.customer_tab.TabIndex = 3;
            this.customer_tab.Text = "CUSTOMER";
            this.customer_tab.UseVisualStyleBackColor = true;
            // 
            // customer_update_button
            // 
            this.customer_update_button.Location = new System.Drawing.Point(344, 6);
            this.customer_update_button.Name = "customer_update_button";
            this.customer_update_button.Size = new System.Drawing.Size(112, 23);
            this.customer_update_button.TabIndex = 4;
            this.customer_update_button.Text = "Update Character";
            this.customer_update_button.UseVisualStyleBackColor = true;
            this.customer_update_button.Click += new System.EventHandler(this.customer_update_button_Click);
            // 
            // customer_insert_button
            // 
            this.customer_insert_button.Location = new System.Drawing.Point(226, 6);
            this.customer_insert_button.Name = "customer_insert_button";
            this.customer_insert_button.Size = new System.Drawing.Size(112, 23);
            this.customer_insert_button.TabIndex = 3;
            this.customer_insert_button.Text = "Insert Character";
            this.customer_insert_button.UseVisualStyleBackColor = true;
            this.customer_insert_button.Click += new System.EventHandler(this.customer_insert_button_Click);
            // 
            // customer_delete_button
            // 
            this.customer_delete_button.Location = new System.Drawing.Point(116, 6);
            this.customer_delete_button.Name = "customer_delete_button";
            this.customer_delete_button.Size = new System.Drawing.Size(104, 23);
            this.customer_delete_button.TabIndex = 2;
            this.customer_delete_button.Text = "Delete Character";
            this.customer_delete_button.UseVisualStyleBackColor = true;
            this.customer_delete_button.Click += new System.EventHandler(this.customer_delete_button_Click);
            // 
            // customer_select_button
            // 
            this.customer_select_button.Location = new System.Drawing.Point(6, 6);
            this.customer_select_button.Name = "customer_select_button";
            this.customer_select_button.Size = new System.Drawing.Size(104, 23);
            this.customer_select_button.TabIndex = 1;
            this.customer_select_button.Text = "Select Customer";
            this.customer_select_button.UseVisualStyleBackColor = true;
            this.customer_select_button.Click += new System.EventHandler(this.customer_select_button_Click);
            // 
            // customer_dg
            // 
            this.customer_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.customer_fname,
            this.customer_sname,
            this.customer_account_creation_date,
            this.customer_region,
            this.customer_date_of_birth,
            this.customer_password,
            this.customer_billing_address});
            this.customer_dg.Location = new System.Drawing.Point(6, 35);
            this.customer_dg.Name = "customer_dg";
            this.customer_dg.Size = new System.Drawing.Size(499, 301);
            this.customer_dg.TabIndex = 0;
            // 
            // customer_id
            // 
            this.customer_id.HeaderText = "Customer ID";
            this.customer_id.Name = "customer_id";
            // 
            // customer_fname
            // 
            this.customer_fname.HeaderText = "Customer First Name";
            this.customer_fname.Name = "customer_fname";
            // 
            // customer_sname
            // 
            this.customer_sname.HeaderText = "Customer Surname";
            this.customer_sname.Name = "customer_sname";
            // 
            // customer_account_creation_date
            // 
            this.customer_account_creation_date.HeaderText = "Customer Account Creation Date";
            this.customer_account_creation_date.Name = "customer_account_creation_date";
            // 
            // customer_region
            // 
            this.customer_region.HeaderText = "Customer Region";
            this.customer_region.Name = "customer_region";
            // 
            // customer_date_of_birth
            // 
            this.customer_date_of_birth.HeaderText = "Customer Date of Birth";
            this.customer_date_of_birth.Name = "customer_date_of_birth";
            // 
            // customer_password
            // 
            this.customer_password.HeaderText = "Customer Password";
            this.customer_password.Name = "customer_password";
            // 
            // customer_billing_address
            // 
            this.customer_billing_address.HeaderText = "Customer Billing Address";
            this.customer_billing_address.Name = "customer_billing_address";
            // 
            // faction_tab
            // 
            this.faction_tab.Controls.Add(this.insert_faction_button);
            this.faction_tab.Controls.Add(this.update_faction_button);
            this.faction_tab.Controls.Add(this.delete_faction_button);
            this.faction_tab.Controls.Add(this.select_faction_button);
            this.faction_tab.Controls.Add(this.faction_dg);
            this.faction_tab.Location = new System.Drawing.Point(4, 22);
            this.faction_tab.Name = "faction_tab";
            this.faction_tab.Padding = new System.Windows.Forms.Padding(3);
            this.faction_tab.Size = new System.Drawing.Size(966, 339);
            this.faction_tab.TabIndex = 4;
            this.faction_tab.Text = "FACTION";
            this.faction_tab.UseVisualStyleBackColor = true;
            // 
            // insert_faction_button
            // 
            this.insert_faction_button.Location = new System.Drawing.Point(334, 2);
            this.insert_faction_button.Name = "insert_faction_button";
            this.insert_faction_button.Size = new System.Drawing.Size(103, 23);
            this.insert_faction_button.TabIndex = 4;
            this.insert_faction_button.Text = "Insert Faction";
            this.insert_faction_button.UseVisualStyleBackColor = true;
            this.insert_faction_button.Click += new System.EventHandler(this.insert_faction_button_Click);
            // 
            // update_faction_button
            // 
            this.update_faction_button.Location = new System.Drawing.Point(225, 2);
            this.update_faction_button.Name = "update_faction_button";
            this.update_faction_button.Size = new System.Drawing.Size(103, 23);
            this.update_faction_button.TabIndex = 3;
            this.update_faction_button.Text = "Update Faction";
            this.update_faction_button.UseVisualStyleBackColor = true;
            this.update_faction_button.Click += new System.EventHandler(this.update_faction_button_Click);
            // 
            // delete_faction_button
            // 
            this.delete_faction_button.Location = new System.Drawing.Point(116, 2);
            this.delete_faction_button.Name = "delete_faction_button";
            this.delete_faction_button.Size = new System.Drawing.Size(103, 23);
            this.delete_faction_button.TabIndex = 2;
            this.delete_faction_button.Text = "Delete Faction";
            this.delete_faction_button.UseVisualStyleBackColor = true;
            this.delete_faction_button.Click += new System.EventHandler(this.delete_faction_button_Click);
            // 
            // select_faction_button
            // 
            this.select_faction_button.Location = new System.Drawing.Point(7, 2);
            this.select_faction_button.Name = "select_faction_button";
            this.select_faction_button.Size = new System.Drawing.Size(103, 23);
            this.select_faction_button.TabIndex = 1;
            this.select_faction_button.Text = "Select Faction";
            this.select_faction_button.UseVisualStyleBackColor = true;
            this.select_faction_button.Click += new System.EventHandler(this.select_faction_button_Click);
            // 
            // faction_dg
            // 
            this.faction_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faction_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faction_id,
            this.faction_name,
            this.faction_level,
            this.faction_rank,
            this.faction_perk});
            this.faction_dg.Location = new System.Drawing.Point(6, 31);
            this.faction_dg.Name = "faction_dg";
            this.faction_dg.Size = new System.Drawing.Size(499, 305);
            this.faction_dg.TabIndex = 0;
            // 
            // faction_id
            // 
            this.faction_id.HeaderText = "Faction ID";
            this.faction_id.Name = "faction_id";
            // 
            // faction_name
            // 
            this.faction_name.HeaderText = "Faction Name";
            this.faction_name.Name = "faction_name";
            // 
            // faction_level
            // 
            this.faction_level.HeaderText = "Faction Level";
            this.faction_level.Name = "faction_level";
            // 
            // faction_rank
            // 
            this.faction_rank.HeaderText = "Faction Rank";
            this.faction_rank.Name = "faction_rank";
            // 
            // faction_perk
            // 
            this.faction_perk.HeaderText = "Faction Perk";
            this.faction_perk.Name = "faction_perk";
            // 
            // item_tab
            // 
            this.item_tab.Controls.Add(this.item_insert_button);
            this.item_tab.Controls.Add(this.item_update_button);
            this.item_tab.Controls.Add(this.item_delete_button);
            this.item_tab.Controls.Add(this.item_select_button);
            this.item_tab.Controls.Add(this.item_dg);
            this.item_tab.Location = new System.Drawing.Point(4, 22);
            this.item_tab.Name = "item_tab";
            this.item_tab.Padding = new System.Windows.Forms.Padding(3);
            this.item_tab.Size = new System.Drawing.Size(966, 339);
            this.item_tab.TabIndex = 5;
            this.item_tab.Text = "ITEM";
            this.item_tab.UseVisualStyleBackColor = true;
            // 
            // item_insert_button
            // 
            this.item_insert_button.Location = new System.Drawing.Point(334, 3);
            this.item_insert_button.Name = "item_insert_button";
            this.item_insert_button.Size = new System.Drawing.Size(108, 23);
            this.item_insert_button.TabIndex = 5;
            this.item_insert_button.Text = "Insert Item";
            this.item_insert_button.UseVisualStyleBackColor = true;
            this.item_insert_button.Click += new System.EventHandler(this.item_insert_button_Click);
            // 
            // item_update_button
            // 
            this.item_update_button.Location = new System.Drawing.Point(220, 3);
            this.item_update_button.Name = "item_update_button";
            this.item_update_button.Size = new System.Drawing.Size(108, 23);
            this.item_update_button.TabIndex = 3;
            this.item_update_button.Text = "Update Item";
            this.item_update_button.UseVisualStyleBackColor = true;
            this.item_update_button.Click += new System.EventHandler(this.item_update_button_Click);
            // 
            // item_delete_button
            // 
            this.item_delete_button.Location = new System.Drawing.Point(113, 2);
            this.item_delete_button.Name = "item_delete_button";
            this.item_delete_button.Size = new System.Drawing.Size(101, 23);
            this.item_delete_button.TabIndex = 2;
            this.item_delete_button.Text = "Delete Item";
            this.item_delete_button.UseVisualStyleBackColor = true;
            this.item_delete_button.Click += new System.EventHandler(this.item_delete_button_Click);
            // 
            // item_select_button
            // 
            this.item_select_button.Location = new System.Drawing.Point(7, 2);
            this.item_select_button.Name = "item_select_button";
            this.item_select_button.Size = new System.Drawing.Size(100, 23);
            this.item_select_button.TabIndex = 1;
            this.item_select_button.Text = "Select Item";
            this.item_select_button.UseVisualStyleBackColor = true;
            this.item_select_button.Click += new System.EventHandler(this.item_select_button_Click);
            // 
            // item_dg
            // 
            this.item_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_id,
            this.item_name,
            this.item_description,
            this.item_type,
            this.item_weight,
            this.item_cost});
            this.item_dg.Location = new System.Drawing.Point(6, 31);
            this.item_dg.Name = "item_dg";
            this.item_dg.Size = new System.Drawing.Size(499, 302);
            this.item_dg.TabIndex = 0;
            // 
            // item_id
            // 
            this.item_id.HeaderText = "Item ID";
            this.item_id.Name = "item_id";
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name";
            this.item_name.Name = "item_name";
            // 
            // item_description
            // 
            this.item_description.HeaderText = "Item Description";
            this.item_description.Name = "item_description";
            // 
            // item_type
            // 
            this.item_type.HeaderText = "Item Type";
            this.item_type.Name = "item_type";
            // 
            // item_weight
            // 
            this.item_weight.HeaderText = "Item Weight";
            this.item_weight.Name = "item_weight";
            // 
            // item_cost
            // 
            this.item_cost.HeaderText = "Item Cost";
            this.item_cost.Name = "item_cost";
            // 
            // race_tab
            // 
            this.race_tab.Controls.Add(this.race_dg);
            this.race_tab.Controls.Add(this.race_insert_button);
            this.race_tab.Controls.Add(this.race_update_button);
            this.race_tab.Controls.Add(this.race_delete_button);
            this.race_tab.Controls.Add(this.race_select_button);
            this.race_tab.Location = new System.Drawing.Point(4, 22);
            this.race_tab.Name = "race_tab";
            this.race_tab.Padding = new System.Windows.Forms.Padding(3);
            this.race_tab.Size = new System.Drawing.Size(966, 339);
            this.race_tab.TabIndex = 6;
            this.race_tab.Text = "RACE";
            this.race_tab.UseVisualStyleBackColor = true;
            // 
            // race_dg
            // 
            this.race_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.race_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.race_id,
            this.race_name,
            this.race_ability});
            this.race_dg.Location = new System.Drawing.Point(6, 35);
            this.race_dg.Name = "race_dg";
            this.race_dg.Size = new System.Drawing.Size(502, 298);
            this.race_dg.TabIndex = 4;
            // 
            // race_id
            // 
            this.race_id.HeaderText = "Race ID";
            this.race_id.Name = "race_id";
            // 
            // race_name
            // 
            this.race_name.HeaderText = "Race Name";
            this.race_name.Name = "race_name";
            // 
            // race_ability
            // 
            this.race_ability.HeaderText = "Race Ability";
            this.race_ability.Name = "race_ability";
            // 
            // race_insert_button
            // 
            this.race_insert_button.Location = new System.Drawing.Point(318, 6);
            this.race_insert_button.Name = "race_insert_button";
            this.race_insert_button.Size = new System.Drawing.Size(98, 23);
            this.race_insert_button.TabIndex = 3;
            this.race_insert_button.Text = "Insert Race";
            this.race_insert_button.UseVisualStyleBackColor = true;
            this.race_insert_button.Click += new System.EventHandler(this.race_insert_button_Click);
            // 
            // race_update_button
            // 
            this.race_update_button.Location = new System.Drawing.Point(214, 6);
            this.race_update_button.Name = "race_update_button";
            this.race_update_button.Size = new System.Drawing.Size(98, 23);
            this.race_update_button.TabIndex = 2;
            this.race_update_button.Text = "Update Race";
            this.race_update_button.UseVisualStyleBackColor = true;
            this.race_update_button.Click += new System.EventHandler(this.race_update_button_Click);
            // 
            // race_delete_button
            // 
            this.race_delete_button.Location = new System.Drawing.Point(110, 6);
            this.race_delete_button.Name = "race_delete_button";
            this.race_delete_button.Size = new System.Drawing.Size(98, 23);
            this.race_delete_button.TabIndex = 1;
            this.race_delete_button.Text = "Delete Race";
            this.race_delete_button.UseVisualStyleBackColor = true;
            this.race_delete_button.Click += new System.EventHandler(this.race_delete_button_Click);
            // 
            // race_select_button
            // 
            this.race_select_button.Location = new System.Drawing.Point(6, 6);
            this.race_select_button.Name = "race_select_button";
            this.race_select_button.Size = new System.Drawing.Size(98, 23);
            this.race_select_button.TabIndex = 0;
            this.race_select_button.Text = "Select Race";
            this.race_select_button.UseVisualStyleBackColor = true;
            this.race_select_button.Click += new System.EventHandler(this.race_select_button_Click);
            // 
            // server_tab
            // 
            this.server_tab.Controls.Add(this.server_insert_button);
            this.server_tab.Controls.Add(this.server_update_button);
            this.server_tab.Controls.Add(this.server_delete_button);
            this.server_tab.Controls.Add(this.select_server_button);
            this.server_tab.Controls.Add(this.server_dg);
            this.server_tab.Location = new System.Drawing.Point(4, 22);
            this.server_tab.Name = "server_tab";
            this.server_tab.Padding = new System.Windows.Forms.Padding(3);
            this.server_tab.Size = new System.Drawing.Size(966, 339);
            this.server_tab.TabIndex = 7;
            this.server_tab.Text = "SERVER";
            this.server_tab.UseVisualStyleBackColor = true;
            // 
            // server_insert_button
            // 
            this.server_insert_button.Location = new System.Drawing.Point(367, 6);
            this.server_insert_button.Name = "server_insert_button";
            this.server_insert_button.Size = new System.Drawing.Size(114, 23);
            this.server_insert_button.TabIndex = 4;
            this.server_insert_button.Text = "Insert Server";
            this.server_insert_button.UseVisualStyleBackColor = true;
            this.server_insert_button.Click += new System.EventHandler(this.server_insert_button_Click);
            // 
            // server_update_button
            // 
            this.server_update_button.Location = new System.Drawing.Point(247, 6);
            this.server_update_button.Name = "server_update_button";
            this.server_update_button.Size = new System.Drawing.Size(114, 23);
            this.server_update_button.TabIndex = 3;
            this.server_update_button.Text = "Update Server";
            this.server_update_button.UseVisualStyleBackColor = true;
            this.server_update_button.Click += new System.EventHandler(this.server_update_button_Click);
            // 
            // server_delete_button
            // 
            this.server_delete_button.Location = new System.Drawing.Point(127, 6);
            this.server_delete_button.Name = "server_delete_button";
            this.server_delete_button.Size = new System.Drawing.Size(114, 23);
            this.server_delete_button.TabIndex = 2;
            this.server_delete_button.Text = "Delete Server";
            this.server_delete_button.UseVisualStyleBackColor = true;
            this.server_delete_button.Click += new System.EventHandler(this.server_delete_button_Click);
            // 
            // select_server_button
            // 
            this.select_server_button.Location = new System.Drawing.Point(7, 6);
            this.select_server_button.Name = "select_server_button";
            this.select_server_button.Size = new System.Drawing.Size(114, 23);
            this.select_server_button.TabIndex = 1;
            this.select_server_button.Text = "Select Server";
            this.select_server_button.UseVisualStyleBackColor = true;
            this.select_server_button.Click += new System.EventHandler(this.select_server_button_Click);
            // 
            // server_dg
            // 
            this.server_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.server_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.server_id,
            this.s_region_id,
            this.server_name,
            this.server_capacity});
            this.server_dg.Location = new System.Drawing.Point(6, 32);
            this.server_dg.Name = "server_dg";
            this.server_dg.Size = new System.Drawing.Size(499, 301);
            this.server_dg.TabIndex = 0;
            // 
            // server_id
            // 
            this.server_id.HeaderText = "SERVER ID";
            this.server_id.Name = "server_id";
            // 
            // s_region_id
            // 
            this.s_region_id.HeaderText = "REGION ID";
            this.s_region_id.Name = "s_region_id";
            // 
            // server_name
            // 
            this.server_name.HeaderText = "Server Name";
            this.server_name.Name = "server_name";
            // 
            // server_capacity
            // 
            this.server_capacity.HeaderText = "Server Capacity";
            this.server_capacity.Name = "server_capacity";
            // 
            // server_by_region_query_tab
            // 
            this.server_by_region_query_tab.Controls.Add(this.server_select_cb);
            this.server_by_region_query_tab.Controls.Add(this.server_query_dg);
            this.server_by_region_query_tab.Location = new System.Drawing.Point(4, 22);
            this.server_by_region_query_tab.Name = "server_by_region_query_tab";
            this.server_by_region_query_tab.Padding = new System.Windows.Forms.Padding(3);
            this.server_by_region_query_tab.Size = new System.Drawing.Size(966, 339);
            this.server_by_region_query_tab.TabIndex = 8;
            this.server_by_region_query_tab.Text = "SERVER BY REGION";
            this.server_by_region_query_tab.UseVisualStyleBackColor = true;
            this.server_by_region_query_tab.Enter += new System.EventHandler(this.server_by_region_query_tab_Click);
            // 
            // server_select_cb
            // 
            this.server_select_cb.FormattingEnabled = true;
            this.server_select_cb.Location = new System.Drawing.Point(6, 9);
            this.server_select_cb.Name = "server_select_cb";
            this.server_select_cb.Size = new System.Drawing.Size(121, 21);
            this.server_select_cb.TabIndex = 2;
            this.server_select_cb.SelectedIndexChanged += new System.EventHandler(this.server_select_cb_SelectedIndexChanged_1);
            // 
            // server_query_dg
            // 
            this.server_query_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.server_query_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.region_column,
            this.server_name_column,
            this.server_capacity_column});
            this.server_query_dg.Location = new System.Drawing.Point(6, 36);
            this.server_query_dg.Name = "server_query_dg";
            this.server_query_dg.Size = new System.Drawing.Size(954, 297);
            this.server_query_dg.TabIndex = 0;
            // 
            // region_column
            // 
            this.region_column.HeaderText = "Region";
            this.region_column.Name = "region_column";
            // 
            // server_name_column
            // 
            this.server_name_column.HeaderText = "Server";
            this.server_name_column.Name = "server_name_column";
            // 
            // server_capacity_column
            // 
            this.server_capacity_column.HeaderText = "Capacity";
            this.server_capacity_column.Name = "server_capacity_column";
            // 
            // subscription_tab
            // 
            this.subscription_tab.Controls.Add(this.subscription_insert_button);
            this.subscription_tab.Controls.Add(this.subscription_select_button);
            this.subscription_tab.Controls.Add(this.subscription_delete_button);
            this.subscription_tab.Controls.Add(this.subscription_update_button);
            this.subscription_tab.Controls.Add(this.subscription_dg);
            this.subscription_tab.Location = new System.Drawing.Point(4, 22);
            this.subscription_tab.Name = "subscription_tab";
            this.subscription_tab.Padding = new System.Windows.Forms.Padding(3);
            this.subscription_tab.Size = new System.Drawing.Size(966, 339);
            this.subscription_tab.TabIndex = 9;
            this.subscription_tab.Text = "SUBSCRIPTION";
            this.subscription_tab.UseVisualStyleBackColor = true;
            // 
            // subscription_insert_button
            // 
            this.subscription_insert_button.Location = new System.Drawing.Point(368, 6);
            this.subscription_insert_button.Name = "subscription_insert_button";
            this.subscription_insert_button.Size = new System.Drawing.Size(113, 23);
            this.subscription_insert_button.TabIndex = 6;
            this.subscription_insert_button.Text = "Insert Subscription ";
            this.subscription_insert_button.UseVisualStyleBackColor = true;
            this.subscription_insert_button.Click += new System.EventHandler(this.subscription_insert_button_Click);
            // 
            // subscription_select_button
            // 
            this.subscription_select_button.Location = new System.Drawing.Point(11, 6);
            this.subscription_select_button.Name = "subscription_select_button";
            this.subscription_select_button.Size = new System.Drawing.Size(113, 23);
            this.subscription_select_button.TabIndex = 5;
            this.subscription_select_button.Text = "Select Subscription ";
            this.subscription_select_button.UseVisualStyleBackColor = true;
            this.subscription_select_button.Click += new System.EventHandler(this.subscription_select_button_Click);
            // 
            // subscription_delete_button
            // 
            this.subscription_delete_button.Location = new System.Drawing.Point(130, 6);
            this.subscription_delete_button.Name = "subscription_delete_button";
            this.subscription_delete_button.Size = new System.Drawing.Size(113, 23);
            this.subscription_delete_button.TabIndex = 4;
            this.subscription_delete_button.Text = "Delete Subscription ";
            this.subscription_delete_button.UseVisualStyleBackColor = true;
            this.subscription_delete_button.Click += new System.EventHandler(this.subscription_delete_button_Click);
            // 
            // subscription_update_button
            // 
            this.subscription_update_button.Location = new System.Drawing.Point(249, 6);
            this.subscription_update_button.Name = "subscription_update_button";
            this.subscription_update_button.Size = new System.Drawing.Size(113, 23);
            this.subscription_update_button.TabIndex = 3;
            this.subscription_update_button.Text = "Update Subscription ";
            this.subscription_update_button.UseVisualStyleBackColor = true;
            this.subscription_update_button.Click += new System.EventHandler(this.subscription_update_button_Click);
            // 
            // subscription_dg
            // 
            this.subscription_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscription_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscription_id,
            this.subscription_customer_id,
            this.subscription_start_date,
            this.subscription_end_date,
            this.subscription_status});
            this.subscription_dg.Location = new System.Drawing.Point(6, 35);
            this.subscription_dg.Name = "subscription_dg";
            this.subscription_dg.Size = new System.Drawing.Size(954, 298);
            this.subscription_dg.TabIndex = 0;
            // 
            // subscription_id
            // 
            this.subscription_id.HeaderText = "SUBSCRIPTION ID ";
            this.subscription_id.Name = "subscription_id";
            // 
            // subscription_customer_id
            // 
            this.subscription_customer_id.HeaderText = "CUSTOMER ID";
            this.subscription_customer_id.Name = "subscription_customer_id";
            // 
            // subscription_start_date
            // 
            this.subscription_start_date.HeaderText = "Subscription Start Date";
            this.subscription_start_date.Name = "subscription_start_date";
            // 
            // subscription_end_date
            // 
            this.subscription_end_date.HeaderText = "Subscription End Date";
            this.subscription_end_date.Name = "subscription_end_date";
            // 
            // subscription_status
            // 
            this.subscription_status.HeaderText = "Subscripton Status";
            this.subscription_status.Name = "subscription_status";
            // 
            // customer_by_subscription_tab
            // 
            this.customer_by_subscription_tab.Controls.Add(this.customer_by_subscription_cb);
            this.customer_by_subscription_tab.Controls.Add(this.customer_by_subscription_dg);
            this.customer_by_subscription_tab.Location = new System.Drawing.Point(4, 22);
            this.customer_by_subscription_tab.Name = "customer_by_subscription_tab";
            this.customer_by_subscription_tab.Padding = new System.Windows.Forms.Padding(3);
            this.customer_by_subscription_tab.Size = new System.Drawing.Size(966, 339);
            this.customer_by_subscription_tab.TabIndex = 10;
            this.customer_by_subscription_tab.Text = "CUSTOMER BY SUBSCRIPTION";
            this.customer_by_subscription_tab.UseVisualStyleBackColor = true;
            // 
            // customer_by_subscription_cb
            // 
            this.customer_by_subscription_cb.FormattingEnabled = true;
            this.customer_by_subscription_cb.Location = new System.Drawing.Point(7, 7);
            this.customer_by_subscription_cb.Name = "customer_by_subscription_cb";
            this.customer_by_subscription_cb.Size = new System.Drawing.Size(121, 21);
            this.customer_by_subscription_cb.TabIndex = 1;
            this.customer_by_subscription_cb.SelectedIndexChanged += new System.EventHandler(this.customer_by_subscription_cb_SelectedIndexChanged);
            // 
            // customer_by_subscription_dg
            // 
            this.customer_by_subscription_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_by_subscription_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_subscription_customer_id,
            this.customer_subscription_status});
            this.customer_by_subscription_dg.Location = new System.Drawing.Point(3, 34);
            this.customer_by_subscription_dg.Name = "customer_by_subscription_dg";
            this.customer_by_subscription_dg.Size = new System.Drawing.Size(957, 299);
            this.customer_by_subscription_dg.TabIndex = 0;
            // 
            // customer_subscription_customer_id
            // 
            this.customer_subscription_customer_id.HeaderText = "Customer ID";
            this.customer_subscription_customer_id.Name = "customer_subscription_customer_id";
            // 
            // customer_subscription_status
            // 
            this.customer_subscription_status.HeaderText = "Subscription Status ";
            this.customer_subscription_status.Name = "customer_subscription_status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 389);
            this.Controls.Add(this.form);
            this.Name = "Form1";
            this.Text = "Form1";
            this.form.ResumeLayout(false);
            this.class_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.class_dg)).EndInit();
            this.region_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.region_dg)).EndInit();
            this.character_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.character_dg)).EndInit();
            this.customer_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_dg)).EndInit();
            this.faction_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.faction_dg)).EndInit();
            this.item_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.item_dg)).EndInit();
            this.race_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.race_dg)).EndInit();
            this.server_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.server_dg)).EndInit();
            this.server_by_region_query_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.server_query_dg)).EndInit();
            this.subscription_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscription_dg)).EndInit();
            this.customer_by_subscription_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer_by_subscription_dg)).EndInit();
            this.ResumeLayout(false);
            this.customer_by_subscription_tab.Enter += new System.EventHandler(this.customer_by_subscription_tab_Click);

        }


        #endregion
        private System.Windows.Forms.TabControl form;
        private System.Windows.Forms.TabPage class_tab;
        private System.Windows.Forms.TabPage region_tab;
        private System.Windows.Forms.DataGridView class_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_health;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_mana;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_attack;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_defense;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_ability;
        private System.Windows.Forms.Button class_select_button;
        private System.Windows.Forms.Button delete_class_button;
        private System.Windows.Forms.Button insert_class_button;
        private System.Windows.Forms.Button update_class_button;
        private System.Windows.Forms.DataGridView region_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn region_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn region_name;
        private System.Windows.Forms.Button region_update_button;
        private System.Windows.Forms.Button region_insert_button;
        private System.Windows.Forms.Button region_delete_button;
        private System.Windows.Forms.Button region_select_button;
        private System.Windows.Forms.TabPage character_tab;
        private System.Windows.Forms.DataGridView character_dg;
        private System.Windows.Forms.Button character_update_button;
        private System.Windows.Forms.Button character_insert_button;
        private System.Windows.Forms.Button character_delete_button;
        private System.Windows.Forms.Button character_select_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn character_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn character_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn character_play_time;
        private System.Windows.Forms.TabPage customer_tab;
        private System.Windows.Forms.DataGridView customer_dg;
        private System.Windows.Forms.Button customer_update_button;
        private System.Windows.Forms.Button customer_insert_button;
        private System.Windows.Forms.Button customer_delete_button;
        private System.Windows.Forms.Button customer_select_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_account_creation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_billing_address;
        private System.Windows.Forms.TabPage faction_tab;
        private System.Windows.Forms.DataGridView faction_dg;
        private System.Windows.Forms.Button insert_faction_button;
        private System.Windows.Forms.Button update_faction_button;
        private System.Windows.Forms.Button delete_faction_button;
        private System.Windows.Forms.Button select_faction_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn faction_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn faction_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn faction_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn faction_rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn faction_perk;
        private System.Windows.Forms.TabPage item_tab;
        private System.Windows.Forms.DataGridView item_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cost;
        private System.Windows.Forms.Button item_insert_button;
        private System.Windows.Forms.Button item_update_button;
        private System.Windows.Forms.Button item_delete_button;
        private System.Windows.Forms.Button item_select_button;
        private System.Windows.Forms.TabPage race_tab;
        private System.Windows.Forms.Button race_insert_button;
        private System.Windows.Forms.Button race_update_button;
        private System.Windows.Forms.Button race_delete_button;
        private System.Windows.Forms.Button race_select_button;
        private System.Windows.Forms.DataGridView race_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn race_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn race_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn race_ability;
        private System.Windows.Forms.TabPage server_tab;
        private System.Windows.Forms.Button server_insert_button;
        private System.Windows.Forms.Button server_update_button;
        private System.Windows.Forms.Button server_delete_button;
        private System.Windows.Forms.Button select_server_button;
        private System.Windows.Forms.DataGridView server_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_region_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_capacity;
        private System.Windows.Forms.TabPage server_by_region_query_tab;
        private System.Windows.Forms.DataGridView server_query_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn region_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn server_capacity_column;
        private System.Windows.Forms.TabPage subscription_tab;
        private System.Windows.Forms.Button subscription_update_button;
        private System.Windows.Forms.DataGridView subscription_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscription_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscription_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscription_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscription_end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscription_status;
        private System.Windows.Forms.Button subscription_select_button;
        private System.Windows.Forms.Button subscription_delete_button;
        private System.Windows.Forms.Button subscription_insert_button;
        private System.Windows.Forms.TabPage customer_by_subscription_tab;
        private System.Windows.Forms.DataGridView customer_by_subscription_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_subscription_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_subscription_status;
        private System.Windows.Forms.ComboBox server_select_cb;
        private System.Windows.Forms.ComboBox customer_by_subscription_cb;
    }
}

