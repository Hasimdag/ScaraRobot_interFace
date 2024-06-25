using ClosedXML.Excel;
using Guna.UI2.WinForms;
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

namespace Robtek_V1._1
{
    public partial class VakumModül : Form
    {

        String data;
        int saveStatus = 0;
        int runStatus = 0;
        bool vakum_mod=false;
        int speedSlider = 500;
        int accelerationSlider = 500;
        int xP = 0;
        int yP = 450;
        int zP = 1;
        float L1 = 279.93F; // L1 = 228mm
        float L2 =169.94F; // L2 = 136.5mm
        float theta1, theta2, phi, z;
        int positionsCounter = 0;
        String[] positions = new String[100];
        int timeout = 0;
        String prob_durumu = "vakum";

        private void VakumModül_Load(object sender, EventArgs e)
        {
            move_listview.Columns.Add("X axis", 114);
            move_listview.Columns.Add("Y axis", 114);
            move_listview.Columns.Add("Z axis", 114);
            move_listview.Columns.Add("Mil dönüşü", 114);
            move_listview.Columns.Add("Vakum Modu ", 114);
            move_listview.Columns.Add("Hız", 114);
            move_listview.Columns.Add("Hızlanma", 114);
            move_listview.Columns.Add("Bekleme Süresi", 114);

            x_axis_text_Side.KeyDown += new KeyEventHandler(x_axis_text_Side_KeyDown);
            y_axis_text_Side.KeyDown += new KeyEventHandler(y_axis_text_Side_KeyDown);
            z_axis_text_Side.KeyDown += new KeyEventHandler(z_axis_text_Side_KeyDown);


            updateData();
            first_label();

            // Kayıt durumu sıfırla
            saveStatus = 0;
            CheckRunButtonState();
            activeIK = false;

            j1label.Text = jointslider1.Value.ToString();
            j2label.Text = jointslider2.Value.ToString();
            j3label.Text = jointslider3.Value.ToString();
            j4label.Text = jointslider4.Value.ToString();
          
            accelerationlabel.Text = jointaccelerationslider.Value.ToString();
            speedlabel.Text = jointspeedslider.Value.ToString();
        }

        Boolean activeIK = false;

        public VakumModül()
        {
            InitializeComponent();
            serialPort1 = SerialPortSingleton.GetInstance().GetSerialPort();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (VakumToggleSwitch.Checked)
            {
                vakum_mod = true;
            }
            else
            {
                vakum_mod = false;
            }
            updateData();
        }

        private void CheckRunButtonState()
        {
            if (move_listview.Items.Count > 0)
            {

                run_button.Enabled = true;
                button4.Enabled = true;
                button4.BackColor = Color.White;
                run_button.BackColor = Color.White;
              

            }
            else
            {
                run_button.Enabled = false;
                button4.Enabled = false;
                button4.BackColor= Color.Silver;
                run_button.BackColor = Color.Silver;
                

            }
        }

        private void first_label()
        {
            x_axis_text_Side.Text = xP.ToString();
            y_axis_text_Side.Text = yP.ToString();
            z_axis_text_Side.Text = zP.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveData();
            
            // Data dizesini virgül karakterine göre ayır
            string[] dataParts = data.Split(',');

            // Verilerin sırasıyla atanacağı değişkenler
            string x, y, z, mil_dönüşü, vakummode, hiz, hızlanma, timeout_durumu;

            // İlk veriyi alma
            if (dataParts.Length > 0)
            {
                // İkinci veriden başlayarak diğer verilere ata
                if (dataParts.Length >= 10)
                {
                    x = dataParts[2];
                    y = dataParts[3];
                    z = dataParts[4];
                    mil_dönüşü = dataParts[5];

                    // Vakum modu değerini true/false olarak gönder, ancak ekranda "Açık" veya "Kapalı" olarak göster
                    vakummode = dataParts[6] == "True" ? "Açık" : "Kapalı";

                    hiz = dataParts[7];
                    hızlanma = dataParts[8];
                    timeout_durumu = dataParts[9];

                    // ListViewItem oluştur ve ListView'e ekle
                    String[] bilgiler = { x, y, z, mil_dönüşü, vakummode, hiz, hızlanma, timeout_durumu };
                    ListViewItem kayıt = new ListViewItem(bilgiler);
                    move_listview.Items.Add(kayıt);
                }
                else
                {
                    // Uyarı ver, yeterli veri parçası yok
                    MessageBox.Show("Veri, beklenen parça sayısına uymuyor.");
                }
            }
            else
            {
                // Uyarı ver, veri parçaları eksik
                MessageBox.Show("Veri parçaları eksik.");
            }
            CheckRunButtonState();
        }

        private void x_axis_text_Side_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşunun varsayılan işlevini bastır
                e.SuppressKeyPress = true;

                // Metni ekrana yazdır
                if (int.TryParse(x_axis_text_Side.Text, out int xValue))
                {
                    xP = xValue;
                    activeIK = true;
                    InverseKinematics(xP, yP);
                }
                else
                {
                    // Hata durumu: Geçerli bir tam sayı girilmedi
                    MessageBox.Show("Lütfen geçerli bir tam sayı giriniz.");
                    // Giriş kutusunu temizleme (isteğe bağlı)
                    x_axis_text_Side.Text = "";
                }
            }
        }

        private void y_axis_text_Side_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşunun varsayılan işlevini bastır
                e.SuppressKeyPress = true;

                // Metni ekrana yazdır
                if (int.TryParse(y_axis_text_Side.Text, out int yValue))
                {
                    yP = yValue;
                    activeIK = true;
                    InverseKinematics(xP, yP);
                }
                else
                {
                    // Hata durumu: Geçerli bir tam sayı girilmedi
                    MessageBox.Show("Lütfen geçerli bir tam sayı giriniz.");
                    // Giriş kutusunu temizleme (isteğe bağlı)
                    y_axis_text_Side.Text = "";
                }
            }
        }

        private void z_axis_text_Side_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşunun varsayılan işlevini bastır
                e.SuppressKeyPress = true;

                // Metni ekrana yazdır
                if (int.TryParse(z_axis_text_Side.Text, out int zValue))
                {
                    zP = zValue;
                    activeIK = true;
                    InverseKinematics(xP, yP);
                }
                else
                {
                    // Hata durumu: Geçerli bir tam sayı girilmedi
                    MessageBox.Show("Lütfen geçerli bir tam sayı giriniz.");
                    // Giriş kutusunu temizleme (isteğe bağlı)
                    z_axis_text_Side.Text = "";
                }
            }
        }









        public void stop()
        {
            if (runStatus == 1)
            {
                runStatus = 0;
                move_button.Enabled = true;
                run_button.Enabled = true;
                stop_button.Enabled = false;
                stop_button.BackColor = Color.Silver;
                run_button.BackColor = Color.White;
                move_button.Enabled = true;
                pozisyon_ekle_button.Enabled = true;
                item_delete_button.Enabled = true;
                button5.Enabled = true;
                button4.Enabled = true;

                move_button.BackColor = Color.White;
                pozisyon_ekle_button.BackColor = Color.White;
                item_delete_button.BackColor = Color.White;
                button5.BackColor = Color.White;
                button4.BackColor = Color.White;
            }

            // Arduino'ya "Stop" gönderme
            serialPort1.WriteLine("Stop");
        }

        public void updateSA()
        {

            serialPort1.WriteLine(data);
            
        }

        // Adımları temizle
        public void clearSteps()
        {
            saveStatus = 2;
            ClearData();
            //serialPort1.WriteLine(data);
            Console.WriteLine("Clear: " + data);
            saveStatus = 0;
            move_listview.Items.Clear();
            CheckRunButtonState();

        }
        public void move()
        {
            MoveData();
            serialPort1.WriteLine(data);
            
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen) // Seri portun açık olup olmadığını kontrol ediyoruz
            {
                KontrolForm kontrolForm = new KontrolForm();
                // Kontrol formunu modal olarak açıyoruz (kullanıcı etkileşimi bekliyoruz)

                // Label içeriğini kontrol ediyoruz
                if (kontrolForm.RobotModelLabelContent != "Model Bulunamadı")
                {
                    saveStatus = 0;
                    run(); // Koşul sağlanıyorsa run fonksiyonunu çalıştırıyoruz
                    Home_button.Enabled = false;
                    Home_button.BackColor = Color.Silver;
                }
                else
                {
                    MessageBox.Show("Makine bağlantısını kontrol edin.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seri port bağlantısı açık değil. Lütfen bağlantıyı kontrol edin.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void run()
        {
            if (runStatus == 0)
            {
                runStatus = 1;
                move_button.Enabled = false;
                run_button.Enabled = false;
                stop_button.Enabled = true;
                run_button.BackColor = Color.Silver;
                stop_button.BackColor = Color.White;
                move_button.Enabled = false;
                pozisyon_ekle_button.Enabled = false;
                item_delete_button.Enabled = false;
                button5.Enabled = false;
                button4.Enabled = false;

                move_button.BackColor = Color.Silver;
                pozisyon_ekle_button.BackColor = Color.Silver;
                item_delete_button.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
            }

            // İlk elemanı işleme ve ek veri gönderme
            if (move_listview.Items.Count > 0)
            {
                ListViewItem firstItem = move_listview.Items[0];
                string additionalData = "2,0";
                additionalData += "," + firstItem.Text;
                foreach (ListViewItem.ListViewSubItem subItem in firstItem.SubItems)
                {
                    additionalData += "," + subItem.Text;
                }
                additionalData += "," + prob_durumu;
                Console.WriteLine("Sending: " + additionalData);
                serialPort1.WriteLine(additionalData);
            }

            // Diğer elemanları işleme
            for (int i = 0; i < move_listview.Items.Count; i++)
            {
                ListViewItem item = move_listview.Items[i];
                string data = "1";
                data += "," + item.Text;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    data += "," + subItem.Text;
                }
                data += "," + prob_durumu;
                Console.WriteLine("Sending: " + data);
                serialPort1.WriteLine(data);
            }

            // 1 saniye gecikme
            System.Threading.Thread.Sleep(1000);

            // Arduino'ya "Run" yazısı gönderme
            string runCommand = "Run";
            Console.WriteLine("Sending: " + runCommand);
            serialPort1.WriteLine(runCommand);
        }





        private void stop_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // Seri portun açık olup olmadığını kontrol ediyoruz
            {
                KontrolForm kontrolForm = new KontrolForm();
                
                // Label içeriğini kontrol ediyoruz
                if (kontrolForm.RobotModelLabelContent != "Model Bulunamadı")
                {
                    saveStatus = 0;
                    stop(); // Koşul sağlanıyorsa stop fonksiyonunu çalıştırıyoruz
                    Home_button.Enabled = true;
                    Home_button.BackColor = Color.White;
                    Console.WriteLine("Gönderildi ve durduruldu.");
                }
                else
                {
                    MessageBox.Show("Makine bağlantısını kontrol edin.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seri port bağlantısı açık değil. Lütfen bağlantıyı kontrol edin.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void item_delete_button_Click(object sender, EventArgs e)
        {
            // Her seçili öğe için işlem yap
            foreach (ListViewItem item in move_listview.SelectedItems)
            {
                // Eğer öğenin checkbox'u işaretlenmişse
                if (item.Checked)
                {
                    // Öğeyi listeden kaldır
                    move_listview.Items.Remove(item);
                    CheckRunButtonState();
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // Seri portun açık olup olmadığını kontrol ediyoruz
            {
                KontrolForm kontrolForm = new KontrolForm();
                // Kontrol formunu modal olarak açıyoruz (kullanıcı etkileşimi bekliyoruz)

                // Label içeriğini kontrol ediyoruz
                if (kontrolForm.RobotModelLabelContent != "Model Bulunamadı")
                {
                    move(); // Koşul sağlanıyorsa move fonksiyonunu çalıştırıyoruz
                }
                else
                {
                    MessageBox.Show("Makine bağlantısını kontrol edin.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seri port bağlantısı açık değil. Lütfen bağlantıyı kontrol edin.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void jointslider1_ValueChanged(object sender, EventArgs e)
        {
            if (activeIK == false)
            {
                theta1 = (float)Math.Round((double)jointslider1.Value);
                theta2 = (float)Math.Round((double)jointslider2.Value);


                ForwardKinematics();
                j1label.Text = jointslider1.Value.ToString();
                MoveData();
                
            }
            activeIK = false;
        }

        private void jointslider2_ValueChanged(object sender, EventArgs e)
        {
            if (activeIK == false)
            {
                theta1 = (float)Math.Round((double)jointslider1.Value);
                theta2 = (float)Math.Round((double)jointslider2.Value);


                ForwardKinematics();
                j2label.Text = jointslider2.Value.ToString();
                MoveData();
               
            }
            activeIK = false;
        }

        private void jointslider3_ValueChanged(object sender, EventArgs e)
        {

            if (activeIK == false)
            {
                theta1 = (float)Math.Round((double)jointslider1.Value);
                theta2 = (float)Math.Round((double)jointslider2.Value);

                ForwardKinematics();
                j3label.Text = jointslider3.Value.ToString();
                MoveData();
               
            }
           
        }

        private void jointslider4_ValueChanged(object sender, EventArgs e)
        {
            if (activeIK == false)
            {

                zP = jointslider4.Value;
                
                j4label.Text = jointslider4.Value.ToString();
                MoveData();
               

            }
            activeIK = false;
        }

       

        private void jointaccelerationslider_ValueChanged(object sender, EventArgs e)
        {

            accelerationSlider = (int)jointaccelerationslider.Value;
            accelerationlabel.Text = jointaccelerationslider.Value.ToString();

        }

        private void jointspeedslider_ValueChanged(object sender, EventArgs e)
        {
            speedSlider = (int)jointspeedslider.Value;
            speedlabel.Text = jointspeedslider.Value.ToString();
        }

        private void timeout_texbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşunun varsayılan işlevini bastır
                e.SuppressKeyPress = true;

                // Metni ekrana yazdır
                if (int.TryParse(timeout_texbox.Text, out int timeoutValue))
                {
                    timeout = timeoutValue;
                }
                else
                {
                    // Hata durumu: Geçerli bir tam sayı girilmedi
                    MessageBox.Show("Lütfen geçerli bir tam sayı giriniz.");
                    // Giriş kutusunu temizleme (isteğe bağlı)
                    timeout_texbox.Text = "";
                }
            }
        }






        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Programı kaydetmek istiyor musunuz?", "Kaydetme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
                saveFileDialog.Title = "Kaydet";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Yeni bir Excel iş kitabı oluştur
                        using (var workbook = new XLWorkbook())
                        {
                            // Yeni bir sayfa oluştur
                            var worksheet = workbook.Worksheets.Add("Veri Sayfası");

                            // ListView'deki verileri Excel sayfasına ve Arduino'ya aktar
                            int row = 1;
                            foreach (ListViewItem item in move_listview.Items)
                            {
                                int col = 1;

                                // İlk iki sütuna 1 ve 0 değerlerini ekleyin
                                worksheet.Cell(row, col).Value = 1;
                                worksheet.Cell(row, col + 1).Value = 0;
                                worksheet.Cell(row, col + 10).Value = prob_durumu;
                                col += 2;

                                // ListView'deki verileri diğer sütunlara aktar
                                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                                {
                                    worksheet.Cell(row, col).Value = subItem.Text;
                                    col++;
                                }
                                row++;

                                // Veriyi seri porta gönder
                                string data = $"1,0,{item.SubItems[0].Text},{item.SubItems[1].Text},{item.SubItems[2].Text},{item.SubItems[3].Text},{item.SubItems[4].Text},{item.SubItems[5].Text},{item.SubItems[6].Text},{item.SubItems[7].Text},{prob_durumu}";
                                
                              
                                
                            }

                            // Excel dosyasını kaydet
                            workbook.SaveAs(filePath);
                        }

                        MessageBox.Show("Veriler başarıyla kaydedildi, Excel dosyasına aktarıldı ve Arduino'ya gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kaydetme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






        public void saveData()
        {
            data = $"{1},{runStatus},{Math.Round((double)jointslider1.Value)},{Math.Round((double)jointslider2.Value)},{Math.Round((double)jointslider3.Value)},{Math.Round((double)jointslider4.Value)},{vakum_mod},{speedSlider},{accelerationSlider},{timeout},{prob_durumu}";
            Console.WriteLine(data);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Dosyası|*.xlsx";
            openFileDialog.Title = "Dosya Seç";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Excel dosyasını aç
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1); // İlk sayfayı seç

                        // Dosyanın formatını kontrol et
                        if (worksheet.Cell(1, 1).Value.ToString() != "1" || worksheet.Cell(1, 2).Value.ToString() != "0" || worksheet.Cell(1, 11).Value.ToString() != prob_durumu)
                        {
                            MessageBox.Show("Yüklenmek istenilen dosya,vakum moduna uygun değildir.Lütfen geçerli bir dosya yükleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // ListView'e verileri ekle
                        move_listview.Items.Clear(); // Önceki verileri temizle

                        int rowCount = worksheet.RowsUsed().Count();
                        for (int i = 1; i <= rowCount; i++) // 2. satırdan başlayarak verileri al
                        {
                            ListViewItem item = new ListViewItem();

                            // Excel dosyasındaki sütunların doğru sırasına göre hücrelerden değerleri al
                            item.Text = worksheet.Cell(i, 3).Value.ToString(); // ListView'in ilk sütunu, Excel'in 3. sütunu
                            item.SubItems.Add(worksheet.Cell(i, 4).Value.ToString()); // X değeri
                            item.SubItems.Add(worksheet.Cell(i, 5).Value.ToString()); // Y değeri
                            item.SubItems.Add(worksheet.Cell(i, 6).Value.ToString()); // Z değeri
                            item.SubItems.Add(worksheet.Cell(i, 7).Value.ToString()); // Mil dönüşü değeri
                            item.SubItems.Add(worksheet.Cell(i, 8).Value.ToString()); // vakum modu değeri
                            item.SubItems.Add(worksheet.Cell(i, 9).Value.ToString()); // Hız değeri
                            item.SubItems.Add(worksheet.Cell(i, 10).Value.ToString()); // Hızlanma değeri
                            item.SubItems.Add(worksheet.Cell(i, 11).Value.ToString()); // Timeout durumu değeri

                            move_listview.Items.Add(item);

                            // Veriyi seri porta gönder
                            string data = $"{worksheet.Cell(i, 1).Value.ToString()},{worksheet.Cell(i, 2).Value.ToString()},{worksheet.Cell(i, 3).Value.ToString()},{worksheet.Cell(i, 4).Value.ToString()},{worksheet.Cell(i, 5).Value.ToString()},{worksheet.Cell(i, 6).Value.ToString()},{worksheet.Cell(i, 7).Value.ToString()},{worksheet.Cell(i, 8).Value.ToString()},{worksheet.Cell(i, 9).Value.ToString()},{worksheet.Cell(i, 10).Value.ToString()},{worksheet.Cell(i, 11).Value.ToString()}";
                            Console.WriteLine(data);
                        }
                    }

                    MessageBox.Show("Veri başarıyla yüklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CheckRunButtonState();
        }

        private void all_clear_button_Click(object sender, EventArgs e)
        {
            clearSteps();
        }

        public void updateData()
        {
            data = $"{0},{runStatus},{Math.Round((double)jointslider1.Value)},{Math.Round((double)jointslider2.Value)},{Math.Round((double)jointslider3.Value)},{Math.Round((double)jointslider4.Value)},{vakum_mod},{speedSlider},{accelerationSlider},{timeout},{prob_durumu}";
            Console.WriteLine("update Data: " + saveStatus);
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            KontrolForm kontrolForm = new KontrolForm();// Seri portun açık olup olmadığını kontrol edin
            if (serialPort1.IsOpen)
            {
                Console.WriteLine("Buraya girdi");
                // Etiketin "Model Bulunamadı" olup olmadığını kontrol edin
                if (kontrolForm.RobotModelLabelContent != "Model Bulunamadı")
                {
                    Console.WriteLine("Buraya da girdi");
                    // Arduino'ya "Homing" mesajını gönderin
                    string message = "Homing";
                    Console.WriteLine("Sending: " + message);
                    serialPort1.WriteLine(message);

                }
            }
        }


        public void MoveData()
        {
            data = $"{3},{0},{Math.Round((double)jointslider1.Value)},{Math.Round((double)jointslider2.Value)},{Math.Round((double)jointslider3.Value)},{zP},{vakum_mod},{speedSlider},{accelerationSlider},{timeout},{prob_durumu}";
            serialPort1.WriteLine(data);
        }
        public void ClearData()
        {
            data = $"{saveStatus},{runStatus},{Math.Round((double)jointslider1.Value)},{Math.Round((double)jointslider2.Value)},{Math.Round((double)jointslider3.Value)},{zP},{vakum_mod},{speedSlider},{accelerationSlider},{timeout},{prob_durumu}";
            serialPort1.WriteLine(data);
        }
        // FORWARD KINEMATICS
        private void ForwardKinematics()
        {
            // Dereceleri radyana çevir
            float theta1F = theta1 * (float)Math.PI / 180;
            float theta2F = theta2 * (float)Math.PI / 180;

            // X ve Y pozisyonlarını hesapla ve yuvarla
            yP = (int)Math.Round(L1 * Math.Cos(theta1F) + L2 * Math.Cos(theta1F + theta2F));
            xP = (int)Math.Round(L1 * Math.Sin(theta1F) + L2 * Math.Sin(theta1F + theta2F));

            first_label();
        }

        // INVERSE KINEMATICS
        private void InverseKinematics(float x, float y)
        {
            // Theta2'yi hesapla
            theta2 = (float)Math.Acos((Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(L1, 2) - Math.Pow(L2, 2)) / (2 * L1 * L2));
            if (x < 0 && y < 0)
            {
                theta2 = (-1) * theta2;
            }

            // Theta1'i hesapla
            theta1 = (float)Math.Atan(x / y) - (float)Math.Atan((L2 * Math.Sin(theta2)) / (L1 + L2 * Math.Cos(theta2)));

            // Dereceleri düzelt
            theta2 = (-1) * theta2 * 180 / (float)Math.PI;
            theta1 = theta1 * 180 / (float)Math.PI;

            // Farklı dört açı için uygun ayarları yap
            if (x >= 0 && y >= 0)
            {
                theta1 = 90 - theta1;
            }
            if (x < 0 && y > 0)
            {
                theta1 = 90 - theta1;
            }
            if (x < 0 && y < 0)
            {
                theta1 = 270 - theta1;
                phi = 270 - theta1 - theta2;
                phi = (-1) * phi;
            }
            if (x > 0 && y < 0)
            {
                theta1 = -90 - theta1;
            }
            if (x < 0 && y == 0)
            {
                theta1 = 270 + theta1;
            }

            // Gripper'ı X eksenine paralel yapacak Phi açısını hesapla
            phi = 90 + theta1 + theta2;
            phi = (-1) * phi;

            // Phi açısını ayarla
            if (x < 0 && y < 0)
            {
                phi = 270 - theta1 - theta2;
            }
            if (Math.Abs(phi) > 165)
            {
                phi = 180 + phi;
            }

            // float değerleri int değerlerine yuvarlayarak dönüştürme



            // Yuvarlama işlemi
            // Yuvarlama işlemi
            int intTheta1 = (int)Math.Round(theta1);  // 3
            int intTheta2 = (int)Math.Round(theta2);  // 3
            int intPhi = (int)Math.Round(phi);

            // Değerleri int türüne dönüştürme
            int theta1Value = (int)theta1;
            int theta2Value = (int)theta2;
            int phiValue = (int)phi;
            int zPValue = (int)zP;  // zP'nin de yuvarlanması gerekiyorsa

            // Slider değerlerini kontrol ederek güncelleme
            if (theta1Value >= jointslider1.Minimum && theta1Value <= jointslider1.Maximum)
            {
                jointslider1.Value = theta1Value;
            }

            if (theta2Value >= jointslider2.Minimum && theta2Value <= jointslider2.Maximum)
            {
                jointslider2.Value = theta2Value;
            }

            if (phiValue >= jointslider3.Minimum && phiValue <= jointslider3.Maximum)
            {
                jointslider3.Value = phiValue;
            }

            if (zPValue >= jointslider4.Minimum && zPValue <= jointslider4.Maximum)
            {
                jointslider4.Value = zPValue;
            }



            first_label();
        }

    }
}
