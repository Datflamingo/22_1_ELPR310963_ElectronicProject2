﻿using DA2_CHAM_CONG.daos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DA2_CHAM_CONG.Forms
{
    public partial class formManagement : Form
    {
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        public formManagement()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            baudRate_cbBox.Items.AddRange(BaudRate);
            string[] month_cb = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            month_cbBox.Items.AddRange(month_cb);
        }

        //Connect to Arduino
        //Recieve Data

        String str_dataFromSerialPort_int64 = "";
        long ID;

        private void SetText(string text)
        {

            if (this.id1_txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                str_dataFromSerialPort_int64 = InputData;
                ID = Convert.ToInt64(str_dataFromSerialPort_int64);
                this.id1_txt.Text += text;
                id2_txt.Text = id1_txt.Text;
                id3_txt.Text = id1_txt.Text;
                id4_txt.Text = id1_txt.Text;
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
 
        private void formManagement_Load(object sender, EventArgs e)
        {
            comPort_cbBox.DataSource = SerialPort.GetPortNames();
            baudRate_cbBox.SelectedIndex = 3;
            month_cbBox.SelectedIndex = 0;
        }

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
                            this.dataGridView1.DataSource = dt;
                            this.dataGridView2.DataSource = dt;
                            this.dataGridView3.DataSource = dt;
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


        private void ADD_btn_Click(object sender, EventArgs e)
        {
            var emplBUS = new daos.employeeBUS();
            emplBUS.addEmp(id1_txt.Text, name1_txt.Text, phone1_txt.Text, email1_txt.Text, "14000000");
            id1_txt.Clear();
            id2_txt.Clear();
            id3_txt.Clear();
            id4_txt.Clear();
            name1_txt.Clear();
            phone1_txt.Clear();
            email1_txt.Clear();
            GetAllInformation();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            var emplBUS = new daos.employeeBUS();
            emplBUS.removeEmp(id2_txt.Text);
            id1_txt.Clear();
            id2_txt.Clear();
            id3_txt.Clear();
            id4_txt.Clear();
            GetAllInformation();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Do you want to edit this employee?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                var emplBUS = new daos.employeeBUS();
                emplBUS.addEmp(id2_txt.Text, name2_txt.Text, phone2_txt.Text, email2_txt.Text, "14000000");
                id1_txt.Clear();
                id2_txt.Clear();
                id3_txt.Clear();
                id4_txt.Clear();
                name2_txt.Clear();
                phone2_txt.Clear();
                email2_txt.Clear();
                GetAllInformation();
            }
        }

        private void checkid2_txt_Click(object sender, EventArgs e)
        {
            id1_txt.Clear();
            id3_txt.Clear();
            id4_txt.Clear();
            DataTable dt = new DataTable();
            var emplBUS = new daos.employeeBUS();
            dt = emplBUS.CheckEmp(id2_txt.Text);
            int i = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    switch (i)
                    {
                        case 0:
                            break;
                        case 1:
                            name2_txt.Text = temp;
                            break;
                        case 2:
                            phone2_txt.Text = temp;
                            break;
                        case 3:
                            email2_txt.Text = temp;
                            break;
                    }
                    i++;
                }
            }
            GetAllInformation();
        }

        private void checkid3_txt_Click(object sender, EventArgs e)
        {
            id1_txt.Clear();
            id2_txt.Clear();
            id4_txt.Clear();
            DataTable dt = new DataTable();
            var emplBUS = new daos.employeeBUS();
            dt = emplBUS.CheckEmp(id3_txt.Text);
            int i = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    switch (i)
                    {
                        case 0:
                            break;
                        case 1:
                            name3_txt.Text = temp;
                            break;
                        case 2:
                            phone3_txt.Text = temp;
                            break;
                        case 3:
                            email3_txt.Text = temp;
                            break;
                    }
                    i++;
                }
            }
            GetAllInformation();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            formMain openOtherForm = new formMain();
            this.Hide();
            openOtherForm.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            AboutMe openOtherForm = new AboutMe();
            this.Hide();
            openOtherForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id5_txt.Clear();
            name4_txt.Clear();
            phone4_txt.Clear();
            email4_txt.Clear();
            DataTable dt = new DataTable();
            DataTable dtLate = new DataTable();
            var emplBUS = new daos.employeeBUS();
            dt = emplBUS.CheckEmp(id4_txt.Text);
            dtLate = emplBUS.CheckLateEmp(id4_txt.Text);
            int count = 0;
            int count4Late = 0;
            int monthSelected = Convert.ToInt32(month_cbBox.Text);
            int monthColumn = (((monthSelected - 1) * 2) + 6);
            int monthColumn4Late = monthSelected + 1;
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    switch (count)
                    {
                        case 0:
                            id5_txt.Text = temp;
                            break;
                        case 1:
                            name4_txt.Text = temp;
                            break;
                        case 2:
                            phone4_txt.Text = temp;
                            break;
                        case 3:
                            email4_txt.Text = temp;
                            break;
                        case 4:
                            baseSalary_txt.Text = temp;
                            break;
                        case 5:
                            break;
                        case 6:
                            if(count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 7:
                            break;
                        case 8:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 9:
                            break;
                        case 10:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 11:
                            break;
                        case 12:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 13:
                            break;
                        case 14:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 15:
                            break;
                        case 16:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 17:
                            break;
                        case 18:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 19:
                            break;
                        case 20:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 21:
                            break;
                        case 22:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 23:
                            break;
                        case 24:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 25:
                            break;
                        case 26:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 27:
                            break;
                        case 28:
                            if (count == monthColumn)
                            {
                                dayOfMonth_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                    }
                    count++;
                }

            }

            foreach (DataRow dataRow in dtLate.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    switch (count4Late)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 3:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 4:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 5:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 6:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 7:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 8:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 9:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 10:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 11:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 12:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;
                        case 13:
                            if (count4Late == monthColumn4Late)
                            {
                                Late_txt.Text = temp;
                            }
                            else
                            {
                            }
                            break;

                    }
                    count4Late++;
                }
            }
            id1_txt.Clear();
            id2_txt.Clear();
            id3_txt.Clear();
            id4_txt.Clear();

        }


    }
}
