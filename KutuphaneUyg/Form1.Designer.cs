namespace KutuphaneUyg
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
            this.components = new System.ComponentModel.Container();
            this.kutuphaneDbDataSet = new KutuphaneUyg.KutuphaneDbDataSet();
            this.tableUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableUserTableAdapter = new KutuphaneUyg.KutuphaneDbDataSetTableAdapters.tableUserTableAdapter();
            this.kadi = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisBilgilendirme = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kutuphaneDbDataSet
            // 
            this.kutuphaneDbDataSet.DataSetName = "KutuphaneDbDataSet";
            this.kutuphaneDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableUserBindingSource
            // 
            this.tableUserBindingSource.DataMember = "tableUser";
            this.tableUserBindingSource.DataSource = this.kutuphaneDbDataSet;
            // 
            // tableUserTableAdapter
            // 
            this.tableUserTableAdapter.ClearBeforeFill = true;
            // 
            // kadi
            // 
            this.kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadi.Location = new System.Drawing.Point(12, 37);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(196, 35);
            this.kadi.TabIndex = 0;
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola.Location = new System.Drawing.Point(12, 113);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(196, 35);
            this.parola.TabIndex = 1;
            this.parola.UseSystemPasswordChar = true;
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(12, 164);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(196, 44);
            this.giris.TabIndex = 2;
            this.giris.Text = "Giris Yap";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "PAROLA";
            // 
            // girisBilgilendirme
            // 
            this.girisBilgilendirme.AutoSize = true;
            this.girisBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBilgilendirme.Location = new System.Drawing.Point(14, 227);
            this.girisBilgilendirme.Name = "girisBilgilendirme";
            this.girisBilgilendirme.Size = new System.Drawing.Size(0, 16);
            this.girisBilgilendirme.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "hizli giris";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.girisBilgilendirme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.kadi);
            this.Name = "Form1";
            this.Text = "GIRIS YAP";
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private KutuphaneDbDataSet kutuphaneDbDataSet;
        private System.Windows.Forms.BindingSource tableUserBindingSource;
        private KutuphaneDbDataSetTableAdapters.tableUserTableAdapter tableUserTableAdapter;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label girisBilgilendirme;
        private System.Windows.Forms.Button button1;
    }
}

