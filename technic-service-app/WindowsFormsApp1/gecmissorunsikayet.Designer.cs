
namespace WindowsFormsApp1
{
    partial class gecmissorunsikayet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.perid = new System.Windows.Forms.TextBox();
            this.txtyonid = new System.Windows.Forms.TextBox();
            this.btnvarsayılan = new System.Windows.Forms.Button();
            this.btntrh = new System.Windows.Forms.Button();
            this.btnkulidgore = new System.Windows.Forms.Button();
            this.btnperidgore = new System.Windows.Forms.Button();
            this.btnkonugore = new System.Windows.Forms.Button();
            this.btnyoneticiidgore = new System.Windows.Forms.Button();
            this.btnraporsil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(958, 579);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorun / Şikayetler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 548);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(983, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(993, 198);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(196, 30);
            this.txtid.TabIndex = 3;
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(993, 402);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(196, 30);
            this.txtkonu.TabIndex = 3;
            // 
            // perid
            // 
            this.perid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.perid.Location = new System.Drawing.Point(993, 297);
            this.perid.Name = "perid";
            this.perid.Size = new System.Drawing.Size(196, 30);
            this.perid.TabIndex = 3;
            // 
            // txtyonid
            // 
            this.txtyonid.Location = new System.Drawing.Point(993, 506);
            this.txtyonid.Name = "txtyonid";
            this.txtyonid.Size = new System.Drawing.Size(196, 30);
            this.txtyonid.TabIndex = 6;
            // 
            // btnvarsayılan
            // 
            this.btnvarsayılan.BackColor = System.Drawing.Color.AliceBlue;
            this.btnvarsayılan.Location = new System.Drawing.Point(983, 13);
            this.btnvarsayılan.Name = "btnvarsayılan";
            this.btnvarsayılan.Size = new System.Drawing.Size(216, 41);
            this.btnvarsayılan.TabIndex = 7;
            this.btnvarsayılan.Text = "Varsayılan goster";
            this.btnvarsayılan.UseVisualStyleBackColor = false;
            this.btnvarsayılan.Click += new System.EventHandler(this.btnvarsayılan_Click);
            // 
            // btntrh
            // 
            this.btntrh.BackColor = System.Drawing.Color.AliceBlue;
            this.btntrh.Location = new System.Drawing.Point(983, 140);
            this.btntrh.Name = "btntrh";
            this.btntrh.Size = new System.Drawing.Size(216, 47);
            this.btntrh.TabIndex = 8;
            this.btntrh.Text = "Tarihe göre ara";
            this.btntrh.UseVisualStyleBackColor = false;
            this.btntrh.Click += new System.EventHandler(this.btntrh_Click);
            // 
            // btnkulidgore
            // 
            this.btnkulidgore.BackColor = System.Drawing.Color.AliceBlue;
            this.btnkulidgore.Location = new System.Drawing.Point(983, 234);
            this.btnkulidgore.Name = "btnkulidgore";
            this.btnkulidgore.Size = new System.Drawing.Size(216, 47);
            this.btnkulidgore.TabIndex = 9;
            this.btnkulidgore.Text = "Kullanıcı id göre ara";
            this.btnkulidgore.UseVisualStyleBackColor = false;
            this.btnkulidgore.Click += new System.EventHandler(this.btnkulidgore_Click);
            // 
            // btnperidgore
            // 
            this.btnperidgore.BackColor = System.Drawing.Color.AliceBlue;
            this.btnperidgore.Location = new System.Drawing.Point(983, 333);
            this.btnperidgore.Name = "btnperidgore";
            this.btnperidgore.Size = new System.Drawing.Size(216, 47);
            this.btnperidgore.TabIndex = 10;
            this.btnperidgore.Text = "Personel id  göre ara";
            this.btnperidgore.UseVisualStyleBackColor = false;
            this.btnperidgore.Click += new System.EventHandler(this.btnperidgore_Click);
            // 
            // btnkonugore
            // 
            this.btnkonugore.BackColor = System.Drawing.Color.AliceBlue;
            this.btnkonugore.Location = new System.Drawing.Point(983, 438);
            this.btnkonugore.Name = "btnkonugore";
            this.btnkonugore.Size = new System.Drawing.Size(216, 47);
            this.btnkonugore.TabIndex = 11;
            this.btnkonugore.Text = "Konu\'ya göre ara";
            this.btnkonugore.UseVisualStyleBackColor = false;
            this.btnkonugore.Click += new System.EventHandler(this.btnkonugore_Click);
            // 
            // btnyoneticiidgore
            // 
            this.btnyoneticiidgore.BackColor = System.Drawing.Color.AliceBlue;
            this.btnyoneticiidgore.Location = new System.Drawing.Point(983, 542);
            this.btnyoneticiidgore.Name = "btnyoneticiidgore";
            this.btnyoneticiidgore.Size = new System.Drawing.Size(216, 47);
            this.btnyoneticiidgore.TabIndex = 12;
            this.btnyoneticiidgore.Text = "Yönetici id göre ara";
            this.btnyoneticiidgore.UseVisualStyleBackColor = false;
            this.btnyoneticiidgore.Click += new System.EventHandler(this.btnyoneticiidgore_Click);
            // 
            // btnraporsil
            // 
            this.btnraporsil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnraporsil.Location = new System.Drawing.Point(983, 57);
            this.btnraporsil.Name = "btnraporsil";
            this.btnraporsil.Size = new System.Drawing.Size(216, 41);
            this.btnraporsil.TabIndex = 13;
            this.btnraporsil.Text = "Seçili raporu sil";
            this.btnraporsil.UseVisualStyleBackColor = false;
            this.btnraporsil.Click += new System.EventHandler(this.btnraporsil_Click);
            // 
            // gecmissorunsikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1201, 592);
            this.Controls.Add(this.btnraporsil);
            this.Controls.Add(this.btnyoneticiidgore);
            this.Controls.Add(this.btnkonugore);
            this.Controls.Add(this.btnperidgore);
            this.Controls.Add(this.btnkulidgore);
            this.Controls.Add(this.btntrh);
            this.Controls.Add(this.btnvarsayılan);
            this.Controls.Add(this.txtyonid);
            this.Controls.Add(this.perid);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "gecmissorunsikayet";
            this.Text = "gecmissorunsikayet";
            this.Load += new System.EventHandler(this.gecmissorunsikayet_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.TextBox perid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtyonid;
        private System.Windows.Forms.Button btnvarsayılan;
        private System.Windows.Forms.Button btntrh;
        private System.Windows.Forms.Button btnkulidgore;
        private System.Windows.Forms.Button btnperidgore;
        private System.Windows.Forms.Button btnkonugore;
        private System.Windows.Forms.Button btnyoneticiidgore;
        private System.Windows.Forms.Button btnraporsil;
    }
}