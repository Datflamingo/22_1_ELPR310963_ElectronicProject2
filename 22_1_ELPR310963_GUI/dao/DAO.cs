using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DA2_CHAM_CONG.daos
{
    public class DAO
    {
        public dataprovider.DBConnection conn;

        public DAO()
        {
            conn = new dataprovider.DBConnection();
        }

        public void Attendance(String id, String Jan_act, String Feb_act, String Mar_act, String Apr_act, String May_act, String Jun_act, String Jul_act, String Aug_act, String Sep_act, String Oct_act, String Nov_act, String Dec_act)
        {
            const string sql = "update ATTENDANCE set Jan_act = @Jan_act, Feb_act = @Feb_act, Mar_act = @Mar_act, Apr_act = @Apr_act, May_act = @May_act, Jun_act = @Jun_act, Jul_act = @Jul_act, Aug_act = @Aug_act, Sep_act = @Sep_act, Oct_act = @Oct_act, Nov_act = @Nov_act, Dec_act = @Dec_act, where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[13];
            sqlParameters[0] = new SqlParameter("@Jan_act", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(Jan_act);
            sqlParameters[1] = new SqlParameter("@Feb_act", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToString(Feb_act);
            sqlParameters[2] = new SqlParameter("@Mar_act", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(Jan_act);
            sqlParameters[3] = new SqlParameter("@Apr_act", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToString(Jan_act);
            sqlParameters[4] = new SqlParameter("@May_act", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToString(Jan_act);
            sqlParameters[5] = new SqlParameter("@Jun_act", SqlDbType.Int);
            sqlParameters[5].Value = Convert.ToString(Jan_act);
            sqlParameters[6] = new SqlParameter("@Jul_act", SqlDbType.Int);
            sqlParameters[6].Value = Convert.ToString(Jan_act);
            sqlParameters[7] = new SqlParameter("@Aug_act", SqlDbType.Int);
            sqlParameters[7].Value = Convert.ToString(Jan_act);
            sqlParameters[8] = new SqlParameter("@Sep_act", SqlDbType.Int);
            sqlParameters[8].Value = Convert.ToString(Jan_act);
            sqlParameters[9] = new SqlParameter("@Oct_act", SqlDbType.Int);
            sqlParameters[9].Value = Convert.ToString(Jan_act);
            sqlParameters[10] = new SqlParameter("@Nov_act", SqlDbType.Int);
            sqlParameters[10].Value = Convert.ToString(Jan_act);
            sqlParameters[11] = new SqlParameter("@Dec_act", SqlDbType.Int);
            sqlParameters[11].Value = Convert.ToString(Jan_act);
            sqlParameters[12] = new SqlParameter("@id", SqlDbType.BigInt);
            sqlParameters[12].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
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

        public void attendacne(String id, String Jan_act, String Feb_act, String Mar_act, String Apr_act, String May_act, String Jun_act, String Jul_act, String Aug_act, String Sep_act, String Oct_act, String Nov_act, String Dec_act)
        {
            employeeDAO.Attendance(id, Jan_act, Feb_act, Mar_act, Apr_act, May_act, Jun_act, Jul_act, Aug_act, Sep_act, Oct_act, Nov_act, Dec_act);

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
