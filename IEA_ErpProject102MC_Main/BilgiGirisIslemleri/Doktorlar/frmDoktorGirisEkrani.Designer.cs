
namespace IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Doktorlar
{
    partial class frmDoktorGirisEkrani
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
            this.txtDokVergiD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDokVnTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDokMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDokTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDokMAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDokHAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDokAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDokGsm = new System.Windows.Forms.MaskedTextBox();
            this.txtDokDep = new System.Windows.Forms.ComboBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtDKoduBul = new System.Windows.Forms.TextBox();
            this.txtDokUnvan = new System.Windows.Forms.ComboBox();
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
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblDoktorKodu = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDokVergiD
            // 
            this.txtDokVergiD.Location = new System.Drawing.Point(721, 165);
            this.txtDokVergiD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokVergiD.Name = "txtDokVergiD";
            this.txtDokVergiD.Size = new System.Drawing.Size(247, 22);
            this.txtDokVergiD.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktor Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokVnTc
            // 
            this.txtDokVnTc.Location = new System.Drawing.Point(721, 212);
            this.txtDokVnTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokVnTc.Mask = "00000000000";
            this.txtDokVnTc.Name = "txtDokVnTc";
            this.txtDokVnTc.Size = new System.Drawing.Size(120, 22);
            this.txtDokVnTc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Unvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(171, 111);
            this.txtSehir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(216, 24);
            this.txtSehir.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(580, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vergi Dairesi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokMail
            // 
            this.txtDokMail.Location = new System.Drawing.Point(168, 266);
            this.txtDokMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokMail.Name = "txtDokMail";
            this.txtDokMail.Size = new System.Drawing.Size(216, 22);
            this.txtDokMail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(612, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 49);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vergi No\r\n- Tc No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDokTel
            // 
            this.txtDokTel.Location = new System.Drawing.Point(171, 191);
            this.txtDokTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokTel.Mask = "(999) 000-0000";
            this.txtDokTel.Name = "txtDokTel";
            this.txtDokTel.Size = new System.Drawing.Size(132, 22);
            this.txtDokTel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(580, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dok. Hast Adres  :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokMAdres
            // 
            this.txtDokMAdres.Location = new System.Drawing.Point(721, 95);
            this.txtDokMAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokMAdres.Multiline = true;
            this.txtDokMAdres.Name = "txtDokMAdres";
            this.txtDokMAdres.Size = new System.Drawing.Size(325, 53);
            this.txtDokMAdres.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(29, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor Tel :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokHAdres
            // 
            this.txtDokHAdres.Location = new System.Drawing.Point(721, 15);
            this.txtDokHAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokHAdres.Multiline = true;
            this.txtDokHAdres.Name = "txtDokHAdres";
            this.txtDokHAdres.Size = new System.Drawing.Size(325, 53);
            this.txtDokHAdres.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(563, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dok. Muayene Adres :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(29, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Doktor Mail :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokAdi
            // 
            this.txtDokAdi.Location = new System.Drawing.Point(168, 75);
            this.txtDokAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokAdi.Name = "txtDokAdi";
            this.txtDokAdi.Size = new System.Drawing.Size(325, 22);
            this.txtDokAdi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(29, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sehir :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(41, 151);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 28);
            this.label15.TabIndex = 4;
            this.label15.Text = "Departmani";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(41, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cep Telefonu";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDokGsm
            // 
            this.txtDokGsm.Location = new System.Drawing.Point(171, 224);
            this.txtDokGsm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokGsm.Mask = "(999) 000-0000";
            this.txtDokGsm.Name = "txtDokGsm";
            this.txtDokGsm.Size = new System.Drawing.Size(115, 22);
            this.txtDokGsm.TabIndex = 12;
            // 
            // txtDokDep
            // 
            this.txtDokDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDokDep.FormattingEnabled = true;
            this.txtDokDep.Location = new System.Drawing.Point(171, 154);
            this.txtDokDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokDep.Name = "txtDokDep";
            this.txtDokDep.Size = new System.Drawing.Size(160, 24);
            this.txtDokDep.TabIndex = 10;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.txtDokGsm);
            this.pnlOrta.Controls.Add(this.txtDokDep);
            this.pnlOrta.Controls.Add(this.txtDKoduBul);
            this.pnlOrta.Controls.Add(this.txtDokUnvan);
            this.pnlOrta.Controls.Add(this.txtDokVergiD);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtDokVnTc);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtDokMail);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtDokTel);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtDokMAdres);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtDokHAdres);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtDokAdi);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 71);
            this.pnlOrta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1371, 353);
            this.pnlOrta.TabIndex = 9;
            // 
            // txtDKoduBul
            // 
            this.txtDKoduBul.Location = new System.Drawing.Point(45, 7);
            this.txtDKoduBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDKoduBul.Name = "txtDKoduBul";
            this.txtDKoduBul.Size = new System.Drawing.Size(451, 22);
            this.txtDKoduBul.TabIndex = 24;
            // 
            // txtDokUnvan
            // 
            this.txtDokUnvan.FormattingEnabled = true;
            this.txtDokUnvan.Location = new System.Drawing.Point(168, 42);
            this.txtDokUnvan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDokUnvan.Name = "txtDokUnvan";
            this.txtDokUnvan.Size = new System.Drawing.Size(328, 24);
            this.txtDokUnvan.TabIndex = 20;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1296, 10);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(53, 49);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 424);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1371, 14);
            this.splitter1.TabIndex = 8;
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
            this.CariMail});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 438);
            this.Liste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Doktor Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 107;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Doktor Adi";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Doktor Telefonu";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 127;
            // 
            // DoktorGsm
            // 
            this.DoktorGsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DoktorGsm.HeaderText = "Doktor Gsm";
            this.DoktorGsm.MinimumWidth = 6;
            this.DoktorGsm.Name = "DoktorGsm";
            this.DoktorGsm.Width = 103;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Doktor Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 584);
            this.pnlAlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1371, 34);
            this.pnlAlt.TabIndex = 6;
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.lblDoktorKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1371, 71);
            this.pnlUst.TabIndex = 5;
            // 
            // lblDoktorKodu
            // 
            this.lblDoktorKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoktorKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorKodu.Location = new System.Drawing.Point(623, 23);
            this.lblDoktorKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoktorKodu.Name = "lblDoktorKodu";
            this.lblDoktorKodu.Size = new System.Drawing.Size(133, 28);
            this.lblDoktorKodu.TabIndex = 4;
            this.lblDoktorKodu.Text = "***";
            this.lblDoktorKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(81, 15);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(53, 49);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmDoktorGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 618);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoktorGirisEkrani";
            this.Text = "frmDoktorGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoktorGirisEkrani_Load);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtDokVergiD;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtDokVnTc;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDokMail;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txtDokTel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDokMAdres;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDokHAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtDokAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox txtDokGsm;
        public System.Windows.Forms.ComboBox txtDokDep;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlUst;
        public System.Windows.Forms.Label lblDoktorKodu;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox txtDokUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorGsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.TextBox txtDKoduBul;
    }
}