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
    public partial class item_form : Form
    {
        Form1 firstformRef; //reference to main form
        bool insertFlag = false; //is insert? (update)
        //db object
        DBConnection mySqlSrc = new DBConnection();
        string updateId = ""; //id for record to update

        //constructor (modified to get reference from main form and insert flag)
        public item_form(ref Form1 form1Handle, bool isInsert, string upId)
        {
            //set flags and handles before initialisation
            insertFlag = isInsert;
            firstformRef = form1Handle;
            InitializeComponent();

            updateId = upId; //get an update id
            //if insert flag is not set (in update mode)
            if (!insertFlag)
            {
                //create results string
                List<string>[] results = new List<string>[6];
                //get record for the matching id
                results = mySqlSrc.SelectItemRow(updateId);

                //fill the boxes with the corresponding values
                item_name_txt.Text = results[1][0].ToString();
                item_description_txt.Text = results[2][0].ToString();
                item_type_txt.Text = results[3][0].ToString();
                item_weight_txt.Text = results[4][0].ToString();
                item_cost_txt.Text = results[5][0].ToString();
            
            }
        }

        private bool ValidateFields()
        {
            //flag for validation and message string
            bool validFlag = true;
            string validMessage = "";

            //NAME: Check to see if NAME is entered

            if (item_name_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a name!";
                validFlag = false;
            }

            //DESCRIPTION:

            if (item_description_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a description!";
                validFlag = false;
            }

            //TYPE: 

            if (item_type_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a type!";
                validFlag = false;
            }


            //WEIGHT: Check to see if HEALTH is entered

            if (item_weight_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter weight!";
                validFlag = false;
            }
            else
            {
                //integer container for weight bonus
                int ItemWeight;
                //attempt to parse the text as int
                if (int.TryParse(item_weight_txt.Text, out ItemWeight))
                {
                    if (ItemWeight < 0 || ItemWeight > 10)
                    {
                        validMessage += "\n\n Item weight must be between 0 and 10!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Item weight must be a valid number!";
                    validFlag = false;
                }
            }

            //COST

            if (item_cost_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter cost!";
                validFlag = false;
            }
            else
            {
                //integer container for weight bonus
                int ItemCost;
                //attempt to parse the text as int
                if (int.TryParse(item_weight_txt.Text, out ItemCost))
                {
                    if (ItemCost < 0 || ItemCost > 999)
                    {
                        validMessage += "\n\n Item cost must be between 0 and 999!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Item weight must be a valid number!";
                    validFlag = false;
                }
            }
            return validFlag; 
        }



        public item_form()
        {
            InitializeComponent();
        }

        private void insert_item_button_Click(object sender, EventArgs e)
        {
            //check in insert mode
            if (insertFlag)
            {
                //check fields are valid
                if (ValidateFields())
                {
                    //send the values from text boxes to insert class using DBconnection instance
                    mySqlSrc.InsertItem(item_name_txt.Text.ToString(),
                        item_description_txt.Text.ToString(),
                        item_type_txt.Text.ToString(),
                        item_weight_txt.Text.ToString(),
                        item_cost_txt.Text.ToString());


                    //close form
                    this.Close();
                }
            }
            //otherwise we are in update mode
            else
            {
                //check fields are valid
                if (ValidateFields())
                {
                    //call updateitem method
                    mySqlSrc.UpdateItem(updateId,
                        item_name_txt.Text.ToString(), 
                       item_description_txt.Text.ToString(),
                        item_type_txt.Text.ToString(),
                        item_weight_txt.Text.ToString(),
                        item_cost_txt.Text.ToString());

                    //close this form
                    this.Close();
                }
            }
        }

        private void item_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //set the class open flag to false of the main form 
            firstformRef.itemFormIsOpen = false;
            //call the reselectresults method on main form
            firstformRef.SelectItemResults();
        }

    }
 }
