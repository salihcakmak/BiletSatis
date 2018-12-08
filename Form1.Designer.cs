namespace OtobusFirması
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OtobusFirması.DataSet1();
            this.sehirlerTableAdapter = new OtobusFirması.DataSet1TableAdapters.SehirlerTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdffasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.biletDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletİptaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüsİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüsEkleSilGöruntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüsSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehirİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerTableAdapter1 = new OtobusFirması.DataSet1TableAdapters.MusterilerTableAdapter();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdffasdfToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.genelİşlemlerToolStripMenuItem,
            this.seferlerToolStripMenuItem,
            this.çalışanİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdffasdfToolStripMenuItem
            // 
            this.asdffasdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.biletOluşturToolStripMenuItem,
            this.biletDüzenleToolStripMenuItem,
            this.biletİptaliToolStripMenuItem});
            this.asdffasdfToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdffasdfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.asdffasdfToolStripMenuItem.Name = "asdffasdfToolStripMenuItem";
            this.asdffasdfToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.asdffasdfToolStripMenuItem.Text = "Bilet İşlemleri";
            // 
            // biletOluşturToolStripMenuItem
            // 
            this.biletOluşturToolStripMenuItem.Name = "biletOluşturToolStripMenuItem";
            this.biletOluşturToolStripMenuItem.Size = new System.Drawing.Size(178, 6);
            this.biletOluşturToolStripMenuItem.Click += new System.EventHandler(this.biletOluşturToolStripMenuItem_Click);
            // 
            // biletDüzenleToolStripMenuItem
            // 
            this.biletDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletDüzenleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_edit_173002;
            this.biletDüzenleToolStripMenuItem.Name = "biletDüzenleToolStripMenuItem";
            this.biletDüzenleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.biletDüzenleToolStripMenuItem.Text = "Bilet Düzenle";
            // 
            // biletİptaliToolStripMenuItem
            // 
            this.biletİptaliToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletİptaliToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_Delete_1493279;
            this.biletİptaliToolStripMenuItem.Name = "biletİptaliToolStripMenuItem";
            this.biletİptaliToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.biletİptaliToolStripMenuItem.Text = "Bilet İptali";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriGörüntüleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriEkleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_7_330410;
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriGörüntüleToolStripMenuItem
            // 
            this.müşteriGörüntüleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriGörüntüleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_search_173095;
            this.müşteriGörüntüleToolStripMenuItem.Name = "müşteriGörüntüleToolStripMenuItem";
            this.müşteriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.müşteriGörüntüleToolStripMenuItem.Text = "Müşteri Görüntüle / Düzenle";
            this.müşteriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.müşteriGörüntüleToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriSilToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_Delete_1493279;
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
            // 
            // genelİşlemlerToolStripMenuItem
            // 
            this.genelİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otobüsİşlemleriToolStripMenuItem,
            this.şehirİşlemleriToolStripMenuItem});
            this.genelİşlemlerToolStripMenuItem.Name = "genelİşlemlerToolStripMenuItem";
            this.genelİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.genelİşlemlerToolStripMenuItem.Text = "Genel İşlemler";
            // 
            // otobüsİşlemleriToolStripMenuItem
            // 
            this.otobüsİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaİşlemiToolStripMenuItem,
            this.otobüsEkleSilGöruntüleToolStripMenuItem,
            this.otobüsSilToolStripMenuItem});
            this.otobüsİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otobüsİşlemleriToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_old_go_last_23497;
            this.otobüsİşlemleriToolStripMenuItem.Name = "otobüsİşlemleriToolStripMenuItem";
            this.otobüsİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.otobüsİşlemleriToolStripMenuItem.Text = "Otobüs İşlemleri";
            // 
            // markaİşlemiToolStripMenuItem
            // 
            this.markaİşlemiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.markaİşlemiToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_old_go_next_23498;
            this.markaİşlemiToolStripMenuItem.Name = "markaİşlemiToolStripMenuItem";
            this.markaİşlemiToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.markaİşlemiToolStripMenuItem.Text = "Marka İşlemi";
            this.markaİşlemiToolStripMenuItem.Click += new System.EventHandler(this.markaİşlemiToolStripMenuItem_Click);
            // 
            // otobüsEkleSilGöruntüleToolStripMenuItem
            // 
            this.otobüsEkleSilGöruntüleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otobüsEkleSilGöruntüleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_7_330410;
            this.otobüsEkleSilGöruntüleToolStripMenuItem.Name = "otobüsEkleSilGöruntüleToolStripMenuItem";
            this.otobüsEkleSilGöruntüleToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.otobüsEkleSilGöruntüleToolStripMenuItem.Text = "Otobüs Ekle";
            this.otobüsEkleSilGöruntüleToolStripMenuItem.Click += new System.EventHandler(this.otobüsEkleSilGöruntüleToolStripMenuItem_Click);
            // 
            // otobüsSilToolStripMenuItem
            // 
            this.otobüsSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otobüsSilToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_Delete_1493279;
            this.otobüsSilToolStripMenuItem.Name = "otobüsSilToolStripMenuItem";
            this.otobüsSilToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.otobüsSilToolStripMenuItem.Text = "Otobüs Sil";
            this.otobüsSilToolStripMenuItem.Click += new System.EventHandler(this.otobüsSilToolStripMenuItem_Click);
            // 
            // şehirİşlemleriToolStripMenuItem
            // 
            this.şehirİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şehirİşlemleriToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_old_go_last_23497;
            this.şehirİşlemleriToolStripMenuItem.Name = "şehirİşlemleriToolStripMenuItem";
            this.şehirİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.şehirİşlemleriToolStripMenuItem.Text = "Şehir İşlemleri";
            this.şehirİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.şehirİşlemleriToolStripMenuItem_Click);
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferOluşturToolStripMenuItem,
            this.seferGörüntüleToolStripMenuItem,
            this.seferDüzenleToolStripMenuItem,
            this.seferSilToolStripMenuItem});
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.seferlerToolStripMenuItem.Text = "Seferler";
            // 
            // seferOluşturToolStripMenuItem
            // 
            this.seferOluşturToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seferOluşturToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_7_330410;
            this.seferOluşturToolStripMenuItem.Name = "seferOluşturToolStripMenuItem";
            this.seferOluşturToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.seferOluşturToolStripMenuItem.Text = "Sefer Oluştur";
            // 
            // seferGörüntüleToolStripMenuItem
            // 
            this.seferGörüntüleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seferGörüntüleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_search_173095;
            this.seferGörüntüleToolStripMenuItem.Name = "seferGörüntüleToolStripMenuItem";
            this.seferGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.seferGörüntüleToolStripMenuItem.Text = "Sefer Görüntüle";
            // 
            // seferDüzenleToolStripMenuItem
            // 
            this.seferDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seferDüzenleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_edit_173002;
            this.seferDüzenleToolStripMenuItem.Name = "seferDüzenleToolStripMenuItem";
            this.seferDüzenleToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.seferDüzenleToolStripMenuItem.Text = "Sefer Düzenle";
            // 
            // seferSilToolStripMenuItem
            // 
            this.seferSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seferSilToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_Delete_1493279;
            this.seferSilToolStripMenuItem.Name = "seferSilToolStripMenuItem";
            this.seferSilToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.seferSilToolStripMenuItem.Text = "Sefer Sil";
            // 
            // çalışanİşlemleriToolStripMenuItem
            // 
            this.çalışanİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanEkleToolStripMenuItem,
            this.çalışansToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.çalışanİşlemleriToolStripMenuItem.Name = "çalışanİşlemleriToolStripMenuItem";
            this.çalışanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.çalışanİşlemleriToolStripMenuItem.Text = "Çalışan İşlemleri";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çalışanEkleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_7_330410;
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.çalışanEkleToolStripMenuItem.Text = "Ekle";
            this.çalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.çalışanEkleToolStripMenuItem_Click);
            // 
            // çalışansToolStripMenuItem
            // 
            this.çalışansToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çalışansToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_search_173095;
            this.çalışansToolStripMenuItem.Name = "çalışansToolStripMenuItem";
            this.çalışansToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.çalışansToolStripMenuItem.Text = "Görüntüle";
            this.çalışansToolStripMenuItem.Click += new System.EventHandler(this.çalışansToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.düzenleToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_edit_173002;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silToolStripMenuItem.Image = global::OtobusFirması.Properties.Resources.if_Delete_1493279;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // musterilerTableAdapter1
            // 
            this.musterilerTableAdapter1.ClearBeforeFill = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem1.Image = global::OtobusFirması.Properties.Resources.if_7_330410;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem1.Text = "Bilet Oluştur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtobusFirması.Properties.Resources.img1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 612);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private DataSet1TableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdffasdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletİptaliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otobüsİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otobüsEkleSilGöruntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otobüsSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private DataSet1TableAdapters.MusterilerTableAdapter musterilerTableAdapter1;
        private System.Windows.Forms.ToolStripSeparator biletOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;




    }
}

