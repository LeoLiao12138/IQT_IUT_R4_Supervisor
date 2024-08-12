using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace IQT_IUT_R4_Supervisor
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        string command_type = "user";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            // 清空ComboBox中的现有项
            com_num.Items.Clear();
            // 将串口列表添加到ComboBox中
            com_num.Items.AddRange(ports);
            // 设置默认选中第一个串口
            if (com_num.Items.Count > 0)
            {
                com_num.SelectedIndex = 0;
            }

            string[] parameters = { "CT","PT","QV","TA" };
            Parameter.Items.Clear();
            Parameter.Items.AddRange(parameters);
            if(Parameter.Items.Count >0)
            {
                Parameter.SelectedIndex = 0;
            }
        }

        private StringBuilder HextoASCIItoByte(string inputString)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(inputString);

            // 将字节数组转换为16进制字符串
            StringBuilder hexString = new StringBuilder();
            foreach (byte b in asciiBytes)
            {
                hexString.AppendFormat("{0:X2}", b);
            }
            return hexString;
        }

        private byte[] HexStringToBytes(string hexString)
        {
            hexString = hexString.Replace(" ", ""); // 去除空格
            int numberChars = hexString.Length / 2;
            byte[] bytes = new byte[numberChars];
            using (var sr = new StringReader(hexString))
            {
                for (int i = 0; i < numberChars; i++)
                {
                    bytes[i] = Convert.ToByte(new string(new char[2] { (char)sr.Read(), (char)sr.Read() }), 16);
                    Console.WriteLine(bytes[i]);
                }
            }
            return bytes;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = com_num.SelectedItem.ToString();  // 替换为你的串口号，例如 COM3
                    serialPort.BaudRate = 38400;   // 波特率
                    serialPort.DataBits = 8;      // 数据位
                    serialPort.Parity = Parity.Even;   // 校验位
                    serialPort.StopBits = StopBits.One; // 停止位
                    serialPort.Open();
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    connect_button.Enabled = false;
                    disconnect_button.Enabled = true;
                    SR_button.Enabled = true;
                    SW_button.Enabled = true;
                    ER_button.Enabled = true;
                    EW_button.Enabled = true;
                    ES_button.Enabled = true;
                    SS_button.Enabled = true;
                    SP_button.Enabled = true;
                    QU_button.Enabled = true;
                    EPC_QU_button.Enabled = true;
                    read_parameter_button.Enabled = true;
                    write_parameter_button.Enabled = true;
                    MessageBox.Show("串口打开成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开串口失败：" + ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] buffer = new byte[sp.BytesToRead];
            sp.Read(buffer, 0, buffer.Length);
            string response = BitConverter.ToString(buffer).Replace("-", " ");
            //string response = Encoding.ASCII.GetString(buffer);
            if (buffer.Length != 0)
            {
                this.Invoke(new Action(() =>
                {
                    receive_data.Text = response;
                    switch (command_type)
                    {
                        case "user":
                            if (buffer[0] == 0x30)
                            {
                                byte[] user_data = new byte[buffer.Length - 3];
                                Array.Copy(buffer, 1, user_data, 0, buffer.Length - 3);
                                if (Hex_select.Checked == true)
                                {
                                    user_read_data.Text = BitConverter.ToString(user_data).Replace("-", " ");
                                }
                                else
                                {
                                    user_read_data.Text = Encoding.ASCII.GetString(user_data);

                                }
                            }
                            else if (buffer[0] == 0x35)
                            {
                                user_read_data.Text = "no tag";
                            }
                            
                            else if(buffer[0] == 0x41)
                                {
                                user_read_data.Text = "there are more than one tag";
                            }
                            break;
                        case "epc":
                            if (buffer[0] == 0x30)
                            {
                                byte[] user_data = new byte[buffer.Length - 3];
                                Array.Copy(buffer, 1, user_data, 0, buffer.Length - 3);
                                EPC_read_data.Text = BitConverter.ToString(user_data).Replace("-", " ");
                            }
                            else if (buffer[0] == 0x35)
                            {
                                EPC_read_data.Text = "no tag";
                            }
                            else if (buffer[0] == 0x41)
                            {
                                EPC_read_data.Text = "there are more than one tag";
                            }
                            break;
                        case "parameter":
                            if (buffer[0] == 0x30)
                            {
                                byte[] user_data = new byte[buffer.Length - 3];
                                Array.Copy(buffer, 1, user_data, 0, buffer.Length - 3);
                                paramete_inout.Text = BitConverter.ToString(user_data).Replace("-", " ");
                            }
                            else if (buffer[0] == 0x35)
                            {
                                paramete_inout.Text = "no tag";
                            }
                            break;
                        default:
                            break;
                    }
                }));
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    connect_button.Enabled = true;
                    disconnect_button.Enabled = false;
                    SR_button.Enabled = false;
                    SW_button.Enabled = false;
                    ER_button.Enabled = false;
                    EW_button.Enabled = false;
                    ES_button.Enabled = false;
                    SS_button.Enabled = false;
                    SP_button.Enabled = false;
                    QU_button.Enabled = false;
                    EPC_QU_button.Enabled = false;
                    read_parameter_button.Enabled = false;
                    write_parameter_button.Enabled = false;
                    MessageBox.Show("串口已关闭");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("关闭串口失败：" + ex.Message);
            }
        }

        private void SR_button_Click(object sender, EventArgs e)
        {
            string address_text = address.Text;
            string word_num = wordnum.Text;
            string hexString = "53 52"+ HextoASCIItoByte(address_text).ToString() + HextoASCIItoByte(word_num).ToString() +"23 0D"; // 对应ASCII码为"123"
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-"," ");
            command_type = "user";
        }
        
        private void QU_Click(object sender, EventArgs e)
        {
            string hexString = "51 55 23 0D" ; 
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "user";
        }

        private void SW_button_Click(object sender, EventArgs e)
        {
            string address_text = address.Text;
            string word_num = wordnum.Text;
            string data = this.user_write_data.Text;
            string hexString;
            if (Hex_select.Checked ==true)
            {
                hexString = "53 57" + HextoASCIItoByte(address_text).ToString() + HextoASCIItoByte(word_num).ToString() + data + "23 0D";

            }
            else
            {
                hexString = "53 57" + HextoASCIItoByte(address_text).ToString() + HextoASCIItoByte(word_num).ToString() + HextoASCIItoByte(data).ToString() + "23 0D";
            }
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "user";
        }

        private void ER_Click(object sender, EventArgs e)
        {
            string address_text = address.Text;
            string word_num = wordnum.Text;
            string data = this.send_data.Text;
            string hexString = "45 52" + HextoASCIItoByte(address_text).ToString() + HextoASCIItoByte(word_num).ToString() + "23 0D";
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "user";

        }

        private void EW_button_Click(object sender, EventArgs e)
        {
            string address_text = address.Text;
            string word_num = wordnum.Text;
            string data = this.user_write_data.Text;
            string hexString;
            if (Hex_select.Checked == true)
            {
                hexString = "45 57" + HextoASCIItoByte(address_text).ToString() + HextoASCIItoByte(word_num).ToString() + data.Replace(" ", "") + "23 0D";
            }
            else
            {
                hexString = "45 57" + HextoASCIItoByte(address_text).ToString() + HextoASCIItoByte(word_num).ToString() + HextoASCIItoByte(data).ToString() + "23 0D";

            }
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "user";
        }

        private void read_parameter_button_Click(object sender, EventArgs e)
        {
            string command = Parameter.SelectedItem.ToString();
            Console.WriteLine(command);
            byte[] bytes = {};
            switch (command)
            {
                case "CT":
                    break;

                case "PT":
                    string PT_hexString = "52 50 55 50 54 00 00 23 0D";
                    Console.WriteLine(PT_hexString);
                    bytes = HexStringToBytes(PT_hexString);
                    break;

                case "QV":
                    string QV_hexString = "52 50 55 51 56 00 00 23 0D";
                    Console.WriteLine(QV_hexString);
                    bytes = HexStringToBytes(QV_hexString);                    

                    break;

                case "TA":
                    string TA_hexString = "52 50 55 54 41 00 00 23 0D";
                    Console.WriteLine(TA_hexString);
                    bytes = HexStringToBytes(TA_hexString);

                    break;

                default:
                    Console.WriteLine("defalut");
                    break;
                    
            }
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "parameter";
        }

        private void write_parameter_button_Click(object sender, EventArgs e)
        {
            string command = Parameter.SelectedItem.ToString();
            byte[] bytes = { };
            switch (command)
            {
                case "CT":
                    string tag_type = paramete_inout.Text;
                    string CT_hexString = "43 54 " + tag_type + " 23 0D";
                    Console.WriteLine(CT_hexString);
                    bytes = HexStringToBytes(CT_hexString);
                    break;

                case "PT":
                    string PT_para = paramete_inout.Text;
                    string PT_hexString = "57 50 55 50 54 00 02 00 "+ PT_para+" 23 0D";
                    Console.WriteLine(PT_hexString);
                    bytes = HexStringToBytes(PT_hexString);
                    break;

                case "QV":
                    string QV_para = paramete_inout.Text;
                    string QV_hexString = " 57 50 55 51 56 00 01 "+QV_para.ToString()+" 23 0D";
                    Console.WriteLine(QV_hexString);
                    bytes = HexStringToBytes(QV_hexString);
                    break;

                case "TA":
                    string TA_para = paramete_inout.Text;
                    string TA_hexString = "57 50 55 54 41 00 01 "+TA_para+" 23 0D";
                    Console.WriteLine(TA_hexString);
                    bytes = HexStringToBytes(TA_hexString);
                    break;
            }
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "parameter";
        }

        private void SS_button_Click(object sender, EventArgs e)
        {
            string hexString = "53 53 30 23 0D"; // 对应ASCII码为"123"
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "epc";
        }

        private void ES_button_Click(object sender, EventArgs e)
        {
            string hexString = "45 53 30 23 0D"; 
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "epc";
        }

        private void EPC_QU_button_Click(object sender, EventArgs e)
        {
            string hexString = "51 55 23 0D";
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "epc";
        }

        private void SP_button_Click(object sender, EventArgs e)
        {
            string epc_data = EPC_write_data.Text;
            string hexString = "53 50 45 " +epc_data+" 23 0D";
            Console.WriteLine(hexString);
            byte[] bytes = HexStringToBytes(hexString);
            serialPort.Write(bytes, 0, bytes.Length);
            send_data.Text = BitConverter.ToString(bytes).Replace("-", " ");
            command_type = "epc";
        }

        private void EP_button_Click(object sender, EventArgs e)
        {

        }

        private void usr_receive_data_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
