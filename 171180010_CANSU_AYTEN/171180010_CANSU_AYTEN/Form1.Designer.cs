namespace _171180010_CANSU_AYTEN
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
            this.liste = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.prosesinSahipOlduğuThreadSayısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesinKullandığıBellekMiktarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesinKullandığıİşlemciYüzdesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesiÖldürmekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.ContextMenuStrip = this.contextMenuStrip1;
            this.liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liste.FormattingEnabled = true;
            this.liste.ItemHeight = 18;
            this.liste.Location = new System.Drawing.Point(12, 60);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(583, 436);
            this.liste.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prosesinSahipOlduğuThreadSayısıToolStripMenuItem,
            this.prosesinKullandığıBellekMiktarıToolStripMenuItem,
            this.prosesinKullandığıİşlemciYüzdesiToolStripMenuItem,
            this.prosesiÖldürmekToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(309, 100);
            // 
            // prosesinSahipOlduğuThreadSayısıToolStripMenuItem
            // 
            this.prosesinSahipOlduğuThreadSayısıToolStripMenuItem.Name = "prosesinSahipOlduğuThreadSayısıToolStripMenuItem";
            this.prosesinSahipOlduğuThreadSayısıToolStripMenuItem.Size = new System.Drawing.Size(308, 24);
            this.prosesinSahipOlduğuThreadSayısıToolStripMenuItem.Text = "Prosesin sahip olduğu thread sayısı";
            this.prosesinSahipOlduğuThreadSayısıToolStripMenuItem.Click += new System.EventHandler(this.prosesinSahipOlduğuThreadSayısıToolStripMenuItem_Click);
            // 
            // prosesinKullandığıBellekMiktarıToolStripMenuItem
            // 
            this.prosesinKullandığıBellekMiktarıToolStripMenuItem.Name = "prosesinKullandığıBellekMiktarıToolStripMenuItem";
            this.prosesinKullandığıBellekMiktarıToolStripMenuItem.Size = new System.Drawing.Size(308, 24);
            this.prosesinKullandığıBellekMiktarıToolStripMenuItem.Text = "Prosesin kullandığı bellek miktarı";
            this.prosesinKullandığıBellekMiktarıToolStripMenuItem.Click += new System.EventHandler(this.prosesinKullandığıBellekMiktarıToolStripMenuItem_Click);
            // 
            // prosesinKullandığıİşlemciYüzdesiToolStripMenuItem
            // 
            this.prosesinKullandığıİşlemciYüzdesiToolStripMenuItem.Name = "prosesinKullandığıİşlemciYüzdesiToolStripMenuItem";
            this.prosesinKullandığıİşlemciYüzdesiToolStripMenuItem.Size = new System.Drawing.Size(308, 24);
            this.prosesinKullandığıİşlemciYüzdesiToolStripMenuItem.Text = "Prosesin kullandığı işlemci yüzdesi";
            this.prosesinKullandığıİşlemciYüzdesiToolStripMenuItem.Click += new System.EventHandler(this.prosesinKullandığıİşlemciYüzdesiToolStripMenuItem_Click);
            // 
            // prosesiÖldürmekToolStripMenuItem
            // 
            this.prosesiÖldürmekToolStripMenuItem.Name = "prosesiÖldürmekToolStripMenuItem";
            this.prosesiÖldürmekToolStripMenuItem.Size = new System.Drawing.Size(308, 24);
            this.prosesiÖldürmekToolStripMenuItem.Text = "Prosesi öldürmek";
            this.prosesiÖldürmekToolStripMenuItem.Click += new System.EventHandler(this.prosesiÖldürmekToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proses Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cansu Ayten - 171180010";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(608, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liste);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BM309 Final Proje Ödevi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prosesinSahipOlduğuThreadSayısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosesinKullandığıBellekMiktarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosesinKullandığıİşlemciYüzdesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosesiÖldürmekToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

