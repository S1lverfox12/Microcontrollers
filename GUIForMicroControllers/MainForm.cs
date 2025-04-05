using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoServoControl
{
    public partial class MainForm : Form
    {
        private SerialPort serialPort;
        private bool isConnected = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeSerialPort();
            InitializeControls();
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void InitializeControls()
        {
            // Инициализация значений для трекбаров
            trackBarA.Minimum = 0;
            trackBarA.Maximum = 120;
            trackBarA.Value = 66;

            trackBarB.Minimum = 30;
            trackBarB.Maximum = 125;
            trackBarB.Value = 90;

            trackBarC.Minimum = 20;
            trackBarC.Maximum = 90;
            trackBarC.Value = 50;

            trackBarD.Minimum = 0;
            trackBarD.Maximum = 120;
            trackBarD.Value = 90;

            trackBarE.Minimum = 10;
            trackBarE.Maximum = 120;
            trackBarE.Value = 120;

            trackBarF.Minimum = 0;
            trackBarF.Maximum = 180;
            trackBarF.Value = 90;

            // Обновление меток с текущими значениями
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lblA.Text = $"A: {trackBarA.Value}°";
            lblB.Text = $"B: {trackBarB.Value}°";
            lblC.Text = $"C: {trackBarC.Value}°";
            lblD.Text = $"D: {trackBarD.Value}°";
            lblE.Text = $"E: {trackBarE.Value}°";
            lblF.Text = $"F: {trackBarF.Value}°";
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            // Выводим данные в лог
            this.Invoke(new Action(() =>
            {
                txtLog.AppendText(data + Environment.NewLine);
                txtLog.ScrollToCaret();
            }));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                try
                {
                    serialPort.PortName = cmbPorts.SelectedItem.ToString();
                    serialPort.Open();
                    isConnected = true;
                    btnConnect.Text = "Отключиться";
                    btnAutoMode.Enabled = true;
                    btnComputerMode.Enabled = true;
                    btnStop.Enabled = true;
                    groupBoxServos.Enabled = true;
                    txtLog.AppendText($"Подключено к {serialPort.PortName}" + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort.Close();
                isConnected = false;
                btnConnect.Text = "Подключиться";
                btnAutoMode.Enabled = false;
                btnComputerMode.Enabled = false;
                btnStop.Enabled = false;
                groupBoxServos.Enabled = false;
                txtLog.AppendText("Отключено" + Environment.NewLine);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Заполняем список доступных COM портов
            cmbPorts.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPorts.Items.Count > 0)
                cmbPorts.SelectedIndex = 0;

            btnAutoMode.Enabled = false;
            btnComputerMode.Enabled = false;
            btnStop.Enabled = false;
            groupBoxServos.Enabled = false;
        }

        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            cmbPorts.Items.Clear();
            cmbPorts.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPorts.Items.Count > 0)
                cmbPorts.SelectedIndex = 0;
        }

        private void btnAutoMode_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                //serialPort.WriteLine("#auto");
                txtLog.AppendText("Включен автоматический режим" + Environment.NewLine);
            }
        }

        private void btnComputerMode_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                //serialPort.WriteLine("#com");
                txtLog.AppendText("Включен режим управления с компьютера" + Environment.NewLine);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                //serialPort.WriteLine("#stop");
                txtLog.AppendText("Режим остановки" + Environment.NewLine);
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (!isConnected) return;

            TrackBar trackBar = sender as TrackBar;
            char servoChar = ' ';

            if (trackBar == trackBarA) servoChar = 'a';
            else if (trackBar == trackBarB) servoChar = 'b';
            else if (trackBar == trackBarC) servoChar = 'c';
            else if (trackBar == trackBarD) servoChar = 'd';
            else if (trackBar == trackBarE) servoChar = 'e';
            else if (trackBar == trackBarF) servoChar = 'f';

            int value = trackBar.Value;
            //serialPort.WriteLine($"{value}{servoChar}");

            UpdateLabels();
        }

        private void btnSetAll_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;

            /*serialPort.WriteLine($"{trackBarA.Value}a");
            serialPort.WriteLine($"{trackBarB.Value}b");
            serialPort.WriteLine($"{trackBarC.Value}c");
            serialPort.WriteLine($"{trackBarD.Value}d");
            serialPort.WriteLine($"{trackBarE.Value}e");
            serialPort.WriteLine($"{trackBarF.Value}f");*/

            txtLog.AppendText($"{trackBarA.Value}a"+ Environment.NewLine);
            txtLog.AppendText($"{trackBarB.Value}b"+ Environment.NewLine);
            txtLog.AppendText($"{trackBarC.Value}c"+ Environment.NewLine);
            txtLog.AppendText($"{trackBarD.Value}d"+ Environment.NewLine);
            txtLog.AppendText($"{trackBarE.Value}e"+ Environment.NewLine);
            txtLog.AppendText($"{trackBarF.Value}f"+ Environment.NewLine);

            UpdateLabels();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trackBarA.Value = 66;
            trackBarB.Value = 90;
            trackBarC.Value = 50;
            trackBarD.Value = 90;
            trackBarE.Value = 120;
            trackBarF.Value = 90;

            if (isConnected)
            {
                btnSetAll_Click(sender, e);
            }
            else
            {
                UpdateLabels();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
            {
                serialPort.Close();
            }
        }
    }
}