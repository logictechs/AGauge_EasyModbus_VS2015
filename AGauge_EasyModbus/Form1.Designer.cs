namespace AGauge_EasyModbus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.tb_Modbus_Server_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.tmr_Modbus_Com = new System.Windows.Forms.Timer(this.components);
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.cb_coil_1 = new System.Windows.Forms.CheckBox();
            this.cb_coil_2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(32, 266);
            this.trackBar1.Maximum = 400;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(205, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(263, 75);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(100, 39);
            this.bt_Connect.TabIndex = 2;
            this.bt_Connect.Text = "&Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // tb_Modbus_Server_IP
            // 
            this.tb_Modbus_Server_IP.Location = new System.Drawing.Point(263, 49);
            this.tb_Modbus_Server_IP.Name = "tb_Modbus_Server_IP";
            this.tb_Modbus_Server_IP.Size = new System.Drawing.Size(100, 20);
            this.tb_Modbus_Server_IP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modbus Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connection Status:";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(375, 56);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(37, 13);
            this.lb_status.TabIndex = 6;
            this.lb_status.Text = "Offline";
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Location = new System.Drawing.Point(263, 120);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(100, 37);
            this.bt_Disconnect.TabIndex = 7;
            this.bt_Disconnect.Text = "&Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // tmr_Modbus_Com
            // 
            this.tmr_Modbus_Com.Tick += new System.EventHandler(this.tmr_Modbus_Com_Tick);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(32, 33);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(205, 180);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Value = 0F;
            // 
            // cb_coil_1
            // 
            this.cb_coil_1.AutoSize = true;
            this.cb_coil_1.Location = new System.Drawing.Point(263, 196);
            this.cb_coil_1.Name = "cb_coil_1";
            this.cb_coil_1.Size = new System.Drawing.Size(52, 17);
            this.cb_coil_1.TabIndex = 8;
            this.cb_coil_1.Text = "Coil 1";
            this.cb_coil_1.UseVisualStyleBackColor = true;
            // 
            // cb_coil_2
            // 
            this.cb_coil_2.AutoSize = true;
            this.cb_coil_2.Location = new System.Drawing.Point(263, 219);
            this.cb_coil_2.Name = "cb_coil_2";
            this.cb_coil_2.Size = new System.Drawing.Size(52, 17);
            this.cb_coil_2.TabIndex = 9;
            this.cb_coil_2.Text = "Coil 2";
            this.cb_coil_2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 346);
            this.Controls.Add(this.cb_coil_2);
            this.Controls.Add(this.cb_coil_1);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Modbus_Server_IP);
            this.Controls.Add(this.bt_Connect);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.aGauge1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.TextBox tb_Modbus_Server_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.Timer tmr_Modbus_Com;
        private System.Windows.Forms.CheckBox cb_coil_1;
        private System.Windows.Forms.CheckBox cb_coil_2;
    }
}

