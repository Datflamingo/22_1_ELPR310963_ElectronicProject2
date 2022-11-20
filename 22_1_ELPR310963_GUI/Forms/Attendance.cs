using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DA2_CHAM_CONG
{
    public partial class Attendance : Form
    {
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        public Attendance()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox2.Items.AddRange(BaudRate);
        }
        public string Day()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 2);
            return str;
        }

        public string Month()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(3, 2);
            return str;
        }

        public string Year()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(6, 4);
            return str;
        }

        public string Time()
        {
            string str = DateTime.Now.ToString().Trim();
            string str_day = str.Substring(0, 2);
            string str_month = str.Substring(3, 2);
            string str_year = str.Substring(6, 4);
            string str_hour = str.Substring(11, 2);
            string str_minute = str.Substring(14, 2);
            string str_second = str.Substring(17, 2);
            return str_day + '/' + str_month + '/' + str_year + ' ' + str_hour + ':' + str_minute + ':' + str_second;
        }

        String str_dataFromSerialPort_int64 = "";
        long ID;

        private void SetText(string text)
        {

            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                    str_dataFromSerialPort_int64 = InputData;
                    ID = Convert.ToInt64(str_dataFromSerialPort_int64);
                    this.txt_ID.Text += text;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
            comboBox2.SelectedIndex = 3;
            textBox1.Text = Day();
            textBox2.Text = Month();
            textBox3.Text = Year();
            string a = "07:00:00";
            DateTime dat12 = DateTime.ParseExact(a, "HH:mm:ss", null);
            txt_7h.Text = dat12.ToString();
            textBox4.Text = dat12.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
                textBox1.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            txt_timeCheckedIn.Text = Time();
        }

       


    }
}
