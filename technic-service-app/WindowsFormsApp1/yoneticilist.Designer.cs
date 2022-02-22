
namespace WindowsFormsApp1
{
    partial class yoneticilist
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Gainsboro;
            this.lblid.Location = new System.Drawing.Point(772, 28);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(36, 22);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "İD:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(814, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(126, 30);
            this.txtid.TabIndex = 2;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Location = new System.Drawing.Point(757, 333);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(183, 46);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.AliceBlue;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Location = new System.Drawing.Point(757, 229);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(183, 46);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Location = new System.Drawing.Point(757, 281);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(183, 46);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(814, 60);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(126, 30);
            this.txtad.TabIndex = 7;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.BackColor = System.Drawing.Color.Gainsboro;
            this.lblad.Location = new System.Drawing.Point(768, 64);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(40, 22);
            this.lblad.TabIndex = 6;
            this.lblad.Text = "Ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(814, 96);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(126, 30);
            this.txtsoyad.TabIndex = 9;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.BackColor = System.Drawing.Color.Gainsboro;
            this.lblsoyad.Location = new System.Drawing.Point(743, 100);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(65, 22);
            this.lblsoyad.TabIndex = 8;
            this.lblsoyad.Text = "Soayd:";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(814, 132);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(126, 30);
            this.txttc.TabIndex = 11;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.BackColor = System.Drawing.Color.Gainsboro;
            this.lbltc.Location = new System.Drawing.Point(772, 136);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(36, 22);
            this.lbltc.TabIndex = 10;
            this.lbltc.Text = "Tc:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(814, 168);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(126, 30);
            this.txtsifre.TabIndex = 13;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblsifre.Location = new System.Drawing.Point(753, 172);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(55, 22);
            this.lblsifre.TabIndex = 12;
            this.lblsifre.Text = "Sifre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 376);
            this.panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // yoneticilist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(949, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yoneticilist";
            this.Text = "Yönetici listesi";
            this.Load += new System.EventHandler(this.yoneticilist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}