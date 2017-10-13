using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Login_System
{
    class DatabaseIO
    {
        internal static string accountStatus = null;
        protected static string user = null;
        protected string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=windows)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=pms;Password=pms";
        OracleConnection conn;

        public DatabaseIO()
        {
            
        }

        public bool checkUsernameAndPassword(string username, string password)
        {
            using (conn = new OracleConnection(connectionString))
            {
                string SQL = "SELECT USERNAME,PASSWORD,STATUS FROM LOGIN " +
                             "WHERE USERNAME = :GIVEN_USER_NAME";
                using (OracleCommand cmd = new OracleCommand(SQL, conn))
                {
                    OracleParameter userName = new OracleParameter();
                    userName.OracleDbType = OracleDbType.Varchar2;
                    userName.Value = username;
                    cmd.Parameters.Add(userName);
               
                    conn.Open();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        string pass = null;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            user = row["USERNAME"].ToString();
                            pass = row["PASSWORD"].ToString();
                            accountStatus = row["STATUS"].ToString();
                        }

                        if (user == null)
                            return false;
                        else
                        {
                            if (pass.Equals(password))
                                return true;
                            else
                                return false;
                        }
                    }
                }
            }
        }






        internal void CreateUser(string username, string password,string status)
        {
            try
            {
                using (conn = new OracleConnection(connectionString))
                {
                    string SQL = "INSERT INTO LOGIN VALUES(:USER_NAME,:PASSWORD,:STATUS)";

                    using (OracleCommand cmd = new OracleCommand(SQL, conn))
                    {
                        OracleParameter user = new OracleParameter();
                        OracleParameter pass = new OracleParameter();
                        OracleParameter stat = new OracleParameter();
                        user.OracleDbType = OracleDbType.Varchar2;
                        pass.OracleDbType = OracleDbType.Varchar2;
                        stat.OracleDbType = OracleDbType.Varchar2;
                        user.Value = username;
                        pass.Value = password;
                        stat.Value = status;

                        cmd.Parameters.Add(user);
                        cmd.Parameters.Add(pass);
                        cmd.Parameters.Add(stat);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        System.Windows.Forms.MessageBox.Show("User Account Successfully Created");
                    }
                }
            }
            catch (OracleException ex)
            {
                if(ex.Number.ToString().Equals("1"))
                    System.Windows.Forms.MessageBox.Show("Username already exists");
                else
                    System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }


        internal void ChangePassword(string newPass)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "update login set password = :newpassword where username = :givenuser";
                using (OracleCommand cmd = new OracleCommand(sql,conn))
                {
                    OracleParameter NPass = new OracleParameter();
                    NPass.OracleDbType = OracleDbType.Varchar2;
                    NPass.Value = newPass;

                    OracleParameter User = new OracleParameter();
                    User.OracleDbType = OracleDbType.Varchar2;
                    User.Value = DatabaseIO.user;

                    cmd.Parameters.Add(NPass);
                    cmd.Parameters.Add(User);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Password successfully changed");
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Unsuccessful");
                    }
                }
            } 
        }


        internal System.Windows.Forms.AutoCompleteStringCollection GetAutoCompleteDrugNames()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("Get_Drug_Names", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter drugNames = new OracleParameter("RetVal",OracleDbType.RefCursor);
                    drugNames.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(drugNames);

                    System.Windows.Forms.AutoCompleteStringCollection Names = new System.Windows.Forms.AutoCompleteStringCollection();

                    try
                    {
                        cmd.ExecuteNonQuery();

                        OracleDataReader reader = ((OracleRefCursor)drugNames.Value).GetDataReader();
                        

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Names.Add(reader[i].ToString());
                            }
                        }

                        return Names;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
                        return Names;
                    }
                }
            }
        }


        public List<string> GetVoiceSearchGrammar()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("Get_Drug_Names", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter drugNames = new OracleParameter("RetVal", OracleDbType.RefCursor);
                    drugNames.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(drugNames);

                    cmd.ExecuteNonQuery();

                    OracleDataReader reader = ((OracleRefCursor)drugNames.Value).GetDataReader();
                    List<string> Names = new List<string>();
                    
                    try
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Names.Add(reader[i].ToString());
                               // Console.WriteLine(reader[i].ToString());
                            }
                               
                        }

                        return Names;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
                        return Names;
                    }
                }
            }
        }



        public void GetDrugSearchResult(string drugName,out string locId,out string genName,out string locDir,out string price,out string power,out string quantity,out string manName,out string details)
        {
            locId = "null"; genName = "null"; locDir = "null"; price = "null"; power = "null"; quantity = "null"; manName = "null"; details = "null"; 
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
               // String sql = "Select location_id, price, drug_power, quantity, man_id, drug_details From drug_info Where drug_name = :given_drug_name";
                String sql = "Select location_id,generic_name, location_direction, price, drug_power, quantity, man_name, drug_details From (drug_info natural join manufacturer_info natural join drug_location) Where drug_name = :given_drug_name";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleParameter givenDrugName = new OracleParameter("drug_name", OracleDbType.Varchar2);
                    givenDrugName.Value = drugName;
                    
                    cmd.Parameters.Add(givenDrugName);
                   
                    conn.Open();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach(DataRow row in dataTable.Rows)
                        {
                            locId = row["location_id"].ToString();
                            genName = row["generic_name"].ToString();
                            locDir = row["location_direction"].ToString();
                            price = row["price"].ToString();
                            power = row["drug_power"].ToString();
                            quantity = row["quantity"].ToString();
                            manName = row["man_name"].ToString();
                            details = row["drug_details"].ToString();
                        }
                    }
                }
            }


        }


        public void GetDrugSearchResultByID(string drugId,out string name, out string locId,out string genName,out string locDir, out string price, out string power, out string quantity, out string manName, out string details)
        {
            name = "null"; locId = "null"; genName = "null";  locDir = "null"; price = "null"; power = "null"; quantity = "null"; manName = "null"; details = "null";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                // String sql = "Select location_id, price, drug_power, quantity, man_id, drug_details From drug_info Where drug_name = :given_drug_name";
                String sql = "Select drug_name,location_id,generic_name,location_direction, price, drug_power, quantity, man_name, drug_details From (drug_info natural join manufacturer_info natural join drug_location) Where drug_id = :given_drug_id";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleParameter givenDrugName = new OracleParameter("drug_id", OracleDbType.Int32);
                    givenDrugName.Value = drugId;

                    cmd.Parameters.Add(givenDrugName);

                    conn.Open();

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            name = row["drug_name"].ToString();
                            locId = row["location_id"].ToString();
                            genName = row["generic_name"].ToString();
                            locDir = row["location_direction"].ToString();
                            price = row["price"].ToString();
                            power = row["drug_power"].ToString();
                            quantity = row["quantity"].ToString();
                            manName = row["man_name"].ToString();
                            details = row["drug_details"].ToString();
                        }
                    }
                }
            }


        }



        internal void FillInventoryNotificationValues(System.Windows.Forms.DataGridView dataGridViewNotification)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string sql = "Select drug_name, quantity, price, drug_power, man_name as Manufacturer From (drug_info natural join manufacturer_info)"+
                             "where quantity <= 10 Order by quantity";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    conn.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewNotification.DataSource = dt;
                    }
                }
            }
        }



        internal List<string> GetMedicalAssistantSpeech(string word)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select drug_name from drug_info where drug_details like '%' || :given_value || '%'";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleParameter Word = new OracleParameter();
                    Word.OracleDbType = OracleDbType.Varchar2;
                    Word.Value = word;

                    cmd.Parameters.Add(Word);

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        List<string> names = new List<string>();

                        foreach(DataRow row in dt.Rows)
                        {
                            names.Add(row["drug_name"].ToString());
                        }

                        return names;
                    }
                }
            }
        }



        public void FillManufacturerInfo(System.Windows.Forms.DataGridView dataGrid)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from manufacturer_info";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
        }


        public void FillDrugInfo(System.Windows.Forms.DataGridView dataGrid)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from show_drug_info";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
        }


        public void FillEmpInfo(System.Windows.Forms.DataGridView dataGrid)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from emp_info where emp_name <> 'null'";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
        }


        internal void FillBuyingInfo(System.Windows.Forms.DataGridView dataGridViewBuyingInfo)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from show_buying_info";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewBuyingInfo.DataSource = dt;
                    }
                }
            }
        }

        internal void FillSellingInfo(System.Windows.Forms.DataGridView dataGridViewSellingInfo)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from show_selling_info";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewSellingInfo.DataSource = dt;
                    }
                }
            }
        }

        internal void FillLoginInfo(System.Windows.Forms.DataGridView dataGrid)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from login";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
        }






        internal void GetReportData(out string totalBuy, out string totalSell, out string numBought, out string numSold, out string bestEmp)
        {
            totalBuy = "0"; totalSell = "0"; numBought = "0"; numSold = "0"; bestEmp = "null";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("get_report_data", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter retCur = new OracleParameter("RetVal", OracleDbType.RefCursor);
                    retCur.Direction = ParameterDirection.ReturnValue;

                    cmd.Parameters.Add(retCur);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        OracleDataReader reader = ((OracleRefCursor)retCur.Value).GetDataReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                totalBuy = reader[0].ToString();
                                totalSell = reader[1].ToString();
                                bestEmp = reader[2].ToString();
                                numSold = reader[3].ToString();
                                numBought = reader[4].ToString();

                            }
                        }

                    }
                    catch (OracleException)
                    {

                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }




        internal void GetManSearchResult(string name, out string id, out string contact, out string rep)
        {
            id = "null"; contact = "null"; rep = "null";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from manufacturer_info where man_name = :given_name";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    cmd.Parameters.Add(Name);
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            id = row["man_id"].ToString();
                            contact = row["man_contact"].ToString();
                            rep = row["man_representative"].ToString();
                        }
                    }
                }
            }
        }



        internal void FillArchiveBuyingInfo(System.Windows.Forms.DataGridView dataGridViewArBuying)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from archive_buying_info";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewArBuying.DataSource = dt;
                    }
                }
            }
        }

        internal void FillArchiveSellingInfo(System.Windows.Forms.DataGridView dataGridViewArSelling)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from archive_selling_info";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewArSelling.DataSource = dt;
                    }
                }
            }
        }



        internal void GetEmpSearchResult(string id, out string name, out string type, out string salary, out string contact)
        {
            name = "null"; type = "null"; salary = "null"; contact = "null";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "select emp_name,emp_type,emp_salary,emp_contact from emp_info where emp_id = :givenId";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleParameter ID = new OracleParameter();
                    ID.OracleDbType = OracleDbType.Int32;
                    ID.Value = id;

                    cmd.Parameters.Add(ID);

                    try
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                name = row["emp_name"].ToString();
                                type = row["emp_type"].ToString();
                                salary = row["emp_salary"].ToString();
                                contact = row["emp_contact"].ToString();
                            }
                        }
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Search failed due to database error");
                    }
                }
            }
        }


    }

}
