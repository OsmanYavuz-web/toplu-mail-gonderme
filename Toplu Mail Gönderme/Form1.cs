using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Eklenenler
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using System.Threading;
using System.Collections;
using System.Net.Mail;
using System.Net;

namespace Toplu_Mail_Gönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Thread t_MailGonder;
        bool kontrol;
        int sayac;

        #region FORM_LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread Çalıştırma
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region FORM_CLOSED & FORM_CLOSING
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Email Gönderen Adresler

        #region Seçili Sil
        private void seçiliSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_EmailGonderenAdresler.SelectedItems[0].Remove();
        }
        #endregion

        #region Listeyi sil
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Listeyi silinsin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                listView_EmailGonderenAdresler.Items.Clear();
            }
        }
        #endregion

        #region Liste yükle
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                try
                {
                    listView_EmailGonderenAdresler.Items.Clear();

                    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    openFileDialog1.DefaultExt = "csv";
                    openFileDialog1.Title = "CSV Dosyası Aç";
                    openFileDialog1.Filter = "CSV (*.csv)|*.csv";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileStream srcFS;
                        srcFS = new FileStream(openFileDialog1.FileName, FileMode.Open);
                        srcFS.Flush();

                        StreamReader srcSR = new StreamReader(srcFS, System.Text.Encoding.Default);
                        do
                        {
                            string ins = srcSR.ReadLine();
                            string[] columns = ins.Split(',');

                            ListViewItem lvi = new ListViewItem(columns[0].Replace("\"", ""));

                            lvi.SubItems.Add(ins);

                            for (int i = 1; i < columns.Count(); i++)
                            {
                                lvi.SubItems.Add(columns[i].Replace("\"", ""));
                            }

                            listView_EmailGonderenAdresler.Items.Add(lvi);

                            label_ToplamEmailAdresi.Text = "Toplam: " + listView_EmailGonderenAdresler.Items.Count.ToString();

                        } while (true);
                        srcFS.Close();

                    }
                }
                catch //(Exception errorMsg)
                {
                    //MessageBox.Show(errorMsg.Message, "Error reading a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        #endregion


        #endregion

        #region Email Gönderilecek Adresler

        #region Kolon Aktar
        private void button2_KolonAktar_Click(object sender, EventArgs e)
        {
            listBox_CekilecekKolonlar.Items.Insert(0, textBox_Kolon.Text);
        }
        #endregion

        #region Kolon Sil
        private void button2_KolonSil_Click(object sender, EventArgs e)
        {
            listBox_CekilecekKolonlar.Items.Remove(listBox_CekilecekKolonlar.SelectedItem);
        }



        #endregion

        #region CSV Dosyası Aktarma

        private void button_CSVDosyaAktarma_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                try
                {

                    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    openFileDialog1.DefaultExt = "csv";
                    openFileDialog1.Title = "CSV Dosyası Aç";
                    openFileDialog1.Filter = "CSV (*.csv)|*.csv";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        listView_EmailAlıcıları.Items.Clear();

                        FileStream srcFS;
                        srcFS = new FileStream(openFileDialog1.FileName, FileMode.Open);
                        srcFS.Flush();

                        StreamReader srcSR = new StreamReader(srcFS);

                        string write = srcSR.ReadLine();
                        string[] columnsW = write.Split(',');

                        int say = -1;

                        ArrayList dizi = new ArrayList();


                        foreach (var item in columnsW)
                        {
                            say++;
                            if (listBox_CekilecekKolonlar.Items.Contains(item.Replace("\"", "")))
                            {
                                listView_EmailAlıcıları.Columns.Add(item.Replace("\"", ""), 150);
                                dizi.Add(say);
                            }
                        }



                        do
                        {
                            string ins = srcSR.ReadLine();
                            string[] columns = ins.Split(',');
                            ListViewItem lvi = new ListViewItem(columns[0].Replace("\"", ""));


                            foreach (var item2 in dizi)
                            {
                                int i = int.Parse(item2.ToString());
                                if (i != 0)
                                {
                                    if (columns[i] != "")
                                    {
                                        lvi.SubItems.Add(columns[i].Replace("\"", ""));
                                    }
                                }
                            }

                            listView_EmailAlıcıları.Items.Add(lvi);

                            label_ToplamGonderilecekEmail.Text = "Toplam: " + listView_EmailAlıcıları.Items.Count.ToString();


                        } while (true);
                        srcFS.Close();
                    }
                }
                catch //(Exception errorMsg)
                {
                    //MessageBox.Show(errorMsg.Message, "Error reading a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        #endregion

        #endregion

        #region Başlat 
        private void button_Baslat_Click(object sender, EventArgs e)
        {
            if (listView_EmailGonderenAdresler.Items.Count < 1 || listView_EmailAlıcıları.Items.Count < 1)
            {
                MessageBox.Show("Gönderici/Alıcı email listesi yüklenmemiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult soru = MessageBox.Show("Email gönderme başlatılsın mı?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    // pasif duruma getir
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox4.Enabled = false;
                    button_Baslat.Enabled = false;

                    // aktif duruma getir
                    button_Durdur.Enabled = true;

                    sayac = 0;

                    // Başlat
                    t_MailGonder = new Thread(delegate ()
                    {
                        mailGonder();
                    });
                    t_MailGonder.Start();
                }
            }
        }
        #endregion

        #region Durdur
        private void button_Durdur_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Email gönderme durdurulsun mu?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                // pasif duruma getir
                button_Durdur.Enabled = false;

                // aktif duruma getir
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox4.Enabled = true;
                button_Baslat.Enabled = true;
                
                // Durdur
                t_MailGonder.Abort();
            }
        }
        #endregion

        #region smtp ile mail gönderme Fonksiyonu > mailAt()
        void mailAt(
            string host,
            string port,
            string gonderen_email,
            string gonderen_sifre,
            string alan_email,
            string baslik,
            string mesaj
           )
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(gonderen_email, baslik);
                mail.Sender = new MailAddress(gonderen_email, baslik);
                mail.To.Add(alan_email); // mail gönderilecek kişi
                mail.Subject = baslik; // mail başlığı
                mail.IsBodyHtml = true; // html mail gönderme aktif
                mail.Body = mesaj; // mail içeriği
                mail.BodyEncoding = Encoding.UTF8;
                mail.SubjectEncoding = Encoding.UTF8;

                SmtpClient sc = new SmtpClient();
                sc.Port = int.Parse(port); // mail port
                sc.Host = host; // mail sunucusu
                sc.EnableSsl = true; // ssl kapalı
                sc.Credentials = new NetworkCredential(gonderen_email, gonderen_sifre); // mail adresi ve şifresi

                // mail durumu
                object userState = mail;
                kontrol = true;

                try
                {
                    sc.SendAsync(mail, (object)mail);

                    // bilgi mesajı
                    textBox_Durum.Text = "Email gönderildi.";
                    status_Label.ForeColor = Color.DarkGreen;
                    status_Label.Text = "Alıcı: " + alan_email + " email gönderildi.";
                }
                catch (SmtpException ex)
                {
                    kontrol = false;
                    textBox_Durum.Text = "Hata: " + ex.Message + "\nAlıcı: " + alan_email;
                    status_Label.ForeColor = Color.DarkRed;
                    status_Label.Text = "Hata: " + ex.Message;
                    // MessageBox.Show("Hata: " + ex.Message);
                }
            }
            catch
            {
                status_Label.ForeColor = Color.DarkRed;
                status_Label.Text = alan_email + " email adresine gönderilirken hata oluştu!";
                //MessageBox.Show("Mail gönderilirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Mail Gönderme Thread İşlemi
        void mailGonder()
        {
            try
            {
                // bilgi mesajı
                status_Label.ForeColor = Color.DarkBlue;
                status_Label.Text = "Mail gönderme işlemi başladı.";
                MessageBox.Show("Mail gönderme işlemi başladı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // listview toplam
                int listTop = listView_EmailAlıcıları.Items.Count;

                // listeyi dolaş
                for (int secili = 0; secili < listTop; secili++)
                {

                    int toplamListeSayısı = listView_EmailAlıcıları.Items.Count - 1;
                   // MessageBox.Show("Toplam: " + toplamListeSayısı.ToString() + " " + "Sayaç: " + sayac.ToString());
                    if (toplamListeSayısı == sayac)
                    {
                        // pasif duruma getir
                        button_Durdur.Enabled = false;

                        // aktif duruma getir
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = true;
                        groupBox4.Enabled = true;
                        button_Baslat.Enabled = true;


                        // bilgi mesajı
                        status_Label.ForeColor = Color.DarkBlue;
                        status_Label.Text = "Mail gönderme işlemi tamamlandı.";
                        MessageBox.Show("Mail gönderme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Durdur
                        t_MailGonder.Abort();
                    }
                    else
                    {

                        // satır seç
                        listView_EmailAlıcıları.Items[secili].Selected = true;
                        listView_EmailAlıcıları.Select();
                        string satir = "";
                        satir += listView_EmailAlıcıları.Items[secili].Text;
                        // satır itemlerini dolaş
                        for (int i = 1; i < listView_EmailAlıcıları.Items[secili].SubItems.Count; i++)
                        {
                            satir += "#" + listView_EmailAlıcıları.Items[secili].SubItems[i].Text;
                        }


                        // gönderici bilgileri seç
                        int topGonderici = listView_EmailGonderenAdresler.Items.Count;
                        Random rSec = new Random();
                        int seciliGonderici = rSec.Next(0, topGonderici);

                        // satır seç
                        listView_EmailGonderenAdresler.Items[seciliGonderici].Selected = true;
                        listView_EmailGonderenAdresler.Select();
                        string gonderen = "";
                        gonderen += listView_EmailGonderenAdresler.Items[seciliGonderici].Text;

                        // satır itemlerini dolaş
                        for (int ii = 1; ii < listView_EmailGonderenAdresler.Items[seciliGonderici].SubItems.Count; ii++)
                        {
                            gonderen += "," + listView_EmailGonderenAdresler.Items[seciliGonderici].SubItems[ii].Text;
                        }

                        string[] gondericiBilgileri = gonderen.Split(',');

                        // değişkenler
                        string host = gondericiBilgileri[2].Replace("\"", "").ToString();
                        string port = gondericiBilgileri[3].Replace("\"", "").ToString();
                        string gonderen_email = gondericiBilgileri[4].Replace("\"", "").ToString();
                        string gonderen_sifre = gondericiBilgileri[5].Replace("\"", "").ToString();

                        string alan_email = "";
                        string baslik = textBox_mailBaslik.Text;
                        string mesaj = richTextBox_mailMesaj.Text;

                        // alıcı email
                        string[] gelen = satir.Split('#');
                        foreach (var item in gelen)
                        {
                            if (item.IndexOf("@") != -1)
                            {
                                alan_email = item;
                            }
                        }

                        // mesaj
                        mesaj = mesaj.Replace("{" + "firstname" + "}", gelen[0].ToString());

                        textBox_GonderenEmail.Text = gonderen_email;
                        textBox_AlanEmail.Text = alan_email;

                        // email mi?
                        if (alan_email.IndexOf("@") != -1)
                        {
                            // bilgi mesajları
                            status_Label.ForeColor = Color.DarkBlue;
                            status_Label.Text = "Alıcı: " + alan_email + " email gönderiliyor.";
                            textBox_Durum.Text = "Email gönderiliyor.";

                            //MessageBox.Show(mesaj);

                            // mail gönder
                            mailAt(host, port, gonderen_email, gonderen_sifre, alan_email, baslik, mesaj);
                        }
                        else
                        {
                            textBox_Durum.Text = "Alcı email adresi geçersiz.";
                            status_Label.ForeColor = Color.DarkRed;
                            status_Label.Text = "Alcı email adresi geçersiz.";
                        }

                        // sayaç
                        sayac = sayac + 1;

                        // timeout
                        string sure = textBox_Timeout.Text + "000";
                        Thread.Sleep(int.Parse(sure));


                    }
                }
            }
            catch (Exception ex)
            {
                // bilgi mesajı
                status_Label.ForeColor = Color.DarkRed;
                status_Label.Text = "Mail gönderme işlemi sırasında hata oluştu. Hata:" + ex.Message;
            }

        }

        #endregion

        private void button_ListeTemizle_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Listeyi silinsin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                listView_EmailAlıcıları.Items.Clear();
            }
        }
    }


}
    






