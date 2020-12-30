using System.Drawing.Drawing2D;

namespace ConfigGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.createConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.browseConfigurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aggregateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseDataBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.browseThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.millToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollgangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.threadsList = new System.Windows.Forms.ComboBox();
            this.dataMillConfig = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataThreadSignals = new System.Windows.Forms.DataGridView();
            this.dataSubsriptions = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataBlocks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkThreadStopAtEnds = new System.Windows.Forms.CheckBox();
            this.textThreadDirection = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textThreadFinish = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textThreadStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textThreadNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textThreadName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textThreadUid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataThreadSensors = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMillConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataThreadSignals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubsriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBlocks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThreadSensors)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1448, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Главное меню";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createConfigurationMenuItem,
            this.openConfigurationMenuItem,
            this.saveConfigurationMenuItem,
            this.saveAsConfigurationMenuItem,
            this.toolStripSeparator1,
            this.browseConfigurationMenuItem,
            this.toolStripSeparator2,
            this.exitMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // createConfigurationMenuItem
            // 
            this.createConfigurationMenuItem.Name = "createConfigurationMenuItem";
            this.createConfigurationMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createConfigurationMenuItem.Size = new System.Drawing.Size(260, 22);
            this.createConfigurationMenuItem.Text = "Создать";
            this.createConfigurationMenuItem.Click += new System.EventHandler(this.createConfigurationMenuItem_Click);
            // 
            // openConfigurationMenuItem
            // 
            this.openConfigurationMenuItem.Name = "openConfigurationMenuItem";
            this.openConfigurationMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openConfigurationMenuItem.Size = new System.Drawing.Size(260, 22);
            this.openConfigurationMenuItem.Text = "Открыть...";
            this.openConfigurationMenuItem.Click += new System.EventHandler(this.openConfigurationMenuItem_Click);
            // 
            // saveConfigurationMenuItem
            // 
            this.saveConfigurationMenuItem.Name = "saveConfigurationMenuItem";
            this.saveConfigurationMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveConfigurationMenuItem.Size = new System.Drawing.Size(260, 22);
            this.saveConfigurationMenuItem.Text = "Сохранить";
            this.saveConfigurationMenuItem.Click += new System.EventHandler(this.saveConfigurationMenuItem_Click);
            // 
            // saveAsConfigurationMenuItem
            // 
            this.saveAsConfigurationMenuItem.Name = "saveAsConfigurationMenuItem";
            this.saveAsConfigurationMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsConfigurationMenuItem.Size = new System.Drawing.Size(260, 22);
            this.saveAsConfigurationMenuItem.Text = "Сохранить как...";
            this.saveAsConfigurationMenuItem.Click += new System.EventHandler(this.saveAsConfigurationMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // browseConfigurationMenuItem
            // 
            this.browseConfigurationMenuItem.Name = "browseConfigurationMenuItem";
            this.browseConfigurationMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.browseConfigurationMenuItem.Size = new System.Drawing.Size(260, 22);
            this.browseConfigurationMenuItem.Text = "Просмотр конфигурации";
            this.browseConfigurationMenuItem.Click += new System.EventHandler(this.browseConfigurationMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitMenuItem.Size = new System.Drawing.Size(260, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggregateToolStripMenuItem,
            this.linearToolStripMenuItem,
            this.dataBlockToolStripMenuItem,
            this.sensorToolStripMenuItem,
            this.cageToolStripMenuItem,
            this.labelToolStripMenuItem,
            this.threadToolStripMenuItem1,
            this.millToolStripMenuItem,
            this.ingotToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.subscriptionToolStripMenuItem,
            this.rollgangToolStripMenuItem,
            this.signalToolStripMenuItem,
            this.techUnitToolStripMenuItem,
            this.deleterToolStripMenuItem,
            this.stopperToolStripMenuItem});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton2.Text = "Объекты";
            // 
            // aggregateToolStripMenuItem
            // 
            this.aggregateToolStripMenuItem.Name = "aggregateToolStripMenuItem";
            this.aggregateToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.aggregateToolStripMenuItem.Text = "Агрегаты";
            // 
            // linearToolStripMenuItem
            // 
            this.linearToolStripMenuItem.Name = "linearToolStripMenuItem";
            this.linearToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.linearToolStripMenuItem.Text = "Агрегаты линейного перемещения";
            // 
            // dataBlockToolStripMenuItem
            // 
            this.dataBlockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseDataBlockToolStripMenuItem,
            this.addDataBlockToolStripMenuItem,
            this.editDataBlockToolStripMenuItem});
            this.dataBlockToolStripMenuItem.Name = "dataBlockToolStripMenuItem";
            this.dataBlockToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.dataBlockToolStripMenuItem.Text = "Блоки данных";
            // 
            // browseDataBlockToolStripMenuItem
            // 
            this.browseDataBlockToolStripMenuItem.Name = "browseDataBlockToolStripMenuItem";
            this.browseDataBlockToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.browseDataBlockToolStripMenuItem.Text = "Обзор";
            this.browseDataBlockToolStripMenuItem.Click += new System.EventHandler(this.browseDataBlockToolStripMenuItem_Click);
            // 
            // addDataBlockToolStripMenuItem
            // 
            this.addDataBlockToolStripMenuItem.Name = "addDataBlockToolStripMenuItem";
            this.addDataBlockToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addDataBlockToolStripMenuItem.Text = "Добавить";
            this.addDataBlockToolStripMenuItem.Click += new System.EventHandler(this.addDataBlockToolStripMenuItem_Click);
            // 
            // editDataBlockToolStripMenuItem
            // 
            this.editDataBlockToolStripMenuItem.Name = "editDataBlockToolStripMenuItem";
            this.editDataBlockToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editDataBlockToolStripMenuItem.Text = "Редактировать";
            this.editDataBlockToolStripMenuItem.Click += new System.EventHandler(this.editDataBlockToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.sensorToolStripMenuItem.Text = "Датчики";
            // 
            // cageToolStripMenuItem
            // 
            this.cageToolStripMenuItem.Name = "cageToolStripMenuItem";
            this.cageToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.cageToolStripMenuItem.Text = "Клети";
            // 
            // labelToolStripMenuItem
            // 
            this.labelToolStripMenuItem.Name = "labelToolStripMenuItem";
            this.labelToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.labelToolStripMenuItem.Text = "Метки";
            // 
            // threadToolStripMenuItem1
            // 
            this.threadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseThreadsToolStripMenuItem,
            this.addThreadToolStripMenuItem,
            this.editThreadToolStripMenuItem});
            this.threadToolStripMenuItem1.Name = "threadToolStripMenuItem1";
            this.threadToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.threadToolStripMenuItem1.Text = "Нити";
            // 
            // browseThreadsToolStripMenuItem
            // 
            this.browseThreadsToolStripMenuItem.Name = "browseThreadsToolStripMenuItem";
            this.browseThreadsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.browseThreadsToolStripMenuItem.Text = "Обзор";
            this.browseThreadsToolStripMenuItem.Click += new System.EventHandler(this.browseThreadToolStripMenuItem_Click);
            // 
            // addThreadToolStripMenuItem
            // 
            this.addThreadToolStripMenuItem.Name = "addThreadToolStripMenuItem";
            this.addThreadToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addThreadToolStripMenuItem.Text = "Добавить";
            this.addThreadToolStripMenuItem.Click += new System.EventHandler(this.addThreadToolStripMenuItem_Click);
            // 
            // editThreadToolStripMenuItem
            // 
            this.editThreadToolStripMenuItem.Name = "editThreadToolStripMenuItem";
            this.editThreadToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editThreadToolStripMenuItem.Text = "Редактировать";
            this.editThreadToolStripMenuItem.Click += new System.EventHandler(this.editThreadToolStripMenuItem_Click);
            // 
            // millToolStripMenuItem
            // 
            this.millToolStripMenuItem.Name = "millToolStripMenuItem";
            this.millToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.millToolStripMenuItem.Text = "Общие параметры";
            this.millToolStripMenuItem.Click += new System.EventHandler(this.millToolStripMenuItem_Click);
            // 
            // ingotToolStripMenuItem
            // 
            this.ingotToolStripMenuItem.Name = "ingotToolStripMenuItem";
            this.ingotToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.ingotToolStripMenuItem.Text = "Параметры ЕУ";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.connectionToolStripMenuItem.Text = "Подключение";
            // 
            // subscriptionToolStripMenuItem
            // 
            this.subscriptionToolStripMenuItem.Name = "subscriptionToolStripMenuItem";
            this.subscriptionToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.subscriptionToolStripMenuItem.Text = "Подписки";
            this.subscriptionToolStripMenuItem.Click += new System.EventHandler(this.subscriptionToolStripMenuItem_Click);
            // 
            // rollgangToolStripMenuItem
            // 
            this.rollgangToolStripMenuItem.Name = "rollgangToolStripMenuItem";
            this.rollgangToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.rollgangToolStripMenuItem.Text = "Рольганги";
            // 
            // signalToolStripMenuItem
            // 
            this.signalToolStripMenuItem.Name = "signalToolStripMenuItem";
            this.signalToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.signalToolStripMenuItem.Text = "Сигналы";
            // 
            // techUnitToolStripMenuItem
            // 
            this.techUnitToolStripMenuItem.Name = "techUnitToolStripMenuItem";
            this.techUnitToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.techUnitToolStripMenuItem.Text = "Техузлы";
            // 
            // deleterToolStripMenuItem
            // 
            this.deleterToolStripMenuItem.Name = "deleterToolStripMenuItem";
            this.deleterToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.deleterToolStripMenuItem.Text = "Удаление застрявших";
            // 
            // stopperToolStripMenuItem
            // 
            this.stopperToolStripMenuItem.Name = "stopperToolStripMenuItem";
            this.stopperToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.stopperToolStripMenuItem.Text = "Упоры";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 840);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(1448, 28);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "Готово.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нить:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // threadsList
            // 
            this.threadsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threadsList.Location = new System.Drawing.Point(57, 29);
            this.threadsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.threadsList.Name = "threadsList";
            this.threadsList.Size = new System.Drawing.Size(358, 23);
            this.threadsList.TabIndex = 3;
            this.threadsList.SelectedValueChanged += new System.EventHandler(this.threadsList_SelectedValueChanged);
            // 
            // dataMillConfig
            // 
            this.dataMillConfig.AllowUserToAddRows = false;
            this.dataMillConfig.AllowUserToDeleteRows = false;
            this.dataMillConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataMillConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMillConfig.Location = new System.Drawing.Point(7, 28);
            this.dataMillConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataMillConfig.Name = "dataMillConfig";
            this.dataMillConfig.ReadOnly = true;
            this.dataMillConfig.Size = new System.Drawing.Size(422, 260);
            this.dataMillConfig.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Общие параметры:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataThreadSignals
            // 
            this.dataThreadSignals.AllowUserToAddRows = false;
            this.dataThreadSignals.AllowUserToDeleteRows = false;
            this.dataThreadSignals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataThreadSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThreadSignals.Location = new System.Drawing.Point(436, 331);
            this.dataThreadSignals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataThreadSignals.Name = "dataThreadSignals";
            this.dataThreadSignals.ReadOnly = true;
            this.dataThreadSignals.Size = new System.Drawing.Size(394, 260);
            this.dataThreadSignals.TabIndex = 1;
            // 
            // dataSubsriptions
            // 
            this.dataSubsriptions.AllowUserToAddRows = false;
            this.dataSubsriptions.AllowUserToDeleteRows = false;
            this.dataSubsriptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataSubsriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubsriptions.Location = new System.Drawing.Point(436, 28);
            this.dataSubsriptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataSubsriptions.Name = "dataSubsriptions";
            this.dataSubsriptions.ReadOnly = true;
            this.dataSubsriptions.Size = new System.Drawing.Size(394, 260);
            this.dataSubsriptions.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(436, 307);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(394, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Сигналы:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(436, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подписки:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Блоки данных:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataBlocks
            // 
            this.dataBlocks.AllowUserToAddRows = false;
            this.dataBlocks.AllowUserToDeleteRows = false;
            this.dataBlocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBlocks.Location = new System.Drawing.Point(9, 330);
            this.dataBlocks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataBlocks.Name = "dataBlocks";
            this.dataBlocks.ReadOnly = true;
            this.dataBlocks.Size = new System.Drawing.Size(420, 261);
            this.dataBlocks.TabIndex = 5;
            this.dataBlocks.Text = "dataGridView1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkThreadStopAtEnds);
            this.groupBox1.Controls.Add(this.textThreadDirection);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textThreadFinish);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textThreadStart);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textThreadNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textThreadName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textThreadUid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.threadsList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(429, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры линии производства";
            // 
            // checkThreadStopAtEnds
            // 
            this.checkThreadStopAtEnds.Enabled = false;
            this.checkThreadStopAtEnds.Location = new System.Drawing.Point(232, 168);
            this.checkThreadStopAtEnds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkThreadStopAtEnds.Name = "checkThreadStopAtEnds";
            this.checkThreadStopAtEnds.Size = new System.Drawing.Size(183, 25);
            this.checkThreadStopAtEnds.TabIndex = 16;
            this.checkThreadStopAtEnds.Text = "Останавливать на концах";
            this.checkThreadStopAtEnds.UseVisualStyleBackColor = true;
            // 
            // textThreadDirection
            // 
            this.textThreadDirection.Location = new System.Drawing.Point(107, 168);
            this.textThreadDirection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textThreadDirection.Name = "textThreadDirection";
            this.textThreadDirection.ReadOnly = true;
            this.textThreadDirection.Size = new System.Drawing.Size(109, 23);
            this.textThreadDirection.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 173);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Направление:";
            // 
            // textThreadFinish
            // 
            this.textThreadFinish.Location = new System.Drawing.Point(298, 135);
            this.textThreadFinish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textThreadFinish.Name = "textThreadFinish";
            this.textThreadFinish.ReadOnly = true;
            this.textThreadFinish.Size = new System.Drawing.Size(117, 23);
            this.textThreadFinish.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(203, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Завершение:";
            // 
            // textThreadStart
            // 
            this.textThreadStart.Location = new System.Drawing.Point(75, 135);
            this.textThreadStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textThreadStart.Name = "textThreadStart";
            this.textThreadStart.ReadOnly = true;
            this.textThreadStart.Size = new System.Drawing.Size(104, 23);
            this.textThreadStart.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Начало:";
            // 
            // textThreadNumber
            // 
            this.textThreadNumber.Location = new System.Drawing.Point(337, 70);
            this.textThreadNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textThreadNumber.Name = "textThreadNumber";
            this.textThreadNumber.ReadOnly = true;
            this.textThreadNumber.Size = new System.Drawing.Size(78, 23);
            this.textThreadNumber.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(246, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Номер нити:";
            // 
            // textThreadName
            // 
            this.textThreadName.Location = new System.Drawing.Point(117, 104);
            this.textThreadName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textThreadName.Name = "textThreadName";
            this.textThreadName.ReadOnly = true;
            this.textThreadName.Size = new System.Drawing.Size(298, 23);
            this.textThreadName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Наименование:";
            // 
            // textThreadUid
            // 
            this.textThreadUid.Location = new System.Drawing.Point(122, 70);
            this.textThreadUid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textThreadUid.Name = "textThreadUid";
            this.textThreadUid.ReadOnly = true;
            this.textThreadUid.Size = new System.Drawing.Size(106, 23);
            this.textThreadUid.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Идентификатор:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataThreadSensors);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(7, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(796, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Объекты слежения";
            // 
            // dataThreadSensors
            // 
            this.dataThreadSensors.AllowUserToAddRows = false;
            this.dataThreadSensors.AllowUserToDeleteRows = false;
            this.dataThreadSensors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataThreadSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThreadSensors.Location = new System.Drawing.Point(407, 45);
            this.dataThreadSensors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataThreadSensors.Name = "dataThreadSensors";
            this.dataThreadSensors.ReadOnly = true;
            this.dataThreadSensors.Size = new System.Drawing.Size(382, 147);
            this.dataThreadSensors.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(407, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(380, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Датчики:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1448, 815);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataThreadSignals);
            this.tabPage1.Controls.Add(this.dataMillConfig);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataBlocks);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataSubsriptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1440, 787);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры конфигурации";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1440, 787);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Параметры нитей";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 868);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конфигурация ССМ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMillConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataThreadSignals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubsriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBlocks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataThreadSensors)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.DataGridView dataThreadSensors;

        private System.Windows.Forms.DataGridView dataThreadSignals;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.DataGridView dataBlocks;
        private System.Windows.Forms.DataGridView dataMillConfig;
        private System.Windows.Forms.DataGridView dataSubsriptions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.CheckBox checkThreadStopAtEnds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textThreadDirection;
        private System.Windows.Forms.TextBox textThreadFinish;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textThreadName;
        private System.Windows.Forms.TextBox textThreadNumber;
        private System.Windows.Forms.TextBox textThreadStart;
        private System.Windows.Forms.TextBox textThreadUid;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ToolStripMenuItem addDataBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggregateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseConfigurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseDataBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createConfigurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingotToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem labelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem millToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollgangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsConfigurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signalToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ToolStripMenuItem stopperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techUnitToolStripMenuItem;
        private System.Windows.Forms.ComboBox threadsList;
        private System.Windows.Forms.ToolStripMenuItem threadToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

       #endregion
    }
}