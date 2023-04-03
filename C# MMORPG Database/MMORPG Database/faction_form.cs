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
    public partial class faction_form : Form
    {
        Form1 firstformRef; //reference to main form
        bool insertFlag = false; //is insert? (update)
        //db object
        DBConnection mySqlSrc = new DBConnection();
        string updateId = ""; //id for record to update

        //constructor (modified to get reference from main form and insert flag)
        public faction_form(ref Form1 form1Handle, bool isInsert, string upId)
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
                List<string>[] results = new List<string>[4];
                //get record for the matching id
                results = mySqlSrc.SelectClassRow(updateId);

                //fill the boxes with the corresponding values
                faction_name_txt.Text = results[0][0].ToString();
                faction_level_txt.Text = results[1][0].ToString();
                faction_rank_txt.Text = results[2][0].ToString();
                faction_perk_txt.Text = results[3][0].ToString();

            }
        }

        private bool ValidateFields()
        {
            //flag for validation and message string
            bool validFlag = true;
            string validMessage = "";

            //NAME: Check to see if NAME is entered

            if (faction_name_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a name!";
                validFlag = false;
            }

            //LEVEL

            if (faction_level_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a faction level!";
                validFlag = false;
            }
            else
            {
                //integer container for hlevel
                int FactionLevel;
                //attempt to parse the text as int
                if (int.TryParse(faction_level_txt.Text, out FactionLevel))
                {
                    if (FactionLevel < 0 || FactionLevel > 99)
                    {
                        validMessage += "\n\n Faction Level must be between 0 and 99!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Faction Level must be a valid number!";
                    validFlag = false;
                }
            }
            //RANK

            if (faction_level_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a faction rank!";
                validFlag = false;
            }
            else
            {
                //integer container for health bonus
                int FactionRank;
                //attempt to parse the text as int
                if (int.TryParse(faction_rank_txt.Text, out FactionRank))
                {
                    if (FactionRank < 0 || FactionRank > 99)
                    {
                        validMessage += "\n\n Faction Level must be between 0 and 99!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Faction Level must be a valid number!";
                    validFlag = false;
                }
            }


            //PERK

            if (faction_perk_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a perk!";
                validFlag = false;
            }
            //if not valid then display message
            if (!validFlag)
            {
                MessageBox.Show(validMessage);
                //return whether valid or not

            }
            return validFlag;
        }


        private void insert_faction_button_Click(object sender, EventArgs e)
        {
            //check in insert mode
            if (insertFlag)
            {
                //check fields are valid
                if (ValidateFields())
                {
                    //send the values from text boxes to insert class using DBconnection instance
                    mySqlSrc.InsertFaction(
                        faction_name_txt.Text.ToString(),
                        faction_level_txt.Text.ToString(),
                        faction_rank_txt.Text.ToString(),
                        faction_perk_txt.Text.ToString());

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
                    //call updateclass method
                    mySqlSrc.UpdateFaction(updateId,
                      faction_name_txt.Text.ToString(),
                        faction_level_txt.Text.ToString(),
                        faction_rank_txt.Text.ToString(),
                        faction_perk_txt.Text.ToString());

                    //close this form
                    this.Close();
                }
            }
        }

        //form closing event handeler
        private void faction_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //set the class open flag to false of the main form 
            firstformRef.factionFormIsOpen = false;
            //call the reselectresults method on main form
            firstformRef.SelectFactionResults();
        }
    }



}