using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG_Database
{
    //DATABASE CONNECTION CHECK
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string username;
        private string password;

        //connecting to database
        private bool OpenConnection()
        {
            //exception handelling
            try
            {
                //if it connects, run true
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Uh oh!" + ex);
                return false;
            }
        }

        //close the connection
        private bool CloseConnection()
        {
            //exception handelling
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Close fail" + ex);
                return false;
            }
        }

        //test connection
        public void TestConnnection()
        {
            //use the open connection method
            if (this.OpenConnection())
            {
                //if successful, state so in dialogue
                MessageBox.Show("connection successful");
            }
            //use the close connection method
            this.CloseConnection();
        }

        //Constructor
        public DBConnection()
        {
            Initialize();

        }

        //INITIALIZE CONNECTION 

        private void Initialize()
        {
            server = "fdsc-intmeddev.blackpool.ac.uk";
            username = "30153698_DCAP";
            password = "8PYVJ";
            port = "3306";
            database = "30153698_DCAP";

            //string to connect to database
            string connectionString = "SERVER =" + server + ";"
                + "PORT =" + port + ";"
                + "DATABASE =" + database + ";"
                + "UID =" + username + ";"
                + "PASSWORD =" + password + ";";

            //store the connection, supplying connection string
            connection = new MySqlConnection(connectionString);
        }

        //*******CLASS CODE



        //select all records from class
        public List<string>[] SelectClass()
        {
            //list all objects for columns
            List<string>[] results = new List<string>[7];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();
            results[5] = new List<string>();
            results[6] = new List<string>();

            //query (selects all columns and rows from CLASS)
            string query = "SELECT * FROM `CLASS`";

            //open connection
            if (this.OpenConnection())
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reader' to get results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    //in the square brackets the string must match the column/name on database
                    results[0].Add(dataReader["class_id"] + "");
                    results[1].Add(dataReader["class_name"] + "");
                    results[2].Add(dataReader["class_health"] + "");
                    results[3].Add(dataReader["class_mana"] + "");
                    results[4].Add(dataReader["class_attack"] + "");
                    results[5].Add(dataReader["class_defence"] + "");
                    results[6].Add(dataReader["class_ability"] + "");
                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();

            }
            //return the results list
            return results;
        }

        //delete class
        public void DeleteClass(string id)
        {
            //use ID to delete specific records
            string query = "DELETE FROM `CLASS` " +
                "WHERE `class_id` = " +
                id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert class

        public void InsertClass(string class_name, string class_health, string class_mana, string class_attack, string class_defence, string class_ability)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `CLASS`" +
                "(`class_name`,`class_health`,`class_mana`,`class_attack`,`class_defence`,`class_ability`)"
                + "VALUES" +
                "('" + class_name + "', " + class_health + "," + class_mana + "," + class_attack + "," + class_defence + ",'" + class_ability + "')";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }//select single class row
        public List<string>[] SelectClassRow(string id)
        {
            //list object(for columns)
            List<string>[] results = new List<string>[7];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();
            results[5] = new List<string>();
            results[6] = new List<string>();

            //SELECT query for single row based on ID
            string query = "SELECT * FROM `CLASS` WHERE `class_id`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["class_id"] + "");
                    results[1].Add(dataReader["class_name"] + "");
                    results[2].Add(dataReader["class_health"] + "");
                    results[3].Add(dataReader["class_mana"] + "");
                    results[4].Add(dataReader["class_attack"] + "");
                    results[5].Add(dataReader["class_defence"] + "");
                    results[6].Add(dataReader["class_ability"] + "");
                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }

        //update class
        public void UpdateClass(string class_id, string class_name, string class_health, string class_mana, string class_attack, string class_defence, string class_ability)
        {
            //UPDATE query with SET column = value syntax, WHERE 'id' = id
            string query = "UPDATE `CLASS`" +
                " SET `class_name` = '" + class_name + "'," +
                "`class_health` = " + class_health + "," +
                "`class_mana` = " + class_mana + "," +
                "`class_attack` = " + class_attack + "," +
                "`class_defence` = " + class_defence + "," +
                "`class_ability` = '" + class_ability +
                "' WHERE `class_id` = " + class_id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();

            }

            //close connection
            this.CloseConnection();

        }
        //**********REGION CODE
        public List<string>[] SelectRegion()
        {
            //list objeccts (for column) 
            List<string>[] results = new List<string>[2];
            results[0] = new List<string>();
            results[1] = new List<string>();

            //query
            string query = "SELECT * FROM `REGION`";

            //open connection
            if (this.OpenConnection())
            {
                //create a MySQL command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop through each row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["region_id"] + "");
                    results[1].Add(dataReader["region_name"] + "");
                }

                //close data reader
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }
        //delete region
        public void DeleteRegion(string id)
        {
            string query = "DELETE FROM `REGION` " +
                "WHERE `region_id` = " +
                id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //run command 
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert region
        public void InsertRegion(string region_name)
        {
            //single quotes arouynd variable value in string
            string query = "INSERT INTO `REGION` " +
                "(`region_name`)" +
                "VALUES " +
                "('" + region_name + "')";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }
        //select single region row
        public List<string>[] SelectRegionRow(string id)
        {
            //list object for columns
            List<string>[] results = new List<string>[2];
            results[0] = new List<string>();
            results[1] = new List<string>();

            //query
            string query = "SELECT * FROM `REGION` WHERE `region_id` = " + id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["region_id"] + "");
                    results[1].Add(dataReader["region_name"] + "");
                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }
        //update region
        public void UpdateRegion(string region_id, string region_name)
        {
            string query = "UPDATE `REGION` " +
                "SET `region_name` = '" + region_name + "'" +
                " WHERE `region_id` = " + region_id;

            //open connection
            if (this.OpenConnection())
            {
                //create sql command 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command 
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //***********CHARACTER CODE
        public List<string>[] SelectCharacter()
        {
            //list objeccts (for column) 
            List<string>[] results = new List<string>[3];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();

            //query
            string query = "SELECT * FROM `CHARACTER`";

            //open connection
            if (this.OpenConnection())
            {
                //create a MySQL command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop through each row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["character_id"] + "");
                    results[1].Add(dataReader["character_level"] + "");
                    results[2].Add(dataReader["character_play_time"] + "");
                }

                //close data reader
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }
        //delete character
        public void DeleteCharacter(string id)
        {
            string query = "DELETE FROM `CHARACTER` " +
                "WHERE `character_id` = " +
                id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //run command 
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert Character
        public void InsertCharacter(string character_level, string character_play_time)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `CHARACTER`" +
                "(`character_level`,`character_play_time`)"
                + "VALUES" +
                "(" + character_level + ", " + character_play_time + ")";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }
        //select single character row
        public List<string>[] SelectCharacterRow(string id)
        {
            //list object for columns
            List<string>[] results = new List<string>[3];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();

            //query
            string query = "SELECT * FROM `CHARACTER` WHERE `character_id` = " + id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["character_id"] + "");
                    results[1].Add(dataReader["character_level"] + "");
                    results[2].Add(dataReader["character_play_time"] + "");
                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }
        //update character
        public void UpdateCharacter(string character_id, string character_level, string character_play_time)
        {
            string query = "UPDATE `CHARACTER`" + 
                " SET `character_level` = " + character_level + "," +
                "`character_play_time` = " + character_play_time +
                " WHERE `character_id` = " + character_id;

            //open connection
            if (this.OpenConnection())
            {
                //create sql command 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command 
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //****************CUSTOMER
        public List<string>[] SelectCustomer()
        {
            //list objeccts (for column) 
            List<string>[] results = new List<string>[8];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();
            results[5] = new List<string>();
            results[6] = new List<string>();
            results[7] = new List<string>();

            //query
            string query = "SELECT * FROM `CUSTOMER`";

            //open connection
            if (this.OpenConnection())
            {
                //create a MySQL command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop through each row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["customer_id"] + "");
                    results[1].Add(dataReader["customer_fname"] + "");
                    results[2].Add(dataReader["customer_sname"] + "");
                    results[3].Add(dataReader["customer_account_creation_date"] + "");
                    results[4].Add(dataReader["customer_region"] + "");
                    results[5].Add(dataReader["customer_date_of_birth"] + "");
                    results[6].Add(dataReader["customer_password"] + "");
                    results[7].Add(dataReader["customer_billing_address"] + "");
                }

                //close data reader
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }
        //delete character
        public void DeleteCustomer(string id)
        {
            string query = "DELETE FROM `CUSTOMER` " +
                "WHERE `customer_id` = " +
                id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //run command 
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert Customer
        public void InsertCustomer(string customer_fname, string customer_sname, string customer_account_creation_date, string customer_region, string customer_date_of_birth, string customer_password, string customer_billing_address)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `CUSTOMER`" +
                "(`customer_fname`,`customer_sname`,`customer_account_creation_date`,`customer_region`,`customer_date_of_birth`,`customer_password`,`customer_billing_address`)"
                + "VALUES" +
                "('" + customer_fname + "', '" + customer_sname + "', " + customer_account_creation_date + ", " + customer_region + "," + customer_date_of_birth + ", '" + customer_password + "','" + customer_billing_address + " ')";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }
        //select single customer row
        public List<string>[] SelectCustomerRow(string id)
        {
            //list object for columns
            List<string>[] results = new List<string>[8];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();
            results[5] = new List<string>();
            results[6] = new List<string>();
            results[7] = new List<string>();

            //query
            string query = "SELECT * FROM `CUSTOMER` WHERE `customer_id` = " + id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["customer_id"] + "");
                    results[1].Add(dataReader["customer_fname"] + "");
                    results[2].Add(dataReader["customer_sname"] + "");
                    results[3].Add(dataReader["customer_account_creation_date"] + "");
                    results[4].Add(dataReader["customer_region"] + "");
                    results[5].Add(dataReader["customer_date_of_birth"] + "");
                    results[6].Add(dataReader["customer_password"] + "");
                    results[7].Add(dataReader["customer_billing_address"] + "");
                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }
        //update customer
        public void UpdateCustomer(string customer_id, string customer_fname, string customer_sname, string customer_account_creation_date, string customer_region, string customer_date_of_birth, string customer_password, string customer_billing_address)
        {
            string query = "UPDATE `CUSTOMER`" +
                " SET `customer_fname` = `" + customer_fname + "`," +
                "`customer_sname` = `" + customer_sname + "`," +
                "`customer_account_creation_date` = " + customer_account_creation_date + "," +
                "`customer_region` = " + customer_region + "," +
                "`customer_date_of_birth` = " + customer_date_of_birth + "," +

                "`customer_password` = `" + customer_password + "`," +
                "`customer_billing_address` = `" + customer_billing_address + 
                 " WHERE `customer_id` = " + customer_id;


            //open connection
            if (this.OpenConnection())
            {
                //create sql command 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command 
                 cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }
        //*******FACTION CODE



        //select all records from faction
        public List<string>[] SelectFaction()
        {
            //list all objects for columns
            List<string>[] results = new List<string>[5];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();


            //query (selects all columns and rows from faction
            string query = "SELECT * FROM `FACTION`";

            //open connection
            if (this.OpenConnection())
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reader' to get results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    //in the square brackets the string must match the column/name on database
                    results[0].Add(dataReader["faction_id"] + "");
                    results[1].Add(dataReader["faction_name"] + "");
                    results[2].Add(dataReader["faction_level"] + "");
                    results[3].Add(dataReader["faction_rank"] + "");
                    results[4].Add(dataReader["faction_perk"] + "");

                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();

            }
            //return the results list
            return results;
        }

        //delete class
        public void DeleteFaction(string id)
        {
            //use ID to delete specific records
            string query = "DELETE FROM `FACTION` " +
                "WHERE `faction_id` = " +
                id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert faction

        public void InsertFaction(string faction_name, string faction_level, string faction_rank, string faction_perk)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `FACTION`" +
                "(`faction_name`,`faction_level`,`faction_rank`,`faction_perk`)"
                + "VALUES" +
                "('" + faction_name + "', " + faction_level + "," + faction_rank + ",'" + faction_perk + "')";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }//select single class row
        public List<string>[] SelectFactionRow(string id)
        {
            //list object(for columns)
            List<string>[] results = new List<string>[5];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();

            //SELECT query for single row based on ID
            string query = "SELECT * FROM `FACTION` WHERE `faction_id`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["faction_id"] + "");
                    results[1].Add(dataReader["faction_name"] + "");
                    results[2].Add(dataReader["faction_level"] + "");
                    results[3].Add(dataReader["faction_rank"] + "");
                    results[4].Add(dataReader["faction_perk"] + "");

                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }

        //update class
        public void UpdateFaction(string faction_id, string faction_name, string faction_level, string faction_rank, string faction_perk)
        {
            //UPDATE query with SET column = value syntax, WHERE 'id' = id
            string query = "UPDATE `FACTION`" +
                "SET `faction_name` = '" + faction_name + "'," +
                "`faction_level` = " + faction_level + "," +
                "`faction_rank` = " + faction_rank + "," +
                "`faction_perk` = '" + faction_perk + "'," +
                "WHERE `faction_id` = " + faction_id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();

            }

            //close connection
            this.CloseConnection();

        }

        //**************ITEM
        //select all records from faction
        public List<string>[] SelectItem()
        {
            //list all objects for columns
            List<string>[] results = new List<string>[6];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();
            results[5] = new List<string>();


            //query (selects all columns and rows from faction
            string query = "SELECT * FROM `ITEM`";

            //open connection
            if (this.OpenConnection())
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reader' to get results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    //in the square brackets the string must match the column/name on database
                    results[0].Add(dataReader["item_id"] + "");
                    results[1].Add(dataReader["item_name"] + "");
                    results[2].Add(dataReader["item_description"] + "");
                    results[3].Add(dataReader["item_type"] + "");
                    results[4].Add(dataReader["item_weight"] + "");
                    results[5].Add(dataReader["item_cost"] + "");

                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();

            }
            //return the results list
            return results;
        }

        //delete item
        public void DeleteItem(string id)
        {
            //use ID to delete specific records
            string query = "DELETE FROM `ITEM` " +
                "WHERE `item_id` = " +
                id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert item

        public void InsertItem(string item_name, string item_description, string item_type, string item_weight, string item_cost)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `ITEM`" +
                "(`item_name`,`item_description`,`item_type`,`item_weight`, `item_cost`)"
                + "VALUES" +
                "('" + item_name + "', '" + item_description + "','" + item_type + "'," + item_weight + "," + item_cost + ")";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }//select single class row
        public List<string>[] SelectItemRow(string id)
        {
            //list object(for columns)
            List<string>[] results = new List<string>[6];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();
            results[5] = new List<string>();

            //SELECT query for single row based on ID
            string query = "SELECT * FROM `ITEM` WHERE `item_id`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["item_id"] + "");
                    results[1].Add(dataReader["item_name"] + "");
                    results[2].Add(dataReader["item_description"] + "");
                    results[3].Add(dataReader["item_type"] + "");
                    results[4].Add(dataReader["item_weight"] + "");
                    results[5].Add(dataReader["item_cost"] + "");

                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }

        //update citem
        public void UpdateItem(string item_id, string item_name, string item_description, string item_type, string item_weight, string item_cost)
        {
            //UPDATE query with SET column = value syntax, WHERE 'id' = id
            string query = "UPDATE `ITEM`" +
                " SET  `item_name` = '" + item_name + "'," +
                "`item_description` = '" + item_description + "'," +
                "`item_type` = '" + item_type + "'," +
                "`item_weight` = " + item_weight + "," +
                "`item_cost` = " + item_cost +
                " WHERE  `item_id` = " + item_id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();

            }

            //close connection
            this.CloseConnection();

        }

        //**************RACE




        //select all records from race
        public List<string>[] SelectRace()
        {
            //list all objects for columns
            List<string>[] results = new List<string>[3];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();


            //query (selects all columns and rows from RACE)
            string query = "SELECT * FROM `RACE`";

            //open connection
            if (this.OpenConnection())
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reader' to get results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    //in the square brackets the string must match the column/name on database
                    results[0].Add(dataReader["race_id"] + "");
                    results[1].Add(dataReader["race_name"] + "");
                    results[2].Add(dataReader["race_ability"] + "");

                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();

            }
            //return the results list
            return results;
        }

        //delete race
        public void DeleteRace(string id)
        {
            //use ID to delete specific records
            string query = "DELETE FROM `race` " +
                "WHERE `race_id` = " +
                id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert race

        public void InsertRace(string race_name, string race_ability)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `RACE`" +
                "(`race_name`,`race_ability`)"
                + "VALUES" +
                "('" + race_name + "', '" + race_ability + "')";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }//select single class row
        public List<string>[] SelectraceRow(string id)
        {
            //list object(for columns)
            List<string>[] results = new List<string>[3];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();


            //SELECT query for single row based on ID
            string query = "SELECT * FROM `RACE` WHERE `race_id`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["race_id"] + "");
                    results[1].Add(dataReader["race_name"] + "");
                    results[2].Add(dataReader["race_ability"] + "");

                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }

        //update class
        public void Updaterace(string race_id, string race_name, string race_ability)
        {
            //UPDATE query with SET column = value syntax, WHERE 'id' = id
            string query = "UPDATE `RACE`" +
                "SET `race_name` = '" + race_name + "'," +
                "`race_ability` = " + race_ability +
                "WHERE `race_id` = " + race_id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();

            }

            //close connection
            this.CloseConnection();

        }
        //*******SERVER CODE



        //select all records from server
        public List<string>[] SelectServer()
        {
            //list all objects for columns
            List<string>[] results = new List<string>[4];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();


            //query (selects all columns and rows from SERVER)
            string query = "SELECT * FROM `SERVER`";

            //open connection
            if (this.OpenConnection())
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reader' to get results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    //in the square brackets the string must match the column/name on database
                    results[0].Add(dataReader["server_id"] + "");
                    results[1].Add(dataReader["region_id"] + "");
                    results[2].Add(dataReader["server_name"] + "");
                    results[3].Add(dataReader["server_capacity"] + "");

                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();

            }
            //return the results list
            return results;
        }

        //delete server
        public void DeleteServer(string id)
        {
            //use ID to delete specific records
            string query = "DELETE FROM `SERVER` " +
                "WHERE `server_id` = " +
                id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert server

        public void InsertServer(string region_id, string server_name, string server_capacity)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `SERVER` " +
                "(`region_id`,`server_name`,`server_capacity`) "
                + "VALUES " +
                "(" + region_id + ", '" + server_name + "', " + server_capacity + ")";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }//select single class row
        public List<string>[] SelectServerRow(string id)
        {
            //list object(for columns)
            List<string>[] results = new List<string>[4];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();


            //SELECT query for single row based on ID
            string query = "SELECT * FROM `SERVER` WHERE `server_id`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["server_id"] + "");
                    results[1].Add(dataReader["region_id"] + "");
                    results[2].Add(dataReader["server_name"] + "");
                    results[3].Add(dataReader["server_capacity"] + "");

                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }

        //update Server
        public void UpdateServer(string server_id, string region_id, string server_name, string server_capacity)
        {
            //UPDATE query with SET column = value syntax, WHERE 'id' = id
            string query = "UPDATE `SERVER`" +
                "SET `region_id` = " + region_id + "," +
                "`server_name` = '" + server_name + "'," +
                "`server_capacity` = " + server_capacity;


            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();

            }

            //close connection
            this.CloseConnection();

        }

        //*******SUBSCRIPTION CODE



        //select all records from subscription
        public List<string>[] SelectSubscription()
        {
            //list all objects for columns
            List<string>[] results = new List<string>[5];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();


            //query (selects all columns and rows from SUBSCRIPTION)
            string query = "SELECT * FROM `SUBSCRIPTION`";

            //open connection
            if (this.OpenConnection())
            {
                // create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a 'data reader' to get results
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    //in the square brackets the string must match the column/name on database
                    results[0].Add(dataReader["subscription_id"] + "");
                    results[1].Add(dataReader["customer_id"] + "");
                    results[2].Add(dataReader["subscription_start_date"] + "");
                    results[3].Add(dataReader["subscription_end_date"] + "");
                    results[4].Add(dataReader["subscription_status"] + "");

                }

                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();

            }
            //return the results list
            return results;
        }

        //delete subscription
        public void DeleteSubscription(string id)
        {
            //use ID to delete specific records
            string query = "DELETE FROM `SUBSCRIPTION` " +
                "WHERE `subscription_id` = " +
                id;

            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }
            //close connection
            this.CloseConnection();
        }

        //insert subscription

        public void InsertSubscription (string customer_id, string subscription_start_date, string subscription_end_date, string subscription_status)
        {
            //INSERT QUERY adding values (no single quotes around number values
            string query = "INSERT INTO `SUBSCRIPTION` " +
                "(`customer_id`,`subscription_start_date`,`subscription_end_date`,`subscription_status`) "
                + "VALUES " +
                "(" + customer_id + ", " + subscription_start_date + ", " + subscription_end_date + "," + subscription_status + ")";

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();
            }

            //close connection
            this.CloseConnection();
        }//select single subscription row
        public List<string>[] SelectSubscriptionRow(string id)
        {
            //list object(for columns)
            List<string>[] results = new List<string>[4];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();
            results[3] = new List<string>();
            results[4] = new List<string>();


            //SELECT query for single row based on ID
            string query = "SELECT * FROM `SUBSCRIPTION` WHERE `subscription_id`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create a data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loops through each row of the results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["subscription_id"] + "");
                    results[1].Add(dataReader["customer_id"] + "");
                    results[2].Add(dataReader["subscription_start_date"] + "");
                    results[3].Add(dataReader["subscription_end_date"] + "");
                     results[4].Add(dataReader["subscription_end_date"] + "");

                }
                //close data reader and connection
                dataReader.Close();
                this.CloseConnection();
            }
            return results;
        }

        //update subscription
        public void UpdateSubscription(string subscription_id, string customer_id, string subscription_start_date, string subscription_end_date, string subscription_status)
        {
            //UPDATE query with SET column = value syntax, WHERE 'id' = id
            string query = "UPDATE `SUBSCRIPTION`" +
                "SET `customer_id` = " + customer_id + "," +
                "`subscription_start_date` = " + subscription_start_date + "," +
                "`subscription_end_date` = " + subscription_end_date + "," +
                "`subscription_status` = " + subscription_status;


            //open connection 
            if (this.OpenConnection())
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //run command
                cmd.ExecuteNonQuery();

            }

            //close connection
            this.CloseConnection();
        }


//********SELECT SERVER BY REGION QUERY
        public List<string>[] SelectServerByRegion(string id)
        {
            //list object for columns)
            List<string>[] results = new List<string>[3];
            results[0] = new List<string>();
            results[1] = new List<string>();
            results[2] = new List<string>();

            //query using inner join to match ids
            string query = "SELECT * FROM `SERVER` INNER JOIN `REGION`"
                + "ON `REGION`.`region_id` = `SERVER`.`region_id`"
                + "WHERE `REGION`.`region_id`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop through row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["region_name"] + "");
                    results[1].Add(dataReader["server_name"] + "");
                    results[2].Add(dataReader["server_capacity"] + "");
                }
                    //close data reader
                    dataReader.Close();
                    this.CloseConnection();
                }
                
                return results;
            
        }
//********SELECT CUSTOMER BY SUBSCRIPTION QUERY
        public List<string>[] SelectCustomerBySubscription(string id)
        {
            //list object for columns)
            List<string>[] results = new List<string>[2];
            results[0] = new List<string>();
            results[1] = new List<string>();
         

            //query using inner join to match ids
            string query = "SELECT * FROM `CUSTOMER` INNER JOIN `SUBSCRIPTION`"
                + "ON `CUSTOMER`.`customer_id` = `SUBSCRIPTION`.`subscription_status`"
                + "WHERE `SUBSCRIPTION`.`subscription_status`=" + id;

            //open connection
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //create data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //loop through row of results
                while (dataReader.Read())
                {
                    results[0].Add(dataReader["customer_id"] + "");
                    results[1].Add(dataReader["subscription_status"] + "");
                   
                }
                //close data reader
                dataReader.Close();
                this.CloseConnection();
            }

            return results;

        }
    }
}
