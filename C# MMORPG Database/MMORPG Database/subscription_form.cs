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
    public partial class subscription_form : Form
    {
        Form1 firstformref; //ref the main form
        bool insertflag = false; //is the program in insert mode? 
        string updateId = ""; //record update is required

        //database object
        DBConnection mySqlSrc = new DBConnection();

        //constructor with ref to main form; insert flag + updateid 
        public subscription_form(ref Form1 form1handle, bool isInsert, string upId)
        {
            //set vars
            updateId = upId;
            insertflag = isInsert;
            firstformref = form1handle;
            InitializeComponent();

            //bind combobox  to dictionary, allowing a key = value pair
            Dictionary<string, string> customerItem = new Dictionary<string, string>();

            //get list for results of region table 
            List<string>[] results = new List<string>[5];
            results = mySqlSrc.SelectCustomer();

            //count rows
            int rows = results[0].Count;
            for (int i = 0; i < rows; i++)
            {
                //[cloumn][row] add to the dictionary object to id and name
                customerItem.Add(results[0][i], results[0][i]);
            }

            //bind dictionary object and set key -> value (as id -> name) 
            subscription_customer_id_cb.DataSource = new BindingSource(customerItem, null);
            subscription_customer_id_cb.DisplayMember = "Value";
            subscription_customer_id_cb.ValueMember = "Key";



            //if not in insert mode, update mode
            if (!insertflag)
            {
                List<string>[] upResults = new List<string>[5];

                //send id to get results
                upResults = mySqlSrc.SelectCustomerRow(updateId);

                //update combo box, get region id from selected records
                string temp_subscriptionId = upResults[0][0].ToString();

                //loop through rows of full region results
                for (int i = 0; i < rows; i++)
                {
                    //get region_id of current combobox index
                    string value =
                        ((KeyValuePair<string, string>)subscription_customer_id_cb.Items[i]).Key;
                    //if the value matches the current region id, set SelectedIndex to iteration to display correct region
                    if (value == temp_subscriptionId)
                    {
                        subscription_customer_id_cb.SelectedIndex = i;
                    }

                    //update text boxes 
                    subscription_start_date_txt.Text = upResults[2][0].ToString();
                    subscription_end_date_txt.Text = upResults[3][0].ToString();
                    subscription_status_txt.Text = upResults[4][0].ToString(); 
                }
            }
        }

        private bool ValidateFields()
        {
            //valid flag and message 
            bool validFlag = true;
            string validMsg = "";

            //region - check entry 
            if (subscription_customer_id_cb.Text.ToString() == "")
            {
                //if no - update msg and flag 
                validMsg += "You need to select a Customer ID!";
                validFlag = false;
            }

            //region - check entry 
            if (subscription_status_txt.Text.ToString() == "")
            {
                //if no - update msg and flag 
                validMsg += "You need to enter a status!";
                validFlag = false;
            }

          
            //start date
            if (subscription_start_date_txt.Text.ToString() == "")
            {
                validMsg += "You need to enter a capacity!";
            }
            else
            {
                int date;
                if (int.TryParse(subscription_start_date_txt.Text, out date))
                {
                    //if its a valid int 
                    if (date < 0 || date > 311299)
                    {
                        validMsg += "Must be a valid date (format DDMMYY)";
                        validFlag = false;
                    }
                }
                else
                {
                    validMsg += "date must be a valid int!";
                    validFlag = false;
                }
            }
            //if invalid show show message 
            if (!validFlag)
                MessageBox.Show(validMsg);

            return validFlag;
        }



        //form closing event 
        private void subscription_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            firstformref.subscriptionFormIsOpen = false;
            firstformref.SelectSubscriptionResults();
        }

        private void insert_subscription_Click(object sender, EventArgs e)
        {
            //check is update or insert mode, run relevent methods to  run queries with validation checks 
            if (insertflag)
            {
                if (ValidateFields())
                {
                    mySqlSrc.InsertSubscription(
                        ((KeyValuePair<string, string>)
                    subscription_customer_id_cb.SelectedItem).Key.ToString(),
                    subscription_start_date_txt.Text.ToString(),
                    subscription_end_date_txt.Text.ToString(),
                    subscription_status_txt.Text.ToString());
                    this.Close();
                }
            }
            else
            {
                if (ValidateFields())
                {
                    mySqlSrc.UpdateSubscription(updateId,
                        ((KeyValuePair<string, string>)subscription_customer_id_cb.SelectedItem)
                        .Key.ToString(),
                         subscription_start_date_txt.Text.ToString(),
                         subscription_end_date_txt.Text.ToString(),
                         subscription_status_txt.Text.ToString());
                    this.Close();
                }

            }
        }

    }
}