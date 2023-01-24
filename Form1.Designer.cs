namespace NORECOIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.DurumKontrol = new System.Windows.Forms.Label();
            this.deagle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.susturucubar = new MetroFramework.Controls.MetroComboBox();
            this.pistolbar = new MetroFramework.Controls.MetroComboBox();
            this.tec9bar = new MetroFramework.Controls.MetroComboBox();
            this.uzibar = new MetroFramework.Controls.MetroComboBox();
            this.shotgunbar = new MetroFramework.Controls.MetroComboBox();
            this.m4bar = new MetroFramework.Controls.MetroComboBox();
            this.ak47bar = new MetroFramework.Controls.MetroComboBox();
            this.mp5bar = new MetroFramework.Controls.MetroComboBox();
            this.deaglebar = new MetroFramework.Controls.MetroComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durum:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DurumKontrol
            // 
            this.DurumKontrol.AutoSize = true;
            this.DurumKontrol.BackColor = System.Drawing.SystemColors.Desktop;
            this.DurumKontrol.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumKontrol.ForeColor = System.Drawing.Color.Coral;
            this.DurumKontrol.Location = new System.Drawing.Point(75, 20);
            this.DurumKontrol.Name = "DurumKontrol";
            this.DurumKontrol.Size = new System.Drawing.Size(19, 13);
            this.DurumKontrol.TabIndex = 1;
            this.DurumKontrol.Text = "...";
            this.DurumKontrol.Click += new System.EventHandler(this.label2_Click);
            // 
            // deagle
            // 
            this.deagle.AutoEllipsis = true;
            this.deagle.AutoSize = true;
            this.deagle.BackColor = System.Drawing.Color.Transparent;
            this.deagle.Cursor = System.Windows.Forms.Cursors.Default;
            this.deagle.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.deagle.ForeColor = System.Drawing.Color.Red;
            this.deagle.Location = new System.Drawing.Point(15, 42);
            this.deagle.Margin = new System.Windows.Forms.Padding(0);
            this.deagle.Name = "deagle";
            this.deagle.Size = new System.Drawing.Size(81, 47);
            this.deagle.TabIndex = 2;
            this.deagle.Text = "3";
            this.deagle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deagle.Click += new System.EventHandler(this.deagle_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "8";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 47);
            this.label3.TabIndex = 13;
            this.label3.Text = "H";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "5";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 47);
            this.label5.TabIndex = 15;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 47);
            this.label6.TabIndex = 16;
            this.label6.Text = "9";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(15, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 47);
            this.label7.TabIndex = 17;
            this.label7.Text = "7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(15, 372);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 47);
            this.label8.TabIndex = 18;
            this.label8.Text = "6";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("GTAWEAPON3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(13, 419);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 47);
            this.label9.TabIndex = 19;
            this.label9.Text = "2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.textBox1);
            this.metroPanel1.Controls.Add(this.susturucubar);
            this.metroPanel1.Controls.Add(this.pistolbar);
            this.metroPanel1.Controls.Add(this.tec9bar);
            this.metroPanel1.Controls.Add(this.uzibar);
            this.metroPanel1.Controls.Add(this.shotgunbar);
            this.metroPanel1.Controls.Add(this.m4bar);
            this.metroPanel1.Controls.Add(this.ak47bar);
            this.metroPanel1.Controls.Add(this.mp5bar);
            this.metroPanel1.Controls.Add(this.deaglebar);
            this.metroPanel1.Controls.Add(this.label9);
            this.metroPanel1.Controls.Add(this.label8);
            this.metroPanel1.Controls.Add(this.label7);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.deagle);
            this.metroPanel1.Controls.Add(this.DurumKontrol);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-6, -7);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(270, 513);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // susturucubar
            // 
            this.susturucubar.DisplayMember = "1";
            this.susturucubar.FormattingEnabled = true;
            this.susturucubar.ItemHeight = 23;
            this.susturucubar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.susturucubar.Location = new System.Drawing.Point(79, 430);
            this.susturucubar.Name = "susturucubar";
            this.susturucubar.PromptText = "[NORMAL]";
            this.susturucubar.Size = new System.Drawing.Size(152, 29);
            this.susturucubar.Style = MetroFramework.MetroColorStyle.Red;
            this.susturucubar.TabIndex = 55;
            this.susturucubar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.susturucubar.UseSelectable = true;
            this.susturucubar.SelectedIndexChanged += new System.EventHandler(this.susturucubar_SelectedIndexChanged);
            // 
            // pistolbar
            // 
            this.pistolbar.DisplayMember = "1";
            this.pistolbar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pistolbar.FormattingEnabled = true;
            this.pistolbar.ItemHeight = 23;
            this.pistolbar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.pistolbar.Location = new System.Drawing.Point(79, 385);
            this.pistolbar.Name = "pistolbar";
            this.pistolbar.PromptText = "[NORMAL]";
            this.pistolbar.Size = new System.Drawing.Size(152, 29);
            this.pistolbar.Style = MetroFramework.MetroColorStyle.Red;
            this.pistolbar.TabIndex = 54;
            this.pistolbar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pistolbar.UseSelectable = true;
            this.pistolbar.SelectedIndexChanged += new System.EventHandler(this.pistolbar_SelectedIndexChanged);
            // 
            // tec9bar
            // 
            this.tec9bar.DisplayMember = "1";
            this.tec9bar.FormattingEnabled = true;
            this.tec9bar.ItemHeight = 23;
            this.tec9bar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.tec9bar.Location = new System.Drawing.Point(79, 340);
            this.tec9bar.Name = "tec9bar";
            this.tec9bar.PromptText = "[NORMAL]";
            this.tec9bar.Size = new System.Drawing.Size(152, 29);
            this.tec9bar.Style = MetroFramework.MetroColorStyle.Red;
            this.tec9bar.TabIndex = 53;
            this.tec9bar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tec9bar.UseSelectable = true;
            this.tec9bar.SelectedIndexChanged += new System.EventHandler(this.tec9bar_SelectedIndexChanged);
            // 
            // uzibar
            // 
            this.uzibar.DisplayMember = "1";
            this.uzibar.FormattingEnabled = true;
            this.uzibar.ItemHeight = 23;
            this.uzibar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.uzibar.Location = new System.Drawing.Point(79, 293);
            this.uzibar.Name = "uzibar";
            this.uzibar.PromptText = "[NORMAL]";
            this.uzibar.Size = new System.Drawing.Size(152, 29);
            this.uzibar.Style = MetroFramework.MetroColorStyle.Red;
            this.uzibar.TabIndex = 52;
            this.uzibar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uzibar.UseSelectable = true;
            this.uzibar.SelectedIndexChanged += new System.EventHandler(this.uzibar_SelectedIndexChanged);
            // 
            // shotgunbar
            // 
            this.shotgunbar.DisplayMember = "1";
            this.shotgunbar.FormattingEnabled = true;
            this.shotgunbar.ItemHeight = 23;
            this.shotgunbar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.shotgunbar.Location = new System.Drawing.Point(79, 246);
            this.shotgunbar.Name = "shotgunbar";
            this.shotgunbar.PromptText = "[NORMAL]";
            this.shotgunbar.Size = new System.Drawing.Size(152, 29);
            this.shotgunbar.Style = MetroFramework.MetroColorStyle.Red;
            this.shotgunbar.TabIndex = 51;
            this.shotgunbar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.shotgunbar.UseSelectable = true;
            this.shotgunbar.SelectedIndexChanged += new System.EventHandler(this.shotgunbar_SelectedIndexChanged);
            // 
            // m4bar
            // 
            this.m4bar.DisplayMember = "1";
            this.m4bar.FormattingEnabled = true;
            this.m4bar.ItemHeight = 23;
            this.m4bar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.m4bar.Location = new System.Drawing.Point(79, 199);
            this.m4bar.Name = "m4bar";
            this.m4bar.PromptText = "[NORMAL]";
            this.m4bar.Size = new System.Drawing.Size(152, 29);
            this.m4bar.Style = MetroFramework.MetroColorStyle.Red;
            this.m4bar.TabIndex = 50;
            this.m4bar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.m4bar.UseSelectable = true;
            this.m4bar.SelectedIndexChanged += new System.EventHandler(this.m4bar_SelectedIndexChanged);
            // 
            // ak47bar
            // 
            this.ak47bar.DisplayMember = "1";
            this.ak47bar.FormattingEnabled = true;
            this.ak47bar.ItemHeight = 23;
            this.ak47bar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.ak47bar.Location = new System.Drawing.Point(79, 151);
            this.ak47bar.Name = "ak47bar";
            this.ak47bar.PromptText = "[NORMAL]";
            this.ak47bar.Size = new System.Drawing.Size(152, 29);
            this.ak47bar.Style = MetroFramework.MetroColorStyle.Red;
            this.ak47bar.TabIndex = 49;
            this.ak47bar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ak47bar.UseSelectable = true;
            this.ak47bar.SelectedIndexChanged += new System.EventHandler(this.ak47bar_SelectedIndexChanged);
            // 
            // mp5bar
            // 
            this.mp5bar.DisplayMember = "1";
            this.mp5bar.FormattingEnabled = true;
            this.mp5bar.ItemHeight = 23;
            this.mp5bar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.mp5bar.Location = new System.Drawing.Point(79, 104);
            this.mp5bar.Name = "mp5bar";
            this.mp5bar.PromptText = "[NORMAL]";
            this.mp5bar.Size = new System.Drawing.Size(152, 29);
            this.mp5bar.Style = MetroFramework.MetroColorStyle.Red;
            this.mp5bar.TabIndex = 48;
            this.mp5bar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mp5bar.UseSelectable = true;
            this.mp5bar.SelectedIndexChanged += new System.EventHandler(this.mp5bar_SelectedIndexChanged);
            this.mp5bar.SelectedValueChanged += new System.EventHandler(this.mp5bar_SelectedValueChanged);
            // 
            // deaglebar
            // 
            this.deaglebar.DisplayMember = "0";
            this.deaglebar.FormattingEnabled = true;
            this.deaglebar.ItemHeight = 23;
            this.deaglebar.Items.AddRange(new object[] {
            "[Normal]",
            "[LiteLegit]",
            "[Legit]",
            "[Hard]",
            "[RAGE]"});
            this.deaglebar.Location = new System.Drawing.Point(79, 57);
            this.deaglebar.Name = "deaglebar";
            this.deaglebar.PromptText = "[NORMAL]";
            this.deaglebar.Size = new System.Drawing.Size(152, 29);
            this.deaglebar.Style = MetroFramework.MetroColorStyle.Red;
            this.deaglebar.TabIndex = 47;
            this.deaglebar.TabStop = false;
            this.deaglebar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deaglebar.UseSelectable = true;
            this.deaglebar.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.deaglebar.SelectedValueChanged += new System.EventHandler(this.deaglebar_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Swis721 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(21, 482);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 14);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "DC: Trusted#6236";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(255, 501);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "legit nospread by TrusteD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DurumKontrol;
        private System.Windows.Forms.Label deagle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox deaglebar;
        private MetroFramework.Controls.MetroComboBox susturucubar;
        private MetroFramework.Controls.MetroComboBox pistolbar;
        private MetroFramework.Controls.MetroComboBox tec9bar;
        private MetroFramework.Controls.MetroComboBox uzibar;
        private MetroFramework.Controls.MetroComboBox shotgunbar;
        private MetroFramework.Controls.MetroComboBox m4bar;
        private MetroFramework.Controls.MetroComboBox ak47bar;
        public MetroFramework.Controls.MetroComboBox mp5bar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

