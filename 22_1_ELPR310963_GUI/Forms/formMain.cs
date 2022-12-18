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

        //Real time Configuration
        public string RealTime()
        {
            string str = DateTime.Now.ToString().Trim();
            string str_day = str.Substring(0, 2);
            string str_month = str.Substring(3, 2);
            string str_year = str.Substring(6, 4);
            string str_hour = str.Substring(11, 2);
            string str_minute = str.Substring(14, 2);
            string str_second = str.Substring(17, 2);
            int day = Convert.ToInt16(str_day);
            int month = Convert.ToInt16(str_month);
            int year = Convert.ToInt16(str_year);
            return str_day + '/' + str_month + '/' + str_year + ' ' + str_hour + ':' + str_minute + ':' + str_second;
        }
        public int count()
        {
            string str = DateTime.Now.ToString().Trim();
            string str_month = str.Substring(0, 2);
            string str_day = str.Substring(3, 2);
            string str_year = str.Substring(6, 4);
            string str_hour = str.Substring(11, 2);
            string str_minute = str.Substring(14, 2);
            string str_second = str.Substring(17, 2);
            int day = Convert.ToInt16(str_day);
            int month = Convert.ToInt16(str_month);
            int year = Convert.ToInt16(str_year);
            int thismonthColumn = (((Convert.ToInt32(month) - 1) * 2) + 6);
            int thismonth_use = thismonthColumn;
            return thismonth_use;
        }

        //Virtual time which user setup
        public string VirtualTime()
        {
            string str_day = day_txt.Text;
            string str_month = month_txt.Text;
            string str_year = year_txt.Text;
            string str_hour = hour_txt.Text;
            string str_minute = minute_txt.Text;
            string str_second = second_txt.Text;
            int day = Convert.ToInt16(str_day);
            int month = Convert.ToInt16(str_month);
            int year = Convert.ToInt16(str_year);
            return str_month + '/' + str_day + '/' + str_year + ' ' + str_hour + ':' + str_minute + ':' + str_second;
        }
        public int VirtualThisMonth()
        {
            int month = Convert.ToInt16(month_txt.Text);
            int thismonthColumn = (((Convert.ToInt32(month) - 1) * 2) + 6);
            int thismonth_use = thismonthColumn;
            return thismonth_use;
        }

        public int VirtualThisMonth4Late()
        {
            int month = Convert.ToInt16(month_txt.Text);
            int thismonthColumn = (Convert.ToInt32(month) + 1);
            int thismonth_use = thismonthColumn;
            return thismonth_use;
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
                this.idDisplayed_txt.Text += text;
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
                serialPort1.BaudRate = Convert.ToInt16(baudRate_cbBox.Text);
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
            year_txt.Text = "2022";
            hour_txt.Text = "6";
            minute_txt.Text = "45";
            second_txt.Text = "45";

            comPort_cbBox.DataSource = SerialPort.GetPortNames();
            baudRate_cbBox.SelectedIndex = 3;

            string amWT = "07:00:00";
            DateTime amTime = DateTime.ParseExact(amWT, "HH:mm:ss", null);
            amWorkingTime_txt.Text = amTime.ToString();

            string pmWT = "13:00:00";
            DateTime pmTime = DateTime.ParseExact(pmWT, "HH:mm:ss", null);
            pmWorkingTime_txt.Text = pmTime.ToString();

        }

        //Display Information of a employee
        private void GetAllInformation()
        {
            DataSet data = new DataSet();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from ATTENDANCE where id = @id";
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

        //difine dates-calculated arrays
        string[] datesBefore = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", };
        string[] datesAfter = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", };
        string[] lateDatesAfter = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", };
        string[] lateDatesBefore = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", };
        int[] LastDates = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int[] LastLateDates = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //Main Activity when someone checkin
        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            idDisplayed_txt.Clear();
            DataTable dt = new DataTable();
            DataTable dtLate = new DataTable();
            var emplBUS = new daos.employeeBUS();
            dt = emplBUS.CheckEmp(str_dataFromSerialPort_int64);
            dtLate = emplBUS.CheckLateEmp(str_dataFromSerialPort_int64);
            int count = 0;
            int count4Late = 0;
            int thisMonthRef = VirtualThisMonth();
            int thisMonthRef4Late = VirtualThisMonth4Late();
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    switch (count)
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
                            if (count == thisMonthRef)
                            {
                                LastDates[0] = Convert.ToInt16(datesBefore[0]) + 1;
                            }
                            else
                            {
                                LastDates[0] = Convert.ToInt16(datesBefore[0]);
                            }
                            break;
                        case 7:
                            break;
                        case 8:
                            datesBefore[1] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[1] = Convert.ToInt16(datesBefore[1]) + 1;
                            }
                            else
                            {
                                LastDates[1] = Convert.ToInt16(datesBefore[1]);
                            }
                            break;
                        case 9:
                            break;
                        case 10:
                            datesBefore[2] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[2] = Convert.ToInt16(datesBefore[2]) + 1;
                            }
                            else
                            {
                                LastDates[2] = Convert.ToInt16(datesBefore[2]);
                            }
                            break;
                        case 11:
                            break;
                        case 12:
                            datesBefore[3] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[3] = Convert.ToInt16(datesBefore[3]) + 1;
                            }
                            else
                            {
                                LastDates[3] = Convert.ToInt16(datesBefore[3]);
                            }
                            break;
                        case 13:
                            break;
                        case 14:
                            datesBefore[4] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[4] = Convert.ToInt16(datesBefore[4]) + 1;
                            }
                            else
                            {
                                LastDates[4] = Convert.ToInt16(datesBefore[4]);
                            }
                            break;
                        case 15:
                            break;
                        case 16:
                            datesBefore[5] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[5] = Convert.ToInt16(datesBefore[5]) + 1;
                            }
                            else
                            {
                                LastDates[5] = Convert.ToInt16(datesBefore[5]);
                            }
                            break;
                        case 17:
                            break;
                        case 18:
                            datesBefore[6] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[6] = Convert.ToInt16(datesBefore[6]) + 1;
                            }
                            else
                            {
                                LastDates[6] = Convert.ToInt16(datesBefore[6]);
                            }
                            break;
                        case 19:
                            break;
                        case 20:
                            datesBefore[7] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[7] = Convert.ToInt16(datesBefore[7]) + 1;
                            }
                            else
                            {
                                LastDates[7] = Convert.ToInt16(datesBefore[7]);
                            }
                            break;
                        case 21:
                            break;
                        case 22:
                            datesBefore[8] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[8] = Convert.ToInt16(datesBefore[8]) + 1;
                            }
                            else
                            {
                                LastDates[8] = Convert.ToInt16(datesBefore[8]);
                            }
                            break;
                        case 23:
                            break;
                        case 24:
                            datesBefore[9] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[9] = Convert.ToInt16(datesBefore[9]) + 1;
                            }
                            else
                            {
                                LastDates[9] = Convert.ToInt16(datesBefore[9]);
                            }
                            break;
                        case 25:
                            break;
                        case 26:
                            datesBefore[10] = temp;
                            if (count == thisMonthRef)
                            {
                                LastDates[10] = Convert.ToInt16(datesBefore[10]) + 1;
                            }
                            else
                            {
                                LastDates[10] = Convert.ToInt16(datesBefore[10]);
                            }
                            break;
                        case 27:
                            break;
                        case 28:
                            datesBefore[11] = temp;
                            if(count == thisMonthRef)
                            {
                                LastDates[11] = Convert.ToInt16(datesBefore[11]) + 1;
                            }
                            else
                            {
                                LastDates[11] = Convert.ToInt16(datesBefore[11]);
                            }
                            break;
                    }
                    count++;

                    //Assign data for each month in Attendance table
                    datesAfter[0] = Convert.ToString(LastDates[0]);
                    datesAfter[1] = Convert.ToString(LastDates[1]);
                    datesAfter[2] = Convert.ToString(LastDates[2]);
                    datesAfter[3] = Convert.ToString(LastDates[3]);
                    datesAfter[4] = Convert.ToString(LastDates[4]);
                    datesAfter[5] = Convert.ToString(LastDates[5]);
                    datesAfter[6] = Convert.ToString(LastDates[6]);
                    datesAfter[7] = Convert.ToString(LastDates[7]);
                    datesAfter[8] = Convert.ToString(LastDates[8]);
                    datesAfter[9] = Convert.ToString(LastDates[9]);
                    datesAfter[10] = Convert.ToString(LastDates[10]);
                    datesAfter[11] = Convert.ToString(LastDates[11]);
                }
            }

            foreach (DataRow dataRow in dtLate.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    if((Convert.ToInt32(hour_txt.Text) > 7) || ((Convert.ToInt32(hour_txt.Text) == 7) && (Convert.ToInt32(second_txt.Text) > 0)))
                    {
                        switch (count4Late)
                        {
                            case 0:
                                break;
                            case 1:
                                break;
                            case 2:
                                lateDatesBefore[0] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[0] = Convert.ToInt16(lateDatesBefore[0]) + 1;
                                }
                                else
                                {
                                    LastLateDates[0] = Convert.ToInt16(lateDatesBefore[0]);
                                }
                                break;
                            case 3:
                                lateDatesBefore[1] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[1] = Convert.ToInt16(lateDatesBefore[1]) + 1;
                                }
                                else
                                {
                                    LastLateDates[1] = Convert.ToInt16(lateDatesBefore[1]);
                                }
                                break;
                            case 4:
                                lateDatesBefore[2] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[2] = Convert.ToInt16(lateDatesBefore[2]) + 1;
                                }
                                else
                                {
                                    LastLateDates[2] = Convert.ToInt16(lateDatesBefore[2]);
                                }
                                break;
                            case 5:
                                lateDatesBefore[3] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[3] = Convert.ToInt16(lateDatesBefore[3]) + 1;
                                }
                                else
                                {
                                    LastLateDates[3] = Convert.ToInt16(lateDatesBefore[3]);
                                }
                                break;
                            case 6:
                                lateDatesBefore[4] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[4] = Convert.ToInt16(lateDatesBefore[4]) + 1;
                                }
                                else
                                {
                                    LastLateDates[4] = Convert.ToInt16(lateDatesBefore[4]);
                                }
                                break;
                            case 7:
                                lateDatesBefore[5] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[5] = Convert.ToInt16(lateDatesBefore[5]) + 1;
                                }
                                else
                                {
                                    LastLateDates[5] = Convert.ToInt16(lateDatesBefore[5]);
                                }
                                break;
                            case 8:
                                lateDatesBefore[6] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[6] = Convert.ToInt16(lateDatesBefore[6]) + 1;
                                }
                                else
                                {
                                    LastLateDates[6] = Convert.ToInt16(lateDatesBefore[6]);
                                }
                                break;
                            case 9:
                                lateDatesBefore[7] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[7] = Convert.ToInt16(lateDatesBefore[7]) + 1;
                                }
                                else
                                {
                                    LastLateDates[7] = Convert.ToInt16(lateDatesBefore[7]);
                                }
                                break;
                            case 10:
                                lateDatesBefore[8] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[8] = Convert.ToInt16(lateDatesBefore[8]) + 1;
                                }
                                else
                                {
                                    LastLateDates[8] = Convert.ToInt16(lateDatesBefore[8]);
                                }
                                break;
                            case 11:
                                lateDatesBefore[9] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[9] = Convert.ToInt16(lateDatesBefore[9]) + 1;
                                }
                                else
                                {
                                    LastLateDates[9] = Convert.ToInt16(lateDatesBefore[9]);
                                }
                                break;
                            case 12:
                                lateDatesBefore[10] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[10] = Convert.ToInt16(lateDatesBefore[10]) + 1;
                                }
                                else
                                {
                                    LastLateDates[10] = Convert.ToInt16(lateDatesBefore[10]);
                                }
                                break;
                            case 13:
                                lateDatesBefore[11] = temp;
                                if (count4Late == thisMonthRef4Late)
                                {
                                    LastLateDates[11] = Convert.ToInt16(lateDatesBefore[11]) + 1;
                                }
                                else
                                {
                                    LastLateDates[11] = Convert.ToInt16(lateDatesBefore[11]);
                                }
                                break;
                        }
                        count4Late++;

                        //Assign data for each month in late table
                        lateDatesAfter[0] = Convert.ToString(LastLateDates[0]);
                        lateDatesAfter[1] = Convert.ToString(LastLateDates[1]);
                        lateDatesAfter[2] = Convert.ToString(LastLateDates[2]);
                        lateDatesAfter[3] = Convert.ToString(LastLateDates[3]);
                        lateDatesAfter[4] = Convert.ToString(LastLateDates[4]);
                        lateDatesAfter[5] = Convert.ToString(LastLateDates[5]);
                        lateDatesAfter[6] = Convert.ToString(LastLateDates[6]);
                        lateDatesAfter[7] = Convert.ToString(LastLateDates[7]);
                        lateDatesAfter[8] = Convert.ToString(LastLateDates[8]);
                        lateDatesAfter[9] = Convert.ToString(LastLateDates[9]);
                        lateDatesAfter[10] = Convert.ToString(LastLateDates[10]);
                        lateDatesAfter[11] = Convert.ToString(LastLateDates[11]);
                    }
                }
            }
            emplBUS.attendacne(str_dataFromSerialPort_int64, datesAfter[0], datesAfter[1], datesAfter[2], datesAfter[3], datesAfter[4], datesAfter[5], datesAfter[6], datesAfter[7], datesAfter[8], datesAfter[9], datesAfter[10], datesAfter[11]);
            emplBUS.late(str_dataFromSerialPort_int64, lateDatesAfter[0], lateDatesAfter[1], lateDatesAfter[2], lateDatesAfter[3], lateDatesAfter[4], lateDatesAfter[5], lateDatesAfter[6], lateDatesAfter[7], lateDatesAfter[8], lateDatesAfter[9], lateDatesAfter[10], lateDatesAfter[11]);

            GetAllInformation();
        }

        private void setTime_btn_Click(object sender, EventArgs e)
        {
            timeCheckIn_txt.Text = VirtualTime();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            formManagement openOtherForm = new formManagement();
            this.Hide();
            openOtherForm.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            AboutMe openOtherForm = new AboutMe();
            this.Hide();
            openOtherForm.ShowDialog();
            this.Close();
        }
    }
}
