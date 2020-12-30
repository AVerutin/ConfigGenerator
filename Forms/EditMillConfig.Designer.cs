using System.ComponentModel;

namespace ConfigGenerator.Forms
{
    partial class EditMillConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMillConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.textIPVisual = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPortVisual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPortArchive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textServerArchive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearchArchiveFile = new System.Windows.Forms.Button();
            this.textArchiveFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textPeriodWriting = new System.Windows.Forms.TextBox();
            this.textPeriodAccumulation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBufferSize = new System.Windows.Forms.TextBox();
            this.textFileSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textMaxUnitsCount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textMaxAcceleration = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textMaxSpeed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textSensorTail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textSensorHead = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textAfterCage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP сервера визуализации:";
            // 
            // textIPVisual
            // 
            this.textIPVisual.Location = new System.Drawing.Point(95, 30);
            this.textIPVisual.Name = "textIPVisual";
            this.textIPVisual.Size = new System.Drawing.Size(115, 20);
            this.textIPVisual.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPortVisual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textIPVisual);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сервер визуализации";
            // 
            // textPortVisual
            // 
            this.textPortVisual.Location = new System.Drawing.Point(342, 30);
            this.textPortVisual.Name = "textPortVisual";
            this.textPortVisual.Size = new System.Drawing.Size(82, 20);
            this.textPortVisual.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(250, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Порт сервера визуализации:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPortArchive);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textServerArchive);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonSearchArchiveFile);
            this.groupBox2.Controls.Add(this.textArchiveFilePath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сервер архивирования";
            // 
            // textPortArchive
            // 
            this.textPortArchive.Location = new System.Drawing.Point(359, 48);
            this.textPortArchive.Name = "textPortArchive";
            this.textPortArchive.Size = new System.Drawing.Size(65, 20);
            this.textPortArchive.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(224, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Порт сервера архивов:";
            // 
            // textServerArchive
            // 
            this.textServerArchive.Location = new System.Drawing.Point(125, 48);
            this.textServerArchive.Name = "textServerArchive";
            this.textServerArchive.Size = new System.Drawing.Size(85, 20);
            this.textServerArchive.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP сервера архивов:";
            // 
            // buttonSearchArchiveFile
            // 
            this.buttonSearchArchiveFile.Location = new System.Drawing.Point(398, 22);
            this.buttonSearchArchiveFile.Name = "buttonSearchArchiveFile";
            this.buttonSearchArchiveFile.Size = new System.Drawing.Size(26, 23);
            this.buttonSearchArchiveFile.TabIndex = 9;
            this.buttonSearchArchiveFile.Text = "...";
            this.buttonSearchArchiveFile.UseVisualStyleBackColor = true;
            this.buttonSearchArchiveFile.Click += new System.EventHandler(this.buttonSearchArchiveFile_Click);
            // 
            // textArchiveFilePath
            // 
            this.textArchiveFilePath.Location = new System.Drawing.Point(125, 22);
            this.textArchiveFilePath.Name = "textArchiveFilePath";
            this.textArchiveFilePath.ReadOnly = true;
            this.textArchiveFilePath.Size = new System.Drawing.Size(267, 20);
            this.textArchiveFilePath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Файл тегов архива:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textPeriodWriting);
            this.groupBox3.Controls.Add(this.textPeriodAccumulation);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBufferSize);
            this.groupBox3.Controls.Add(this.textFileSize);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textComment);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общие параметры";
            // 
            // textPeriodWriting
            // 
            this.textPeriodWriting.Location = new System.Drawing.Point(342, 61);
            this.textPeriodWriting.Name = "textPeriodWriting";
            this.textPeriodWriting.Size = new System.Drawing.Size(82, 20);
            this.textPeriodWriting.TabIndex = 4;
            // 
            // textPeriodAccumulation
            // 
            this.textPeriodAccumulation.Location = new System.Drawing.Point(128, 61);
            this.textPeriodAccumulation.Name = "textPeriodAccumulation";
            this.textPeriodAccumulation.Size = new System.Drawing.Size(82, 20);
            this.textPeriodAccumulation.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(247, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Период записи:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Период накопления:";
            // 
            // textBufferSize
            // 
            this.textBufferSize.Location = new System.Drawing.Point(314, 95);
            this.textBufferSize.Name = "textBufferSize";
            this.textBufferSize.Size = new System.Drawing.Size(110, 20);
            this.textBufferSize.TabIndex = 6;
            // 
            // textFileSize
            // 
            this.textFileSize.Location = new System.Drawing.Point(101, 95);
            this.textFileSize.Name = "textFileSize";
            this.textFileSize.Size = new System.Drawing.Size(82, 20);
            this.textFileSize.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(200, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "Суммарный размер файла буфера:";
            // 
            // textComment
            // 
            this.textComment.Location = new System.Drawing.Point(238, 33);
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(186, 20);
            this.textComment.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 33);
            this.label8.TabIndex = 5;
            this.label8.Text = "Размер файла буффера:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(149, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Комментарий:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(43, 33);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(97, 20);
            this.textName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Имя:";
            // 
            // textMaxUnitsCount
            // 
            this.textMaxUnitsCount.Location = new System.Drawing.Point(125, 49);
            this.textMaxUnitsCount.Name = "textMaxUnitsCount";
            this.textMaxUnitsCount.Size = new System.Drawing.Size(107, 20);
            this.textMaxUnitsCount.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Макс. кол-во единиц:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textMaxAcceleration);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textMaxSpeed);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.textMaxUnitsCount);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(12, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 103);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры слежения";
            // 
            // textMaxAcceleration
            // 
            this.textMaxAcceleration.Location = new System.Drawing.Point(125, 75);
            this.textMaxAcceleration.Name = "textMaxAcceleration";
            this.textMaxAcceleration.Size = new System.Drawing.Size(107, 20);
            this.textMaxAcceleration.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(5, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Ускорение объекта:";
            // 
            // textMaxSpeed
            // 
            this.textMaxSpeed.Location = new System.Drawing.Point(149, 23);
            this.textMaxSpeed.Name = "textMaxSpeed";
            this.textMaxSpeed.Size = new System.Drawing.Size(83, 20);
            this.textMaxSpeed.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Макс. скорость объекта:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(145, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(236, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textSensorTail);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textSensorHead);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.textAfterCage);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(262, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 103);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Окрестности положения";
            // 
            // textSensorTail
            // 
            this.textSensorTail.Location = new System.Drawing.Point(76, 75);
            this.textSensorTail.Name = "textSensorTail";
            this.textSensorTail.Size = new System.Drawing.Size(98, 20);
            this.textSensorTail.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(25, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Хвост:";
            // 
            // textSensorHead
            // 
            this.textSensorHead.Location = new System.Drawing.Point(76, 49);
            this.textSensorHead.Name = "textSensorHead";
            this.textSensorHead.Size = new System.Drawing.Size(98, 20);
            this.textSensorHead.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(22, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Голова:";
            // 
            // textAfterCage
            // 
            this.textAfterCage.Location = new System.Drawing.Point(76, 23);
            this.textAfterCage.Name = "textAfterCage";
            this.textAfterCage.Size = new System.Drawing.Size(98, 20);
            this.textAfterCage.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "За клетью:";
            // 
            // EditMillConfig
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(453, 474);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "EditMillConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Общие параметры стана";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textAfterCage;
        private System.Windows.Forms.TextBox textBufferSize;
        private System.Windows.Forms.TextBox textFileSize;
        private System.Windows.Forms.TextBox textMaxAcceleration;
        private System.Windows.Forms.TextBox textMaxSpeed;
        private System.Windows.Forms.TextBox textMaxUnitsCount;
        private System.Windows.Forms.TextBox textPeriodAccumulation;
        private System.Windows.Forms.TextBox textPeriodWriting;
        private System.Windows.Forms.TextBox textSensorHead;
        private System.Windows.Forms.TextBox textSensorTail;

        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPortArchive;
        private System.Windows.Forms.TextBox textServerArchive;

        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Button buttonSearchArchiveFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textArchiveFilePath;
        private System.Windows.Forms.TextBox textIPVisual;
        private System.Windows.Forms.TextBox textPortVisual;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}