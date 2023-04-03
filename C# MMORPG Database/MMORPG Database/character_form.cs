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
    public partial class character_form : Form
    {
        Form1 firstformRef; //reference to main form
        bool insertFlag = false; //is insert? (update)
        //db object
        DBConnection mySqlSrc = new DBConnection();
        string updateId = ""; //id for record to update

        //constructor (modified to get reference from main form and insert flag)
        public character_form(ref Form1 form1Handle, bool isInsert, string upId)
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
                List<string>[] results = new List<string>[3];
                //get record for the matching id
                results = mySqlSrc.SelectCharacterRow(updateId);

                //fill the boxes with the corresponding values
                character_level_txt.Text = results[1][0].ToString();
                character_play_time_txt.Text = results[2][0].ToString();

            }
        }

        private bool ValidateFields()
        {
            //flag for validation and message string
            bool validFlag = true;
            string validMessage = "";

            //LEVEL: Check to see if NAME is entered

            if (character_level_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter level!";
                validFlag = false;
            }
            else
            {
                //integer container for level
                int Level;
                //attempt to parse the text as int
                if (int.TryParse(character_level_txt.Text, out Level))
                {
                    if (Level < 0 || Level > 99)
                    {
                        validMessage += "\n\n Level must be between 0 and 99!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Level must be a valid number!";
                    validFlag = false;
                }
            }

          



            //PLAY TIME: Check to see if play time is entered
            if (character_play_time_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter play time!";
                validFlag = false;
            }
            else
            {
                //integer container for play time
                int PlayTime;
                //attempt to parse the text as int
                if (int.TryParse(character_play_time_txt.Text, out PlayTime))
                {
                    if (PlayTime < 0 || PlayTime > 100)
                    {
                        validMessage += "\n\n play time must be between 0 and 100!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n play time must be a valid number!";
                    validFlag = false;
                }
            }
            //if invalid, show message
            if (!validFlag)
                MessageBox.Show(validMessage);

            //return result 
            return validFlag;
        }



    private void insert_character_button_Click(object sender, EventArgs e)
        {
            //check in insert mode
            if (insertFlag)
            {
                //check fields are valid
                if (ValidateFields())
                {
                    //send the values from text boxes to insert class using DBconnection instance
                    mySqlSrc.InsertCharacter(character_level_txt.Text.ToString(),
                        character_play_time_txt.Text.ToString());

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
                    //call updatecharacter method
                    mySqlSrc.UpdateCharacter(updateId,
                        character_level_txt.Text.ToString(),
                        character_play_time_txt.Text.ToString());

                    //close this form
                    this.Close();
                }
            }
        }

        //form closing event handeler
        private void character_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //set the class open flag to false of the main form 
            firstformRef.characterFormIsOpen = false;
            //call the reselectresults method on main form
            firstformRef.SelectCharacterResults();
        }

    }



}