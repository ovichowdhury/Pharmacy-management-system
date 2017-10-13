using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Login_System
{
    class DatabaseUpdateDelete : DatabaseIO
    {
        public DatabaseUpdateDelete()
        {

        }

        public void DeleteUserAccount(string username)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string sql = "delete from login where username = :givenName";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleParameter User = new OracleParameter();
                    User.OracleDbType = OracleDbType.Varchar2;
                    User.Value = username;

                    cmd.Parameters.Add(User);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Error deleting user account");
                    }
                }
            }
        }


        internal void DeleteDrugInfoById(string name)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("delete_drug_info_by_id", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Direction = System.Data.ParameterDirection.Input;
                    Name.Value = name;

                    cmd.Parameters.Add(Name);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Deletion Failed..");
                    }
                }
            }
        }


        internal void UpdateDrugName(string name, string value)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_name", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = value;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }


        internal void UpdateDrugPrice(string name, string price)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_price", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Decimal;
                    Value.Value = price;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }



        internal void UpdateDrugPower(string name, string power)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_power", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Decimal;
                    Value.Value = power;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }


        internal void UpdateDrugQuan(string name, string quan)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_quantity", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Int32;
                    Value.Value = quan;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }



        internal void UpdateDrugDetails(string name, string details)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_details", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = details;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }



        internal void UpdateDrugManufacturer(string name, string manName)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_manufacturer", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = manName;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }



        internal void UpdateDrugLocation(string name, string locId, string locDet)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_location", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = locId;

                    OracleParameter Det = new OracleParameter();
                    Det.OracleDbType = OracleDbType.Varchar2;
                    Det.Value = locDet;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);
                    cmd.Parameters.Add(Det);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }


        internal void DeleteManufacturerInfo(string name)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("delete_manufacturer_info", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    cmd.Parameters.Add(Name);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Deletion Failed due to database error");
                    }
                }
            }
        }




        internal void UpdateManName(string name, string value)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("update_man_name", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = value;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed due to database error");
                    }
                }
            }
        }




        internal void UpdateManContact(string name, string contact)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("update_man_contact", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = contact;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed due to database error");
                    }
                }
            }
        }




        internal void UpdateManRep(string name, string rep)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("update_man_rep", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = rep;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed due to database error");
                    }
                }
            }
        }



        internal void ArchiveEmpInfo(string id)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("archive_emp_info", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter ID = new OracleParameter();
                    ID.OracleDbType = OracleDbType.Int32;
                    ID.Value = id;

                    cmd.Parameters.Add(ID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Archivation failed");
                    }
                }
            }
        }


        internal void UpdateEmpName(string id, string name)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("update_emp_name", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter EmpID = new OracleParameter();
                    EmpID.OracleDbType = OracleDbType.Int32;
                    EmpID.Value = id;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = name;

                    cmd.Parameters.Add(EmpID);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed due to database error");
                    }
                }
            }
        }




        internal void UpdateEmpType(string id, string type)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("update_emp_type", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter EmpID = new OracleParameter();
                    EmpID.OracleDbType = OracleDbType.Int32;
                    EmpID.Value = id;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = type;

                    cmd.Parameters.Add(EmpID);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed due to database error");
                    }
                }
            }
        }

        internal void UpdateEmpSalary(string id, string salary)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("update_emp_salary", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter EmpID = new OracleParameter();
                    EmpID.OracleDbType = OracleDbType.Int32;
                    EmpID.Value = id;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Decimal;
                    Value.Value = salary;

                    cmd.Parameters.Add(EmpID);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed due to database error");
                    }
                }
            }
        }


        internal void UpdateEmpContact(string id, string contact)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("update_emp_contact", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter EmpID = new OracleParameter();
                    EmpID.OracleDbType = OracleDbType.Int32;
                    EmpID.Value = id;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = contact;

                    cmd.Parameters.Add(EmpID);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Update failed due to database error");
                    }
                }
            }
        }




        internal void UpdateDrugGenName(string genName, string value)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                using (OracleCommand cmd = new OracleCommand("update_drug_gen_name", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = genName;

                    OracleParameter Value = new OracleParameter();
                    Value.OracleDbType = OracleDbType.Varchar2;
                    Value.Value = value;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Value);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Exception occured update failed");
                    }
                }
            }
        }





    }
}
