
namespace IEA_ErpProject102MC_Main.UrunIslemleri
{
    partial class frmUrunBilgiGirisEkrani
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
            this.txtUKoduBul = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTFirmaId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKutuIcerik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParaB = new System.Windows.Forms.ComboBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.btnSure = new System.Windows.Forms.Button();
            this.txtKulTarih = new System.Windows.Forms.ComboBox();
            this.txtKSure = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.CheckBox();
            this.txtSkt = new System.Windows.Forms.DateTimePicker();
            this.txtUretimT = new System.Windows.Forms.DateTimePicker();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariYetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.pnlOrta.SuspendLayout();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUKoduBul
            // 
            this.txtUKoduBul.Location = new System.Drawing.Point(22, 17);
            this.txtUKoduBul.Margin = new System.Windows.Forms.Padding(4);
            this.txtUKoduBul.Name = "txtUKoduBul";
            this.txtUKoduBul.Size = new System.Drawing.Size(451, 22);
            this.txtUKoduBul.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(747, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Para Birimi :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(666, 49);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(125, 22);
            this.txtFiyat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Urun Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(147, 268);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarkod.Mask = "0000000000";
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(186, 22);
            this.txtBarkod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Urun Aciklama :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTFirmaId
            // 
            this.txtTFirmaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTFirmaId.FormattingEnabled = true;
            this.txtTFirmaId.Location = new System.Drawing.Point(147, 215);
            this.txtTFirmaId.Margin = new System.Windows.Forms.Padding(4);
            this.txtTFirmaId.Name = "txtTFirmaId";
            this.txtTFirmaId.Size = new System.Drawing.Size(186, 24);
            this.txtTFirmaId.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(518, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Urun Fiyat :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(29, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 49);
            this.label6.TabIndex = 4;
            this.label6.Text = "Urun Barkod :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kutu Icerik :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(509, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Son Kullanma Tarihi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKutuIcerik
            // 
            this.txtKutuIcerik.Location = new System.Drawing.Point(147, 147);
            this.txtKutuIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.txtKutuIcerik.Multiline = true;
            this.txtKutuIcerik.Name = "txtKutuIcerik";
            this.txtKutuIcerik.Size = new System.Drawing.Size(325, 58);
            this.txtKutuIcerik.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(526, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanim Suresi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Visible = false;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(147, 80);
            this.txtUrunAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(325, 58);
            this.txtUrunAciklama.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(526, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Uretim Tarihi :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(147, 49);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(325, 22);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tedarikci Firma :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtParaB
            // 
            this.txtParaB.FormattingEnabled = true;
            this.txtParaB.Location = new System.Drawing.Point(879, 47);
            this.txtParaB.Margin = new System.Windows.Forms.Padding(4);
            this.txtParaB.Name = "txtParaB";
            this.txtParaB.Size = new System.Drawing.Size(144, 24);
            this.txtParaB.TabIndex = 0;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.btnSure);
            this.pnlOrta.Controls.Add(this.txtKulTarih);
            this.pnlOrta.Controls.Add(this.txtKSure);
            this.pnlOrta.Controls.Add(this.txtDurum);
            this.pnlOrta.Controls.Add(this.txtParaB);
            this.pnlOrta.Controls.Add(this.txtSkt);
            this.pnlOrta.Controls.Add(this.txtUretimT);
            this.pnlOrta.Controls.Add(this.txtFiyat);
            this.pnlOrta.Controls.Add(this.txtUKoduBul);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtBarkod);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.txtTFirmaId);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtKutuIcerik);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtUrunAciklama);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtUrunAdi);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 71);
            this.pnlOrta.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1371, 353);
            this.pnlOrta.TabIndex = 9;
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(924, 153);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(209, 28);
            this.btnSure.TabIndex = 29;
            this.btnSure.Text = "Son Kullanma Tarihi Hesapla";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Visible = false;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // txtKulTarih
            // 
            this.txtKulTarih.FormattingEnabled = true;
            this.txtKulTarih.Location = new System.Drawing.Point(797, 156);
            this.txtKulTarih.Name = "txtKulTarih";
            this.txtKulTarih.Size = new System.Drawing.Size(121, 24);
            this.txtKulTarih.TabIndex = 28;
            this.txtKulTarih.Visible = false;
            // 
            // txtKSure
            // 
            this.txtKSure.Location = new System.Drawing.Point(666, 157);
            this.txtKSure.Name = "txtKSure";
            this.txtKSure.Size = new System.Drawing.Size(125, 22);
            this.txtKSure.TabIndex = 27;
            this.txtKSure.Visible = false;
            // 
            // txtDurum
            // 
            this.txtDurum.AutoSize = true;
            this.txtDurum.Location = new System.Drawing.Point(924, 121);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(243, 21);
            this.txtDurum.TabIndex = 26;
            this.txtDurum.Text = "Kullanim Sıresi Eklemek Istıyorum.";
            this.txtDurum.UseVisualStyleBackColor = true;
            this.txtDurum.CheckedChanged += new System.EventHandler(this.txtDurum_CheckedChanged);
            // 
            // txtSkt
            // 
            this.txtSkt.Location = new System.Drawing.Point(666, 120);
            this.txtSkt.Name = "txtSkt";
            this.txtSkt.Size = new System.Drawing.Size(252, 22);
            this.txtSkt.TabIndex = 25;
            // 
            // txtUretimT
            // 
            this.txtUretimT.Location = new System.Drawing.Point(666, 89);
            this.txtUretimT.Name = "txtUretimT";
            this.txtUretimT.Size = new System.Drawing.Size(252, 22);
            this.txtUretimT.TabIndex = 24;
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.lblUrunKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1371, 71);
            this.pnlUst.TabIndex = 5;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(623, 23);
            this.lblUrunKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(133, 28);
            this.lblUrunKodu.TabIndex = 4;
            this.lblUrunKodu.Text = "***";
            this.lblUrunKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.UrunKodu,
            this.UrunAdi,
            this.CariTel,
            this.Barkod,
            this.fiyat,
            this.CariYetkili});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 424);
            this.Liste.Margin = new System.Windows.Forms.Padding(4);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.Size = new System.Drawing.Size(1371, 146);
            this.Liste.TabIndex = 7;
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
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.MinimumWidth = 6;
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.Width = 97;
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi.HeaderText = "Urun Adi";
            this.UrunAdi.MinimumWidth = 6;
            this.UrunAdi.Name = "UrunAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariTel.HeaderText = "Urun Aciklama";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barkod.HeaderText = "Urun Barkod";
            this.Barkod.MinimumWidth = 6;
            this.Barkod.Name = "Barkod";
            this.Barkod.Width = 108;
            // 
            // fiyat
            // 
            this.fiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.MinimumWidth = 6;
            this.fiyat.Name = "fiyat";
            this.fiyat.Width = 67;
            // 
            // CariYetkili
            // 
            this.CariYetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariYetkili.HeaderText = "Son Kullanma Tarihi";
            this.CariYetkili.MinimumWidth = 6;
            this.CariYetkili.Name = "CariYetkili";
            this.CariYetkili.Width = 150;
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 570);
            this.pnlAlt.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1371, 34);
            this.pnlAlt.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 604);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1371, 14);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1296, 10);
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
            // frmUrunBilgiGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 618);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.splitter1);
            this.Name = "frmUrunBilgiGirisEkrani";
            this.Text = "frmUrunBilgiGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUrunBilgiGirisEkrani_Load);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUKoduBul;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtKutuIcerik;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtParaB;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Panel pnlUst;
        public System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox txtTFirmaId;
        private System.Windows.Forms.DateTimePicker txtSkt;
        private System.Windows.Forms.DateTimePicker txtUretimT;
        private System.Windows.Forms.ComboBox txtKulTarih;
        private System.Windows.Forms.TextBox txtKSure;
        private System.Windows.Forms.CheckBox txtDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariYetkili;
        private System.Windows.Forms.Button btnSure;
    }
}