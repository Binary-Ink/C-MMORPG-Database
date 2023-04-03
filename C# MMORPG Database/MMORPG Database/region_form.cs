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
    public partial class region_form : Form
    {
        Form1 firstformRef; //reference to main form
        bool insertFlag = false; //are we in insert mode? 
        string updateId = ""; //record update is required

        //db connection
        DBConnection mySqlSrc = new DBConnection();

        //constructor with reference to main form, insert flag and update id
        public region_form(ref Form1 form1Handle, bool isInsert, string upId)
        {
            updateId = upId;
            insertFlag = isInsert;
            firstformRef = form1Handle;
            InitializeComponent();

            //if not insert mode, update mode
            if (!insertFlag)
            {
                //create new results list 
                List<string>[] results = new List<string>[2];

                //send id to get results
                results = mySqlSrc.SelectRegionRow(updateId);

                //update text box 
                region_name_txt.Text = results[1][0].ToString();
            }
        }
   private bool ValidateFields()
    {
        //valid flag and message
        bool validFlag = true;
        string validMsg = "";

        //check name entry
        if (region_name_txt.Text.ToString() == "")
        {
            //if not, update message and flag
            validMsg += "Enter a name";
            validFlag = false;
        }

        //if invalid, show message
        if (!validFlag)
            MessageBox.Show(validMsg);

        //return result 
        return validFlag;
        }

        private void insert_region_button_Click(object sender, EventArgs e)
        {
            //check if insert or update mode, send relevant data to relevant methods to run queries following validation, validation checks
            if (insertFlag)
            {
                if (ValidateFields())
                {
                    mySqlSrc.InsertRegion(region_name_txt.Text.ToString());
                    this.Close(); 
                }
            }
            else
            {
                if (ValidateFields())
                {
                    mySqlSrc.UpdateRegion(updateId, region_name_txt.Text.ToString());
                    this.Close();
                }
            }
        }

        //form closing event
        private void region_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            firstformRef.regionFormIsOpen = false;
            firstformRef.SelectRegionResults(); 
        }
    }

   }



