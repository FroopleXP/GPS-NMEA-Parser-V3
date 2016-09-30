namespace GPS_NMEA_PARSER {
    partial class gps_nmea {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gps_nmea));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gps_device_comb = new System.Windows.Forms.ComboBox();
            this.gps_baud_comb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gps_disconnect_btn = new System.Windows.Forms.Button();
            this.gps_connect_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gps_connect_btn);
            this.groupBox1.Controls.Add(this.gps_disconnect_btn);
            this.groupBox1.Controls.Add(this.gps_device_comb);
            this.groupBox1.Controls.Add(this.gps_baud_comb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to GPS device";
            // 
            // gps_device_comb
            // 
            this.gps_device_comb.FormattingEnabled = true;
            this.gps_device_comb.Location = new System.Drawing.Point(13, 39);
            this.gps_device_comb.Name = "gps_device_comb";
            this.gps_device_comb.Size = new System.Drawing.Size(174, 21);
            this.gps_device_comb.TabIndex = 1;
            // 
            // gps_baud_comb
            // 
            this.gps_baud_comb.FormattingEnabled = true;
            this.gps_baud_comb.Location = new System.Drawing.Point(13, 84);
            this.gps_baud_comb.Name = "gps_baud_comb";
            this.gps_baud_comb.Size = new System.Drawing.Size(174, 21);
            this.gps_baud_comb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select GPS Device";
            // 
            // gps_disconnect_btn
            // 
            this.gps_disconnect_btn.Location = new System.Drawing.Point(102, 111);
            this.gps_disconnect_btn.Name = "gps_disconnect_btn";
            this.gps_disconnect_btn.Size = new System.Drawing.Size(85, 23);
            this.gps_disconnect_btn.TabIndex = 2;
            this.gps_disconnect_btn.Text = "Disconnect";
            this.gps_disconnect_btn.UseVisualStyleBackColor = true;
            this.gps_disconnect_btn.Click += new System.EventHandler(this.gps_disconnect_btn_Click);
            // 
            // gps_connect_btn
            // 
            this.gps_connect_btn.Location = new System.Drawing.Point(13, 112);
            this.gps_connect_btn.Name = "gps_connect_btn";
            this.gps_connect_btn.Size = new System.Drawing.Size(83, 23);
            this.gps_connect_btn.TabIndex = 1;
            this.gps_connect_btn.Text = "Connect";
            this.gps_connect_btn.UseVisualStyleBackColor = true;
            this.gps_connect_btn.Click += new System.EventHandler(this.gps_connect_btn_Click);
            // 
            // gps_nmea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gps_nmea";
            this.Text = "GPS NMEA Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox gps_device_comb;
        private System.Windows.Forms.ComboBox gps_baud_comb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gps_connect_btn;
        private System.Windows.Forms.Button gps_disconnect_btn;
    }
}

