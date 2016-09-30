using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GPS_NMEA_PARSER {
    public partial class gps_nmea : Form {

        // Array used to store available baud rates
        public int[] baud_rates = { 9600, 115200 };

        public gps_nmea() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // On form load, get a list of the open COMM port
            string[] comm_ports = SerialPort.GetPortNames();
            
            // Checking that there are open ports!
            if (comm_ports.Length > 0) {
                // There are open ports
                foreach (string port in comm_ports) {
                    gps_device_comb.Items.Add(port);
                }

            } else {
                // There are no ports!
                gps_device_comb.Items.Add("No open ports!");
            }

            // Populate the baud rate comm box
            foreach (int rate in baud_rates) {
                gps_baud_comb.Items.Add(rate.ToString());
            }

        }


        // Custom class used to manage the connection and also provide feedback on the connection status
        public class gps_dev_con {
            // Creating the class variables
            public bool gps_dev_conn_status { get; set; }

            // Creating a new serial gateway
            SerialPort gps_serial_gateway = new SerialPort();
            
            // Function used to actually connect
            public void connect_to_device(string comm_port, int baud_rate) {

                // Not already in use, attempt to connect
                gps_serial_gateway.PortName = comm_port;
                gps_serial_gateway.BaudRate = baud_rate;

                // Checking if the port is already in use
                if (!gps_serial_gateway.IsOpen) {

                    // Attempting the connection
                    try {

                        // Opening the port
                        gps_serial_gateway.Open();
                        // Alerting the user!
                        MessageBox.Show("Connected!");
                        // We got this far, something went right!
                        this.gps_dev_conn_status = true;

                    } catch (Exception e) {
                        // Something went wrong!
                        this.gps_dev_conn_status = false;
                        MessageBox.Show(e.Data.ToString());
                    }

                } else {
                    // Already in use
                    MessageBox.Show("Serial port is already in use!");
                }

            }

            // Used to disconnect from the serial port
            public void disconnect() {
                try {
                    // Closing the connection
                    gps_serial_gateway.Close();
                    this.gps_dev_conn_status = false;
                    MessageBox.Show("Failed to close connection!");
                } catch (Exception e) {
                    MessageBox.Show(e.Data.ToString());
                }
            }

        }

        // GPS Connect button press
        private void gps_connect_btn_Click(object sender, EventArgs e) {

            // Disabling the button
            gps_connect_btn.Enabled = false;

            // Getting the connection details
            string comm_port = gps_device_comb.SelectedItem.ToString();
            string baud_rate_raw = gps_baud_comb.SelectedItem.ToString();
            int baud_rate;

            // Parsing the baud rate as an integer
            int.TryParse(baud_rate_raw, out baud_rate);

            // Starting the connection
            gps_dev_con gps_device_connection = new gps_dev_con();
            gps_device_connection.connect_to_device(comm_port, baud_rate);

            // Checking the connection status
            if (!gps_device_connection.gps_dev_conn_status) {
                gps_connect_btn.Enabled = true;
            }

        }

        private void gps_disconnect_btn_Click(object sender, EventArgs e) {
            gps_dev_con gps_device_connection = new gps_dev_con();
            gps_device_connection.disconnect();
        }
    }
}
