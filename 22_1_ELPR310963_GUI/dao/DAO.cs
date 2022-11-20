using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA2_CHAM_CONG.daos
{
    public class DAO
    {
        public dataprovider.DBConnection conn;

        public DAO()
        {
            conn = new dataprovider.DBConnection();
        }

        public void removeEmployee(String id)
        {
            const string sql = "delete from ATTENDANCE where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[0].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void addEmployee(String id, String Name, String Phone, String Email, String Base)
        {
            const string sql = "insert into ACTTENDANCE(id, Name, Phone, Email, Base) values(@id, @Name, @Phone, @Email, @Base)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[0].Value = Convert.ToString(id);
            sqlParameters[1] = new SqlParameter("@Name", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Name);
            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Phone);
            sqlParameters[3] = new SqlParameter("@Email", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(Email);
            sqlParameters[4] = new SqlParameter("@Base", SqlDbType.BigInt);
            sqlParameters[4].Value = Convert.ToString(Base);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void editEmployee(String id, String Name, String Phone, String Email, String Base)
        {
            const string sql = "update ATTENDANCE set id = @id, @Name, @Phone, @Email, @Base where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[0].Value = Convert.ToString(id);
            sqlParameters[1] = new SqlParameter("@Name", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Name);
            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(Phone);
            sqlParameters[3] = new SqlParameter("@Email", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(Email);
            sqlParameters[4] = new SqlParameter("@Base", SqlDbType.BigInt);
            sqlParameters[4].Value = Convert.ToString(Base);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public DataTable CheckID(String id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                string sql = "select * from ATTENDANCE where id = ";
                sql = sql + id;
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            dt.Load(dataReader);
                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dt;
        }
    }

    public class employeeBUS
    {
        private DAO employeeDAO;
        public employeeBUS()
        {
            employeeDAO = new DAO();
        }
        public void addEmp(String id, String Name, String Phone, String Email, String Base)
        {
            employeeDAO.addEmployee(id, Name, Phone, Email, Base);
        }

        public void editEmp(String id, String Name, String Phone, String Email, String Base)
        {
            employeeDAO.editEmployee(id, Name, Phone, Email, Base);
        }

        public void removeEmp(String id)
        {
            employeeDAO.removeEmployee(id);
        }

        public DataTable CheckEmp(String id)
        {
            return employeeDAO.CheckID(id);
        }
    }
}
