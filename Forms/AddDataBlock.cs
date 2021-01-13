using System;
using System.Windows.Forms;
using ConfigGenerator.Data;
using ConfigParser.ConfigurationUnits;
using ConfigParser.Types;

namespace ConfigGenerator.Forms
{
    public partial class AddDataBlock : Form
    {
        public DataBlockUnit DataBlock { get; set; }
        public DialogResult Result { get; private set; }
        
        public AddDataBlock()
        {
            InitializeComponent();
            DataBlock = null;
            Result = DialogResult.None;
            comboType.SelectedIndex = 0;
        }

        /// <summary>
        /// Нажата кнопка OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DataBlock = new DataBlockUnit();
            DataBlock.Uid = string.IsNullOrEmpty(textUid.Text) ? 0 : int.Parse(textUid.Text);
            DataBlock.Name = textName.Text;
            DataBlock.Port = string.IsNullOrEmpty(textPort.Text) ? 0 : int.Parse(textPort.Text);
            DataBlock.DataBlockSize = string.IsNullOrEmpty(textBlockSize.Text) ? 0 : int.Parse(textBlockSize.Text);
            DataBlock.SenderHost = textSenderIp.Text;
            DataBlock.SenderPort = string.IsNullOrEmpty(textSenderPort.Text) ? 0 : int.Parse(textSenderPort.Text);
            DataBlock.Reversal = checkReversal.Checked;
            DataBlock.HasHead = checkHeader.Checked;
            DataBlock.ServerName = textServer.Text;
            DataBlock.ServerPath = textPath.Text;

            switch (comboType.Text)
            {
                case "TIMESET":
                    DataBlock.Type = DataBlockType.TIMESET;
                    break;
                case "TCP_CLIENT":
                    DataBlock.Type = DataBlockType.TCP_CLIENT;
                    break;
                case "TCP_SERVER":
                    DataBlock.Type = DataBlockType.TCP_SERVER;
                    break;
                case "OPC":
                    DataBlock.Type = DataBlockType.OPC;
                    break;
                case "UDP":
                    DataBlock.Type = DataBlockType.UDP;
                    break;
            }
            Result = DialogResult.OK;
        }

        /// <summary>
        /// Нажата кнопка Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataBlock = null;
            Result = DialogResult.Cancel;
        }

        public void EditDataBlock()
        {
            if (DataBlock != null)
            {
                textUid.Text = DataBlock.Uid.ToString();
                textName.Text = DataBlock.Name;
                textPort.Text = DataBlock.Port.ToString();
                textServer.Text = DataBlock.ServerName;
                textPath.Text = DataBlock.ServerPath;
                textBlockSize.Text = DataBlock.DataBlockSize.ToString();
                textSenderIp.Text = DataBlock.SenderHost;
                textSenderPort.Text = DataBlock.SenderPort.ToString();
                checkReversal.Checked = DataBlock.Reversal;
                checkHeader.Checked = DataBlock.HasHead;

                switch (DataBlock.Type)
                {
                    case DataBlockType.TIMESET: comboType.SelectedIndex = 0; break;
                    case DataBlockType.TCP_CLIENT: comboType.SelectedIndex = 1; break;
                    case DataBlockType.TCP_SERVER: comboType.SelectedIndex = 2; break;
                    case DataBlockType.OPC: comboType.SelectedIndex = 3; break;
                    case DataBlockType.UDP: comboType.SelectedIndex = 4; break;
                }

                textUid.Enabled = false;
                textName.Focus();
                ShowDialog();
            }
        }
    }
}