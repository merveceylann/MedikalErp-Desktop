
namespace IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Personeller
{
    partial class frmPersonelGirisEkrani
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
            this.txtPGsm = new System.Windows.Forms.MaskedTextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtPUnvan = new System.Windows.Forms.ComboBox();
            this.txtPBitis = new System.Windows.Forms.DateTimePicker();
            this.txtPBaslama = new System.Windows.Forms.DateTimePicker();
            this.txtPDep = new System.Windows.Forms.ComboBox();
            this.txtHKoduBul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorGsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariBaslama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariBitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPersonelKodu = new System.Windows.Forms.Label();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPGsm
            // 
            this.txtPGsm.Location = new System.Drawing.Point(173, 229);
            this.txtPGsm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPGsm.Mask = "(999) 000-0000";
            this.txtPGsm.Name = "txtPGsm";
            this.txtPGsm.Size = new System.Drawing.Size(132, 22);
            this.txtPGsm.TabIndex = 12;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.checkBox1);
            this.pnlOrta.Controls.Add(this.txtPUnvan);
            this.pnlOrta.Controls.Add(this.txtPBitis);
            this.pnlOrta.Controls.Add(this.txtPBaslama);
            this.pnlOrta.Controls.Add(this.txtPGsm);
            this.pnlOrta.Controls.Add(this.txtPDep);
            this.pnlOrta.Controls.Add(this.txtHKoduBul);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtPMail);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtPTel);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtPAdres);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtPAdi);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 71);
            this.pnlOrta.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1379, 315);
            this.pnlOrta.TabIndex = 14;
            // 
            // txtPUnvan
            // 
            this.txtPUnvan.FormattingEnabled = true;
            this.txtPUnvan.Location = new System.Drawing.Point(167, 48);
            this.txtPUnvan.Margin = new System.Windows.Forms.Padding(4);
            this.txtPUnvan.Name = "txtPUnvan";
            this.txtPUnvan.Size = new System.Drawing.Size(328, 24);
            this.txtPUnvan.TabIndex = 26;
            // 
            // txtPBitis
            // 
            this.txtPBitis.CustomFormat = " ";
            this.txtPBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPBitis.Location = new System.Drawing.Point(720, 142);
            this.txtPBitis.Name = "txtPBitis";
            this.txtPBitis.Size = new System.Drawing.Size(200, 22);
            this.txtPBitis.TabIndex = 25;
            this.txtPBitis.Visible = false;
            this.txtPBitis.ValueChanged += new System.EventHandler(this.txtPBitis_ValueChanged);
            // 
            // txtPBaslama
            // 
            this.txtPBaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPBaslama.Location = new System.Drawing.Point(720, 102);
            this.txtPBaslama.Name = "txtPBaslama";
            this.txtPBaslama.Size = new System.Drawing.Size(200, 22);
            this.txtPBaslama.TabIndex = 25;
            // 
            // txtPDep
            // 
            this.txtPDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPDep.FormattingEnabled = true;
            this.txtPDep.Location = new System.Drawing.Point(173, 159);
            this.txtPDep.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDep.Name = "txtPDep";
            this.txtPDep.Size = new System.Drawing.Size(182, 24);
            this.txtPDep.TabIndex = 10;
            // 
            // txtHKoduBul
            // 
            this.txtHKoduBul.Location = new System.Drawing.Point(44, 15);
            this.txtHKoduBul.Margin = new System.Windows.Forms.Padding(4);
            this.txtHKoduBul.Name = "txtHKoduBul";
            this.txtHKoduBul.Size = new System.Drawing.Size(451, 22);
            this.txtHKoduBul.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Unvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(173, 116);
            this.txtSehir.Margin = new System.Windows.Forms.Padding(4);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(182, 24);
            this.txtSehir.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(562, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "İse Baslangic Tarihi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPMail
            // 
            this.txtPMail.Location = new System.Drawing.Point(170, 265);
            this.txtPMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtPMail.Name = "txtPMail";
            this.txtPMail.Size = new System.Drawing.Size(216, 22);
            this.txtPMail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(588, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 49);
            this.label6.TabIndex = 4;
            this.label6.Text = "İsten Ayrilis Tarihi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // txtPTel
            // 
            this.txtPTel.Location = new System.Drawing.Point(173, 196);
            this.txtPTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtPTel.Mask = "(999) 000-0000";
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(132, 22);
            this.txtPTel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(584, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Adres  :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(31, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Personel Tel :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPAdres
            // 
            this.txtPAdres.Location = new System.Drawing.Point(720, 22);
            this.txtPAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAdres.Multiline = true;
            this.txtPAdres.Name = "txtPAdres";
            this.txtPAdres.Size = new System.Drawing.Size(303, 68);
            this.txtPAdres.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(29, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Personel Mail :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPAdi
            // 
            this.txtPAdi.Location = new System.Drawing.Point(170, 80);
            this.txtPAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAdi.Name = "txtPAdi";
            this.txtPAdi.Size = new System.Drawing.Size(325, 22);
            this.txtPAdi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(31, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sehir :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(20, 156);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 28);
            this.label15.TabIndex = 4;
            this.label15.Text = "Departmani :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(31, 221);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cep Telefonu :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1304, 10);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(60, 49);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.Sil32x32;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(204, 16);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(53, 48);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(143, 15);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(53, 49);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.Save_icon64x64;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(20, 15);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(53, 49);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 386);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1379, 14);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.CariKodu,
            this.CariAdi,
            this.CariTel,
            this.DoktorGsm,
            this.CariMail,
            this.CariBaslama,
            this.CariBitis});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 400);
            this.Liste.Margin = new System.Windows.Forms.Padding(4);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.Size = new System.Drawing.Size(1379, 146);
            this.Liste.TabIndex = 12;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 6;
            this.Sira.Name = "Sira";
            this.Sira.Width = 62;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Personel Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 119;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Personel Adi";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Personel Telefonu";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 140;
            // 
            // DoktorGsm
            // 
            this.DoktorGsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DoktorGsm.HeaderText = "Personel Gsm";
            this.DoktorGsm.MinimumWidth = 6;
            this.DoktorGsm.Name = "DoktorGsm";
            this.DoktorGsm.Width = 116;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Personel Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 112;
            // 
            // CariBaslama
            // 
            this.CariBaslama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariBaslama.HeaderText = "Ise Baslama Tarihi";
            this.CariBaslama.MinimumWidth = 6;
            this.CariBaslama.Name = "CariBaslama";
            this.CariBaslama.Width = 140;
            // 
            // CariBitis
            // 
            this.CariBitis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariBitis.HeaderText = "Isten Ayrilma Tarihi";
            this.CariBitis.MinimumWidth = 6;
            this.CariBitis.Name = "CariBitis";
            this.CariBitis.Width = 144;
            // 
            // lblPersonelKodu
            // 
            this.lblPersonelKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPersonelKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKodu.Location = new System.Drawing.Point(627, 23);
            this.lblPersonelKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonelKodu.Name = "lblPersonelKodu";
            this.lblPersonelKodu.Size = new System.Drawing.Size(133, 28);
            this.lblPersonelKodu.TabIndex = 4;
            this.lblPersonelKodu.Text = "***";
            this.lblPersonelKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 546);
            this.pnlAlt.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1379, 34);
            this.pnlAlt.TabIndex = 11;
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.lblPersonelKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1379, 71);
            this.pnlUst.TabIndex = 10;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(81, 15);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(53, 49);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(926, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 21);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Is Bitis Tarihi Eklensin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmPersonelGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 580);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonelGirisEkrani";
            this.Text = "frmPersonelGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonelGirisEkrani_Load);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox txtPGsm;
        private System.Windows.Forms.Panel pnlOrta;
        public System.Windows.Forms.ComboBox txtPDep;
        private System.Windows.Forms.TextBox txtHKoduBul;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPMail;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txtPTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPAdres;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        public System.Windows.Forms.Label lblPersonelKodu;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker txtPBitis;
        private System.Windows.Forms.DateTimePicker txtPBaslama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorGsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariBaslama;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtPUnvan;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}