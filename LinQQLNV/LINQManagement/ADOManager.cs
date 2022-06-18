using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace QuanLyNhanSuADO.ADOManagement
{
    public class ADOManager
    {

            private SqlConnection connection;
            public ADOManager(string connectionString)
            {
                this.connection = new SqlConnection(connectionString);
            }

            private bool OpenConnection()
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Error ! " + ex.Message, "Information");
                        return false;
                    }
                }
                return true;
            }

            private bool CloseConnection()
            {
                if (connection.State == ConnectionState.Open)
                {
                    try
                    {
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Error! " + ex.Message, "Information");
                        return false;
                    }
                }
                return true;
            }

            public bool ExecuteNonQuery(string sql, SqlParameter[] sqlParameter = null)
            {
                try
                {
                    if (OpenConnection())
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        if (sqlParameter != null)
                        {
                            command.Parameters.AddRange(sqlParameter);
                        }
                        return command.ExecuteNonQuery() > 0;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ExecuteNonQuery Error ! " + ex.Message, "Information");
                    return false;
                }
                finally
                {
                    CloseConnection();
                }
            }

            public DataTable ExecuteQuery(string sql, SqlParameter[] sqlParameters = null)
            {
                try
                {
                    if (OpenConnection())
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        if (sqlParameters != null)
                        {
                            command.Parameters.AddRange(sqlParameters);
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        CloseConnection();
                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ExecuteQuery Error ! " + ex.Message, "Information");
                }
                return null;
            }
        }
    
}
