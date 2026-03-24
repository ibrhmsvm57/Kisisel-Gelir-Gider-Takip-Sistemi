namespace KisiselAsistan
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.YeniIslem = new System.Windows.Forms.GroupBox();
            this.dgvFinans = new System.Windows.Forms.DataGridView();
            this.lblGelir = new System.Windows.Forms.Label();
            this.lblGider = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.numTutar = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.dtpGorevTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.clbGorevler = new System.Windows.Forms.CheckedListBox();
            this.btnSilGorev = new System.Windows.Forms.Button();
            this.btnSilFinans = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.YeniIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(728, 426);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.lblNet);
            this.tabPage1.Controls.Add(this.lblGider);
            this.tabPage1.Controls.Add(this.lblGelir);
            this.tabPage1.Controls.Add(this.dgvFinans);
            this.tabPage1.Controls.Add(this.YeniIslem);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Finans";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.btnSilGorev);
            this.tabPage2.Controls.Add(this.clbGorevler);
            this.tabPage2.Controls.Add(this.btnGorevEkle);
            this.tabPage2.Controls.Add(this.dtpGorevTarih);
            this.tabPage2.Controls.Add(this.txtGorev);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yapılacaklar";
            // 
            // YeniIslem
            // 
            this.YeniIslem.Controls.Add(this.btnSilFinans);
            this.YeniIslem.Controls.Add(this.btnEkle);
            this.YeniIslem.Controls.Add(this.dtpTarih);
            this.YeniIslem.Controls.Add(this.txtAciklama);
            this.YeniIslem.Controls.Add(this.numTutar);
            this.YeniIslem.Controls.Add(this.cmbTur);
            this.YeniIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniIslem.Location = new System.Drawing.Point(23, 24);
            this.YeniIslem.Name = "YeniIslem";
            this.YeniIslem.Size = new System.Drawing.Size(664, 116);
            this.YeniIslem.TabIndex = 0;
            this.YeniIslem.TabStop = false;
            this.YeniIslem.Text = "İşlem Ekle";
            // 
            // dgvFinans
            // 
            this.dgvFinans.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFinans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinans.Location = new System.Drawing.Point(23, 162);
            this.dgvFinans.Name = "dgvFinans";
            this.dgvFinans.RowHeadersWidth = 51;
            this.dgvFinans.RowTemplate.Height = 24;
            this.dgvFinans.Size = new System.Drawing.Size(664, 136);
            this.dgvFinans.TabIndex = 1;
            // 
            // lblGelir
            // 
            this.lblGelir.AutoSize = true;
            this.lblGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelir.Location = new System.Drawing.Point(22, 329);
            this.lblGelir.Name = "lblGelir";
            this.lblGelir.Size = new System.Drawing.Size(44, 16);
            this.lblGelir.TabIndex = 2;
            this.lblGelir.Text = "Gelir:";
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGider.Location = new System.Drawing.Point(232, 329);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(49, 16);
            this.lblGider.TabIndex = 3;
            this.lblGider.Text = "Gider:";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNet.Location = new System.Drawing.Point(448, 329);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(35, 16);
            this.lblNet.TabIndex = 4;
            this.lblNet.Text = "Net:";
            // 
            // cmbTur
            // 
            this.cmbTur.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.cmbTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Gelir",
            "Gider"});
            this.cmbTur.Location = new System.Drawing.Point(424, 26);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 24);
            this.cmbTur.TabIndex = 5;
            this.cmbTur.Text = "Tür:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(20, 28);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(122, 22);
            this.txtAciklama.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(325, 70);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 31);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // numTutar
            // 
            this.numTutar.DecimalPlaces = 2;
            this.numTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numTutar.Location = new System.Drawing.Point(229, 28);
            this.numTutar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTutar.Name = "numTutar";
            this.numTutar.Size = new System.Drawing.Size(120, 22);
            this.numTutar.TabIndex = 8;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(20, 79);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(219, 22);
            this.dtpTarih.TabIndex = 9;
            // 
            // txtGorev
            // 
            this.txtGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorev.Location = new System.Drawing.Point(54, 25);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(173, 22);
            this.txtGorev.TabIndex = 0;
            this.txtGorev.Text = "Yapılacak Görev:";
            // 
            // dtpGorevTarih
            // 
            this.dtpGorevTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGorevTarih.Location = new System.Drawing.Point(342, 23);
            this.dtpGorevTarih.Name = "dtpGorevTarih";
            this.dtpGorevTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpGorevTarih.TabIndex = 1;
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.BackColor = System.Drawing.Color.Lime;
            this.btnGorevEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevEkle.Location = new System.Drawing.Point(54, 96);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(136, 34);
            this.btnGorevEkle.TabIndex = 2;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = false;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // clbGorevler
            // 
            this.clbGorevler.AccessibleName = "";
            this.clbGorevler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clbGorevler.FormattingEnabled = true;
            this.clbGorevler.Location = new System.Drawing.Point(30, 162);
            this.clbGorevler.Name = "clbGorevler";
            this.clbGorevler.Size = new System.Drawing.Size(640, 180);
            this.clbGorevler.TabIndex = 3;
            // 
            // btnSilGorev
            // 
            this.btnSilGorev.BackColor = System.Drawing.Color.Red;
            this.btnSilGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilGorev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSilGorev.Location = new System.Drawing.Point(389, 96);
            this.btnSilGorev.Name = "btnSilGorev";
            this.btnSilGorev.Size = new System.Drawing.Size(153, 37);
            this.btnSilGorev.TabIndex = 4;
            this.btnSilGorev.Text = "Seçili Görevi Sil";
            this.btnSilGorev.UseVisualStyleBackColor = false;
            this.btnSilGorev.Click += new System.EventHandler(this.btnSilGorev_Click);
            // 
            // btnSilFinans
            // 
            this.btnSilFinans.BackColor = System.Drawing.Color.Red;
            this.btnSilFinans.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilFinans.Location = new System.Drawing.Point(487, 70);
            this.btnSilFinans.Name = "btnSilFinans";
            this.btnSilFinans.Size = new System.Drawing.Size(139, 31);
            this.btnSilFinans.TabIndex = 10;
            this.btnSilFinans.Text = "Seçili İşlemi Sil";
            this.btnSilFinans.UseVisualStyleBackColor = false;
            this.btnSilFinans.Click += new System.EventHandler(this.btnSilFinans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.YeniIslem.ResumeLayout(false);
            this.YeniIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox YeniIslem;
        private System.Windows.Forms.DataGridView dgvFinans;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.NumericUpDown numTutar;
        private System.Windows.Forms.CheckedListBox clbGorevler;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.DateTimePicker dtpGorevTarih;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Button btnSilGorev;
        private System.Windows.Forms.Button btnSilFinans;
    }
}

