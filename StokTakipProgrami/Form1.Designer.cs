namespace StokTakipProgrami
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAraSatis = new System.Windows.Forms.CheckBox();
            this.buttonSilBarkod = new System.Windows.Forms.Button();
            this.buttonAraTur = new System.Windows.Forms.Button();
            this.buttonAraBarkod = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAraTur = new System.Windows.Forms.ComboBox();
            this.textBoxAraBarkod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.numericUpDownFiyat = new System.Windows.Forms.NumericUpDown();
            this.buttonKayitTamam = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxKayit = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBarkod = new System.Windows.Forms.TextBox();
            this.buttonResim = new System.Windows.Forms.Button();
            this.textBoxUrunAd = new System.Windows.Forms.TextBox();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.comboBoxBirim = new System.Windows.Forms.ComboBox();
            this.checkBoxSatis = new System.Windows.Forms.CheckBox();
            this.numericUpDownStok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDepo = new System.Windows.Forms.ComboBox();
            this.comboBoxCinsi = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxGuncelle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKayit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 70);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(419, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "Yenile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ürün Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ürün Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ürün Ara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(546, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 645);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 639);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(12, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 569);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxGuncelle);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.checkBoxAraSatis);
            this.groupBox2.Controls.Add(this.buttonSilBarkod);
            this.groupBox2.Controls.Add(this.buttonAraTur);
            this.groupBox2.Controls.Add(this.buttonAraBarkod);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBoxAraTur);
            this.groupBox2.Controls.Add(this.textBoxAraBarkod);
            this.groupBox2.Location = new System.Drawing.Point(10, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 228);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Urun Ara";
            // 
            // checkBoxAraSatis
            // 
            this.checkBoxAraSatis.AutoSize = true;
            this.checkBoxAraSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxAraSatis.Location = new System.Drawing.Point(200, 185);
            this.checkBoxAraSatis.Name = "checkBoxAraSatis";
            this.checkBoxAraSatis.Size = new System.Drawing.Size(217, 24);
            this.checkBoxAraSatis.TabIndex = 28;
            this.checkBoxAraSatis.Text = "Satışı Etkin Ürünleri Arama";
            this.checkBoxAraSatis.UseVisualStyleBackColor = true;
            this.checkBoxAraSatis.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonSilBarkod
            // 
            this.buttonSilBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSilBarkod.Location = new System.Drawing.Point(98, 70);
            this.buttonSilBarkod.Name = "buttonSilBarkod";
            this.buttonSilBarkod.Size = new System.Drawing.Size(86, 31);
            this.buttonSilBarkod.TabIndex = 24;
            this.buttonSilBarkod.Text = "Barkod Sil";
            this.buttonSilBarkod.UseVisualStyleBackColor = true;
            this.buttonSilBarkod.Click += new System.EventHandler(this.buttonSilBarkod_Click);
            // 
            // buttonAraTur
            // 
            this.buttonAraTur.Location = new System.Drawing.Point(232, 71);
            this.buttonAraTur.Name = "buttonAraTur";
            this.buttonAraTur.Size = new System.Drawing.Size(85, 31);
            this.buttonAraTur.TabIndex = 23;
            this.buttonAraTur.Text = "Tür Ara";
            this.buttonAraTur.UseVisualStyleBackColor = true;
            this.buttonAraTur.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // buttonAraBarkod
            // 
            this.buttonAraBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAraBarkod.Location = new System.Drawing.Point(6, 70);
            this.buttonAraBarkod.Name = "buttonAraBarkod";
            this.buttonAraBarkod.Size = new System.Drawing.Size(86, 31);
            this.buttonAraBarkod.TabIndex = 21;
            this.buttonAraBarkod.Text = "Barkod Ara";
            this.buttonAraBarkod.UseVisualStyleBackColor = true;
            this.buttonAraBarkod.Click += new System.EventHandler(this.buttonAraBarkod_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(231, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ürün Türü Arama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(5, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Barkod Arama";
            // 
            // comboBoxAraTur
            // 
            this.comboBoxAraTur.FormattingEnabled = true;
            this.comboBoxAraTur.Items.AddRange(new object[] {
            "Gıda",
            "Giyim",
            "Kirtasiye",
            "Temizlik",
            "İlac",
            "Yakit",
            "Elektronik",
            "Zuccaciye"});
            this.comboBoxAraTur.Location = new System.Drawing.Point(232, 44);
            this.comboBoxAraTur.Name = "comboBoxAraTur";
            this.comboBoxAraTur.Size = new System.Drawing.Size(178, 21);
            this.comboBoxAraTur.TabIndex = 21;
            // 
            // textBoxAraBarkod
            // 
            this.textBoxAraBarkod.Location = new System.Drawing.Point(6, 44);
            this.textBoxAraBarkod.Name = "textBoxAraBarkod";
            this.textBoxAraBarkod.Size = new System.Drawing.Size(178, 20);
            this.textBoxAraBarkod.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.numericUpDownFiyat);
            this.groupBox1.Controls.Add(this.buttonKayitTamam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBoxKayit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBarkod);
            this.groupBox1.Controls.Add(this.buttonResim);
            this.groupBox1.Controls.Add(this.textBoxUrunAd);
            this.groupBox1.Controls.Add(this.textBoxAciklama);
            this.groupBox1.Controls.Add(this.comboBoxBirim);
            this.groupBox1.Controls.Add(this.checkBoxSatis);
            this.groupBox1.Controls.Add(this.numericUpDownStok);
            this.groupBox1.Controls.Add(this.comboBoxDepo);
            this.groupBox1.Controls.Add(this.comboBoxCinsi);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 321);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Kayıt";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(307, 269);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(63, 42);
            this.buttonGuncelle.TabIndex = 21;
            this.buttonGuncelle.Text = "Ürün Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // numericUpDownFiyat
            // 
            this.numericUpDownFiyat.Location = new System.Drawing.Point(144, 191);
            this.numericUpDownFiyat.Name = "numericUpDownFiyat";
            this.numericUpDownFiyat.Size = new System.Drawing.Size(135, 20);
            this.numericUpDownFiyat.TabIndex = 20;
            // 
            // buttonKayitTamam
            // 
            this.buttonKayitTamam.Location = new System.Drawing.Point(376, 269);
            this.buttonKayitTamam.Name = "buttonKayitTamam";
            this.buttonKayitTamam.Size = new System.Drawing.Size(116, 42);
            this.buttonKayitTamam.TabIndex = 19;
            this.buttonKayitTamam.Text = "Ürün Kayıt";
            this.buttonKayitTamam.UseVisualStyleBackColor = true;
            this.buttonKayitTamam.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(18, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Açıklama";
            // 
            // pictureBoxKayit
            // 
            this.pictureBoxKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKayit.Location = new System.Drawing.Point(343, 32);
            this.pictureBoxKayit.Name = "pictureBoxKayit";
            this.pictureBoxKayit.Size = new System.Drawing.Size(149, 125);
            this.pictureBoxKayit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKayit.TabIndex = 0;
            this.pictureBoxKayit.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(18, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fiyat+KDV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(18, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cinsi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(18, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Depo Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Barkod";
            // 
            // textBoxBarkod
            // 
            this.textBoxBarkod.Location = new System.Drawing.Point(144, 32);
            this.textBoxBarkod.Name = "textBoxBarkod";
            this.textBoxBarkod.Size = new System.Drawing.Size(135, 20);
            this.textBoxBarkod.TabIndex = 1;
            // 
            // buttonResim
            // 
            this.buttonResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonResim.Location = new System.Drawing.Point(423, 164);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(69, 57);
            this.buttonResim.TabIndex = 10;
            this.buttonResim.Text = "Resim Ekle";
            this.buttonResim.UseVisualStyleBackColor = true;
            this.buttonResim.Click += new System.EventHandler(this.buttonResim_Click);
            // 
            // textBoxUrunAd
            // 
            this.textBoxUrunAd.Location = new System.Drawing.Point(144, 58);
            this.textBoxUrunAd.Name = "textBoxUrunAd";
            this.textBoxUrunAd.Size = new System.Drawing.Size(135, 20);
            this.textBoxUrunAd.TabIndex = 2;
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(144, 248);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(135, 63);
            this.textBoxAciklama.TabIndex = 9;
            // 
            // comboBoxBirim
            // 
            this.comboBoxBirim.FormattingEnabled = true;
            this.comboBoxBirim.Items.AddRange(new object[] {
            "Adet",
            "Koli",
            "Palet"});
            this.comboBoxBirim.Location = new System.Drawing.Point(144, 84);
            this.comboBoxBirim.Name = "comboBoxBirim";
            this.comboBoxBirim.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBirim.TabIndex = 3;
            // 
            // checkBoxSatis
            // 
            this.checkBoxSatis.Checked = true;
            this.checkBoxSatis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSatis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBoxSatis.Location = new System.Drawing.Point(343, 164);
            this.checkBoxSatis.Name = "checkBoxSatis";
            this.checkBoxSatis.Size = new System.Drawing.Size(74, 57);
            this.checkBoxSatis.TabIndex = 8;
            this.checkBoxSatis.Text = "Satışta ";
            this.checkBoxSatis.UseVisualStyleBackColor = true;
            // 
            // numericUpDownStok
            // 
            this.numericUpDownStok.Location = new System.Drawing.Point(144, 111);
            this.numericUpDownStok.Name = "numericUpDownStok";
            this.numericUpDownStok.Size = new System.Drawing.Size(135, 20);
            this.numericUpDownStok.TabIndex = 4;
            // 
            // comboBoxDepo
            // 
            this.comboBoxDepo.FormattingEnabled = true;
            this.comboBoxDepo.Items.AddRange(new object[] {
            "Ana Depo",
            "Yan Depo",
            "Diğer"});
            this.comboBoxDepo.Location = new System.Drawing.Point(144, 137);
            this.comboBoxDepo.Name = "comboBoxDepo";
            this.comboBoxDepo.Size = new System.Drawing.Size(135, 21);
            this.comboBoxDepo.TabIndex = 5;
            // 
            // comboBoxCinsi
            // 
            this.comboBoxCinsi.FormattingEnabled = true;
            this.comboBoxCinsi.Items.AddRange(new object[] {
            "Gıda",
            "Giyim",
            "Kirtasiye",
            "Temizlik",
            "İlac",
            "Yakit",
            "Elektronik",
            "Zuccaciye"});
            this.comboBoxCinsi.Location = new System.Drawing.Point(144, 164);
            this.comboBoxCinsi.Name = "comboBoxCinsi";
            this.comboBoxCinsi.Size = new System.Drawing.Size(135, 21);
            this.comboBoxCinsi.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(6, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 31);
            this.button6.TabIndex = 29;
            this.button6.Text = "Barkod Güncelle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // textBoxGuncelle
            // 
            this.textBoxGuncelle.Location = new System.Drawing.Point(6, 156);
            this.textBoxGuncelle.Name = "textBoxGuncelle";
            this.textBoxGuncelle.Size = new System.Drawing.Size(178, 20);
            this.textBoxGuncelle.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(6, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Barkod Güncelleme";
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(343, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 669);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKayit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxKayit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonResim;
        private System.Windows.Forms.TextBox textBoxUrunAd;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.ComboBox comboBoxBirim;
        private System.Windows.Forms.CheckBox checkBoxSatis;
        private System.Windows.Forms.NumericUpDown numericUpDownStok;
        private System.Windows.Forms.ComboBox comboBoxDepo;
        private System.Windows.Forms.ComboBox comboBoxCinsi;
        private System.Windows.Forms.Button buttonKayitTamam;
        private System.Windows.Forms.NumericUpDown numericUpDownFiyat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAraBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBarkod;
        private System.Windows.Forms.Button buttonAraTur;
        private System.Windows.Forms.Button buttonAraBarkod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAraTur;
        private System.Windows.Forms.Button buttonSilBarkod;
        private System.Windows.Forms.CheckBox checkBoxAraSatis;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxGuncelle;
        private System.Windows.Forms.Label label12;
    }
}

