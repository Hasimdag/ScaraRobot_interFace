using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Robtek_V1._1
{
    public partial class KontrolForm : Form
    {
        private Timer timer;
        private String port_Number;
        bool staus = false;

        private SerialPort serialPort1;
        private bool connectionLostNotified = false;

        public KontrolForm()
        {
            InitializeComponent();
            InitializeTimer();
            this.DoubleBuffered = true;
            serialPort1 = SerialPortSingleton.GetInstance().GetSerialPort();

        }

        public string RobotModelLabelContent
        {
            get { return robot_model_label.Text; }
        }

        private void KontrolForm_Load(object sender, EventArgs e)
        {
            CheckArduinoPort();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 500; // Her 0.5 saniyede bir çalışacak (500 milisaniye)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            CheckArduinoPort();
           

        }




        private void CheckArduinoPort()
        {
            string arduinoPort = GetArduinoPort();
            if (!string.IsNullOrEmpty(arduinoPort))
            {
                port_gösterge.Text = "Port: " + arduinoPort;
                port_Number = arduinoPort;
                connectionLostNotified = false;
            }
            else
            {
                port_gösterge.Text = "Port: ";
                port_Number = "";
                
                    serialPort1.Close();
                    connect_button.Text = "BAĞLAN";
                    durum_label_text.Text = "Bağlı Değil";
                    robot_model_label.Text = "Model Bulunamadı.";
                   
                    connect_button.FillColor = Color.FromArgb(0, 126, 249);
                
                
                if (!connectionLostNotified)
                {
                    AddTextWithBullet("Bağlantı kesildi. Kablo çıkarıldı.");
                    connectionLostNotified = true; // Mesaj gösterildikten sonra bayrağı ayarla
                }
            }
        }

        private string GetArduinoPort()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%'");
                foreach (ManagementObject obj in searcher.Get())
                {
                    string description = obj["Caption"].ToString();
                    if (description.Contains("Arduino") || description.Contains("CH340"))
                    {
                        int startIndex = description.IndexOf("(COM") + 1;
                        int endIndex = description.IndexOf(")", startIndex);
                        return description.Substring(startIndex, endIndex - startIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            return null;
        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            connect_button.Visible = false;
            connect_progresbar.Visible = true;

            await Task.Delay(3000);
            try
            {
                if (connect_button.Text == "BAĞLAN")
                {
                    if (!string.IsNullOrEmpty(port_Number))
                    {
                        try
                        {

                            serialPort1.PortName = port_Number;
                            serialPort1.BaudRate = 115200;

                            serialPort1.Open();

                            if (serialPort1.IsOpen)
                            {

                                durum_label_text.Text = "Bağlı";
                                AddTextWithBullet("Bağlantı kuruldu.");
                                connect_button.Text = "Bağlantıyı Kes";
                                connect_button.FillColor = Color.Green;

                                await Task.Delay(3000);
                                await CallModel();

                            }




                        }
                        catch (Exception ex)
                        {
                            AddTextWithBullet("Bağlantı kurulamadı: " + ex.Message);
                            durum_label_text.Text = "Bağlı Değil";

                            if (serialPort1.IsOpen)
                            {
                                serialPort1.Close();
                                robot_model_label.Text = "Model Bulunamadı.";
                            }
                           
                        }
                    }
                    else
                    {
                        AddTextWithBullet("Bağlantı kurulamadı: Port numarası geçersiz.");
                        durum_label_text.Text = "Bağlı Değil";
                        robot_model_label.Text = "Model Bulunamadı.";

                    }
                }

                else
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                       
                        AddTextWithBullet("Bağlantı kesildi.");
                        connect_button.Text = "BAĞLAN";
                        durum_label_text.Text = "Bağlı Değil";
                        connect_button.FillColor = Color.FromArgb(0, 126, 249);
                        robot_model_label.Text = "Model Bulunamadı.";
                    }
                    


                }
            }
            catch (Exception ex)
            {
                AddTextWithBullet("Bağlantı kurulamadı: " + ex.Message);
                durum_label_text.Text = "Bağlı Değil";

                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                robot_model_label.Text = "Model Bulunamadı.";
            }

            connect_progresbar.Visible = false;
            connect_button.Visible = true;

        }






        private void command_textBox_TextChanged(object sender, EventArgs e)
        {
            // Metin kutusunun mevcut içeriğini al
            string currentText = command_textBox.Text;

            // Satırları ayır
            string[] lines = currentText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Başına orta nokta eklenmiş satırları oluştur
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].StartsWith("• "))
                {
                    lines[i] = "• " + lines[i];
                }
            }

            // Yeni metni birleştir
            string newText = string.Join(Environment.NewLine, lines);

            // Metin kutusunun içeriğini güncelle
            command_textBox.TextChanged -= command_textBox_TextChanged; // Sonsuz döngüyü önlemek için event handler'ı kaldır
            command_textBox.Text = newText;
            command_textBox.TextChanged += command_textBox_TextChanged; // Event handler'ı tekrar ekle

            // İmleci sonuna taşı
            command_textBox.SelectionStart = command_textBox.Text.Length;
            command_textBox.ScrollToCaret();
        }
        private void AddTextWithBullet(string text)
        {
            // TextChanged olayını geçici olarak devre dışı bırak
            command_textBox.TextChanged -= command_textBox_TextChanged;

            // Mevcut metnin sonuna yeni metni ekle
            command_textBox.Text += Environment.NewLine + "• " + text;

            // TextChanged olayını tekrar etkinleştir
            command_textBox.TextChanged += command_textBox_TextChanged;

            // İmleci sonuna taşı
            command_textBox.SelectionStart = command_textBox.Text.Length;
            command_textBox.ScrollToCaret();
        }


        private async Task CallModel()
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(100); // Belirli bir süre beklet
                robot_model_learn();
                if (staus)
                {
                    break;
                }
            }

        }

        private void content_learn()
        {

            if(serialPort1.IsOpen)
            {

                string command = "eprom_veri";
                serialPort1.WriteLine(command);
               
                string content=serialPort1.ReadLine();

                
                AddTextWithBullet(content);
            }
        }

        private void robot_model_learn()
        {
            if (serialPort1.IsOpen)
            {
                string command = "eprom_veri";
                serialPort1.WriteLine(command);
                string response = serialPort1.ReadLine();

                if (!string.IsNullOrEmpty(response) && response.Contains("0922"))
                {
                    int startIndex = response.IndexOf("\"") + 1;
                    int endIndex = response.LastIndexOf("\"");

                    if (startIndex != -1 && endIndex != -1 && startIndex < endIndex)
                    {
                        string result = response.Substring(startIndex, endIndex - startIndex);
                        Console.WriteLine("Model bilgisi: " + result);
                        robot_model_label.Text = result;
                    
                        staus = true;
                    }
                    else
                    {
                        Console.WriteLine("Model bulunamadı.");
                        staus = false;
                    }
                }
                else
                {
                    staus = false;
                }
            }
        }

       

    }
}
