namespace Toplu_Mail_Gönderme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ToplamEmailAdresi = new System.Windows.Forms.Label();
            this.button_ListeyiTemizle = new System.Windows.Forms.Button();
            this.button_ListeYukle = new System.Windows.Forms.Button();
            this.listView_EmailGonderenAdresler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1_EmailGonderenAdresler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçiliSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ListeTemizle = new System.Windows.Forms.Button();
            this.button_CSVDosyaAktarma = new System.Windows.Forms.Button();
            this.listView_EmailAlıcıları = new System.Windows.Forms.ListView();
            this.label_ToplamGonderilecekEmail = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_KolonSil = new System.Windows.Forms.Button();
            this.textBox_Kolon = new System.Windows.Forms.TextBox();
            this.button_KolonAktar = new System.Windows.Forms.Button();
            this.listBox_CekilecekKolonlar = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox_mailMesaj = new System.Windows.Forms.RichTextBox();
            this.textBox_mailBaslik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_Durdur = new System.Windows.Forms.Button();
            this.button_Baslat = new System.Windows.Forms.Button();
            this.textBox_Durum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_AlanEmail = new System.Windows.Forms.TextBox();
            this.textBox_GonderenEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Timeout = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_test = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1_EmailGonderenAdresler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ToplamEmailAdresi);
            this.groupBox1.Controls.Add(this.button_ListeyiTemizle);
            this.groupBox1.Controls.Add(this.button_ListeYukle);
            this.groupBox1.Controls.Add(this.listView_EmailGonderenAdresler);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Gönderen Adresler";
            // 
            // label_ToplamEmailAdresi
            // 
            this.label_ToplamEmailAdresi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ToplamEmailAdresi.Location = new System.Drawing.Point(147, 124);
            this.label_ToplamEmailAdresi.Name = "label_ToplamEmailAdresi";
            this.label_ToplamEmailAdresi.Size = new System.Drawing.Size(146, 13);
            this.label_ToplamEmailAdresi.TabIndex = 16;
            this.label_ToplamEmailAdresi.Text = "Toplam: 0";
            this.label_ToplamEmailAdresi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_ListeyiTemizle
            // 
            this.button_ListeyiTemizle.AutoSize = true;
            this.button_ListeyiTemizle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ListeyiTemizle.ForeColor = System.Drawing.Color.Black;
            this.button_ListeyiTemizle.Location = new System.Drawing.Point(709, 118);
            this.button_ListeyiTemizle.Name = "button_ListeyiTemizle";
            this.button_ListeyiTemizle.Size = new System.Drawing.Size(129, 25);
            this.button_ListeyiTemizle.TabIndex = 15;
            this.button_ListeyiTemizle.Text = "Listeyi Temizle";
            this.button_ListeyiTemizle.UseVisualStyleBackColor = true;
            this.button_ListeyiTemizle.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_ListeYukle
            // 
            this.button_ListeYukle.AutoSize = true;
            this.button_ListeYukle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ListeYukle.ForeColor = System.Drawing.Color.Black;
            this.button_ListeYukle.Location = new System.Drawing.Point(12, 118);
            this.button_ListeYukle.Name = "button_ListeYukle";
            this.button_ListeYukle.Size = new System.Drawing.Size(129, 25);
            this.button_ListeYukle.TabIndex = 14;
            this.button_ListeYukle.Text = "Liste Yükle";
            this.button_ListeYukle.UseVisualStyleBackColor = true;
            this.button_ListeYukle.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView_EmailGonderenAdresler
            // 
            this.listView_EmailGonderenAdresler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_EmailGonderenAdresler.ContextMenuStrip = this.contextMenuStrip1_EmailGonderenAdresler;
            this.listView_EmailGonderenAdresler.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_EmailGonderenAdresler.FullRowSelect = true;
            this.listView_EmailGonderenAdresler.Location = new System.Drawing.Point(12, 24);
            this.listView_EmailGonderenAdresler.MultiSelect = false;
            this.listView_EmailGonderenAdresler.Name = "listView_EmailGonderenAdresler";
            this.listView_EmailGonderenAdresler.Size = new System.Drawing.Size(826, 88);
            this.listView_EmailGonderenAdresler.TabIndex = 1;
            this.listView_EmailGonderenAdresler.UseCompatibleStateImageBehavior = false;
            this.listView_EmailGonderenAdresler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Servis";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gereksiz";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Host";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Port";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Şifre";
            this.columnHeader6.Width = 200;
            // 
            // contextMenuStrip1_EmailGonderenAdresler
            // 
            this.contextMenuStrip1_EmailGonderenAdresler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçiliSilToolStripMenuItem});
            this.contextMenuStrip1_EmailGonderenAdresler.Name = "contextMenuStrip1_EmailGonderenAdresler";
            this.contextMenuStrip1_EmailGonderenAdresler.Size = new System.Drawing.Size(117, 26);
            // 
            // seçiliSilToolStripMenuItem
            // 
            this.seçiliSilToolStripMenuItem.Name = "seçiliSilToolStripMenuItem";
            this.seçiliSilToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.seçiliSilToolStripMenuItem.Text = "Seçili Sil";
            this.seçiliSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliSilToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ListeTemizle);
            this.groupBox2.Controls.Add(this.button_CSVDosyaAktarma);
            this.groupBox2.Controls.Add(this.listView_EmailAlıcıları);
            this.groupBox2.Controls.Add(this.label_ToplamGonderilecekEmail);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 393);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Gönderilecek Adresler";
            // 
            // button_ListeTemizle
            // 
            this.button_ListeTemizle.AutoSize = true;
            this.button_ListeTemizle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ListeTemizle.ForeColor = System.Drawing.Color.Black;
            this.button_ListeTemizle.Location = new System.Drawing.Point(341, 122);
            this.button_ListeTemizle.Name = "button_ListeTemizle";
            this.button_ListeTemizle.Size = new System.Drawing.Size(129, 25);
            this.button_ListeTemizle.TabIndex = 16;
            this.button_ListeTemizle.Text = "Listeyi Temizle";
            this.button_ListeTemizle.UseVisualStyleBackColor = true;
            this.button_ListeTemizle.Click += new System.EventHandler(this.button_ListeTemizle_Click);
            // 
            // button_CSVDosyaAktarma
            // 
            this.button_CSVDosyaAktarma.AutoSize = true;
            this.button_CSVDosyaAktarma.ForeColor = System.Drawing.Color.Black;
            this.button_CSVDosyaAktarma.Location = new System.Drawing.Point(12, 122);
            this.button_CSVDosyaAktarma.Name = "button_CSVDosyaAktarma";
            this.button_CSVDosyaAktarma.Size = new System.Drawing.Size(152, 24);
            this.button_CSVDosyaAktarma.TabIndex = 10;
            this.button_CSVDosyaAktarma.Text = "CSV Dosyası Aktar";
            this.button_CSVDosyaAktarma.UseVisualStyleBackColor = true;
            this.button_CSVDosyaAktarma.Click += new System.EventHandler(this.button_CSVDosyaAktarma_Click);
            // 
            // listView_EmailAlıcıları
            // 
            this.listView_EmailAlıcıları.FullRowSelect = true;
            this.listView_EmailAlıcıları.Location = new System.Drawing.Point(11, 152);
            this.listView_EmailAlıcıları.MultiSelect = false;
            this.listView_EmailAlıcıları.Name = "listView_EmailAlıcıları";
            this.listView_EmailAlıcıları.Size = new System.Drawing.Size(459, 228);
            this.listView_EmailAlıcıları.TabIndex = 9;
            this.listView_EmailAlıcıları.UseCompatibleStateImageBehavior = false;
            this.listView_EmailAlıcıları.View = System.Windows.Forms.View.Details;
            // 
            // label_ToplamGonderilecekEmail
            // 
            this.label_ToplamGonderilecekEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ToplamGonderilecekEmail.Location = new System.Drawing.Point(170, 128);
            this.label_ToplamGonderilecekEmail.Name = "label_ToplamGonderilecekEmail";
            this.label_ToplamGonderilecekEmail.Size = new System.Drawing.Size(146, 13);
            this.label_ToplamGonderilecekEmail.TabIndex = 8;
            this.label_ToplamGonderilecekEmail.Text = "Toplam: 0";
            this.label_ToplamGonderilecekEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.button_KolonSil);
            this.groupBox3.Controls.Add(this.textBox_Kolon);
            this.groupBox3.Controls.Add(this.button_KolonAktar);
            this.groupBox3.Controls.Add(this.listBox_CekilecekKolonlar);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox3.Location = new System.Drawing.Point(12, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 95);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çekilecek Kolonlar";
            // 
            // button_KolonSil
            // 
            this.button_KolonSil.AutoSize = true;
            this.button_KolonSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_KolonSil.Location = new System.Drawing.Point(142, 51);
            this.button_KolonSil.Name = "button_KolonSil";
            this.button_KolonSil.Size = new System.Drawing.Size(100, 32);
            this.button_KolonSil.TabIndex = 3;
            this.button_KolonSil.Text = "Seçili Sil";
            this.button_KolonSil.UseVisualStyleBackColor = true;
            this.button_KolonSil.Click += new System.EventHandler(this.button2_KolonSil_Click);
            // 
            // textBox_Kolon
            // 
            this.textBox_Kolon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kolon.Location = new System.Drawing.Point(11, 23);
            this.textBox_Kolon.Name = "textBox_Kolon";
            this.textBox_Kolon.Size = new System.Drawing.Size(231, 22);
            this.textBox_Kolon.TabIndex = 2;
            // 
            // button_KolonAktar
            // 
            this.button_KolonAktar.AutoSize = true;
            this.button_KolonAktar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_KolonAktar.Location = new System.Drawing.Point(11, 51);
            this.button_KolonAktar.Name = "button_KolonAktar";
            this.button_KolonAktar.Size = new System.Drawing.Size(100, 32);
            this.button_KolonAktar.TabIndex = 1;
            this.button_KolonAktar.Text = "Aktar >";
            this.button_KolonAktar.UseVisualStyleBackColor = true;
            this.button_KolonAktar.Click += new System.EventHandler(this.button2_KolonAktar_Click);
            // 
            // listBox_CekilecekKolonlar
            // 
            this.listBox_CekilecekKolonlar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_CekilecekKolonlar.FormattingEnabled = true;
            this.listBox_CekilecekKolonlar.ItemHeight = 14;
            this.listBox_CekilecekKolonlar.Items.AddRange(new object[] {
            "firstname",
            "email"});
            this.listBox_CekilecekKolonlar.Location = new System.Drawing.Point(248, 23);
            this.listBox_CekilecekKolonlar.Name = "listBox_CekilecekKolonlar";
            this.listBox_CekilecekKolonlar.Size = new System.Drawing.Size(199, 60);
            this.listBox_CekilecekKolonlar.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox_mailMesaj);
            this.groupBox4.Controls.Add(this.textBox_mailBaslik);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox4.Location = new System.Drawing.Point(503, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 326);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mail İçeriği";
            // 
            // richTextBox_mailMesaj
            // 
            this.richTextBox_mailMesaj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_mailMesaj.Location = new System.Drawing.Point(9, 83);
            this.richTextBox_mailMesaj.Name = "richTextBox_mailMesaj";
            this.richTextBox_mailMesaj.Size = new System.Drawing.Size(338, 230);
            this.richTextBox_mailMesaj.TabIndex = 3;
            this.richTextBox_mailMesaj.Text = "Merhaba {firstname},\n\nToplu mail gönderme programının testini yapıyoruz.\n\nSaygıla" +
    "rla";
            // 
            // textBox_mailBaslik
            // 
            this.textBox_mailBaslik.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_mailBaslik.Location = new System.Drawing.Point(9, 41);
            this.textBox_mailBaslik.Name = "textBox_mailBaslik";
            this.textBox_mailBaslik.Size = new System.Drawing.Size(338, 22);
            this.textBox_mailBaslik.TabIndex = 2;
            this.textBox_mailBaslik.Text = "Toplu Mail Gönderme Test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mail Konusu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mail Başlığı";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_Durdur);
            this.groupBox6.Controls.Add(this.button_Baslat);
            this.groupBox6.Controls.Add(this.textBox_Durum);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.textBox_AlanEmail);
            this.groupBox6.Controls.Add(this.textBox_GonderenEmail);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox6.Location = new System.Drawing.Point(12, 569);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(848, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gönderme Penceresi";
            // 
            // button_Durdur
            // 
            this.button_Durdur.AutoSize = true;
            this.button_Durdur.ForeColor = System.Drawing.Color.Maroon;
            this.button_Durdur.Location = new System.Drawing.Point(12, 58);
            this.button_Durdur.Name = "button_Durdur";
            this.button_Durdur.Size = new System.Drawing.Size(120, 33);
            this.button_Durdur.TabIndex = 13;
            this.button_Durdur.Text = "Durdur";
            this.button_Durdur.UseVisualStyleBackColor = true;
            this.button_Durdur.Click += new System.EventHandler(this.button_Durdur_Click);
            // 
            // button_Baslat
            // 
            this.button_Baslat.AutoSize = true;
            this.button_Baslat.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_Baslat.Location = new System.Drawing.Point(12, 21);
            this.button_Baslat.Name = "button_Baslat";
            this.button_Baslat.Size = new System.Drawing.Size(120, 33);
            this.button_Baslat.TabIndex = 12;
            this.button_Baslat.Text = "Başlat";
            this.button_Baslat.UseVisualStyleBackColor = true;
            this.button_Baslat.Click += new System.EventHandler(this.button_Baslat_Click);
            // 
            // textBox_Durum
            // 
            this.textBox_Durum.Location = new System.Drawing.Point(630, 32);
            this.textBox_Durum.Multiline = true;
            this.textBox_Durum.Name = "textBox_Durum";
            this.textBox_Durum.ReadOnly = true;
            this.textBox_Durum.Size = new System.Drawing.Size(208, 50);
            this.textBox_Durum.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label11.Location = new System.Drawing.Point(576, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "Durum";
            // 
            // textBox_AlanEmail
            // 
            this.textBox_AlanEmail.Location = new System.Drawing.Point(284, 60);
            this.textBox_AlanEmail.Name = "textBox_AlanEmail";
            this.textBox_AlanEmail.ReadOnly = true;
            this.textBox_AlanEmail.Size = new System.Drawing.Size(286, 22);
            this.textBox_AlanEmail.TabIndex = 9;
            // 
            // textBox_GonderenEmail
            // 
            this.textBox_GonderenEmail.Location = new System.Drawing.Point(284, 32);
            this.textBox_GonderenEmail.Name = "textBox_GonderenEmail";
            this.textBox_GonderenEmail.ReadOnly = true;
            this.textBox_GonderenEmail.Size = new System.Drawing.Size(286, 22);
            this.textBox_GonderenEmail.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label9.Location = new System.Drawing.Point(209, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 14);
            this.label9.TabIndex = 7;
            this.label9.Text = "Alıcı Bilgisi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label8.Location = new System.Drawing.Point(174, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Gönderen Bilgisi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label10.Location = new System.Drawing.Point(9, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mail Gönderme Aralığı (sn)";
            // 
            // textBox_Timeout
            // 
            this.textBox_Timeout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Timeout.Location = new System.Drawing.Point(182, 25);
            this.textBox_Timeout.Name = "textBox_Timeout";
            this.textBox_Timeout.Size = new System.Drawing.Size(56, 22);
            this.textBox_Timeout.TabIndex = 3;
            this.textBox_Timeout.Text = "10";
            this.textBox_Timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_Timeout);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.ForeColor = System.Drawing.Color.GreenYellow;
            this.groupBox5.Location = new System.Drawing.Point(503, 503);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 60);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Toplu Mail Gönderme Ayarları";
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(879, 72);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 6;
            this.button_test.Text = "button1";
            this.button_test.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 672);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "Durum:";
            // 
            // status_Label
            // 
            this.status_Label.BackColor = System.Drawing.Color.Transparent;
            this.status_Label.Name = "status_Label";
            this.status_Label.Size = new System.Drawing.Size(49, 17);
            this.status_Label.Text = "Bekliyor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(872, 694);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Mail Gönderme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1_EmailGonderenAdresler.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_EmailGonderenAdresler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1_EmailGonderenAdresler;
        private System.Windows.Forms.ToolStripMenuItem seçiliSilToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Kolon;
        private System.Windows.Forms.Button button_KolonAktar;
        private System.Windows.Forms.ListBox listBox_CekilecekKolonlar;
        private System.Windows.Forms.Button button_KolonSil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox_mailMesaj;
        private System.Windows.Forms.TextBox textBox_mailBaslik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_Durdur;
        private System.Windows.Forms.Button button_Baslat;
        private System.Windows.Forms.TextBox textBox_Durum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_AlanEmail;
        private System.Windows.Forms.TextBox textBox_GonderenEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_ListeYukle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button_ListeyiTemizle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Timeout;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_ToplamGonderilecekEmail;
        private System.Windows.Forms.Label label_ToplamEmailAdresi;
        private System.Windows.Forms.Button button_CSVDosyaAktarma;
        private System.Windows.Forms.ListView listView_EmailAlıcıları;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_Label;
        private System.Windows.Forms.Button button_ListeTemizle;
    }
}

