using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
 
        private void formManagement_Load(object sender, EventArgs e)
        {
            comPort_cbBox.DataSource = SerialPort.GetPortNames();
            baudRate_cbBox.SelectedIndex = 3;
        }

    }
}
