
namespace WindowsFormsApp1
{
    partial class girisPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpersonel = new System.Windows.Forms.Button();
            this.btnyonetici = new System.Windows.Forms.Button();
            this.btnkullanici = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnpersonel);
            this.groupBox1.Controls.Add(this.btnyonetici);
            this.groupBox1.Controls.Add(this.btnkullanici);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİS PANELİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(577, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teknik Personel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(344, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yonetici";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(70, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı";
            // 
            // btnpersonel
            // 
            this.btnpersonel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpersonel.BackgroundImage")));
            this.btnpersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpersonel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnpersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpersonel.Location = new System.Drawing.Point(565, 29);
            this.btnpersonel.Name = "btnpersonel";
            this.btnpersonel.Size = new System.Drawing.Size(230, 213);
            this.btnpersonel.TabIndex = 0;
            this.btnpersonel.UseVisualStyleBackColor = true;
            this.btnpersonel.Click += new System.EventHandler(this.btnpersonel_Click);
            // 
            // btnyonetici
            // 
            this.btnyonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnyonetici.BackgroundImage")));
            this.btnyonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyonetici.Location = new System.Drawing.Point(289, 29);
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Size = new System.Drawing.Size(230, 213);
            this.btnyonetici.TabIndex = 0;
            this.btnyonetici.UseVisualStyleBackColor = true;
            this.btnyonetici.Click += new System.EventHandler(this.btnyonetici_Click);
            // 
            // btnkullanici
            // 
            this.btnkullanici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkullanici.BackgroundImage")));
            this.btnkullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullanici.Location = new System.Drawing.Point(20, 29);
            this.btnkullanici.Name = "btnkullanici";
            this.btnkullanici.Size = new System.Drawing.Size(230, 213);
            this.btnkullanici.TabIndex = 0;
            this.btnkullanici.UseVisualStyleBackColor = true;
            this.btnkullanici.Click += new System.EventHandler(this.btnkullanici_Click);
            // 
            // girisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(868, 367);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "girisPanel";
            this.Text = "Giris";
         //   this.Load += new System.EventHandler(this.girisPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpersonel;
        private System.Windows.Forms.Button btnyonetici;
        private System.Windows.Forms.Button btnkullanici;
    }
}

