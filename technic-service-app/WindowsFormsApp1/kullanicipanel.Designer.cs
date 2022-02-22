
namespace WindowsFormsApp1
{
    partial class kullanicipanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicipanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchtxtack = new System.Windows.Forms.RichTextBox();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btngonder = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btngecmis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.btngeri);
            this.groupBox1.Controls.Add(this.lblad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idlbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(87, 50);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(100, 22);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(123, 26);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(30, 22);
            this.idlbl.TabIndex = 0;
            this.idlbl.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı İd:";
            // 
            // rchtxtack
            // 
            this.rchtxtack.Location = new System.Drawing.Point(303, 27);
            this.rchtxtack.Name = "rchtxtack";
            this.rchtxtack.Size = new System.Drawing.Size(417, 172);
            this.rchtxtack.TabIndex = 2;
            this.rchtxtack.Text = "";
            // 
            // txtkonu
            // 
            this.txtkonu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonu.Location = new System.Drawing.Point(129, 112);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(169, 30);
            this.txtkonu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(4, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Konu / Başlık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(303, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lutfen sorun / şikayet\'inizi anlaşılır biçimde yazınız";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(65, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sorun / Sikayet Tarihi\r\n";
            // 
            // btngonder
            // 
            this.btngonder.BackColor = System.Drawing.Color.AliceBlue;
            this.btngonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngonder.Location = new System.Drawing.Point(511, 207);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(206, 47);
            this.btngonder.TabIndex = 7;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = false;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Bisque;
            this.btngeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeri.BackgroundImage")));
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngeri.Location = new System.Drawing.Point(259, 26);
            this.btngeri.Margin = new System.Windows.Forms.Padding(0);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(22, 22);
            this.btngeri.TabIndex = 8;
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btngecmis
            // 
            this.btngecmis.BackColor = System.Drawing.Color.AliceBlue;
            this.btngecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngecmis.Location = new System.Drawing.Point(8, 207);
            this.btngecmis.Name = "btngecmis";
            this.btngecmis.Size = new System.Drawing.Size(206, 47);
            this.btngecmis.TabIndex = 8;
            this.btngecmis.Text = "Geçmiş";
            this.btngecmis.UseVisualStyleBackColor = false;
            this.btngecmis.Click += new System.EventHandler(this.btngecmis_Click);
            // 
            // kullanicipanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(729, 259);
            this.Controls.Add(this.btngecmis);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.rchtxtack);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kullanicipanel";
            this.Text = "Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.kullanicipanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchtxtack;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btngecmis;
    }
}