namespace InteractiveMap
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.TextBox();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКэшToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКэшToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.MainMap);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 566);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panelText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Location = new System.Drawing.Point(6, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 550);
            this.panel1.TabIndex = 1;
            // 
            // panelText
            // 
            this.panelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelText.BackColor = System.Drawing.SystemColors.Control;
            this.panelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelText.Location = new System.Drawing.Point(4, 271);
            this.panelText.Multiline = true;
            this.panelText.Name = "panelText";
            this.panelText.ReadOnly = true;
            this.panelText.Size = new System.Drawing.Size(200, 276);
            this.panelText.TabIndex = 2;
            this.panelText.Text = resources.GetString("panelText.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelHeader.Location = new System.Drawing.Point(4, 2);
            this.panelHeader.Multiline = true;
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ReadOnly = true;
            this.panelHeader.Size = new System.Drawing.Size(200, 55);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Text = "Template";
            this.panelHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(6, 10);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomEnabled = true;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(656, 458);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 0D;
            this.MainMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.MainMap_OnMarkerClick);
            this.MainMap.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.MainMap_OnMarkerEnter);
            this.MainMap.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.MainMap_OnMarkerLeave);
            this.MainMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(96, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьБазуToolStripMenuItem,
            this.загрузитьБазуToolStripMenuItem,
            this.сохранитьКэшToolStripMenuItem,
            this.загрузитьКэшToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьБазуToolStripMenuItem
            // 
            this.сохранитьБазуToolStripMenuItem.Name = "сохранитьБазуToolStripMenuItem";
            this.сохранитьБазуToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.сохранитьБазуToolStripMenuItem.Text = "Сохранить базу";
            // 
            // загрузитьБазуToolStripMenuItem
            // 
            this.загрузитьБазуToolStripMenuItem.Name = "загрузитьБазуToolStripMenuItem";
            this.загрузитьБазуToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.загрузитьБазуToolStripMenuItem.Text = "Загрузить базу";
            this.загрузитьБазуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьБазуToolStripMenuItem_Click);
            // 
            // сохранитьКэшToolStripMenuItem
            // 
            this.сохранитьКэшToolStripMenuItem.Name = "сохранитьКэшToolStripMenuItem";
            this.сохранитьКэшToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.сохранитьКэшToolStripMenuItem.Text = "Сохранить кэш";
            this.сохранитьКэшToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКэшToolStripMenuItem_Click);
            // 
            // загрузитьКэшToolStripMenuItem
            // 
            this.загрузитьКэшToolStripMenuItem.Name = "загрузитьКэшToolStripMenuItem";
            this.загрузитьКэшToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.загрузитьКэшToolStripMenuItem.Text = "Загрузить кэш";
            this.загрузитьКэшToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКэшToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.infoShowToolStripMenuItem,
            this.infoHideToolStripMenuItem,
            this.infoToogleToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.test1ToolStripMenuItem.Text = "Test_1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // infoShowToolStripMenuItem
            // 
            this.infoShowToolStripMenuItem.Name = "infoShowToolStripMenuItem";
            this.infoShowToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.infoShowToolStripMenuItem.Text = "Info_Show";
            this.infoShowToolStripMenuItem.Click += new System.EventHandler(this.infoShowToolStripMenuItem_Click);
            // 
            // infoHideToolStripMenuItem
            // 
            this.infoHideToolStripMenuItem.Name = "infoHideToolStripMenuItem";
            this.infoHideToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.infoHideToolStripMenuItem.Text = "Info_Hide";
            this.infoHideToolStripMenuItem.Click += new System.EventHandler(this.infoHideToolStripMenuItem_Click);
            // 
            // infoToogleToolStripMenuItem
            // 
            this.infoToogleToolStripMenuItem.Name = "infoToogleToolStripMenuItem";
            this.infoToogleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.infoToogleToolStripMenuItem.Text = "Info_Toogle";
            this.infoToogleToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Text = "Интерактивная карта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox panelHeader;
        private System.Windows.Forms.TextBox panelText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКэшToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКэшToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToogleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}



