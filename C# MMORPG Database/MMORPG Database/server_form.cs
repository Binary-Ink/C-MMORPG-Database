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
    public partial class server_form : Form
    {
        Form1 firstformref; //ref the main form
        bool insertflag = false; //is the program in insert mode? 
        string updateId = ""; //record update is required

        //database object
        DBConnection mySqlSrc = new DBConnection();

        //constructor with ref to main form; insert flag + updateid 
        public server_form(ref Form1 form1handle, bool isInsert, string upId)
        {
            //set vars
            updateId = upId;
            insertflag = isInsert;
            firstformref = form1handle;
            InitializeComponent();

            //bind combobox  to dictionary, allowing a key = value pair
            Dictionary<string, string> regionItem = new Dictionary<string, string>();

            //get list for results of region table 
            List<string>[] results = new List<string>[5];
            results = mySqlSrc.SelectRegion();

            //count rows
            int rows = results[0].Count;
            for (int i = 0; i < rows; i++)
            {
                //[cloumn][row] add to the dictionary object to id and name
                regionItem.Add(results[0][i], results[1][i]);
            }

            //bind dictionary object and set key -> value (as id -> name) 
            server_region_id_cb.DataSource = new BindingSource(regionItem, null);
            server_region_id_cb.DisplayMember = "Value";
            server_region_id_cb.ValueMember = "Key";



            //if not in insert mode, update mode
            if (!insertflag)
            {
                List<string>[] upResults = new List<string>[5];

                //send id to get results
                upResults = mySqlSrc.SelectServerRow(updateId);

                //update combo box, get region id from selected records
                string temp_regionId = upResults[1][0].ToString();

                //loop through rows of full region results
                for (int i = 0; i < rows; i++)
                {
                    //get region_id of current combobox index
                    string value =
                        ((KeyValuePair<string, string>)server_region_id_cb.Items[i]).Key;
                    //if the value matches the current region id, set SelectedIndex to iteration to display correct region
                    if (value == temp_regionId)
                    {
                        server_region_id_cb.SelectedIndex = i;
                    }

                    //update text boxes 
                    server_name_txt.Text = upResults[2][0].ToString();
                    server_capacity_txt.Text = upResults[3][0].ToString();
                }
            }
        }

        private bool ValidateFields()
        {
            //valid flag and message 
            bool validFlag = true;
            string validMsg = "";

            //region - check entry 
            if (server_region_id_cb.Text.ToString() == "")
            {
                //if no - update msg and flag 
                validMsg += "You need to select a region!";
                validFlag = false;
            }

            //name - check entry 
            if (server_name_txt.Text.ToString() == "")
            {
                validMsg += "You need to enter a name!";
                validFlag = false;
            }
            //capacity
            if (server_capacity_txt.Text.ToString() == "")
            {
                validMsg += "You need to enter a capacity!";
            }
            else
            {
                int capacity;
                if (int.TryParse(server_capacity_txt.Text, out capacity))
                {
                    //if its a valid int 
                    if (capacity < 0 || capacity > 20)
                    {
                        validMsg += "Must be a valid number between 0 and  20";
                        validFlag = false;
                    }
                }
                else
                {
                    validMsg += "Capacity must be a valid int!";
                    validFlag = false;
                }
            }
            //if invalid show show message 
            if (!validFlag)
                MessageBox.Show(validMsg);
          
            return validFlag; 
        }


        private void insert_server_button_Click(object sender, EventArgs e)
        {
            //check is update or insert mode, run relevent methods to  run queries with validation checks 
            if (insertflag)
            {
                if (ValidateFields())
                {
                    mySqlSrc.InsertServer(
                        ((KeyValuePair<string, string>)
                    server_region_id_cb.SelectedItem).Key.ToString(),
                    server_name_txt.Text.ToString(),
                    server_capacity_txt.Text.ToString());
                    this.Close();
                }
            }
            else
            {
                if (ValidateFields())
                {
                    mySqlSrc.UpdateServer(updateId,
                        ((KeyValuePair<string, string>)server_region_id_cb.SelectedItem)
                        .Key.ToString(),
                         server_name_txt.Text.ToString(),
                         server_capacity_txt.Text.ToString());
                    this.Close();
                }

            }
        }

        //form closing event 
        private void server_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            firstformref.serverFormIsOpen = false;
            firstformref.SelectServerResults();
        }
    }
}