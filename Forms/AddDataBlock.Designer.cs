using System.ComponentModel;

namespace ConfigGenerator.Forms
{
    partial class AddDataBlock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataBlock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkHeader = new System.Windows.Forms.CheckBox();
            this.checkReversal = new System.Windows.Forms.CheckBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBlockSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSenderPort = new System.Windows.Forms.TextBox();
            this.textSenderIp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPath);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textServer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkHeader);
            this.groupBox1.Controls.Add(this.checkReversal);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBlockSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textUid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие параметры";
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(103, 129);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(117, 20);
            this.textPath.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Путь доступа:";
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(62, 103);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(158, 20);
            this.textServer.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Сервер:";
            // 
            // checkHeader
            // 
            this.checkHeader.Location = new System.Drawing.Point(145, 173);
            this.checkHeader.Name = "checkHeader";
            this.checkHeader.Size = new System.Drawing.Size(80, 20);
            this.checkHeader.TabIndex = 7;
            this.checkHeader.Text = "Заголовок";
            this.checkHeader.UseVisualStyleBackColor = true;
            // 
            // checkReversal
            // 
            this.checkReversal.Location = new System.Drawing.Point(7, 173);
            this.checkReversal.Name = "checkReversal";
            this.checkReversal.Size = new System.Drawing.Size(128, 20);
            this.checkReversal.TabIndex = 6;
            this.checkReversal.Text = "Перестановка байт";
            this.checkReversal.UseVisualStyleBackColor = true;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(276, 103);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(76, 20);
            this.textPort.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(235, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Порт:";
            // 
            // textBlockSize
            // 
            this.textBlockSize.Location = new System.Drawing.Point(103, 77);
            this.textBlockSize.Name = "textBlockSize";
            this.textBlockSize.Size = new System.Drawing.Size(74, 20);
            this.textBlockSize.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Размер блока:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(103, 51);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(249, 20);
            this.textName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование:";
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {"TIMESET", "TCP_CLIENT", "TCP_SERVER", "OPC", "UDP"});
            this.comboType.Location = new System.Drawing.Point(231, 24);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(190, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип:";
            // 
            // textUid
            // 
            this.textUid.Location = new System.Drawing.Point(103, 24);
            this.textUid.Name = "textUid";
            this.textUid.Size = new System.Drawing.Size(74, 20);
            this.textUid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идентификатор:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSenderPort);
            this.groupBox2.Controls.Add(this.textSenderIp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры отправителя";
            // 
            // textSenderPort
            // 
            this.textSenderPort.Location = new System.Drawing.Point(231, 27);
            this.textSenderPort.Name = "textSenderPort";
            this.textSenderPort.Size = new System.Drawing.Size(121, 20);
            this.textSenderPort.TabIndex = 9;
            // 
            // textSenderIp
            // 
            this.textSenderIp.Location = new System.Drawing.Point(56, 27);
            this.textSenderIp.Name = "textSenderIp";
            this.textSenderIp.Size = new System.Drawing.Size(121, 20);
            this.textSenderIp.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(190, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Порт:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Адрес:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(105, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(209, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddDataBlock
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(380, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDataBlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Блок данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPath;

        private System.Windows.Forms.TextBox textServer;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox textSenderIp;
        private System.Windows.Forms.TextBox textSenderPort;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.CheckBox checkHeader;
        private System.Windows.Forms.CheckBox checkReversal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBlockSize;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPort;

        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUid;

        #endregion
    }
}