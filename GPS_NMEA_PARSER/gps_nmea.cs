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

        }

    }
}
