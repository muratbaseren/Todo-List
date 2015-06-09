namespace udemy_todolist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHakkimda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpYeniGorev = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYapilacaklarListesi = new System.Windows.Forms.Label();
            this.clbYapilacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.lblTamamlananlarListesi = new System.Windows.Forms.Label();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.txtYeniGorev = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnDuzelt = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapistir = new System.Windows.Forms.ToolStripButton();
            this.btnYardim = new System.Windows.Forms.ToolStripButton();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDuzelt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUygHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuDuzelt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpYeniGorev.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.btnDuzelt,
            this.btnSil,
            this.toolStripSeparator,
            this.btnKes,
            this.btnKopyala,
            this.btnYapistir,
            this.toolStripSeparator1,
            this.btnYardim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya,
            this.mnuTodo,
            this.mnuHakkimda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(62, 24);
            this.mnuDosya.Text = "Dosya";
            // 
            // mnuTodo
            // 
            this.mnuTodo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeni,
            this.mnuDuzelt,
            this.toolStripMenuItem1,
            this.mnuSil});
            this.mnuTodo.Name = "mnuTodo";
            this.mnuTodo.Size = new System.Drawing.Size(56, 24);
            this.mnuTodo.Text = "Todo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuHakkimda
            // 
            this.mnuHakkimda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUygHakkinda,
            this.toolStripMenuItem2,
            this.mnuYardim});
            this.mnuHakkimda.Name = "mnuHakkimda";
            this.mnuHakkimda.Size = new System.Drawing.Size(88, 24);
            this.mnuHakkimda.Text = "Hakkımda";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 6);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grpYeniGorev);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTamamlananlarListesi);
            this.splitContainer1.Panel2.Controls.Add(this.lblTamamlananlarListesi);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainer1.Size = new System.Drawing.Size(752, 387);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.TabIndex = 2;
            // 
            // grpYeniGorev
            // 
            this.grpYeniGorev.Controls.Add(this.txtYeniGorev);
            this.grpYeniGorev.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYeniGorev.Location = new System.Drawing.Point(5, 6);
            this.grpYeniGorev.Name = "grpYeniGorev";
            this.grpYeniGorev.Padding = new System.Windows.Forms.Padding(12);
            this.grpYeniGorev.Size = new System.Drawing.Size(322, 99);
            this.grpYeniGorev.TabIndex = 0;
            this.grpYeniGorev.TabStop = false;
            this.grpYeniGorev.Text = "Yeni Görev";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 11);
            this.panel1.TabIndex = 1;
            // 
            // lblYapilacaklarListesi
            // 
            this.lblYapilacaklarListesi.AutoSize = true;
            this.lblYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapilacaklarListesi.Location = new System.Drawing.Point(5, 116);
            this.lblYapilacaklarListesi.Name = "lblYapilacaklarListesi";
            this.lblYapilacaklarListesi.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblYapilacaklarListesi.Size = new System.Drawing.Size(136, 30);
            this.lblYapilacaklarListesi.TabIndex = 2;
            this.lblYapilacaklarListesi.Text = "Yapılacaklar Listesi";
            // 
            // clbYapilacaklarListesi
            // 
            this.clbYapilacaklarListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.clbYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbYapilacaklarListesi.FormattingEnabled = true;
            this.clbYapilacaklarListesi.Location = new System.Drawing.Point(5, 146);
            this.clbYapilacaklarListesi.Name = "clbYapilacaklarListesi";
            this.clbYapilacaklarListesi.Size = new System.Drawing.Size(322, 235);
            this.clbYapilacaklarListesi.TabIndex = 3;
            this.clbYapilacaklarListesi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbYapilacaklarListesi_ItemCheck);
            this.clbYapilacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.clbYapilacaklarListesi_SelectedIndexChanged);
            this.clbYapilacaklarListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbYapilacaklarListesi_MouseUp);
            // 
            // lblTamamlananlarListesi
            // 
            this.lblTamamlananlarListesi.AutoSize = true;
            this.lblTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTamamlananlarListesi.Location = new System.Drawing.Point(5, 6);
            this.lblTamamlananlarListesi.Name = "lblTamamlananlarListesi";
            this.lblTamamlananlarListesi.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblTamamlananlarListesi.Size = new System.Drawing.Size(162, 30);
            this.lblTamamlananlarListesi.TabIndex = 3;
            this.lblTamamlananlarListesi.Text = "Tamamlananlar Listesi";
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.ItemHeight = 18;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(5, 36);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(406, 345);
            this.lstTamamlananlarListesi.TabIndex = 4;
            // 
            // txtYeniGorev
            // 
            this.txtYeniGorev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYeniGorev.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniGorev.Location = new System.Drawing.Point(12, 31);
            this.txtYeniGorev.MaxLength = 120;
            this.txtYeniGorev.Multiline = true;
            this.txtYeniGorev.Name = "txtYeniGorev";
            this.txtYeniGorev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtYeniGorev.Size = new System.Drawing.Size(298, 56);
            this.txtYeniGorev.TabIndex = 0;
            this.txtYeniGorev.Text = "asdasds asd as sa dsadsa d sa ds ad sad sa";
            // 
            // btnYeni
            // 
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = global::udemy_todolist.Properties.Resources.plus_24_16;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(24, 24);
            this.btnYeni.Text = "Yeni Görev";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuzelt.Image = global::udemy_todolist.Properties.Resources.new_24_16;
            this.btnDuzelt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(24, 24);
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = global::udemy_todolist.Properties.Resources.cross_24_16;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(24, 24);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(24, 24);
            this.btnKes.Text = "Kes";
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(24, 24);
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapistir.Image = ((System.Drawing.Image)(resources.GetObject("btnYapistir.Image")));
            this.btnYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(24, 24);
            this.btnYapistir.Text = "Yapıştır";
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYardim.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.Image")));
            this.btnYardim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(24, 24);
            this.btnYardim.Text = "Yardım";
            // 
            // mnuCikis
            // 
            this.mnuCikis.Image = global::udemy_todolist.Properties.Resources.cross_24_16;
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(112, 26);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // mnuYeni
            // 
            this.mnuYeni.Image = global::udemy_todolist.Properties.Resources.plus_24_16;
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuYeni.Size = new System.Drawing.Size(175, 26);
            this.mnuYeni.Text = "Yeni";
            this.mnuYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // mnuDuzelt
            // 
            this.mnuDuzelt.Image = global::udemy_todolist.Properties.Resources.new_24_16;
            this.mnuDuzelt.Name = "mnuDuzelt";
            this.mnuDuzelt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuDuzelt.Size = new System.Drawing.Size(175, 26);
            this.mnuDuzelt.Text = "Düzelt";
            this.mnuDuzelt.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // mnuSil
            // 
            this.mnuSil.Image = global::udemy_todolist.Properties.Resources.cross_24_16;
            this.mnuSil.Name = "mnuSil";
            this.mnuSil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSil.Size = new System.Drawing.Size(175, 26);
            this.mnuSil.Text = "Sil";
            this.mnuSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // mnuUygHakkinda
            // 
            this.mnuUygHakkinda.Image = global::udemy_todolist.Properties.Resources.calendar_24_16;
            this.mnuUygHakkinda.Name = "mnuUygHakkinda";
            this.mnuUygHakkinda.Size = new System.Drawing.Size(215, 26);
            this.mnuUygHakkinda.Text = "Uygulama Hakkında";
            this.mnuUygHakkinda.Click += new System.EventHandler(this.mnuUygHakkinda_Click);
            // 
            // mnuYardim
            // 
            this.mnuYardim.Image = global::udemy_todolist.Properties.Resources.bubble_24_16;
            this.mnuYardim.Name = "mnuYardim";
            this.mnuYardim.Size = new System.Drawing.Size(215, 26);
            this.mnuYardim.Text = "Yardım";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Bilgilendirme";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TodoList";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuYeni,
            this.cmnuDuzelt,
            this.toolStripMenuItem3,
            this.cmnuSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 88);
            // 
            // cmnuYeni
            // 
            this.cmnuYeni.Image = global::udemy_todolist.Properties.Resources.plus_24_16;
            this.cmnuYeni.Name = "cmnuYeni";
            this.cmnuYeni.Size = new System.Drawing.Size(125, 26);
            this.cmnuYeni.Text = "Yeni";
            this.cmnuYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // cmnuDuzelt
            // 
            this.cmnuDuzelt.Image = global::udemy_todolist.Properties.Resources.new_24_16;
            this.cmnuDuzelt.Name = "cmnuDuzelt";
            this.cmnuDuzelt.Size = new System.Drawing.Size(125, 26);
            this.cmnuDuzelt.Text = "Düzelt";
            this.cmnuDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 6);
            // 
            // cmnuSil
            // 
            this.cmnuSil.Image = global::udemy_todolist.Properties.Resources.cross_24_16;
            this.cmnuSil.Name = "cmnuSil";
            this.cmnuSil.Size = new System.Drawing.Size(125, 26);
            this.cmnuSil.Text = "Sil";
            this.cmnuSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 442);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpYeniGorev.ResumeLayout(false);
            this.grpYeniGorev.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripButton btnDuzelt;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnYardim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.ToolStripMenuItem mnuTodo;
        private System.Windows.Forms.ToolStripMenuItem mnuYeni;
        private System.Windows.Forms.ToolStripMenuItem mnuDuzelt;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSil;
        private System.Windows.Forms.ToolStripMenuItem mnuHakkimda;
        private System.Windows.Forms.ToolStripMenuItem mnuUygHakkinda;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuYardim;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpYeniGorev;
        private System.Windows.Forms.CheckedListBox clbYapilacaklarListesi;
        private System.Windows.Forms.Label lblYapilacaklarListesi;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label lblTamamlananlarListesi;
        private System.Windows.Forms.TextBox txtYeniGorev;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuYeni;
        private System.Windows.Forms.ToolStripMenuItem cmnuDuzelt;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cmnuSil;
    }
}

