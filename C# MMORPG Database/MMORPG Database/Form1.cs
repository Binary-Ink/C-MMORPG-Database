using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG_Database
{
    public partial class Form1 : Form
    {
        //db object
        DBConnection mySqlSrc = new DBConnection();

        //class form and open flag
        class_form classForm;
        public bool classFormIsOpen = false;
        //region sub form and open flag
        region_form regionForm;
        public bool regionFormIsOpen = false;
        //character form and open flag
        character_form characterForm;
        public bool characterFormIsOpen = false;
        //customer form and open flag
        customer_form customerForm;
        public bool customerFormIsOpen = false;
        //faction form and open flag
        faction_form factionForm;
        public bool factionFormIsOpen = false;
        //item form and open flag
        item_form itemForm;
        public bool itemFormIsOpen = false;
        //race form and open flag
        race_form raceForm;
        public bool raceFormIsOpen = false;
        //server form and open flag
        server_form serverForm;
        public bool serverFormIsOpen = false;
        //subscription form and open flag
        subscription_form subscriptionForm;
        public bool subscriptionFormIsOpen = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            mySqlSrc.TestConnnection();
        }



        //-------------------------CLASS

        public void ReselectResults()
        {
            //create results list
            List<string>[] results = new List<string>[6];

            //get results from database query
            results = mySqlSrc.SelectClass();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            class_dg.Rows.Clear();

            //loop through each row
            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                class_dg.Rows.Add(results[0][i], //class id
                    results[1][i], //name
                    results[2][i], //health
                    results[3][i], //mana
                    results[4][i], //attack
                    results[5][i], //defence
                    results[6][i] //ability
                    );
            }
        }

        private void class_select_button_Click(object sender, EventArgs e)
        {
            ReselectResults();
        }

        private void delete_class_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = class_dg.Rows.Count;

            //loop through rows 
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (class_dg.Rows[i].Selected)
                {
                    rowId = i; //get row ID
                    isSelected = true; //set selected flag
                }
            }

            //if selected flag set
            if (isSelected)
            {
                //call DeleteClass Method and send id value from grid
                mySqlSrc.DeleteClass(
                    class_dg.Rows[rowId].Cells[0].Value.ToString()
                    );
            }
            else
            {
                MessageBox.Show("No rows selected");
            }
            ReselectResults();
        }

        private void insert_class_button_Click(object sender, EventArgs e)
        {
            //check to see if class form is open or create a new one
            if (classFormIsOpen)
            {
                //if open, set focus on class form
                classForm.Focus();
            }
            else
            {
                //create new form1 object and send this form as reference to classform
                Form1 newform = new Form1();
                newform = this;
                //send form reference and set insert flag to be true
                classForm = new class_form(ref newform, true, "");
                //show form and set open flag
                classForm.Show();
                classFormIsOpen = true;
            }
        }

        private void update_class_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = class_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (class_dg.Rows[i].Selected)
                {
                    //set flags and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create new one
                if (classFormIsOpen)
                {
                    //set focus on existing form
                    classForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference, set false for insert, send record id
                    classForm = new class_form(ref newform, false, class_dg.Rows[rowId].Cells[0].Value.ToString());
                    //show form and set open flag to true
                    classForm.Show();
                    classFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }
        //-----------------------------REGION

        public void SelectRegionResults()
        {
            List<string>[] results = new List<string>[2];

            results = mySqlSrc.SelectRegion();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            region_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                region_dg.Rows.Add(results[0][i], //region id
                                   results[1][i]); //region name
            }
        }

        //select REGION
        private void region_select_button_Click(object sender, EventArgs e)
        {
            SelectRegionResults();
        }
        //delete REGION
        private void region_delete_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = region_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (region_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteRegion(region_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectRegionResults();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }
        //insert REGION 
        private void region_insert_button_Click(object sender, EventArgs e)
        {
            if (regionFormIsOpen)
            {
                regionForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                regionForm = new region_form(ref newform, true, "");
                regionForm.Show();
                regionFormIsOpen = true;
            }
        }
        //update REGION
        private void region_update_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = region_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (region_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (regionFormIsOpen)
                {
                    regionForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    regionForm = new region_form(ref newform, false, region_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    regionForm.Show();
                    regionFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }

        //****************************CHARACTER
        public void SelectCharacterResults()
        {
            List<string>[] results = new List<string>[3];
            results = mySqlSrc.SelectCharacter();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            character_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                character_dg.Rows.Add(results[0][i], //character_id
                    results[1][i], //character level
                    results[2][i] //character play time
                    );
            }
        }
        //select CHARACTER
        private void character_select_button_Click(object sender, EventArgs e)
        {
            SelectCharacterResults();
        }
        //delete CHARACTER
        private void character_delete_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = character_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (character_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteCharacter(character_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectCharacterResults();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }
        //insert CHARACTER
        private void character_insert_button_Click(object sender, EventArgs e)
        {
            if (characterFormIsOpen)
            {
                characterForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                characterForm = new character_form(ref newform, true, "");
                characterForm.Show();
                characterFormIsOpen = true;
            }
        }
        //update CHARACTER
        private void character_update_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = character_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (character_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (characterFormIsOpen)
                {
                    characterForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    characterForm = new character_form(ref newform, false, character_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    characterForm.Show();
                    characterFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }

        //*****************CUSTOMER
        public void SelectCustomerResults()
        {
            List<string>[] results = new List<string>[8];
            results = mySqlSrc.SelectCustomer();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            customer_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                customer_dg.Rows.Add(results[0][i], //customer_id
                    results[1][i], //customer_fname
                    results[2][i], //customer_sname
                    results[3][i], //customer account creation
                    results[4][i], //customer region
                    results[5][i], //customer dob
                    results[6][i], //customer password
                    results[7][i] //customer billing address
                    );
            }
        }

        //select customer
        private void customer_select_button_Click(object sender, EventArgs e)
        {
            List<string>[] results = new List<string>[3];
            results = mySqlSrc.SelectCustomer();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            customer_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                customer_dg.Rows.Add(results[0][i], //customer_id
                    results[1][i], //customer_fname
                    results[2][i], //customer_sname
                    results[3][i], //customer account creation
                    results[4][i], //customer region
                    results[5][i], //customer dob
                    results[6][i], //customer password
                    results[7][i] //customer billing address
                    );
            }
        }
        //delete customer
        private void customer_delete_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = customer_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (customer_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteCustomer(customer_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectCustomerResults();

            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }
        //insert customer
        private void customer_insert_button_Click(object sender, EventArgs e)
        {
            if (customerFormIsOpen)
            {
                customerForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                customerForm = new customer_form(ref newform, true, "");
                customerForm.Show();
                customerFormIsOpen = true;
            }
        }
        //update customer
        private void customer_update_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = customer_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (customer_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (customerFormIsOpen)
                {
                    customerForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    customerForm = new customer_form(ref newform, false, customer_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    customerForm.Show();
                    customerFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }
        //********************FACTION

        public void SelectFactionResults()
        {

            List<string>[] results = new List<string>[5];

            results = mySqlSrc.SelectFaction();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            faction_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                faction_dg.Rows.Add(results[0][i], //faction id
                                   results[1][i], //faction name
                                   results[2][i], //faction level
                                   results[3][i], //faction rank
                                   results[4][i]); //faction perk
            }
        }
        private void select_faction_button_Click(object sender, EventArgs e)
        {
            SelectFactionResults();
        }






        private void delete_faction_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = faction_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (faction_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteFaction(faction_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectFactionResults();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void update_faction_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = faction_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (faction_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (factionFormIsOpen)
                {
                    factionForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    factionForm = new faction_form(ref newform, false, faction_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    factionForm.Show();
                    factionFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }

        private void insert_faction_button_Click(object sender, EventArgs e)
        {
            if (factionFormIsOpen)
            {
                factionForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                factionForm = new faction_form(ref newform, true, "");
                factionForm.Show();
                factionFormIsOpen = true;
            }
        }

        //************************ITEM

        public void SelectItemResults()
        {

            List<string>[] results = new List<string>[6];

            results = mySqlSrc.SelectItem();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            item_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                item_dg.Rows.Add(results[0][i], //item id
                                   results[1][i], //item name
                                   results[2][i], //item description
                                   results[3][i], //item type
                                   results[4][i],//item weight
                                   results[5][i]); //item cost
            }
        }

        private void item_select_button_Click(object sender, EventArgs e)
        {
            SelectItemResults();
        }

        private void item_delete_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = item_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (item_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteItem(item_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectItemResults();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void item_update_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = item_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (item_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (itemFormIsOpen)
                {
                    itemForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    itemForm = new item_form(ref newform, false, item_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    itemForm.Show();
                    itemFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }

        private void item_insert_button_Click(object sender, EventArgs e)
        {
            if (itemFormIsOpen)
            {
                itemForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                itemForm = new item_form(ref newform, true, "");
                itemForm.Show();
                itemFormIsOpen = true;
            }
        }
        //*****************RACE

        public void SelectraceResults()
        {

            List<string>[] results = new List<string>[3];

            results = mySqlSrc.SelectRace();

            //count the rows
            int rows = results[0].Count;

            //clear data grid
            item_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                item_dg.Rows.Add(results[0][i], //race id
                                   results[1][i], //race name 
                                   results[2][i]); //race ability

            }
        }
        private void race_select_button_Click(object sender, EventArgs e)
        {
            SelectraceResults();
        }

        private void race_delete_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = race_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (race_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteRace(race_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectraceResults();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void race_update_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = race_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (race_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (raceFormIsOpen)
                {
                    raceForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    raceForm = new race_form(ref newform, false, race_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    raceForm.Show();
                    raceFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }

        private void race_insert_button_Click(object sender, EventArgs e)
        {
            if (raceFormIsOpen)
            {
                raceForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                raceForm = new race_form(ref newform, true, "");
                raceForm.Show();
                raceFormIsOpen = true;
            }
        }

        //**********************SERVER

        public void SelectServerResults()
        {
            List<string>[] results = new List<string>[4];

            results = mySqlSrc.SelectServer();

            //count rows
            int rows = results[0].Count;

            //clear grid
            server_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                server_dg.Rows.Add(results[0][i], //server_id
                               results[1][i], // region_id
                               results[2][i], // server_name
                                results[3][i]); // server_capacity
            }
        }

        private void select_server_button_Click(object sender, EventArgs e)
        {
            SelectServerResults();
        }

        private void server_delete_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = server_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (server_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteServer(server_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectServerResults();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void server_update_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = server_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (server_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (serverFormIsOpen)
                {
                    serverForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    serverForm = new server_form(ref newform, false, server_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    serverForm.Show();
                    serverFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }

        private void server_insert_button_Click(object sender, EventArgs e)
        {
            if (serverFormIsOpen)
            {
                serverForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                serverForm = new server_form(ref newform, true, "");
                serverForm.Show();
                serverFormIsOpen = true;
            }
        }



//##########SUBSCRIPTION
        public void SelectSubscriptionResults()
        {
            List<string>[] results = new List<string>[5];

            results = mySqlSrc.SelectSubscription();

            //count rows
            int rows = results[0].Count;

            //clear grid
            subscription_dg.Rows.Clear();

            for (int i = 0; i < rows; i++)
            {
                //[column][row]
                subscription_dg.Rows.Add(results[0][i], //subscription
                               results[1][i], // customer id
                               results[2][i], // subscription start
                                results[3][i], // subscription_end
                                results[4][i]); // subscription_status
            }
        }

        private void subscription_update_button_Click(object sender, EventArgs e)
        {
            //check to see if row is selected
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = subscription_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (subscription_dg.Rows[i].Selected)
                {
                    //set flag and id
                    rowId = i;
                    isSelected = true;
                }
            }
            //if a row is selected
            if (isSelected)
            {
                //check to see if form is open or create a new one 
                if (subscriptionFormIsOpen)
                {
                    subscriptionForm.Focus();
                }
                else
                {
                    //create reference to this form
                    Form1 newform = new Form1();
                    newform = this;
                    //send this form reference and set false for insert, send record id
                    subscriptionForm = new subscription_form(ref newform, false, subscription_dg.Rows[rowId].Cells[0].Value.ToString());

                    //show form and set open flag to true
                    subscriptionForm.Show();
                    subscriptionFormIsOpen = true;
                }
            }
            else
            {
                MessageBox.Show("No row selected");

            }
        }


        private void subscription_select_button_Click(object sender, EventArgs e)
        {
            SelectSubscriptionResults(); 
        }

        private void subscription_delete_button_Click(object sender, EventArgs e)
        {
            //check to see if a row is inserted
            bool isSelected = false;
            int rowId = 0;
            int numRows = 0;

            //number of rows in data grid
            numRows = subscription_dg.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                //if row selected
                if (subscription_dg.Rows[i].Selected)
                {
                    rowId = i;
                    isSelected = true;
                }
            }
            if (isSelected)
            {
                mySqlSrc.DeleteSubscription(subscription_dg.Rows[rowId].Cells[0].Value.ToString());
                SelectSubscriptionResults();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void subscription_insert_button_Click(object sender, EventArgs e)
        {
            if (subscriptionFormIsOpen)
            {
                subscriptionForm.Focus();
            }
            else
            {
                Form1 newform = new Form1();
                newform = this;
                subscriptionForm = new subscription_form(ref newform, true, "");
                subscriptionForm.Show();
                subscriptionFormIsOpen = true;
            }
        }
        //################SPECIAL QUERIES################
        //SERVER BY REGION############
        void server_by_region_query_tab_Click(object sender, EventArgs e)
        {
            //bind combobox to dictionary
            //this allows a key value pair
            Dictionary<string, string> regionItem = new Dictionary<string, string>();
            //get new list for results of region table
            List<string>[] results = new List<string>[4];
            results = mySqlSrc.SelectRegion();

            int rows = results[0].Count;
            for (int i = 0; i < rows; i++)
            {
                regionItem.Add(results[0][i], results[1][i]);
            }
            //bind dictionary object with key value
            server_select_cb.DataSource = new BindingSource(regionItem, null);
            server_select_cb.DisplayMember = "Value";
            server_select_cb.ValueMember = "Key";

        }

        private void SelectServerByRegion(string id)
        {
            List<string>[] results = new List<string>[4];
            results = mySqlSrc.SelectServerByRegion(id);

            //count rows
            int rows = results[0].Count;

            //clear grid
            server_query_dg.Rows.Clear();


            for (int i = 0; i < rows; i++)
            {
                //[column][row] 
                server_query_dg.Rows.Add(results[0][i], //region name
                    results[1][i], //server name
                    results[2][i]); //server capacity

            }
        }


        private void server_select_cb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
SelectServerByRegion(((KeyValuePair<string, string>)
               server_select_cb.SelectedItem)
               .Key.ToString());
        }

//#########CUSTOMER BY SUBSCRIPTION
        void customer_by_subscription_tab_Click(object sender, EventArgs e)
        {
            //bind combobox to dictionary
            //this allows a key value pair
            Dictionary<string, string> subscriptionItem = new Dictionary<string, string>();
            //get new list for results of region table
            List<string>[] results = new List<string>[5];
            results = mySqlSrc.SelectSubscription();

            int rows = results[0].Count;
            for (int i = 0; i < rows; i++)
            {
                subscriptionItem.Add(results[0][i], results[4][i]);
            }
            //bind dictionary object with key value
            customer_by_subscription_cb.DataSource = new BindingSource(subscriptionItem, null);
            customer_by_subscription_cb.DisplayMember = "Value";
            customer_by_subscription_cb.ValueMember = "Key";

        }

        private void SelectCustomerBySubscription(string id)
        {
            List<string>[] results = new List<string>[2];
            results = mySqlSrc.SelectCustomerBySubscription(id);

            //count rows
            int rows = results[0].Count;

            //clear grid
            customer_by_subscription_dg.Rows.Clear();


            for (int i = 0; i < rows; i++)
            {
                //[column][row] 
                customer_by_subscription_dg.Rows.Add(results[0][i], //customer id
                    results[1][i]); //subscription status

            }
        }


        private void customer_by_subscription_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
        SelectCustomerBySubscription(((KeyValuePair<string, string>)
               customer_by_subscription_cb.SelectedItem)
               .Key.ToString());
        }

       
        }
    }