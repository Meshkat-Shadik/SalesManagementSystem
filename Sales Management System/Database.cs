using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sales_Management_System
{
    class Database
    {
        MySqlConnection MyConn2 = new MySqlConnection("datasource=localhost;username=root;database=sales_management;password=");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        public DataSet ds = new DataSet();
        public String Login(String username, String password, String table)
        {
            try
            {
                ds = new DataSet();
                adapter = new MySqlDataAdapter("select * from `"+table+"` where username ='" + username + "' and password ='" + password + "';", MyConn2);
                adapter.Fill(ds, table);
                
                if (ds.Tables[table].Rows.Count > 0)
                {
                    string name = "";
                    // return ds.Tables[table].Rows[0].;
                    foreach (DataRow dr in ds.Tables[table].Rows)
                    {
                        name = dr["id"].ToString();
                    }
                    MyConn2.Close();
                    return name;
                }
                else
                {
                    return null;
                }
           
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool insertIntoTable(String tableName, String username, String password)
        {
            try
            {

                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "INSERT INTO `"+ tableName + "`(`username`, `password`) VALUES('" + username+ "','" + password + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool insertIntoProposal(String userid, String product_name, String budget, String amount, String duration, String contact_name, String contact_number, String description, String rejected_reason, String status)
        {
            try
            {

                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "INSERT INTO `proposal_management`(`user_id`, `product_name`, `budget`, `amount`, `duration`, `contact_name`, `contact_number`, `description`, `rejected_reason`, `status`) VALUES('" + userid + "','" + product_name + "','" + budget + "','" + amount + "','" + duration + "','" + contact_name + "','" + contact_number + "','" + description + "','" + rejected_reason + "','" + status + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool makeAnouncement(String tableName, String message, String date, String id)
        {
            try
            {

                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "INSERT INTO `" + tableName + "`(`manager_id`, `message`, `date`) VALUES('" + id + "','" + message + "','" + date + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable showData(String tableName)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "SELECT * FROM `"+tableName+"`;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();
                return dTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable showProject(String id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "SELECT * FROM `project` where user_id="+id;
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();
                return dTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public String showAnnouncement()
        {
            try
            {

                String announcement = "";

                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "SELECT * FROM `anouncement` WHERE 1 order by date desc limit 1;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                var dr = MyCommand2.ExecuteReader();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                if (dr.HasRows)
                {
                    dr.Read();// Get first record.
                    announcement = dr.GetString(2);// Get value of first column as string.
                }
                dr.Close();
                MyConn2.Close();

                return announcement;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public DataTable managerAndAnnouncement()
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "SELECT * FROM `anouncement` order by date desc";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();
                return dTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public DataTable showOpportunityTable(String id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "SELECT * from `opportunities_manaagement` WHERE user_id ="+id;
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                MyConn2.Close();
                return dTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        public bool updateItems(String tableName, String username, String password, String id)
        {
            string MyConnection2 = "datasource=localhost;username=root;database=sales_management;password=";
            MySqlConnection con = new MySqlConnection(MyConnection2);
            MySqlCommand cmd;
            try
            {
                string CmdString = "UPDATE `"+tableName+"` SET `username`=@username,`password`=@password where id='" + id + "'";
                cmd = new MySqlCommand(CmdString, con);

                cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45);


                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;


                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MyConn2.Close();
                    return true;
                }
                else
                {
                    return false;
                }
             //   con.Close();
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteItem(String tableName, String id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query =  "delete from `" + tableName + "` where id='" + id + "';";
                
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;  
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteItemFromProposal(String id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "delete from `proposal` where product_id='" + id + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool insertIntoProject(String userid, String name, String amount, String revenue, String description,  String launchDate, String duration, String contact_name, String contact_mobile, String notes, String status)
        {
            try
            {
                //INSERT INTO `project`(`id`, `user_id`, `name`, `amount`, `revanue`, `description`, `status`, `launchdate`, `duration`, `contactname`, `contact mobile`, `notes`) VALUES('[value-1]', '[value-2]', '[value-3]', '[value-4]', '[value-5]', '[value-6]', '[value-7]', '[value-8]', '[value-9]', '[value-10]', '[value-11]', '[value-12]')

                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "INSERT INTO `project`(`user_id`, `name`, `amount`, `revanue`, `description`, `status`, `launchdate`, `duration`, `contactname`, `contact mobile`, `notes`) VALUES('" + userid + "','" + name + "','" + amount + "','" + revenue + "','" + description +"','" + status + "','" + launchDate + "','" + duration + "','" + contact_name + "','" + contact_mobile + "','" + notes + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool opportunityInsert(String userid, String name, String dateTime, String type, String chanceToclose, String budget, String duration, String contact_name, String contact_mobile, String description, String notes)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "INSERT INTO `opportunities_manaagement`(`name`, `date_time`, `type`, `chance_to_close`, `budget`, `duration`, `contact_name`, `contact_number`, `description`, `notes`, `user_id`) VALUES ('" + name + "','" + dateTime + "','" + type + "','" + chanceToclose + "','" + budget + "','" +duration + "','" +contact_name + "','" + contact_mobile + "','" + description + "','" + notes + "','" + userid + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }




        public bool updateItemFromProposal(String productname, String budget, String amount, String duration, String contact_name, String contact_number, String description, String rejected_reason, String status ,String id)
        {
            
            string MyConnection2 = "datasource=localhost;username=root;database=sales_management;password=";
            MySqlConnection con = new MySqlConnection(MyConnection2);
            MySqlCommand cmd;
            try
            {
                //  string CmdString = "UPDATE `proposal` SET `username`=@username,`password`=@password where id='" + id + "'";
                string CmdString = " UPDATE `proposal_management` SET `product_name`= @product_name,`budget`= @budget,`amount`= @amount,`duration`= @duration,`contact_name`= @contact_name,`contact_number`=@contact_number,`description`=@description,`rejected_reason`= @rejected_reason,`status`= @status WHERE `product_id` = "+id;
                cmd = new MySqlCommand(CmdString, con);

                cmd.Parameters.Add("@product_name", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@budget", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@amount", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@duration", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@contact_name", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@contact_number", MySqlDbType.VarChar,200);
                cmd.Parameters.Add("@description", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@rejected_reason", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@status", MySqlDbType.VarChar, 200);

                cmd.Parameters["@product_name"].Value = productname;
                cmd.Parameters["@budget"].Value = budget;
                cmd.Parameters["@amount"].Value = amount;
                cmd.Parameters["@duration"].Value = duration;
                cmd.Parameters["@contact_name"].Value = contact_name;
                cmd.Parameters["@contact_number"].Value = contact_number;
                cmd.Parameters["@description"].Value = description;
                cmd.Parameters["@rejected_reason"].Value = rejected_reason;
                cmd.Parameters["@status"].Value = status;

                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MyConn2.Close();
                    return true;
                }
                else
                {
                    return false;
                }
                //   con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
           
        }
        public bool updateItemFromOpportunity(String name, String date_time, String type, String chance_to_close, String budget, String duration, String contact_name, String contact_number, String description, String notes, String id)
        {

            string MyConnection2 = "datasource=localhost;username=root;database=sales_management;password=";
            MySqlConnection con = new MySqlConnection(MyConnection2);
            MySqlCommand cmd;
            try
            {
                //  string CmdString = "UPDATE `proposal` SET `username`=@username,`password`=@password where id='" + id + "'";
                string CmdString = " UPDATE `opportunities_manaagement` SET `name`= @name,`date_time`= @date_time,`type`= @type,`chance_to_close`= @chance_to_close,`budget`= @budget,`duration`=@duration,`contact_name`=@contact_name,`contact_number`= @contact_number,`description`= @description ,`notes`=@notes WHERE `id` = " + id;
                cmd = new MySqlCommand(CmdString, con);

                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@date_time", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@type", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@chance_to_close", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@budget", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@duration", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@contact_name", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@contact_number", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@description", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@notes", MySqlDbType.VarChar, 200);

                cmd.Parameters["@name"].Value = name;
                cmd.Parameters["@date_time"].Value = date_time;
                cmd.Parameters["@type"].Value = type;
                cmd.Parameters["@chance_to_close"].Value = chance_to_close;
                cmd.Parameters["@budget"].Value = budget;
                cmd.Parameters["@duration"].Value = duration;
                cmd.Parameters["@contact_name"].Value = contact_name;
                cmd.Parameters["@contact_number"].Value = contact_number;
                cmd.Parameters["@description"].Value = description;
                cmd.Parameters["@notes"].Value = notes;


                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MyConn2.Close();
                    return true;
                }
                else
                {
                    return false;
                }
                //   con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // UPDATE `project` SET `id`='[value-1]',`user_id`='[value-2]',`name`='[value-3]',`amount`='[value-4]',`revanue`='[value-5]',`description`='[value-6]',`status`='[value-7]',`launchdate`='[value-8]',`duration`='[value-9]',`contactname`='[value-10]',`contact mobile`='[value-11]',`notes`='[value-12]' WHERE 1

        public bool updateProject(String name, String amount, String revanue, String description, String status, String duration, String contactname, String contactmobile, String notes, String id)
        {

            string MyConnection2 = "datasource=localhost;username=root;database=sales_management;password=";
            MySqlConnection con = new MySqlConnection(MyConnection2);
            MySqlCommand cmd;
            try
            {
                //  string CmdString = "UPDATE `proposal` SET `username`=@username,`password`=@password where id='" + id + "'";
                string CmdString = " UPDATE `project` SET `name`= @name,`amount`= @amount,`revanue`= @revanue,`description`= @description,`status`=@status,`duration`=@duration,`contactname`= @contactname,`contact mobile`= @contactmobile ,`notes`=@notes WHERE `id` = " + id;
                cmd = new MySqlCommand(CmdString, con);

                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@amount", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@revanue", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@description", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@status", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@duration", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@contactname", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@contactmobile", MySqlDbType.VarChar, 200);
                cmd.Parameters.Add("@notes", MySqlDbType.VarChar, 200);

                cmd.Parameters["@name"].Value = name;
                cmd.Parameters["@amount"].Value = amount;
                cmd.Parameters["@revanue"].Value = revanue;
                cmd.Parameters["@description"].Value = description;
                cmd.Parameters["@status"].Value = status;
                cmd.Parameters["@duration"].Value = duration;
                cmd.Parameters["@contactname"].Value = contactname;
                cmd.Parameters["@contactmobile"].Value = contactmobile;
                cmd.Parameters["@notes"].Value = notes;


                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MyConn2.Close();
                    return true;
                }
                else
                {
                    return false;
                }
                //   con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool deleteItemFromOpportunity(String id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "delete from `opportunities_manaagement` where id='" + id + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteItemFromProject(String id)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = sales_management";
                string Query = "delete from `project` where id='" + id + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

  
}
