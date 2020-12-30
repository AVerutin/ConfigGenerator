using ConfigParser.ConfigurationUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConfigGenerator.Forms
{
    public partial class EditConnection : Form
    {
        public ConnectionStringUnit ConnectionString { get; set; }
        public DialogResult Result { get; private set; }

        public EditConnection()
        {
            InitializeComponent();
            ConnectionString = new ConnectionStringUnit();
            Result = DialogResult.None;
        }

        public void EditConnectionString()
        {
            if(ConnectionString != null)
            {
                ServerName.Text = ConnectionString.Host;
                Port.Text = ConnectionString.Port.ToString();
                DbName.Text = ConnectionString.Database;
                UserName.Text = ConnectionString.UserName;
                UserPassw.Text = ConnectionString.UserPassword;

                useSsl.Checked = ConnectionString.SslMode == "Prefer";
                serverTrust.Checked = ConnectionString.TrustServer;
            }

            ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ConnectionString = new ConnectionStringUnit();
            Result = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ConnectionString.Host = ServerName.Text;
            ConnectionString.Port = int.Parse(Port.Text);
            ConnectionString.Database = DbName.Text;
            ConnectionString.UserName = UserName.Text;
            ConnectionString.UserPassword = UserPassw.Text;

            ConnectionString.SslMode = useSsl.Checked ? "Prefer" : "None";
            ConnectionString.TrustServer = serverTrust.Checked;
            
            Result = DialogResult.OK;
        }
    }
}
