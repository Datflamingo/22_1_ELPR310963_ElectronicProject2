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
                            this.dataGridView4.DataSource = dt;
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
            name1_txt.Clear();
            phone1_txt.Clear();
            email1_txt.Clear();
            GetAllInformation();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            var emplBUS = new daos.employeeBUS();
            emplBUS.removeEmp(id2_txt.Text);
            id3_txt.Clear();
            GetAllInformation();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Do you want to edit this employee?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                var emplBUS = new daos.employeeBUS();
                emplBUS.addEmp(id2_txt.Text, name2_txt.Text, phone2_txt.Text, email2_txt.Text, "14000000");
                id2_txt.Clear();
                name2_txt.Clear();
                phone2_txt.Clear();
                email2_txt.Clear();
                GetAllInformation();
            }
        }

        private void checkid2_txt_Click(object sender, EventArgs e)
        {
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

    }
}
