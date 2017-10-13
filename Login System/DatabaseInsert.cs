using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace Login_System
{
    class DatabaseInsert : DatabaseIO
    {
        public DatabaseInsert()
        {

        }

        public void InsertDrugInformation(string name, string genName, string power, string price, string quantity, string locId, string locDet, string manId, string drugDet)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("insert_drug_info", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Direction = System.Data.ParameterDirection.Input;
                    Name.Value = name;

                    OracleParameter GenName = new OracleParameter();
                    GenName.OracleDbType = OracleDbType.Varchar2;
                    GenName.Direction = System.Data.ParameterDirection.Input;
                    GenName.Value = genName;

                    OracleParameter Power = new OracleParameter();
                    Power.OracleDbType = OracleDbType.Decimal;
                    Power.Direction = System.Data.ParameterDirection.Input;
                    //Power.Value = decimal.Parse(power);
                    Power.Value = power;

                    OracleParameter Price = new OracleParameter();
                    Price.OracleDbType = OracleDbType.Decimal;
                    Price.Direction = System.Data.ParameterDirection.Input;
                    //Price.Value = decimal.Parse(price);
                    Price.Value = price;

                    OracleParameter Quantity = new OracleParameter();
                    Quantity.OracleDbType = OracleDbType.Int32;
                    Quantity.Direction = System.Data.ParameterDirection.Input;
                   // Quantity.Value = Convert.ToInt32(quantity);
                    Quantity.Value = quantity;

                    OracleParameter LocId = new OracleParameter();
                    LocId.OracleDbType = OracleDbType.Varchar2;
                    LocId.Direction = System.Data.ParameterDirection.Input;
                    LocId.Value = locId;

                    OracleParameter LocDet = new OracleParameter();
                    LocDet.OracleDbType = OracleDbType.Varchar2;
                    LocDet.Direction = System.Data.ParameterDirection.Input;
                    LocDet.Value = locDet;

                    OracleParameter ManId = new OracleParameter();
                    ManId.OracleDbType = OracleDbType.Int32;
                    ManId.Direction = System.Data.ParameterDirection.Input;
                    //ManId.Value = Convert.ToInt32(manId);
                    ManId.Value = manId;

                    OracleParameter DrugDet = new OracleParameter();
                    DrugDet.OracleDbType = OracleDbType.Varchar2;
                    DrugDet.Direction = System.Data.ParameterDirection.Input;
                    DrugDet.Value = drugDet;

                    OracleParameter Ret = new OracleParameter();
                    Ret.Direction = System.Data.ParameterDirection.ReturnValue;
                    Ret.OracleDbType = OracleDbType.Varchar2;
                    Ret.Size = 10;

                    cmd.Parameters.Add(Ret);
                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(GenName);
                    cmd.Parameters.Add(Power);
                    cmd.Parameters.Add(Price);
                    cmd.Parameters.Add(Quantity);
                    cmd.Parameters.Add(LocId);
                    cmd.Parameters.Add(LocDet);
                    cmd.Parameters.Add(ManId);
                    cmd.Parameters.Add(DrugDet);
                  

                    try
                    {
                        cmd.ExecuteNonQuery();
                        if (Ret.Value.ToString().Equals("fail"))
                            System.Windows.Forms.MessageBox.Show("Check Manufacturer ID");
                        else
                            System.Windows.Forms.MessageBox.Show("Insertion Successfull");
                    }
                    catch (OracleException ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }


        public void InsertManufacturerInformation(string name, string contact, string representative)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("insert_manufacturer_info", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Contact = new OracleParameter();
                    Contact.OracleDbType = OracleDbType.Varchar2;
                    Contact.Value = contact;

                    OracleParameter Rep = new OracleParameter();
                    Rep.OracleDbType = OracleDbType.Varchar2;
                    Rep.Value = representative;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Contact);
                    cmd.Parameters.Add(Rep);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Insertion Successfull");
                    }
                    catch (OracleException ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Insertion Failed");
                    }

                }
            }
        }



        public void InsertEmpInformation(string name, string type, string salary, string contact)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("insert_emp_info", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Type = new OracleParameter();
                    Type.OracleDbType = OracleDbType.Varchar2;
                    Type.Value = type;

                    OracleParameter Salary = new OracleParameter();
                    Salary.OracleDbType = OracleDbType.Decimal;
                    Salary.Value = salary;

                    OracleParameter Contact = new OracleParameter();
                    Contact.OracleDbType = OracleDbType.Varchar2;
                    Contact.Value = contact;

                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Type);
                    cmd.Parameters.Add(Salary);
                    cmd.Parameters.Add(Contact);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Inserion Successfull");
                    }
                    catch (OracleException ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    catch (Exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Insertion Failed");
                    }

                }
            }
        }

        public string[] InsertBuyingInfo(string name, string quan)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("buyingProcedures.insert_buying_info", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter Name = new OracleParameter();
                    Name.OracleDbType = OracleDbType.Varchar2;
                    Name.Value = name;

                    OracleParameter Quan = new OracleParameter();
                    Quan.OracleDbType = OracleDbType.Int32;
                    Quan.Value = quan;

                    OracleParameter retCur = new OracleParameter("RetVal", OracleDbType.RefCursor);
                    retCur.Direction = System.Data.ParameterDirection.ReturnValue;

                    cmd.Parameters.Add(retCur);
                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Quan);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        OracleDataReader reader = ((OracleRefCursor)retCur.Value).GetDataReader();
                        string[] details = new string[3];

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                details[i] = reader[i].ToString();
                            }
                        }

                        return details;
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Database Exception.Transaction Failed");
                        return null;
                    }
                    catch (Exception)
                    {
                        //System.Windows.Forms.MessageBox.Show("Exception occured.Transaction Failed");
                        return null;
                    }
                }
            }
        }


        public string[] InsertSellingInfo(string emp_id, string c_Name, string discount, string drug_name, string quan)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("buyingProcedures.insert_selling_info", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    OracleParameter retCur = new OracleParameter("RetVal", OracleDbType.RefCursor);
                    retCur.Direction = System.Data.ParameterDirection.ReturnValue;

                    OracleParameter Emp_Id = new OracleParameter();
                    Emp_Id.OracleDbType = OracleDbType.Int32;
                    Emp_Id.Value = emp_id;

                    OracleParameter C_Name = new OracleParameter();
                    C_Name.OracleDbType = OracleDbType.Varchar2;
                    C_Name.Value = c_Name;

                    OracleParameter Discount = new OracleParameter();
                    Discount.OracleDbType = OracleDbType.Decimal;
                    Discount.Value = discount;

                    OracleParameter D_Name = new OracleParameter();
                    D_Name.OracleDbType = OracleDbType.Varchar2;
                    D_Name.Value = drug_name;

                    OracleParameter Quan = new OracleParameter();
                    Quan.OracleDbType = OracleDbType.Int32;
                    Quan.Value = quan;

                    cmd.Parameters.Add(retCur);
                    cmd.Parameters.Add(Emp_Id);
                    cmd.Parameters.Add(C_Name);
                    cmd.Parameters.Add(Discount);
                    cmd.Parameters.Add(D_Name);
                    cmd.Parameters.Add(Quan);

                    try
                    {
                       // Console.WriteLine(emp_id + "  " + c_Name + "  " + discount + " " + drug_name + "  " + quan);
                        cmd.ExecuteNonQuery();
                        OracleDataReader reader = ((OracleRefCursor)retCur.Value).GetDataReader();
                        string[] details = new string[3];

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                details[i] = reader[i].ToString();
                            }
                        }
                        return details;
                    }
                    catch (OracleException)
                    {
                        System.Windows.Forms.MessageBox.Show("Required number of drug is not available in the inventory");
                        return null;
                    }
                    catch (Exception)
                    {
                        //System.Windows.Forms.MessageBox.Show(ex.Message);
                        return null;
                    }
                }
            }
        }




        internal System.Windows.Forms.AutoCompleteStringCollection GetAutoCompleteDrugGenericNames()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("Get_Drug_GenericNames", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter drugGenericNames = new OracleParameter("RetVal", OracleDbType.RefCursor);
                    drugGenericNames.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(drugGenericNames);

                    System.Windows.Forms.AutoCompleteStringCollection Names = new System.Windows.Forms.AutoCompleteStringCollection();

                    try
                    {
                        cmd.ExecuteNonQuery();

                        OracleDataReader reader = ((OracleRefCursor)drugGenericNames.Value).GetDataReader();


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

        internal System.Windows.Forms.AutoCompleteStringCollection GetAutoCompleteDrugLocationIds()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("Get_Drug_LocationId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter drugLocationIds = new OracleParameter("RetVal", OracleDbType.RefCursor);
                    drugLocationIds.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(drugLocationIds);

                    System.Windows.Forms.AutoCompleteStringCollection Ids = new System.Windows.Forms.AutoCompleteStringCollection();

                    try
                    {
                        cmd.ExecuteNonQuery();

                        OracleDataReader reader = ((OracleRefCursor)drugLocationIds.Value).GetDataReader();


                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Ids.Add(reader[i].ToString());
                            }
                        }

                        return Ids;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
                        return Ids;
                    }
                }
            }
        }
    }
}
