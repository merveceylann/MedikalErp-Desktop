
namespace IEA_ErpProject102MC_Main.BilgiGirisIslemleri.Hastaneler
{
    partial class frmHastaneGirisEkrani
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtYetAdi1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtYetAdi2 = new System.Windows.Forms.TextBox();
            this.txtYetDep2 = new System.Windows.Forms.ComboBox();
            this.txtYetAdi3 = new System.Windows.Forms.TextBox();
            this.txtYetDep3 = new System.Windows.Forms.ComboBox();
            this.txtYetTel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetCep1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetTel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetCep2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetTel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetCep3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYetEmail1 = new System.Windows.Forms.TextBox();
            this.txtYetEmail2 = new System.Windows.Forms.TextBox();
            this.txtYetEmail3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHastTipi = new System.Windows.Forms.ComboBox();
            this.txtHastAdi = new System.Windows.Forms.TextBox();
            this.txtHastUnvan = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.txtHastTel = new System.Windows.Forms.MaskedTextBox();
            this.txtHastMail = new System.Windows.Forms.TextBox();
            this.txtYetDep1 = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.txtVergiD = new System.Windows.Forms.TextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariYetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.lblHastaneKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1022, 58);
            this.pnlUst.TabIndex = 0;
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 474);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1022, 28);
            this.pnlAlt.TabIndex = 1;
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
            this.CariMail,
            this.CariYetkili});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 355);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1022, 119);
            this.Liste.TabIndex = 2;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 344);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1022, 11);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane Adi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hastane Unvan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres 1 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(321, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adres 2 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vergi Dairesi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(278, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 40);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vergi No\r\n- Tc No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hastene Tel :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hastene Mail :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sehir :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(632, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Telefon";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(717, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cep Telefonu";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(823, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "E-Mail";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYetAdi1
            // 
            this.txtYetAdi1.Location = new System.Drawing.Point(375, 27);
            this.txtYetAdi1.Name = "txtYetAdi1";
            this.txtYetAdi1.Size = new System.Drawing.Size(126, 20);
            this.txtYetAdi1.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(507, -2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "Departmani";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(372, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Yetkili Adi";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYetAdi2
            // 
            this.txtYetAdi2.Location = new System.Drawing.Point(375, 53);
            this.txtYetAdi2.Name = "txtYetAdi2";
            this.txtYetAdi2.Size = new System.Drawing.Size(126, 20);
            this.txtYetAdi2.TabIndex = 13;
            // 
            // txtYetDep2
            // 
            this.txtYetDep2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtYetDep2.FormattingEnabled = true;
            this.txtYetDep2.Location = new System.Drawing.Point(508, 53);
            this.txtYetDep2.Name = "txtYetDep2";
            this.txtYetDep2.Size = new System.Drawing.Size(121, 21);
            this.txtYetDep2.TabIndex = 14;
            // 
            // txtYetAdi3
            // 
            this.txtYetAdi3.Location = new System.Drawing.Point(375, 78);
            this.txtYetAdi3.Name = "txtYetAdi3";
            this.txtYetAdi3.Size = new System.Drawing.Size(126, 20);
            this.txtYetAdi3.TabIndex = 18;
            // 
            // txtYetDep3
            // 
            this.txtYetDep3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtYetDep3.FormattingEnabled = true;
            this.txtYetDep3.Location = new System.Drawing.Point(508, 79);
            this.txtYetDep3.Name = "txtYetDep3";
            this.txtYetDep3.Size = new System.Drawing.Size(121, 21);
            this.txtYetDep3.TabIndex = 19;
            // 
            // txtYetTel1
            // 
            this.txtYetTel1.Location = new System.Drawing.Point(635, 25);
            this.txtYetTel1.Mask = "(999) 000-0000";
            this.txtYetTel1.Name = "txtYetTel1";
            this.txtYetTel1.Size = new System.Drawing.Size(87, 20);
            this.txtYetTel1.TabIndex = 11;
            // 
            // txtYetCep1
            // 
            this.txtYetCep1.Location = new System.Drawing.Point(726, 26);
            this.txtYetCep1.Mask = "(999) 000-0000";
            this.txtYetCep1.Name = "txtYetCep1";
            this.txtYetCep1.Size = new System.Drawing.Size(87, 20);
            this.txtYetCep1.TabIndex = 12;
            // 
            // txtYetTel2
            // 
            this.txtYetTel2.Location = new System.Drawing.Point(635, 51);
            this.txtYetTel2.Mask = "(999) 000-0000";
            this.txtYetTel2.Name = "txtYetTel2";
            this.txtYetTel2.Size = new System.Drawing.Size(85, 20);
            this.txtYetTel2.TabIndex = 15;
            // 
            // txtYetCep2
            // 
            this.txtYetCep2.Location = new System.Drawing.Point(726, 52);
            this.txtYetCep2.Mask = "(999) 000-0000";
            this.txtYetCep2.Name = "txtYetCep2";
            this.txtYetCep2.Size = new System.Drawing.Size(87, 20);
            this.txtYetCep2.TabIndex = 16;
            // 
            // txtYetTel3
            // 
            this.txtYetTel3.Location = new System.Drawing.Point(635, 78);
            this.txtYetTel3.Mask = "(999) 000-0000";
            this.txtYetTel3.Name = "txtYetTel3";
            this.txtYetTel3.Size = new System.Drawing.Size(85, 20);
            this.txtYetTel3.TabIndex = 20;
            // 
            // txtYetCep3
            // 
            this.txtYetCep3.Location = new System.Drawing.Point(726, 79);
            this.txtYetCep3.Mask = "(999) 000-0000";
            this.txtYetCep3.Name = "txtYetCep3";
            this.txtYetCep3.Size = new System.Drawing.Size(87, 20);
            this.txtYetCep3.TabIndex = 21;
            // 
            // txtYetEmail1
            // 
            this.txtYetEmail1.Location = new System.Drawing.Point(823, 26);
            this.txtYetEmail1.Name = "txtYetEmail1";
            this.txtYetEmail1.Size = new System.Drawing.Size(155, 20);
            this.txtYetEmail1.TabIndex = 13;
            // 
            // txtYetEmail2
            // 
            this.txtYetEmail2.Location = new System.Drawing.Point(823, 52);
            this.txtYetEmail2.Name = "txtYetEmail2";
            this.txtYetEmail2.Size = new System.Drawing.Size(155, 20);
            this.txtYetEmail2.TabIndex = 17;
            // 
            // txtYetEmail3
            // 
            this.txtYetEmail3.Location = new System.Drawing.Point(823, 79);
            this.txtYetEmail3.Name = "txtYetEmail3";
            this.txtYetEmail3.Size = new System.Drawing.Size(155, 20);
            this.txtYetEmail3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Hastane Tipi :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastTipi
            // 
            this.txtHastTipi.FormattingEnabled = true;
            this.txtHastTipi.Location = new System.Drawing.Point(109, 0);
            this.txtHastTipi.Name = "txtHastTipi";
            this.txtHastTipi.Size = new System.Drawing.Size(121, 21);
            this.txtHastTipi.TabIndex = 0;
            // 
            // txtHastAdi
            // 
            this.txtHastAdi.Location = new System.Drawing.Point(109, 32);
            this.txtHastAdi.Name = "txtHastAdi";
            this.txtHastAdi.Size = new System.Drawing.Size(245, 20);
            this.txtHastAdi.TabIndex = 1;
            // 
            // txtHastUnvan
            // 
            this.txtHastUnvan.Location = new System.Drawing.Point(109, 58);
            this.txtHastUnvan.Name = "txtHastUnvan";
            this.txtHastUnvan.Size = new System.Drawing.Size(245, 20);
            this.txtHastUnvan.TabIndex = 2;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(109, 111);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(245, 44);
            this.txtAdres1.TabIndex = 4;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(427, 106);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(245, 44);
            this.txtAdres2.TabIndex = 5;
            // 
            // txtHastTel
            // 
            this.txtHastTel.Location = new System.Drawing.Point(109, 160);
            this.txtHastTel.Mask = "(999) 000-0000";
            this.txtHastTel.Name = "txtHastTel";
            this.txtHastTel.Size = new System.Drawing.Size(100, 20);
            this.txtHastTel.TabIndex = 6;
            // 
            // txtHastMail
            // 
            this.txtHastMail.Location = new System.Drawing.Point(109, 185);
            this.txtHastMail.Name = "txtHastMail";
            this.txtHastMail.Size = new System.Drawing.Size(163, 20);
            this.txtHastMail.TabIndex = 7;
            // 
            // txtYetDep1
            // 
            this.txtYetDep1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtYetDep1.FormattingEnabled = true;
            this.txtYetDep1.Location = new System.Drawing.Point(508, 27);
            this.txtYetDep1.Name = "txtYetDep1";
            this.txtYetDep1.Size = new System.Drawing.Size(121, 21);
            this.txtYetDep1.TabIndex = 10;
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(109, 84);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(163, 21);
            this.txtSehir.TabIndex = 3;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(360, 211);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(88, 20);
            this.txtVnTc.TabIndex = 8;
            // 
            // txtVergiD
            // 
            this.txtVergiD.Location = new System.Drawing.Point(109, 211);
            this.txtVergiD.Name = "txtVergiD";
            this.txtVergiD.Size = new System.Drawing.Size(186, 20);
            this.txtVergiD.TabIndex = 8;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.txtVergiD);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtHastMail);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtHastTel);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtHastUnvan);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtHastAdi);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.txtHastTipi);
            this.pnlOrta.Controls.Add(this.txtYetEmail3);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtYetEmail2);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.txtYetEmail1);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtYetCep3);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtYetCep2);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtYetTel3);
            this.pnlOrta.Controls.Add(this.txtYetAdi1);
            this.pnlOrta.Controls.Add(this.txtYetTel2);
            this.pnlOrta.Controls.Add(this.txtYetAdi2);
            this.pnlOrta.Controls.Add(this.txtYetCep1);
            this.pnlOrta.Controls.Add(this.txtYetAdi3);
            this.pnlOrta.Controls.Add(this.txtYetTel1);
            this.pnlOrta.Controls.Add(this.txtYetDep1);
            this.pnlOrta.Controls.Add(this.txtYetDep3);
            this.pnlOrta.Controls.Add(this.txtYetDep2);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 58);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1022, 286);
            this.pnlOrta.TabIndex = 4;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(966, 8);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(45, 40);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.Sil32x32;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(153, 13);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(40, 39);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(107, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(40, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(61, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(40, 40);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::IEA_ErpProject102MC_Main.Properties.Resources.Save_icon64x64;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(15, 12);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(40, 40);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(464, 19);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(100, 23);
            this.lblHastaneKodu.TabIndex = 4;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Hastane Kodu";
            this.CariKodu.Name = "CariKodu";
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Hastane Adi";
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Hasane Telefonu";
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 105;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Hastane Mail";
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 87;
            // 
            // CariYetkili
            // 
            this.CariYetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariYetkili.HeaderText = "Yetkili Kisi";
            this.CariYetkili.Name = "CariYetkili";
            // 
            // frmHastaneGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1022, 502);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmHastaneGirisEkrani";
            this.Text = "frmHastaneGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHastaneGirisEkrani_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtYetAdi1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtYetAdi2;
        private System.Windows.Forms.ComboBox txtYetDep2;
        private System.Windows.Forms.TextBox txtYetAdi3;
        private System.Windows.Forms.ComboBox txtYetDep3;
        private System.Windows.Forms.MaskedTextBox txtYetTel1;
        private System.Windows.Forms.MaskedTextBox txtYetCep1;
        private System.Windows.Forms.MaskedTextBox txtYetTel2;
        private System.Windows.Forms.MaskedTextBox txtYetCep2;
        private System.Windows.Forms.MaskedTextBox txtYetTel3;
        private System.Windows.Forms.MaskedTextBox txtYetCep3;
        private System.Windows.Forms.TextBox txtYetEmail1;
        private System.Windows.Forms.TextBox txtYetEmail2;
        private System.Windows.Forms.TextBox txtYetEmail3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtHastTipi;
        private System.Windows.Forms.TextBox txtHastAdi;
        private System.Windows.Forms.TextBox txtHastUnvan;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.MaskedTextBox txtHastTel;
        private System.Windows.Forms.TextBox txtHastMail;
        private System.Windows.Forms.ComboBox txtYetDep1;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.TextBox txtVergiD;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariYetkili;
    }
}