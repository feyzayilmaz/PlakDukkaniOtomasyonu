namespace PlakDukkaniBoostMaraton_UI
{
    partial class frm_Listeler
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAlbumAdi = new TextBox();
            label6 = new Label();
            txtSanatci = new TextBox();
            txtFiyati = new TextBox();
            txtIndirimOrani = new TextBox();
            rdoDevam = new RadioButton();
            rdoDurdu = new RadioButton();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvBilgiler = new DataGridView();
            cmbListeSecim = new ComboBox();
            dtCikisTarihi = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBilgiler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Albüm Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 55);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 83);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 112);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Fiyatı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 140);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "İndirim Oranı:";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(122, 26);
            txtAlbumAdi.Margin = new Padding(3, 2, 3, 2);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(219, 23);
            txtAlbumAdi.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 169);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 6;
            label6.Text = "Satış Durumu:";
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(122, 52);
            txtSanatci.Margin = new Padding(3, 2, 3, 2);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(219, 23);
            txtSanatci.TabIndex = 7;
            // 
            // txtFiyati
            // 
            txtFiyati.Location = new Point(122, 110);
            txtFiyati.Margin = new Padding(3, 2, 3, 2);
            txtFiyati.Name = "txtFiyati";
            txtFiyati.Size = new Size(219, 23);
            txtFiyati.TabIndex = 9;
            // 
            // txtIndirimOrani
            // 
            txtIndirimOrani.Location = new Point(122, 137);
            txtIndirimOrani.Margin = new Padding(3, 2, 3, 2);
            txtIndirimOrani.Name = "txtIndirimOrani";
            txtIndirimOrani.Size = new Size(219, 23);
            txtIndirimOrani.TabIndex = 10;
            // 
            // rdoDevam
            // 
            rdoDevam.AutoSize = true;
            rdoDevam.Location = new Point(146, 167);
            rdoDevam.Margin = new Padding(3, 2, 3, 2);
            rdoDevam.Name = "rdoDevam";
            rdoDevam.Size = new Size(62, 19);
            rdoDevam.TabIndex = 12;
            rdoDevam.TabStop = true;
            rdoDevam.Text = "Devam";
            rdoDevam.UseVisualStyleBackColor = true;
            // 
            // rdoDurdu
            // 
            rdoDurdu.AutoSize = true;
            rdoDurdu.Location = new Point(245, 167);
            rdoDurdu.Margin = new Padding(3, 2, 3, 2);
            rdoDurdu.Name = "rdoDurdu";
            rdoDurdu.Size = new Size(58, 19);
            rdoDurdu.TabIndex = 13;
            rdoDurdu.TabStop = true;
            rdoDurdu.Text = "Durdu";
            rdoDurdu.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 202);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(78, 37);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(96, 202);
            btnGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 37);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(177, 202);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(82, 37);
            btnSil.TabIndex = 16;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvBilgiler
            // 
            dgvBilgiler.AllowUserToAddRows = false;
            dgvBilgiler.AllowUserToDeleteRows = false;
            dgvBilgiler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBilgiler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBilgiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBilgiler.Location = new Point(357, 52);
            dgvBilgiler.Margin = new Padding(3, 2, 3, 2);
            dgvBilgiler.MultiSelect = false;
            dgvBilgiler.Name = "dgvBilgiler";
            dgvBilgiler.ReadOnly = true;
            dgvBilgiler.RowHeadersWidth = 51;
            dgvBilgiler.RowTemplate.Height = 29;
            dgvBilgiler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBilgiler.Size = new Size(715, 564);
            dgvBilgiler.TabIndex = 17;
            dgvBilgiler.CellClick += dgvBilgiler_CellClick;
            // 
            // cmbListeSecim
            // 
            cmbListeSecim.FormattingEnabled = true;
            cmbListeSecim.Location = new Point(357, 12);
            cmbListeSecim.Name = "cmbListeSecim";
            cmbListeSecim.Size = new Size(697, 23);
            cmbListeSecim.TabIndex = 25;
            cmbListeSecim.SelectedIndexChanged += cmbListeSecim_SelectedIndexChanged;
            // 
            // dtCikisTarihi
            // 
            dtCikisTarihi.Location = new Point(122, 82);
            dtCikisTarihi.Name = "dtCikisTarihi";
            dtCikisTarihi.Size = new Size(200, 23);
            dtCikisTarihi.TabIndex = 26;
            // 
            // frm_Listeler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 627);
            Controls.Add(dtCikisTarihi);
            Controls.Add(cmbListeSecim);
            Controls.Add(dgvBilgiler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(rdoDurdu);
            Controls.Add(rdoDevam);
            Controls.Add(txtIndirimOrani);
            Controls.Add(txtFiyati);
            Controls.Add(txtSanatci);
            Controls.Add(label6);
            Controls.Add(txtAlbumAdi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_Listeler";
            Text = "AnaBolum";
            Load += frm_Listeler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBilgiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAlbumAdi;
        private Label label6;
        private TextBox txtSanatci;
        private TextBox txtFiyati;
        private TextBox txtIndirimOrani;
        private RadioButton rdoDevam;
        private RadioButton rdoDurdu;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvBilgiler;
        private ComboBox cmbListeSecim;
        private DateTimePicker dtCikisTarihi;
    }
}