using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConfigParser.ConfigurationUnits;

namespace ConfigGenerator.Forms
{
    public partial class AddSubscriptions : Form
    {
        public SubscriptionsUnit Subscription { get; set; }
        public DialogResult Result = DialogResult.None;
        
        public AddSubscriptions()
        {
            InitializeComponent();
            Subscription = new SubscriptionsUnit();
            Result = DialogResult.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Кнопка OK
            Subscription.Threads = int.Parse(textThreads.Text ?? "0");
            foreach (ConfigurationUnit confUnit in Subscription.SubObjects)
            {
                if (confUnit.Parameters.ContainsKey("Port"))
                {
                    confUnit.Parameters["Port"] = textPort.Text ?? "0";
                }
                foreach (ConfigurationUnit confSubUnit in confUnit.SubObjects)
                {
                    if (confUnit.Parameters.ContainsKey("Port"))
                    {
                        confUnit.Parameters["Port"] = textPort.Text ?? "0";
                    }
                }
            }

            Result = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Кнопка отмена
            Subscription = null;
            Result = DialogResult.Cancel;
        }

        public void EditSubscription()
        {
            textThreads.Text = Subscription.Threads.ToString();

            if(Subscription.SubObjects.Count == 0)
            {
                ConfigurationUnit item = new ConfigurationUnit();
                item.Parameters.Add("Port", "0");
                Subscription.SubObjects.Add(item);
            }

            foreach (ConfigurationUnit item in Subscription.SubObjects)
            {
                foreach (KeyValuePair<string, string> parameter in item.Parameters)
                {
                    if (parameter.Key == "Port")
                    {
                        textPort.Text = parameter.Value ?? "";
                    }
                }
            }

            ShowDialog();
        }
    }
}