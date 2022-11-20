using DA2_CHAM_CONG.daos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DA2_CHAM_CONG.Forms
{
    public partial class formMain : Form
    {
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        public formMain()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            baudRate_cbBox.Items.AddRange(BaudRate);
        }

        //Time Configuration
        public string Time()
        {
            string str = DateTime.Now.ToString().Trim();
            string str_day = str.Substring(0, 2);
            string str_month = str.Substring(3, 2);
            string str_year = str.Substring(6, 4);
            string str_hour = str.Substring(11, 2);
            string str_minute = str.Substring(14, 2);
            string str_second = str.Substring(17, 2);
            int day = Convert.ToInt32(str_day);
            int month = Convert.ToInt32(str_month);
            int year = Convert.ToInt32(str_year);
            return str_day + '/' + str_month + '/' + str_year + ' ' + str_hour + ':' + str_minute + ':' + str_second;
        }

        public int ThisMonth()
        {
            string str = DateTime.Now.ToString().Trim();
            string str_day = str.Substring(0, 2);
            string str_month = str.Substring(3, 2);
            string str_year = str.Substring(6, 4);
            string str_hour = str.Substring(11, 2);
            string str_minute = str.Substring(14, 2);
            string str_second = str.Substring(17, 2);
            int day = Convert.ToInt32(str_day);
            int month = Convert.ToInt32(str_month);
            int year = Convert.ToInt32(str_year);
            int thismonthColumn = (((month - 1) * 2) + 6);
            return thismonthColumn;
        }


        //Connect to Arduino
        //Recieve Data

        String str_dataFromSerialPort_int64 = "";
        long ID;

        private void SetText(string text)
        {

            if (this.id_txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                str_dataFromSerialPort_int64 = InputData;
                ID = Convert.ToInt64(str_dataFromSerialPort_int64);
                this.id_txt.Text += text;
            }

        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                SetText(InputData);
            }

        }

        private void cnn_Button_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comPort_cbBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudRate_cbBox.Text);
                serialPort1.Open();
                cnnStatus_label.Text = ("Connected");
                cnnStatus_label.ForeColor = Color.Green;
            }

        }

        private void discnn_Button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            cnnStatus_label.Text = ("Disconnected");
            cnnStatus_label.ForeColor = Color.Red;
        }


        //Form init
        private void formMain_Load(object sender, EventArgs e)
        {
            comPort_cbBox.DataSource = SerialPort.GetPortNames();
            baudRate_cbBox.SelectedIndex = 3;

            string amWT = "07:00:00";
            DateTime amTime = DateTime.ParseExact(amWT, "HH:mm:ss", null);
            amWorkingTime_txt.Text = amTime.ToString();

            string pmWT = "13:00:00";
            DateTime pmTime = DateTime.ParseExact(pmWT, "HH:mm:ss", null);
            pmWorkingTime_txt.Text = pmTime.ToString();

        }

        private void GetAllInformation()
        {
            DataSet data = new DataSet();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from QLHH_main where id = @id";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            this.employeeIn4_grid.DataSource = dt;

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
        }

        string[] datesBefore;
        string[] datesAfter;
        int[] LastDates;
        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            timeCheckIn_txt.Text = Time();
            GetAllInformation();
            DataTable dt = new DataTable();
            var emplBUS = new daos.employeeBUS();
            dt = emplBUS.CheckEmp(str_dataFromSerialPort_int64);
            int thisMonth = ThisMonth();
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    switch (thisMonth)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            datesBefore[0] = temp;
                            LastDates[0] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 7:
                            break;
                        case 8:
                            datesBefore[1] = temp;
                            LastDates[1] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 9:
                            break;
                        case 10:
                            datesBefore[2] = temp;
                            LastDates[2] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 11:
                            break;
                        case 12:
                            datesBefore[3] = temp;
                            LastDates[3] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 13:
                            break;
                        case 14:
                            datesBefore[4] = temp;
                            LastDates[4] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 15:
                            break;
                        case 16:
                            datesBefore[5] = temp;
                            LastDates[5] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 17:
                            break;
                        case 18:
                            datesBefore[6] = temp;
                            LastDates[6] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 19:
                            break;
                        case 20:
                            datesBefore[7] = temp;
                            LastDates[7] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 21:
                            break;
                        case 22:
                            datesBefore[8] = temp;
                            LastDates[8] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 23:
                            break;
                        case 24:
                            datesBefore[9] = temp;
                            LastDates[9] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 25:
                            break;
                        case 26:
                            datesBefore[10] = temp;
                            LastDates[10] = Convert.ToInt32(datesBefore) + 1;
                            break;
                        case 27:
                            break;
                        case 28:
                            datesBefore[11] = temp;
                            LastDates[11] = Convert.ToInt32(datesBefore) + 1;
                            break;
                    }
                    for (int count = 0; count < 12; count++)
                    {
                        datesAfter[count] = Convert.ToString(LastDates[count]);
                    }

                }
            }
            emplBUS.attendacne(str_dataFromSerialPort_int64, datesAfter[0], datesAfter[1], datesAfter[2], datesAfter[3], datesAfter[4], datesAfter[5], datesAfter[6], datesAfter[7], datesAfter[8], datesAfter[9], datesAfter[10], datesAfter[11]);
        }

        
    }
}
