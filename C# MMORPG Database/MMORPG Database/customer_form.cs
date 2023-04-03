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
    public partial class customer_form : Form
    {
        Form1 firstformRef; //reference to main form
        bool insertFlag = false; //are we in insert mode? 
        string updateId = ""; //record update is required

        //db connection
        DBConnection mySqlSrc = new DBConnection();

        //constructor with reference to main form, insert flag and update id
        public customer_form(ref Form1 form1Handle, bool isInsert, string upId)
        {
            updateId = upId;
            insertFlag = isInsert;
            firstformRef = form1Handle;
            InitializeComponent();

            //if not insert mode, update mode
            if (!insertFlag)
            {
                //create new results list 
                List<string>[] results = new List<string>[8];

                //send id to get results
                results = mySqlSrc.SelectCustomerRow(updateId);

                //update text box 
                customer_fname_txt.Text = results[1][0].ToString();
                customer_sname_txt.Text = results[2][0].ToString();
                customer_account_creation_date_txt.Text = results[3][0].ToString();
                customer_region_txt.Text = results[4][0].ToString();
                customer_date_of_birth_txt.Text = results[5][0].ToString();
                customer_password_txt.Text = results[6][0].ToString();
                customer_billing_address_txt.Text = results[7][0].ToString();

            }
        }
        private bool ValidateFields()
        {
            //valid flag and message
            bool validFlag = true;
            string validMsg = "";

            //FNAME: Check to see if NAME is entered

            if (customer_fname_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMsg += "\n\n You need to enter a forename!";
                validFlag = false;
            }
            //SNAME: Check to see if NAME is entered

            if (customer_sname_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMsg += "\n\n You need to enter a surname!";
                validFlag = false;
            }


            //ACCOUNT CREATION DATE: Check to see if ACCOUNT CREATION DATE is entered

            if (customer_account_creation_date_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMsg += "\n\n You need to enter an account creation date!";
                validFlag = false;
            }
            else
            {
                //integer container for ACD
                int AccountCreationDate;
                //attempt to parse the text as int
                if (int.TryParse(customer_account_creation_date_txt.Text, out AccountCreationDate))
                {
                    if (AccountCreationDate < 0 || AccountCreationDate > 311299)
                    {
                        validMsg += "\n\n Account creation date must be between 0 and 311299!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMsg += "\n\n Account Creation must be a valid number!";
                    validFlag = false;
                }
            }

            //return result 
            return validFlag;
        }


        //form closing event
        private void customer_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            firstformRef.customerFormIsOpen = false;
            firstformRef.SelectCustomerResults();
        }



        private void insert_customer_button_Click(object sender, EventArgs e)
        {
            //check if insert or update mode, send relevant data to relevant methods to run queries following validation, validation checks
            if (insertFlag)
            {
                if (ValidateFields())
                {
                    mySqlSrc.InsertCustomer(customer_fname_txt.Text.ToString(),
                customer_sname_txt.Text.ToString(),
                customer_account_creation_date_txt.Text.ToString(),
                customer_region_txt.Text.ToString(),
                customer_date_of_birth_txt.Text.ToString(),
                customer_password_txt.Text.ToString(),
                customer_billing_address_txt.Text.ToString()
                );
                    this.Close();
                }
            }
            else
            {
                if (ValidateFields())
                {
                    mySqlSrc.UpdateCustomer(updateId,
                        customer_fname_txt.Text.ToString(),
                        customer_sname_txt.Text.ToString(),
                        customer_account_creation_date_txt.Text.ToString(),
                        customer_region_txt.Text.ToString(),
                        customer_date_of_birth_txt.Text.ToString(),
                        customer_password_txt.Text.ToString(),
                        customer_billing_address_txt.Text.ToString());
                    this.Close();
                }
            }
        }
    }

}



