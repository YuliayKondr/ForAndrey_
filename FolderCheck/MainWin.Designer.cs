namespace FolderCheck
{
    partial class MainWin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            timerTime.Stop();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainfolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mainadresschange = new System.Windows.Forms.ToolStripMenuItem();
            this.diferentПапкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.check_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastroikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerfninToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.timertenminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timertwelveminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerthirtminToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerfiftyminToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeronehodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timertwohodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxStatistic = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderUser = new System.Windows.Forms.FolderBrowserDialog();
            this.timerCheckFolder = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.check_ToolStripMenuItem,
            this.wToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainfolderToolStripMenuItem,
            this.diferentПапкиToolStripMenuItem,
            this.toolStripSeparator1,
            this.CloseToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.mainToolStripMenuItem.Text = "Главная";
            // 
            // mainfolderToolStripMenuItem
            // 
            this.mainfolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mainadresschange});
            this.mainfolderToolStripMenuItem.Name = "mainfolderToolStripMenuItem";
            this.mainfolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainfolderToolStripMenuItem.Text = "Источник";
            // 
            // Mainadresschange
            // 
            this.Mainadresschange.Name = "Mainadresschange";
            this.Mainadresschange.Size = new System.Drawing.Size(162, 22);
            this.Mainadresschange.Text = "Адрес изменить";
            this.Mainadresschange.Click += new System.EventHandler(this.MainadresschangeToolStripMenuItem_Click);
            // 
            // diferentПапкиToolStripMenuItem
            // 
            this.diferentПапкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DellToolStripMenuItem});
            this.diferentПапкиToolStripMenuItem.Name = "diferentПапкиToolStripMenuItem";
            this.diferentПапкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diferentПапкиToolStripMenuItem.Text = "Получатели";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DellToolStripMenuItem
            // 
            this.DellToolStripMenuItem.Name = "DellToolStripMenuItem";
            this.DellToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.DellToolStripMenuItem.Text = "Удалить";
            this.DellToolStripMenuItem.Click += new System.EventHandler(this.DellToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // check_ToolStripMenuItem
            // 
            this.check_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartingToolStripMenuItem,
            this.StopingToolStripMenuItem,
            this.CheckingToolStripMenuItem});
            this.check_ToolStripMenuItem.Name = "check_ToolStripMenuItem";
            this.check_ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.check_ToolStripMenuItem.Text = "Проверка";
            // 
            // StartingToolStripMenuItem
            // 
            this.StartingToolStripMenuItem.Name = "StartingToolStripMenuItem";
            this.StartingToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.StartingToolStripMenuItem.Text = "Начать проверку";
            this.StartingToolStripMenuItem.Click += new System.EventHandler(this.StartCheckFolderToolStripMenuItem_Click);
            // 
            // StopingToolStripMenuItem
            // 
            this.StopingToolStripMenuItem.Name = "StopingToolStripMenuItem";
            this.StopingToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.StopingToolStripMenuItem.Text = "Остановить проверку";
            this.StopingToolStripMenuItem.Click += new System.EventHandler(this.StopCheckToolStripMenuItem_Click);
            // 
            // CheckingToolStripMenuItem
            // 
            this.CheckingToolStripMenuItem.Name = "CheckingToolStripMenuItem";
            this.CheckingToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.CheckingToolStripMenuItem.Text = "Проверить";
            this.CheckingToolStripMenuItem.Click += new System.EventHandler(this.button1_MouseClick);
            // 
            // wToolStripMenuItem
            // 
            this.wToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastroikaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.wToolStripMenuItem.Name = "wToolStripMenuItem";
            this.wToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.wToolStripMenuItem.Text = "Окно";
            // 
            // nastroikaToolStripMenuItem
            // 
            this.nastroikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntervalToolStripMenuItem});
            this.nastroikaToolStripMenuItem.Name = "nastroikaToolStripMenuItem";
            this.nastroikaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nastroikaToolStripMenuItem.Text = "Настройки";
            // 
            // IntervalToolStripMenuItem
            // 
            this.IntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerfninToolStripMenuItem4,
            this.timertenminToolStripMenuItem,
            this.timertwelveminToolStripMenuItem1,
            this.timerthirtminToolStripMenuItem2,
            this.timerfiftyminToolStripMenuItem3,
            this.timeronehodToolStripMenuItem,
            this.timertwohodToolStripMenuItem});
            this.IntervalToolStripMenuItem.Name = "IntervalToolStripMenuItem";
            this.IntervalToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.IntervalToolStripMenuItem.Text = "Интервал таймера";
            // 
            // timerfninToolStripMenuItem4
            // 
            this.timerfninToolStripMenuItem4.Name = "timerfninToolStripMenuItem4";
            this.timerfninToolStripMenuItem4.Size = new System.Drawing.Size(112, 22);
            this.timerfninToolStripMenuItem4.Text = " 5 мин";
            this.timerfninToolStripMenuItem4.Click += new System.EventHandler(this.SelectedInterval_Click);
            // 
            // timertenminToolStripMenuItem
            // 
            this.timertenminToolStripMenuItem.Name = "timertenminToolStripMenuItem";
            this.timertenminToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.timertenminToolStripMenuItem.Text = "10 мин";
            this.timertenminToolStripMenuItem.Click += new System.EventHandler(this.SelectedInterval_Click);
            // 
            // timertwelveminToolStripMenuItem1
            // 
            this.timertwelveminToolStripMenuItem1.Name = "timertwelveminToolStripMenuItem1";
            this.timertwelveminToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.timertwelveminToolStripMenuItem1.Text = "20 мин";
            this.timertwelveminToolStripMenuItem1.Click += new System.EventHandler(this.SelectedInterval_Click);
            // 
            // timerthirtminToolStripMenuItem2
            // 
            this.timerthirtminToolStripMenuItem2.Name = "timerthirtminToolStripMenuItem2";
            this.timerthirtminToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.timerthirtminToolStripMenuItem2.Text = "30 мин";
            this.timerthirtminToolStripMenuItem2.Click += new System.EventHandler(this.SelectedInterval_Click);
            // 
            // timerfiftyminToolStripMenuItem3
            // 
            this.timerfiftyminToolStripMenuItem3.Name = "timerfiftyminToolStripMenuItem3";
            this.timerfiftyminToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.timerfiftyminToolStripMenuItem3.Text = "45 мин";
            this.timerfiftyminToolStripMenuItem3.Click += new System.EventHandler(this.SelectedInterval_Click);
            // 
            // timeronehodToolStripMenuItem
            // 
            this.timeronehodToolStripMenuItem.Checked = true;
            this.timeronehodToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeronehodToolStripMenuItem.Name = "timeronehodToolStripMenuItem";
            this.timeronehodToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.timeronehodToolStripMenuItem.Text = "1 час";
            this.timeronehodToolStripMenuItem.Click += new System.EventHandler(this.SelectedInterval_Click);
            // 
            // timertwohodToolStripMenuItem
            // 
            this.timertwohodToolStripMenuItem.Name = "timertwohodToolStripMenuItem";
            this.timertwohodToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.timertwohodToolStripMenuItem.Text = "2 часа";
            this.timertwohodToolStripMenuItem.Click += new System.EventHandler(this.SelectedInterval_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listBoxStatistic
            // 
            this.listBoxStatistic.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxStatistic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStatistic.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listBoxStatistic.FormattingEnabled = true;
            this.listBoxStatistic.HorizontalExtent = 10;
            this.listBoxStatistic.HorizontalScrollbar = true;
            this.listBoxStatistic.ItemHeight = 15;
            this.listBoxStatistic.Location = new System.Drawing.Point(0, 49);
            this.listBoxStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxStatistic.Name = "listBoxStatistic";
            this.listBoxStatistic.ScrollAlwaysVisible = true;
            this.listBoxStatistic.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxStatistic.Size = new System.Drawing.Size(684, 244);
            this.listBoxStatistic.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(684, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel4.Image")));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 20);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Visible = false;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel3.Image")));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(34, 20);
            this.toolStripStatusLabel2.Text = "Time";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 15);
            this.toolStripStatusLabel1.Text = "Проверяется адрес";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerCheckFolder
            // 
            this.timerCheckFolder.Interval = 60000;
            this.timerCheckFolder.Tick += new System.EventHandler(this.timerCheckFolder_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "FolderCheck";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "проверяемая директория";
            this.toolStripButton1.Click += new System.EventHandler(this.MainadresschangeToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "добавление папок-получателей";
            this.toolStripButton4.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "удаление папок получателей";
            this.toolStripButton6.Click += new System.EventHandler(this.DellToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "проверить";
            this.toolStripButton2.Click += new System.EventHandler(this.button1_MouseClick);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "начать проверку";
            this.toolStripButton3.Click += new System.EventHandler(this.StartCheckFolderToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "остановить проверку";
            this.toolStripButton5.Click += new System.EventHandler(this.StopCheckToolStripMenuItem_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(230, 24);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 18);
            this.labelTime.TabIndex = 5;
            this.labelTime.Tag = "Time";
            this.labelTime.Text = "Time";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 336);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBoxStatistic);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(700, 375);
            this.MinimumSize = new System.Drawing.Size(700, 375);
            this.Name = "MainWin";
            this.Text = "FolderCheck";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainfolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mainadresschange;
        private System.Windows.Forms.ToolStripMenuItem diferentПапкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DellToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem check_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastroikaToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timerCheckFolder;
        private System.Windows.Forms.ToolStripMenuItem IntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerfninToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem timertenminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timertwelveminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timerthirtminToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem timerfiftyminToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem timeronehodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timertwohodToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListBox listBoxStatistic;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timerTime;
        public System.Windows.Forms.Label labelTime;
    }
}

