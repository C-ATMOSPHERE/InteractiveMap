namespace InteractiveMap
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.TextBox();
            this.zoom_bar = new System.Windows.Forms.TrackBar();
            this.btn_zoom_add = new System.Windows.Forms.Button();
            this.btn_zoom_sub = new System.Windows.Forms.Button();
            this.cb_mapProvider = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.newDescription = new System.Windows.Forms.TextBox();
            this.newHeaderText = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.addImage = new System.Windows.Forms.Button();
            this.prewievImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.сохранитьКэшToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКэшToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_bar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prewievImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.MainMap.OnPositionChanged += new GMap.NET.PositionChanged(this.MainMap_OnPositionChanged);
            this.MainMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.MainMap_OnMapZoomChanged);
            this.MainMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseClick);
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
            // zoom_bar
            // 
            this.zoom_bar.LargeChange = 1;
            this.zoom_bar.Location = new System.Drawing.Point(6, 39);
            this.zoom_bar.Maximum = 1700;
            this.zoom_bar.Minimum = 1;
            this.zoom_bar.Name = "zoom_bar";
            this.zoom_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoom_bar.Size = new System.Drawing.Size(45, 395);
            this.zoom_bar.TabIndex = 2;
            this.zoom_bar.TickFrequency = 50;
            this.zoom_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.zoom_bar.Value = 12;
            this.zoom_bar.ValueChanged += new System.EventHandler(this.zoom_bar_ValueChanged);
            // 
            // btn_zoom_add
            // 
            this.btn_zoom_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zoom_add.Location = new System.Drawing.Point(6, 10);
            this.btn_zoom_add.Name = "btn_zoom_add";
            this.btn_zoom_add.Size = new System.Drawing.Size(45, 23);
            this.btn_zoom_add.TabIndex = 3;
            this.btn_zoom_add.Text = "+";
            this.btn_zoom_add.UseVisualStyleBackColor = true;
            this.btn_zoom_add.Click += new System.EventHandler(this.btn_zoom_add_Click);
            // 
            // btn_zoom_sub
            // 
            this.btn_zoom_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zoom_sub.Location = new System.Drawing.Point(6, 440);
            this.btn_zoom_sub.Name = "btn_zoom_sub";
            this.btn_zoom_sub.Size = new System.Drawing.Size(45, 28);
            this.btn_zoom_sub.TabIndex = 4;
            this.btn_zoom_sub.Text = "-";
            this.btn_zoom_sub.UseVisualStyleBackColor = true;
            this.btn_zoom_sub.Click += new System.EventHandler(this.btn_zoom_sub_Click);
            // 
            // cb_mapProvider
            // 
            this.cb_mapProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mapProvider.FormattingEnabled = true;
            this.cb_mapProvider.Location = new System.Drawing.Point(57, 32);
            this.cb_mapProvider.Name = "cb_mapProvider";
            this.cb_mapProvider.Size = new System.Drawing.Size(200, 21);
            this.cb_mapProvider.TabIndex = 5;
            this.cb_mapProvider.DropDownClosed += new System.EventHandler(this.cb_mapProvider_DropDownClosed);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAddPoint);
            this.groupBox2.Controls.Add(this.newDescription);
            this.groupBox2.Controls.Add(this.newHeaderText);
            this.groupBox2.Controls.Add(this.submit);
            this.groupBox2.Controls.Add(this.addImage);
            this.groupBox2.Controls.Add(this.prewievImage);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_zoom_add);
            this.groupBox2.Controls.Add(this.zoom_bar);
            this.groupBox2.Controls.Add(this.btn_zoom_sub);
            this.groupBox2.Controls.Add(this.cb_mapProvider);
            this.groupBox2.Location = new System.Drawing.Point(726, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 566);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(124, 86);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(133, 23);
            this.btnAddPoint.TabIndex = 11;
            this.btnAddPoint.Text = "Добавить метку";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // newDescription
            // 
            this.newDescription.Location = new System.Drawing.Point(57, 374);
            this.newDescription.Multiline = true;
            this.newDescription.Name = "newDescription";
            this.newDescription.Size = new System.Drawing.Size(200, 164);
            this.newDescription.TabIndex = 10;
            this.newDescription.Text = "Описание";
            // 
            // newHeaderText
            // 
            this.newHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newHeaderText.Location = new System.Drawing.Point(57, 115);
            this.newHeaderText.Name = "newHeaderText";
            this.newHeaderText.Size = new System.Drawing.Size(200, 20);
            this.newHeaderText.TabIndex = 10;
            this.newHeaderText.Text = "Заголовок";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.Control;
            this.submit.Location = new System.Drawing.Point(57, 544);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(200, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Готово";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // addImage
            // 
            this.addImage.BackColor = System.Drawing.SystemColors.Control;
            this.addImage.Location = new System.Drawing.Point(110, 345);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(147, 23);
            this.addImage.TabIndex = 8;
            this.addImage.Text = "Добавить изображение";
            this.addImage.UseVisualStyleBackColor = false;
            this.addImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // prewievImage
            // 
            this.prewievImage.Location = new System.Drawing.Point(57, 141);
            this.prewievImage.Name = "prewievImage";
            this.prewievImage.Size = new System.Drawing.Size(200, 200);
            this.prewievImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prewievImage.TabIndex = 9;
            this.prewievImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(57, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "InfoPanel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поставщик Карт";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьБазуToolStripMenuItem,
            this.загрузитьБазуToolStripMenuItem,
            this.сохранитьКэшToolStripMenuItem,
            this.загрузитьКэшToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьБазуToolStripMenuItem
            // 
            this.сохранитьБазуToolStripMenuItem.Name = "сохранитьБазуToolStripMenuItem";
            this.сохранитьБазуToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.сохранитьБазуToolStripMenuItem.Text = "Сохранить базу";
            this.сохранитьБазуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьБазуToolStripMenuItem_Click);
            // 
            // загрузитьБазуToolStripMenuItem
            // 
            this.загрузитьБазуToolStripMenuItem.Name = "загрузитьБазуToolStripMenuItem";
            this.загрузитьБазуToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.загрузитьБазуToolStripMenuItem.Text = "Загрузить базу";
            this.загрузитьБазуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьБазуToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.infoShowToolStripMenuItem,
            this.infoHideToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.test1ToolStripMenuItem.Text = "Test_1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // infoShowToolStripMenuItem
            // 
            this.infoShowToolStripMenuItem.Name = "infoShowToolStripMenuItem";
            this.infoShowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoShowToolStripMenuItem.Text = "Info_Show";
            this.infoShowToolStripMenuItem.Click += new System.EventHandler(this.infoShowToolStripMenuItem_Click);
            // 
            // infoHideToolStripMenuItem
            // 
            this.infoHideToolStripMenuItem.Name = "infoHideToolStripMenuItem";
            this.infoHideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoHideToolStripMenuItem.Text = "Info_Hide";
            this.infoHideToolStripMenuItem.Click += new System.EventHandler(this.infoHideToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
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
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(732, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom_bar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prewievImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar zoom_bar;
        private System.Windows.Forms.Button btn_zoom_add;
        private System.Windows.Forms.Button btn_zoom_sub;
        private System.Windows.Forms.ComboBox cb_mapProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox panelHeader;
        private System.Windows.Forms.TextBox panelText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox newDescription;
        private System.Windows.Forms.TextBox newHeaderText;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.PictureBox prewievImage;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьБазуToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoHideToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКэшToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКэшToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}



