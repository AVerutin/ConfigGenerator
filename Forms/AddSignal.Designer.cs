using System.ComponentModel;
using System.Windows.Forms;

namespace ConfigGenerator.Forms
{
    partial class AddSignal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSignal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUserWrite = new System.Windows.Forms.CheckBox();
            this.textUid = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textVirtualValue = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboDataBlock = new System.Windows.Forms.ComboBox();
            this.textByte = new System.Windows.Forms.TextBox();
            this.textBit = new System.Windows.Forms.TextBox();
            this.textServerName = new System.Windows.Forms.TextBox();
            this.textAnalogLevel = new System.Windows.Forms.TextBox();
            this.mbOk = new System.Windows.Forms.Button();
            this.mbCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkVirtual = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идентификатор:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(130, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя тега:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Блок данных:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(187, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(225, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Байт:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(225, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Бит:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(130, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Виртуальное значение:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Аналоговый уровень:";
            // 
            // cbUserWrite
            // 
            this.cbUserWrite.Location = new System.Drawing.Point(6, 129);
            this.cbUserWrite.Name = "cbUserWrite";
            this.cbUserWrite.Size = new System.Drawing.Size(118, 24);
            this.cbUserWrite.TabIndex = 10;
            this.cbUserWrite.Text = "Запись значения";
            this.cbUserWrite.UseVisualStyleBackColor = true;
            // 
            // textUid
            // 
            this.textUid.Location = new System.Drawing.Point(103, 26);
            this.textUid.Name = "textUid";
            this.textUid.Size = new System.Drawing.Size(57, 20);
            this.textUid.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(47, 52);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(271, 20);
            this.textName.TabIndex = 2;
            // 
            // textVirtualValue
            // 
            this.textVirtualValue.Location = new System.Drawing.Point(263, 22);
            this.textVirtualValue.Name = "textVirtualValue";
            this.textVirtualValue.Size = new System.Drawing.Size(55, 20);
            this.textVirtualValue.TabIndex = 8;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {"BINARY", "BOOL", "BYTE", "DINT", "DWORD", "DWORDOM", "INT", "REAL", "REALOM", "WORD"});
            this.comboType.Location = new System.Drawing.Point(225, 26);
            this.comboType.MaxDropDownItems = 4;
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(93, 21);
            this.comboType.TabIndex = 3;
            // 
            // comboDataBlock
            // 
            this.comboDataBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDataBlock.DropDownWidth = 200;
            this.comboDataBlock.FormattingEnabled = true;
            this.comboDataBlock.Location = new System.Drawing.Point(88, 78);
            this.comboDataBlock.MaxDropDownItems = 4;
            this.comboDataBlock.Name = "comboDataBlock";
            this.comboDataBlock.Size = new System.Drawing.Size(117, 21);
            this.comboDataBlock.TabIndex = 4;
            // 
            // textByte
            // 
            this.textByte.Location = new System.Drawing.Point(268, 78);
            this.textByte.Name = "textByte";
            this.textByte.Size = new System.Drawing.Size(50, 20);
            this.textByte.TabIndex = 5;
            // 
            // textBit
            // 
            this.textBit.Location = new System.Drawing.Point(268, 104);
            this.textBit.Name = "textBit";
            this.textBit.Size = new System.Drawing.Size(50, 20);
            this.textBit.TabIndex = 6;
            // 
            // textServerName
            // 
            this.textServerName.Location = new System.Drawing.Point(195, 130);
            this.textServerName.Name = "textServerName";
            this.textServerName.Size = new System.Drawing.Size(123, 20);
            this.textServerName.TabIndex = 9;
            // 
            // textAnalogLevel
            // 
            this.textAnalogLevel.Location = new System.Drawing.Point(130, 105);
            this.textAnalogLevel.Name = "textAnalogLevel";
            this.textAnalogLevel.Size = new System.Drawing.Size(75, 20);
            this.textAnalogLevel.TabIndex = 11;
            // 
            // mbOk
            // 
            this.mbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbOk.Location = new System.Drawing.Point(79, 266);
            this.mbOk.Name = "mbOk";
            this.mbOk.Size = new System.Drawing.Size(75, 23);
            this.mbOk.TabIndex = 12;
            this.mbOk.Text = "OK";
            this.mbOk.UseVisualStyleBackColor = true;
            this.mbOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbCancel.Location = new System.Drawing.Point(181, 266);
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Size = new System.Drawing.Size(75, 23);
            this.mbCancel.TabIndex = 13;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseVisualStyleBackColor = true;
            this.mbCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textUid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.textServerName);
            this.groupBox1.Controls.Add(this.textAnalogLevel);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBit);
            this.groupBox1.Controls.Add(this.cbUserWrite);
            this.groupBox1.Controls.Add(this.textByte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboDataBlock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 163);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие параметры";
            // 
            // checkVirtual
            // 
            this.checkVirtual.Location = new System.Drawing.Point(6, 19);
            this.checkVirtual.Name = "checkVirtual";
            this.checkVirtual.Size = new System.Drawing.Size(99, 24);
            this.checkVirtual.TabIndex = 15;
            this.checkVirtual.Text = "Виртуальный";
            this.checkVirtual.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkVirtual);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textVirtualValue);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 51);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры виртуального сигнала";
            // 
            // AddSignal
            // 
            this.AcceptButton = this.mbOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(346, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSignal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сигнал";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkVirtual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Button mbOk;
        private System.Windows.Forms.Button mbCancel;
        private System.Windows.Forms.TextBox textAnalogLevel;
        private System.Windows.Forms.TextBox textBit;
        private System.Windows.Forms.TextBox textByte;
        private System.Windows.Forms.TextBox textServerName;
        private System.Windows.Forms.TextBox textVirtualValue;

        private System.Windows.Forms.ComboBox comboDataBlock;

        private System.Windows.Forms.ComboBox comboType;

        private System.Windows.Forms.CheckBox cbUserWrite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textUid;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}