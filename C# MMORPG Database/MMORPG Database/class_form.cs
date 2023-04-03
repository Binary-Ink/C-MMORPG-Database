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
    public partial class class_form : Form
    {
        Form1 firstformRef; //reference to main form
        bool insertFlag = false; //is insert? (update)
        //db object
        DBConnection mySqlSrc = new DBConnection();
        string updateId = ""; //id for record to update

        //constructor (modified to get reference from main form and insert flag)
        public class_form(ref Form1 form1Handle, bool isInsert, string upId)
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
                results = mySqlSrc.SelectClassRow(updateId);

                //fill the boxes with the corresponding values
                class_name_txt.Text = results[1][0].ToString();
                class_health_txt.Text = results[2][0].ToString();
                class_mana_txt.Text = results[3][0].ToString();
                class_attack_txt.Text = results[4][0].ToString();
                class_defence_txt.Text = results[5][0].ToString();
                class_ability_txt.Text = results[6][0].ToString();
            }
        }

        private bool ValidateFields()
        {
            //flag for validation and message string
            bool validFlag = true;
            string validMessage = "";

            //NAME: Check to see if NAME is entered

            if (class_name_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter a name!";
                validFlag = false;
            }

            //HEALTH: Check to see if HEALTH is entered

            if (class_health_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter health!";
                validFlag = false;
            }
            else
            {
                //integer container for health bonus
                int HealthBonus;
                //attempt to parse the text as int
                if (int.TryParse(class_health_txt.Text, out HealthBonus))
                {
                    if (HealthBonus < 0 || HealthBonus > 10)
                    {
                        validMessage += "\n\n Health bonus must be between 0 and 10!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Health Bonus must be a valid number!";
                    validFlag = false;
                }
            }

            //MANA: Check to see if mana is entered
            if (class_mana_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter mana!";
                validFlag = false;
            }
            else
            {
                //integer container for mana bonus
                int ManaBonus;
                //attempt to parse the text as int
                if (int.TryParse(class_mana_txt.Text, out ManaBonus))
                {
                    if (ManaBonus < 0 || ManaBonus > 10)
                    {
                        validMessage += "\n\n Mana bonus must be between 0 and 10!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Mana Bonus must be a valid number!";
                    validFlag = false;
                }
            }

            //ATTACK: Check to see if Attack is entered
            if (class_attack_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter attack!";
                validFlag = false;
            }
            else
            {
                //integer container for attack bonus
                int AttackBonus;
                //attempt to parse the text as int
                if (int.TryParse(class_attack_txt.Text, out AttackBonus))
                {
                    if (AttackBonus < 0 || AttackBonus > 10)
                    {
                        validMessage += "\n\n Attack bonus must be between 0 and 10!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Attack Bonus must be a valid number!";
                    validFlag = false;
                }
            }

            //DEFENCE: Check to see if defence is entered
            if (class_defence_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter defence!";
                validFlag = false;
            }
            else
            {
                //integer container for defence bonus
                int DefenceBonus;
                //attempt to parse the text as int
                if (int.TryParse(class_defence_txt.Text, out DefenceBonus))
                {
                    if (DefenceBonus < 0 || DefenceBonus > 10)
                    {
                        validMessage += "\n\n Defence bonus must be between 0 and 10!";
                        validFlag = false;
                    }
                }
                else
                {
                    validMessage += "\n\n Defence Bonus must be a valid number!";
                    validFlag = false;
                }
            }

            //ABILITY: Check to see if ABILITY is entered

            if (class_ability_txt.Text.ToString() == "")
            {
                //add to message and set unvalid flag
                validMessage += "\n\n You need to enter an ability!";
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

        private void insert_class_button_Click(object sender, EventArgs e)
        {
            //check in insert mode
            if (insertFlag)
            {
                //check fields are valid
                if (ValidateFields())
                {
                    //send the values from text boxes to insert class using DBconnection instance
                    mySqlSrc.InsertClass(class_name_txt.Text.ToString(),
                        class_health_txt.Text.ToString(),
                        class_mana_txt.Text.ToString(),
                        class_attack_txt.Text.ToString(),
                        class_defence_txt.Text.ToString(),
                        class_ability_txt.Text.ToString());

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
                    mySqlSrc.UpdateClass(updateId,
                        class_name_txt.Text.ToString(),
                        class_health_txt.Text.ToString(),
                        class_mana_txt.Text.ToString(),
                        class_attack_txt.Text.ToString(),
                        class_defence_txt.Text.ToString(),
                        class_ability_txt.Text.ToString());

                    //close this form
                    this.Close();
                }
            }
        }  
        
        //form closing event handeler
        private void class_form_FormClosing(object sender, FormClosingEventArgs e)
{
    //set the class open flag to false of the main form 
    firstformRef.classFormIsOpen = false;
    //call the reselectresults method on main form
    firstformRef.ReselectResults();
    }
}



}