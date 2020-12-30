using System.ComponentModel;

namespace ConfigGenerator.Forms
{
    partial class AddThread
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddThread));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNext = new System.Windows.Forms.TextBox();
            this.textPrev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textUid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDirection = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textFinishY = new System.Windows.Forms.TextBox();
            this.textFinishX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textStartY = new System.Windows.Forms.TextBox();
            this.textStartX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkStopAtEnds = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(210, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(321, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNext);
            this.groupBox1.Controls.Add(this.textPrev);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textUid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие параметры";
            // 
            // textNext
            // 
            this.textNext.Location = new System.Drawing.Point(281, 81);
            this.textNext.Name = "textNext";
            this.textNext.Size = new System.Drawing.Size(74, 20);
            this.textNext.TabIndex = 5;
            // 
            // textPrev
            // 
            this.textPrev.Location = new System.Drawing.Point(112, 81);
            this.textPrev.Name = "textPrev";
            this.textPrev.Size = new System.Drawing.Size(64, 20);
            this.textPrev.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(200, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Следующая:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Предыдущая:";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(294, 28);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(61, 20);
            this.textNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(216, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер нити:";
            // 
            // textUid
            // 
            this.textUid.Location = new System.Drawing.Point(112, 29);
            this.textUid.Name = "textUid";
            this.textUid.Size = new System.Drawing.Size(87, 20);
            this.textUid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Идентификатор:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(112, 55);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(243, 20);
            this.textName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наименование:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboDirection);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Позиция";
            // 
            // comboDirection
            // 
            this.comboDirection.DisplayMember = "0";
            this.comboDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDirection.FormattingEnabled = true;
            this.comboDirection.Items.AddRange(new object[] {"Горизонтально", "Вертикально"});
            this.comboDirection.Location = new System.Drawing.Point(92, 108);
            this.comboDirection.Name = "comboDirection";
            this.comboDirection.Size = new System.Drawing.Size(132, 21);
            this.comboDirection.TabIndex = 11;
            this.comboDirection.Tag = "0";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Направление:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textFinishY);
            this.groupBox4.Controls.Add(this.textFinishX);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(120, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 78);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Завершение";
            // 
            // textFinishY
            // 
            this.textFinishY.Location = new System.Drawing.Point(34, 45);
            this.textFinishY.Name = "textFinishY";
            this.textFinishY.Size = new System.Drawing.Size(58, 20);
            this.textFinishY.TabIndex = 10;
            // 
            // textFinishX
            // 
            this.textFinishX.Location = new System.Drawing.Point(34, 19);
            this.textFinishX.Name = "textFinishX";
            this.textFinishX.Size = new System.Drawing.Size(58, 20);
            this.textFinishX.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textStartY);
            this.groupBox3.Controls.Add(this.textStartX);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(108, 78);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Начало";
            // 
            // textStartY
            // 
            this.textStartY.Location = new System.Drawing.Point(34, 48);
            this.textStartY.Name = "textStartY";
            this.textStartY.Size = new System.Drawing.Size(58, 20);
            this.textStartY.TabIndex = 8;
            // 
            // textStartX
            // 
            this.textStartX.Location = new System.Drawing.Point(34, 22);
            this.textStartX.Name = "textStartX";
            this.textStartX.Size = new System.Drawing.Size(58, 20);
            this.textStartX.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "X:";
            // 
            // checkStopAtEnds
            // 
            this.checkStopAtEnds.Location = new System.Drawing.Point(26, 132);
            this.checkStopAtEnds.Name = "checkStopAtEnds";
            this.checkStopAtEnds.Size = new System.Drawing.Size(166, 22);
            this.checkStopAtEnds.TabIndex = 6;
            this.checkStopAtEnds.Text = "Останавливать на концах";
            this.checkStopAtEnds.UseVisualStyleBackColor = true;
            // 
            // AddThread
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(639, 217);
            this.Controls.Add(this.checkStopAtEnds);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddThread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить линию производства";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkStopAtEnds;
        private System.Windows.Forms.ComboBox comboDirection;
        private System.Windows.Forms.TextBox textFinishX;
        private System.Windows.Forms.TextBox textFinishY;
        private System.Windows.Forms.TextBox textStartY;

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textNext;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textPrev;
        private System.Windows.Forms.TextBox textStartX;
        private System.Windows.Forms.TextBox textUid;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}