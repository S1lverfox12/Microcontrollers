namespace ArduinoServoControl
{
    partial class MainForm
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
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBoxModes = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnComputerMode = new System.Windows.Forms.Button();
            this.btnAutoMode = new System.Windows.Forms.Button();
            this.groupBoxServos = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSetAll = new System.Windows.Forms.Button();
            this.lblF = new System.Windows.Forms.Label();
            this.trackBarF = new System.Windows.Forms.TrackBar();
            this.lblE = new System.Windows.Forms.Label();
            this.trackBarE = new System.Windows.Forms.TrackBar();
            this.lblD = new System.Windows.Forms.Label();
            this.trackBarD = new System.Windows.Forms.TrackBar();
            this.lblC = new System.Windows.Forms.Label();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.lblB = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.lblA = new System.Windows.Forms.Label();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxModes.SuspendLayout();
            this.groupBoxServos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            this.groupBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.btnRefreshPorts);
            this.groupBoxConnection.Controls.Add(this.cmbPorts);
            this.groupBoxConnection.Controls.Add(this.btnConnect);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(300, 80);
            this.groupBoxConnection.TabIndex = 0;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Подключение";
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(6, 48);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshPorts.TabIndex = 2;
            this.btnRefreshPorts.Text = "Обновить";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(6, 19);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbPorts.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(133, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBoxModes
            // 
            this.groupBoxModes.Controls.Add(this.btnStop);
            this.groupBoxModes.Controls.Add(this.btnComputerMode);
            this.groupBoxModes.Controls.Add(this.btnAutoMode);
            this.groupBoxModes.Location = new System.Drawing.Point(318, 12);
            this.groupBoxModes.Name = "groupBoxModes";
            this.groupBoxModes.Size = new System.Drawing.Size(300, 80);
            this.groupBoxModes.TabIndex = 1;
            this.groupBoxModes.TabStop = false;
            this.groupBoxModes.Text = "Режимы работы";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(204, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 50);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnComputerMode
            // 
            this.btnComputerMode.Enabled = false;
            this.btnComputerMode.Location = new System.Drawing.Point(105, 19);
            this.btnComputerMode.Name = "btnComputerMode";
            this.btnComputerMode.Size = new System.Drawing.Size(90, 50);
            this.btnComputerMode.TabIndex = 1;
            this.btnComputerMode.Text = "Управление с ПК";
            this.btnComputerMode.UseVisualStyleBackColor = true;
            this.btnComputerMode.Click += new System.EventHandler(this.btnComputerMode_Click);
            // 
            // btnAutoMode
            // 
            this.btnAutoMode.Enabled = false;
            this.btnAutoMode.Location = new System.Drawing.Point(6, 19);
            this.btnAutoMode.Name = "btnAutoMode";
            this.btnAutoMode.Size = new System.Drawing.Size(90, 50);
            this.btnAutoMode.TabIndex = 0;
            this.btnAutoMode.Text = "Авто режим";
            this.btnAutoMode.UseVisualStyleBackColor = true;
            this.btnAutoMode.Click += new System.EventHandler(this.btnAutoMode_Click);
            // 
            // groupBoxServos
            // 
            this.groupBoxServos.Controls.Add(this.btnReset);
            this.groupBoxServos.Controls.Add(this.btnSetAll);
            this.groupBoxServos.Controls.Add(this.lblF);
            this.groupBoxServos.Controls.Add(this.trackBarF);
            this.groupBoxServos.Controls.Add(this.lblE);
            this.groupBoxServos.Controls.Add(this.trackBarE);
            this.groupBoxServos.Controls.Add(this.lblD);
            this.groupBoxServos.Controls.Add(this.trackBarD);
            this.groupBoxServos.Controls.Add(this.lblC);
            this.groupBoxServos.Controls.Add(this.trackBarC);
            this.groupBoxServos.Controls.Add(this.lblB);
            this.groupBoxServos.Controls.Add(this.trackBarB);
            this.groupBoxServos.Controls.Add(this.lblA);
            this.groupBoxServos.Controls.Add(this.trackBarA);
            this.groupBoxServos.Enabled = false;
            this.groupBoxServos.Location = new System.Drawing.Point(12, 98);
            this.groupBoxServos.Name = "groupBoxServos";
            this.groupBoxServos.Size = new System.Drawing.Size(606, 300);
            this.groupBoxServos.TabIndex = 2;
            this.groupBoxServos.TabStop = false;
            this.groupBoxServos.Text = "Управление сервоприводами";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(525, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetAll
            // 
            this.btnSetAll.Location = new System.Drawing.Point(525, 48);
            this.btnSetAll.Name = "btnSetAll";
            this.btnSetAll.Size = new System.Drawing.Size(75, 23);
            this.btnSetAll.TabIndex = 12;
            this.btnSetAll.Text = "Применить";
            this.btnSetAll.UseVisualStyleBackColor = true;
            this.btnSetAll.Click += new System.EventHandler(this.btnSetAll_Click);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(6, 250);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(28, 13);
            this.lblF.TabIndex = 11;
            this.lblF.Text = "F: 0°";
            // 
            // trackBarF
            // 
            this.trackBarF.Location = new System.Drawing.Point(6, 266);
            this.trackBarF.Name = "trackBarF";
            this.trackBarF.Size = new System.Drawing.Size(513, 45);
            this.trackBarF.TabIndex = 10;
            this.trackBarF.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(6, 210);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(28, 13);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "E: 0°";
            // 
            // trackBarE
            this.trackBarE.Location = new System.Drawing.Point(6, 226);
            this.trackBarE.Name = "trackBarE";
            this.trackBarE.Size = new System.Drawing.Size(513, 225);
            this.trackBarE.TabIndex = 8;
            this.trackBarE.Scroll += new System.EventHandler(this.trackBar_Scroll);
            //
            // lblD
            //
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(6, 170);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(29, 13);
            this.lblD.TabIndex = 7;
            this.lblD.Text = "D: 0°";
            //
            // trackBarD
            //
            this.trackBarD.Location = new System.Drawing.Point(6, 186);
            this.trackBarD.Name = "trackBarD";
            this.trackBarD.Size = new System.Drawing.Size(513, 45);
            this.trackBarD.TabIndex = 6;
            this.trackBarD.Scroll += new System.EventHandler(this.trackBar_Scroll);
            //
            // lblC
            //
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(6, 130);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(28, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C: 0°";
            //
            // trackBarC
            //
            this.trackBarC.Location = new System.Drawing.Point(6, 146);
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(513, 45);
            this.trackBarC.TabIndex = 4;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBar_Scroll);
            //
            // lblB
            //
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(6, 90);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(28, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B: 0°";
            //
            // trackBarB
            //
            this.trackBarB.Location = new System.Drawing.Point(6, 106);
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(513, 45);
            this.trackBarB.TabIndex = 2;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBar_Scroll);
            //
            // lblA
            //
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(6, 50);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(28, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A: 0°";
            //
            // trackBarA
            //
            this.trackBarA.Location = new System.Drawing.Point(6, 66);
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(513, 45);
            this.trackBarA.TabIndex = 0;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBar_Scroll);
            //
            // groupBoxLog
            //
            this.groupBoxLog.Controls.Add(this.txtLog);
            this.groupBoxLog.Location = new System.Drawing.Point(12, 404);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(606, 146);
            this.groupBoxLog.TabIndex = 3;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Лог";
            //
            // txtLog
            //
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(600, 127);
            this.txtLog.TabIndex = 0;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 562);
            this.Controls.Add(this.groupBoxLog);
            this.Controls.Add(this.groupBoxServos);
            this.Controls.Add(this.groupBoxModes);
            this.Controls.Add(this.groupBoxConnection);
            this.Name = "MainForm";
            this.Text = "Управление сервоприводами Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxModes.ResumeLayout(false);
            this.groupBoxServos.ResumeLayout(false);
            this.groupBoxServos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBoxModes;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnComputerMode;
        private System.Windows.Forms.Button btnAutoMode;
        private System.Windows.Forms.GroupBox groupBoxServos;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.TrackBar trackBarF;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TrackBar trackBarE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TrackBar trackBarD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnSetAll;
        private System.Windows.Forms.Button btnReset;
    }
}

