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
    public partial class race_form : Form
    {
        Form1 firstformRef; //reference to main form
        bool insertFlag = false; //is insert? (update)
        //db object
        DBConnection mySqlSrc = new DBConnection();
        string updateId = ""; //id for record to update

        //constructor (modified to get reference from main form and insert flag)
        public race_form(ref Form1 form1Handle, bool isInsert, string upId)
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
                List<string>[] results = new List<string>[2];
                //get record for the matching id
                results = mySqlSrc.SelectClassRow(updateId);

                //fill the boxes with the corresponding values
                race_name_txt.Text = results[1][0].ToString();
                race_ability_txt.Text = results[2][0].ToString();

            }
        }
        private bool ValidateFields()
        {
            //flag for validation and message string
            bool validFlag = true;
            string validMessage = "";

            //NAME: Check to see if NAME is entered

            if (race_name_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a name!";
                validFlag = false;
            }
            //NAME: Check to see if NAME is entered

            if (race_ability_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a name!";
                validFlag = false;
            }
            return validFlag;
        }

        private void insert_race_button_Click(object sender, EventArgs e)
        {
            //set the class open flag to false of the main form 
            firstformRef.raceFormIsOpen = false;
            //call the reselectresults method on main form
            firstformRef.SelectraceResults();
        }
        private void race_form_FormClosing(object sender, FormClosingEventArgs e)
{
    //set the class open flag to false of the main form 
    firstformRef.classFormIsOpen = false;
    //call the reselectresults method on main form
    firstformRef.SelectraceResults();
    }
}
    }

