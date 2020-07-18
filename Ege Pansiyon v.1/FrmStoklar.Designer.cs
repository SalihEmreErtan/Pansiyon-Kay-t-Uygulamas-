namespace Ege_Pansiyon_v._1
{
    partial class FrmStoklar
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
            this.groupBoxMutfak = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTemizle1 = new System.Windows.Forms.Button();
            this.txtIcecekler = new System.Windows.Forms.TextBox();
            this.btnKaydet1 = new System.Windows.Forms.Button();
            this.txtGidalar = new System.Windows.Forms.TextBox();
            this.lblIcecekTutari = new System.Windows.Forms.Label();
            this.lblGidaTutari = new System.Windows.Forms.Label();
            this.groupBoxFaturalar = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxMutfak.SuspendLayout();
            this.groupBoxFaturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMutfak
            // 
            this.groupBoxMutfak.Controls.Add(this.listView1);
            this.groupBoxMutfak.Controls.Add(this.btnTemizle1);
            this.groupBoxMutfak.Controls.Add(this.txtIcecekler);
            this.groupBoxMutfak.Controls.Add(this.btnKaydet1);
            this.groupBoxMutfak.Controls.Add(this.txtGidalar);
            this.groupBoxMutfak.Controls.Add(this.lblIcecekTutari);
            this.groupBoxMutfak.Controls.Add(this.lblGidaTutari);
            this.groupBoxMutfak.Location = new System.Drawing.Point(12, 1);
            this.groupBoxMutfak.Name = "groupBoxMutfak";
            this.groupBoxMutfak.Size = new System.Drawing.Size(329, 333);
            this.groupBoxMutfak.TabIndex = 6;
            this.groupBoxMutfak.TabStop = false;
            this.groupBoxMutfak.Text = "Mutfak";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 205);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 128);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçeçekler";
            this.columnHeader2.Width = 162;
            // 
            // btnTemizle1
            // 
            this.btnTemizle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle1.Location = new System.Drawing.Point(116, 151);
            this.btnTemizle1.Name = "btnTemizle1";
            this.btnTemizle1.Size = new System.Drawing.Size(166, 27);
            this.btnTemizle1.TabIndex = 12;
            this.btnTemizle1.Text = "Temizle";
            this.btnTemizle1.UseVisualStyleBackColor = true;
            this.btnTemizle1.Click += new System.EventHandler(this.btnTemizle1_Click);
            // 
            // txtIcecekler
            // 
            this.txtIcecekler.Location = new System.Drawing.Point(116, 48);
            this.txtIcecekler.Name = "txtIcecekler";
            this.txtIcecekler.Size = new System.Drawing.Size(166, 20);
            this.txtIcecekler.TabIndex = 10;
            // 
            // btnKaydet1
            // 
            this.btnKaydet1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet1.Location = new System.Drawing.Point(116, 119);
            this.btnKaydet1.Name = "btnKaydet1";
            this.btnKaydet1.Size = new System.Drawing.Size(166, 27);
            this.btnKaydet1.TabIndex = 11;
            this.btnKaydet1.Text = "Kaydet";
            this.btnKaydet1.UseVisualStyleBackColor = true;
            this.btnKaydet1.Click += new System.EventHandler(this.btnKaydet1_Click);
            // 
            // txtGidalar
            // 
            this.txtGidalar.Location = new System.Drawing.Point(116, 19);
            this.txtGidalar.Name = "txtGidalar";
            this.txtGidalar.Size = new System.Drawing.Size(166, 20);
            this.txtGidalar.TabIndex = 9;
            // 
            // lblIcecekTutari
            // 
            this.lblIcecekTutari.AutoSize = true;
            this.lblIcecekTutari.BackColor = System.Drawing.Color.Transparent;
            this.lblIcecekTutari.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcecekTutari.Location = new System.Drawing.Point(11, 48);
            this.lblIcecekTutari.Name = "lblIcecekTutari";
            this.lblIcecekTutari.Size = new System.Drawing.Size(99, 16);
            this.lblIcecekTutari.TabIndex = 8;
            this.lblIcecekTutari.Text = "İçeçek Tutarı :";
            // 
            // lblGidaTutari
            // 
            this.lblGidaTutari.AutoSize = true;
            this.lblGidaTutari.BackColor = System.Drawing.Color.Transparent;
            this.lblGidaTutari.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidaTutari.Location = new System.Drawing.Point(23, 20);
            this.lblGidaTutari.Name = "lblGidaTutari";
            this.lblGidaTutari.Size = new System.Drawing.Size(87, 16);
            this.lblGidaTutari.TabIndex = 7;
            this.lblGidaTutari.Text = "Gıda Tutarı :";
            // 
            // groupBoxFaturalar
            // 
            this.groupBoxFaturalar.Controls.Add(this.listView2);
            this.groupBoxFaturalar.Controls.Add(this.txtInternet);
            this.groupBoxFaturalar.Controls.Add(this.label3);
            this.groupBoxFaturalar.Controls.Add(this.btnTemizle2);
            this.groupBoxFaturalar.Controls.Add(this.btnKaydet2);
            this.groupBoxFaturalar.Controls.Add(this.txtSu);
            this.groupBoxFaturalar.Controls.Add(this.txtElektrik);
            this.groupBoxFaturalar.Controls.Add(this.label1);
            this.groupBoxFaturalar.Controls.Add(this.label2);
            this.groupBoxFaturalar.Location = new System.Drawing.Point(374, 1);
            this.groupBoxFaturalar.Name = "groupBoxFaturalar";
            this.groupBoxFaturalar.Size = new System.Drawing.Size(336, 333);
            this.groupBoxFaturalar.TabIndex = 7;
            this.groupBoxFaturalar.TabStop = false;
            this.groupBoxFaturalar.Text = "Faturalar";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 205);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(338, 128);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Elektrik";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Su";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İnternet";
            this.columnHeader5.Width = 110;
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(107, 78);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(166, 20);
            this.txtInternet.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "İnternet :";
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle2.Location = new System.Drawing.Point(107, 152);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(166, 26);
            this.btnTemizle2.TabIndex = 12;
            this.btnTemizle2.Text = "Temizle";
            this.btnTemizle2.UseVisualStyleBackColor = true;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet2.Location = new System.Drawing.Point(107, 119);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(166, 27);
            this.btnKaydet2.TabIndex = 11;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = true;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(107, 48);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(166, 20);
            this.txtSu.TabIndex = 10;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(107, 19);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(166, 20);
            this.txtElektrik.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Su :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elektrik :";
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 346);
            this.Controls.Add(this.groupBoxFaturalar);
            this.Controls.Add(this.groupBoxMutfak);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Stoklar & Faturalar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBoxMutfak.ResumeLayout(false);
            this.groupBoxMutfak.PerformLayout();
            this.groupBoxFaturalar.ResumeLayout(false);
            this.groupBoxFaturalar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxMutfak;
        private System.Windows.Forms.Button btnTemizle1;
        private System.Windows.Forms.Button btnKaydet1;
        private System.Windows.Forms.TextBox txtIcecekler;
        private System.Windows.Forms.TextBox txtGidalar;
        private System.Windows.Forms.Label lblIcecekTutari;
        private System.Windows.Forms.Label lblGidaTutari;
        private System.Windows.Forms.GroupBox groupBoxFaturalar;
        private System.Windows.Forms.Button btnTemizle2;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}