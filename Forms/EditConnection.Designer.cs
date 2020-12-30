
namespace ConfigGenerator.Forms
{
    partial class EditConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConnection));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.useSsl = new System.Windows.Forms.CheckBox();
            this.serverTrust = new System.Windows.Forms.CheckBox();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.DbName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassw = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес сервера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "База данных:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пользователь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль:";
            // 
            // useSsl
            // 
            this.useSsl.AutoSize = true;
            this.useSsl.Location = new System.Drawing.Point(12, 175);
            this.useSsl.Name = "useSsl";
            this.useSsl.Size = new System.Drawing.Size(124, 19);
            this.useSsl.TabIndex = 5;
            this.useSsl.Text = "Использовать SSL";
            this.useSsl.UseVisualStyleBackColor = true;
            // 
            // serverTrust
            // 
            this.serverTrust.AutoSize = true;
            this.serverTrust.Location = new System.Drawing.Point(12, 200);
            this.serverTrust.Name = "serverTrust";
            this.serverTrust.Size = new System.Drawing.Size(197, 19);
            this.serverTrust.TabIndex = 6;
            this.serverTrust.Text = "Доверять сертификату сервера";
            this.serverTrust.UseVisualStyleBackColor = true;
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(108, 15);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(148, 23);
            this.ServerName.TabIndex = 7;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(108, 44);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(148, 23);
            this.Port.TabIndex = 8;
            // 
            // DbName
            // 
            this.DbName.Location = new System.Drawing.Point(108, 73);
            this.DbName.Name = "DbName";
            this.DbName.Size = new System.Drawing.Size(148, 23);
            this.DbName.TabIndex = 9;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(108, 102);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(146, 23);
            this.UserName.TabIndex = 10;
            // 
            // UserPassw
            // 
            this.UserPassw.Location = new System.Drawing.Point(108, 131);
            this.UserPassw.Name = "UserPassw";
            this.UserPassw.Size = new System.Drawing.Size(146, 23);
            this.UserPassw.TabIndex = 11;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(49, 254);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(148, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditConnection
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(268, 300);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.UserPassw);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.DbName);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.serverTrust);
            this.Controls.Add(this.useSsl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditConnection";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Строка подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox useSsl;
        private System.Windows.Forms.CheckBox serverTrust;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox DbName;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassw;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}