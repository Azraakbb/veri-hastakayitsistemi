namespace veriodev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.anasekme = new System.Windows.Forms.TabPage();
            this.Listelebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.KayitSilbtn = new System.Windows.Forms.Button();
            this.gosterbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eklesekme = new System.Windows.Forms.TabPage();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.eklebtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textdy = new System.Windows.Forms.TextBox();
            this.textdt = new System.Windows.Forms.TextBox();
            this.textadres = new System.Windows.Forms.TextBox();
            this.texttel = new System.Windows.Forms.TextBox();
            this.textilac = new System.Windows.Forms.TextBox();
            this.texthastalik = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textad = new System.Windows.Forms.TextBox();
            this.texttc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonTc = new System.Windows.Forms.RadioButton();
            this.radioButtonHastalik = new System.Windows.Forms.RadioButton();
            this.radioButtonHasta = new System.Windows.Forms.RadioButton();
            this.bilgitxt = new System.Windows.Forms.TextBox();
            this.Getirbtn = new System.Windows.Forms.Button();
            this.degerlabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.anasekme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.eklesekme.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.anasekme);
            this.tabControl1.Controls.Add(this.eklesekme);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1384, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // anasekme
            // 
            this.anasekme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anasekme.Controls.Add(this.label12);
            this.anasekme.Controls.Add(this.labelSaat);
            this.anasekme.Controls.Add(this.label10);
            this.anasekme.Controls.Add(this.degerlabel);
            this.anasekme.Controls.Add(this.Getirbtn);
            this.anasekme.Controls.Add(this.bilgitxt);
            this.anasekme.Controls.Add(this.radioButtonHasta);
            this.anasekme.Controls.Add(this.radioButtonHastalik);
            this.anasekme.Controls.Add(this.radioButtonTc);
            this.anasekme.Controls.Add(this.button1);
            this.anasekme.Controls.Add(this.Listelebtn);
            this.anasekme.Controls.Add(this.comboBox1);
            this.anasekme.Controls.Add(this.KayitSilbtn);
            this.anasekme.Controls.Add(this.gosterbtn);
            this.anasekme.Controls.Add(this.dataGridView1);
            this.anasekme.Location = new System.Drawing.Point(4, 25);
            this.anasekme.Name = "anasekme";
            this.anasekme.Padding = new System.Windows.Forms.Padding(3);
            this.anasekme.Size = new System.Drawing.Size(1376, 483);
            this.anasekme.TabIndex = 0;
            this.anasekme.Text = "Tablo Görüntüle";
            this.anasekme.Click += new System.EventHandler(this.anasekme_Click);
            // 
            // Listelebtn
            // 
            this.Listelebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Listelebtn.ForeColor = System.Drawing.Color.White;
            this.Listelebtn.Location = new System.Drawing.Point(1055, 75);
            this.Listelebtn.Name = "Listelebtn";
            this.Listelebtn.Size = new System.Drawing.Size(192, 48);
            this.Listelebtn.TabIndex = 13;
            this.Listelebtn.Text = "Seçeneğe göre listele";
            this.Listelebtn.UseVisualStyleBackColor = false;
            this.Listelebtn.Click += new System.EventHandler(this.Listelebtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hastalık",
            "Hasta Adı",
            "Tc"});
            this.comboBox1.Location = new System.Drawing.Point(885, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Seçiniz";
            // 
            // KayitSilbtn
            // 
            this.KayitSilbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KayitSilbtn.ForeColor = System.Drawing.Color.White;
            this.KayitSilbtn.Location = new System.Drawing.Point(1251, 252);
            this.KayitSilbtn.Name = "KayitSilbtn";
            this.KayitSilbtn.Size = new System.Drawing.Size(108, 44);
            this.KayitSilbtn.TabIndex = 7;
            this.KayitSilbtn.Text = "Kayıt Sil";
            this.KayitSilbtn.UseVisualStyleBackColor = false;
            this.KayitSilbtn.Click += new System.EventHandler(this.KayitSilbtn_Click);
            // 
            // gosterbtn
            // 
            this.gosterbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gosterbtn.ForeColor = System.Drawing.Color.White;
            this.gosterbtn.Location = new System.Drawing.Point(684, 439);
            this.gosterbtn.Name = "gosterbtn";
            this.gosterbtn.Size = new System.Drawing.Size(147, 29);
            this.gosterbtn.TabIndex = 1;
            this.gosterbtn.Text = "Tamamını Göster";
            this.gosterbtn.UseVisualStyleBackColor = false;
            this.gosterbtn.Click += new System.EventHandler(this.gosterbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // eklesekme
            // 
            this.eklesekme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eklesekme.Controls.Add(this.label11);
            this.eklesekme.Controls.Add(this.button2);
            this.eklesekme.Controls.Add(this.guncellebtn);
            this.eklesekme.Controls.Add(this.eklebtn);
            this.eklesekme.Controls.Add(this.label9);
            this.eklesekme.Controls.Add(this.label8);
            this.eklesekme.Controls.Add(this.label7);
            this.eklesekme.Controls.Add(this.label6);
            this.eklesekme.Controls.Add(this.label5);
            this.eklesekme.Controls.Add(this.label4);
            this.eklesekme.Controls.Add(this.label3);
            this.eklesekme.Controls.Add(this.label2);
            this.eklesekme.Controls.Add(this.label1);
            this.eklesekme.Controls.Add(this.textdy);
            this.eklesekme.Controls.Add(this.textdt);
            this.eklesekme.Controls.Add(this.textadres);
            this.eklesekme.Controls.Add(this.texttel);
            this.eklesekme.Controls.Add(this.textilac);
            this.eklesekme.Controls.Add(this.texthastalik);
            this.eklesekme.Controls.Add(this.textsoyad);
            this.eklesekme.Controls.Add(this.textad);
            this.eklesekme.Controls.Add(this.texttc);
            this.eklesekme.Location = new System.Drawing.Point(4, 25);
            this.eklesekme.Name = "eklesekme";
            this.eklesekme.Padding = new System.Windows.Forms.Padding(3);
            this.eklesekme.Size = new System.Drawing.Size(1376, 483);
            this.eklesekme.TabIndex = 1;
            this.eklesekme.Text = "Kayıt Ekle/Güncelle";
            // 
            // guncellebtn
            // 
            this.guncellebtn.BackColor = System.Drawing.Color.IndianRed;
            this.guncellebtn.ForeColor = System.Drawing.Color.White;
            this.guncellebtn.Location = new System.Drawing.Point(909, 315);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(155, 57);
            this.guncellebtn.TabIndex = 19;
            this.guncellebtn.Text = "Kayıt Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = false;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // eklebtn
            // 
            this.eklebtn.BackColor = System.Drawing.Color.IndianRed;
            this.eklebtn.ForeColor = System.Drawing.Color.White;
            this.eklebtn.Location = new System.Drawing.Point(1181, 315);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(158, 57);
            this.eklebtn.TabIndex = 18;
            this.eklebtn.Text = "Kayıt Ekle";
            this.eklebtn.UseVisualStyleBackColor = false;
            this.eklebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(997, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "İlaç :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(946, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hastalık Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(946, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Doğum Yeri :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(471, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(471, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(471, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tc No :";
            // 
            // textdy
            // 
            this.textdy.Location = new System.Drawing.Point(1095, 68);
            this.textdy.Multiline = true;
            this.textdy.Name = "textdy";
            this.textdy.Size = new System.Drawing.Size(176, 42);
            this.textdy.TabIndex = 8;
            // 
            // textdt
            // 
            this.textdt.Location = new System.Drawing.Point(656, 230);
            this.textdt.Multiline = true;
            this.textdt.Name = "textdt";
            this.textdt.Size = new System.Drawing.Size(177, 40);
            this.textdt.TabIndex = 7;
            // 
            // textadres
            // 
            this.textadres.Location = new System.Drawing.Point(656, 68);
            this.textadres.Multiline = true;
            this.textadres.Name = "textadres";
            this.textadres.Size = new System.Drawing.Size(177, 42);
            this.textadres.TabIndex = 6;
            // 
            // texttel
            // 
            this.texttel.Location = new System.Drawing.Point(656, 145);
            this.texttel.Multiline = true;
            this.texttel.Name = "texttel";
            this.texttel.Size = new System.Drawing.Size(177, 43);
            this.texttel.TabIndex = 5;
            // 
            // textilac
            // 
            this.textilac.Location = new System.Drawing.Point(1095, 228);
            this.textilac.Multiline = true;
            this.textilac.Name = "textilac";
            this.textilac.Size = new System.Drawing.Size(176, 42);
            this.textilac.TabIndex = 4;
            // 
            // texthastalik
            // 
            this.texthastalik.Location = new System.Drawing.Point(1095, 145);
            this.texthastalik.Multiline = true;
            this.texthastalik.Name = "texthastalik";
            this.texthastalik.Size = new System.Drawing.Size(176, 42);
            this.texthastalik.TabIndex = 3;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(151, 228);
            this.textsoyad.Multiline = true;
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(168, 42);
            this.textsoyad.TabIndex = 2;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(151, 145);
            this.textad.Multiline = true;
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(168, 43);
            this.textad.TabIndex = 1;
            // 
            // texttc
            // 
            this.texttc.BackColor = System.Drawing.Color.White;
            this.texttc.ForeColor = System.Drawing.Color.Black;
            this.texttc.Location = new System.Drawing.Point(151, 68);
            this.texttc.Multiline = true;
            this.texttc.Name = "texttc";
            this.texttc.Size = new System.Drawing.Size(168, 42);
            this.texttc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1143, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sonraki Sayfaya Geç  >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButtonTc
            // 
            this.radioButtonTc.AutoSize = true;
            this.radioButtonTc.Location = new System.Drawing.Point(885, 212);
            this.radioButtonTc.Name = "radioButtonTc";
            this.radioButtonTc.Size = new System.Drawing.Size(44, 20);
            this.radioButtonTc.TabIndex = 15;
            this.radioButtonTc.TabStop = true;
            this.radioButtonTc.Text = "Tc";
            this.radioButtonTc.UseVisualStyleBackColor = true;
            this.radioButtonTc.CheckedChanged += new System.EventHandler(this.radioButtonTc_CheckedChanged);
            // 
            // radioButtonHastalik
            // 
            this.radioButtonHastalik.AutoSize = true;
            this.radioButtonHastalik.Location = new System.Drawing.Point(961, 212);
            this.radioButtonHastalik.Name = "radioButtonHastalik";
            this.radioButtonHastalik.Size = new System.Drawing.Size(77, 20);
            this.radioButtonHastalik.TabIndex = 16;
            this.radioButtonHastalik.TabStop = true;
            this.radioButtonHastalik.Text = "Hastalık";
            this.radioButtonHastalik.UseVisualStyleBackColor = true;
            // 
            // radioButtonHasta
            // 
            this.radioButtonHasta.AutoSize = true;
            this.radioButtonHasta.Location = new System.Drawing.Point(1055, 212);
            this.radioButtonHasta.Name = "radioButtonHasta";
            this.radioButtonHasta.Size = new System.Drawing.Size(87, 20);
            this.radioButtonHasta.TabIndex = 17;
            this.radioButtonHasta.TabStop = true;
            this.radioButtonHasta.Text = "Hasta Adı";
            this.radioButtonHasta.UseVisualStyleBackColor = true;
            // 
            // bilgitxt
            // 
            this.bilgitxt.Location = new System.Drawing.Point(885, 252);
            this.bilgitxt.Multiline = true;
            this.bilgitxt.Name = "bilgitxt";
            this.bilgitxt.Size = new System.Drawing.Size(162, 40);
            this.bilgitxt.TabIndex = 19;
            // 
            // Getirbtn
            // 
            this.Getirbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Getirbtn.ForeColor = System.Drawing.Color.White;
            this.Getirbtn.Location = new System.Drawing.Point(1095, 252);
            this.Getirbtn.Name = "Getirbtn";
            this.Getirbtn.Size = new System.Drawing.Size(122, 44);
            this.Getirbtn.TabIndex = 20;
            this.Getirbtn.Text = "Ekrana Getir";
            this.Getirbtn.UseVisualStyleBackColor = false;
            this.Getirbtn.Click += new System.EventHandler(this.Getirbtn_Click);
            // 
            // degerlabel
            // 
            this.degerlabel.AutoSize = true;
            this.degerlabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degerlabel.ForeColor = System.Drawing.Color.Black;
            this.degerlabel.Location = new System.Drawing.Point(856, 162);
            this.degerlabel.Name = "degerlabel";
            this.degerlabel.Size = new System.Drawing.Size(346, 19);
            this.degerlabel.TabIndex = 21;
            this.degerlabel.Text = "İstediğiniz bilgileri getimek için seçim yapınız";
            this.degerlabel.Click += new System.EventHandler(this.degerlabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(856, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(345, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tabloyu hangi sıralamayla görmek istersiniz?";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Location = new System.Drawing.Point(1304, 19);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(35, 16);
            this.labelSaat.TabIndex = 23;
            this.labelSaat.Text = "Saat";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 45);
            this.button2.TabIndex = 20;
            this.button2.Text = "Önceki Sayfaya Dön <<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(204, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(896, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Güncellemek istiyorsanız yalnızca güncellenecek bilgileri giriniz kayıt eklemek i" +
    "stiyorsanız lütfen boş alan bırakmayınız\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "HASTA KAYITLARI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.anasekme.ResumeLayout(false);
            this.anasekme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.eklesekme.ResumeLayout(false);
            this.eklesekme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage anasekme;
        private System.Windows.Forms.Button KayitSilbtn;
        private System.Windows.Forms.Button gosterbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage eklesekme;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textdy;
        private System.Windows.Forms.TextBox textdt;
        private System.Windows.Forms.TextBox textadres;
        private System.Windows.Forms.TextBox texttel;
        private System.Windows.Forms.TextBox textilac;
        private System.Windows.Forms.TextBox texthastalik;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox texttc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Listelebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonHastalik;
        private System.Windows.Forms.RadioButton radioButtonTc;
        private System.Windows.Forms.RadioButton radioButtonHasta;
        private System.Windows.Forms.TextBox bilgitxt;
        private System.Windows.Forms.Button Getirbtn;
        private System.Windows.Forms.Label degerlabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

