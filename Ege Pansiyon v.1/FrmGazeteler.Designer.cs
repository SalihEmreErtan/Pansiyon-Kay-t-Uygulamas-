namespace Ege_Pansiyon_v._1
{
    partial class FrmGazeteler
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnHürriyet = new System.Windows.Forms.Button();
            this.btnMilliyet = new System.Windows.Forms.Button();
            this.btnHaberTurk = new System.Windows.Forms.Button();
            this.btnFanatik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(892, 599);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnHürriyet
            // 
            this.btnHürriyet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHürriyet.Location = new System.Drawing.Point(53, 9);
            this.btnHürriyet.Name = "btnHürriyet";
            this.btnHürriyet.Size = new System.Drawing.Size(167, 23);
            this.btnHürriyet.TabIndex = 1;
            this.btnHürriyet.Text = "Hürriyet";
            this.btnHürriyet.UseVisualStyleBackColor = true;
            this.btnHürriyet.Click += new System.EventHandler(this.btnHürriyet_Click);
            // 
            // btnMilliyet
            // 
            this.btnMilliyet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMilliyet.Location = new System.Drawing.Point(251, 9);
            this.btnMilliyet.Name = "btnMilliyet";
            this.btnMilliyet.Size = new System.Drawing.Size(167, 23);
            this.btnMilliyet.TabIndex = 2;
            this.btnMilliyet.Text = "Milliyet";
            this.btnMilliyet.UseVisualStyleBackColor = true;
            this.btnMilliyet.Click += new System.EventHandler(this.btnMilliyet_Click);
            // 
            // btnHaberTurk
            // 
            this.btnHaberTurk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaberTurk.Location = new System.Drawing.Point(457, 9);
            this.btnHaberTurk.Name = "btnHaberTurk";
            this.btnHaberTurk.Size = new System.Drawing.Size(167, 23);
            this.btnHaberTurk.TabIndex = 3;
            this.btnHaberTurk.Text = "Haber Türk";
            this.btnHaberTurk.UseVisualStyleBackColor = true;
            this.btnHaberTurk.Click += new System.EventHandler(this.btnHaberTurk_Click);
            // 
            // btnFanatik
            // 
            this.btnFanatik.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFanatik.Location = new System.Drawing.Point(666, 9);
            this.btnFanatik.Name = "btnFanatik";
            this.btnFanatik.Size = new System.Drawing.Size(167, 23);
            this.btnFanatik.TabIndex = 4;
            this.btnFanatik.Text = "Fanatik";
            this.btnFanatik.UseVisualStyleBackColor = true;
            this.btnFanatik.Click += new System.EventHandler(this.btnFanatik_Click);
            // 
            // FrmGazeteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(891, 635);
            this.Controls.Add(this.btnFanatik);
            this.Controls.Add(this.btnHaberTurk);
            this.Controls.Add(this.btnMilliyet);
            this.Controls.Add(this.btnHürriyet);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGazeteler";
            this.Text = "Gazeteler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHürriyet;
        private System.Windows.Forms.Button btnMilliyet;
        private System.Windows.Forms.Button btnHaberTurk;
        private System.Windows.Forms.Button btnFanatik;
    }
}