using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace AGauge_EasyModbus
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            aGauge1.Value = trackBar1.Value;
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(tb_Modbus_Server_IP.Text, 502);    //Ip-Address and Port of Modbus-TCP-Server
                modbusClient.Connect();
                lb_status.Text = "Connected!";
                tmr_Modbus_Com.Enabled = true;
            }
            catch (Exception ex)
            {
                lb_status.Text = ex.ToString();
                throw;
            }
        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            lb_status.Text = "Offline";
            tmr_Modbus_Com.Enabled = false;
        }

        private void tmr_Modbus_Com_Tick(object sender, EventArgs e)
        {
            tmr_Modbus_Com.Enabled = false;

            modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });    //Write Coils starting with Address 5
            bool[] readCoils = modbusClient.ReadCoils(0, 10);                        //Read 10 Coils from Server, starting with address 0
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);    //Read 10 Holding Registers from Server, starting with Address 1

            aGauge1.Value = readHoldingRegisters[0];

            cb_coil_1.Checked = readCoils[0];
            cb_coil_2.Checked = readCoils[1];
            

            tmr_Modbus_Com.Enabled = true;
        }
    }
}
