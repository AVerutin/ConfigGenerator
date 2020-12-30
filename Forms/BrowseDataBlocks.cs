using System.Collections.Generic;
using System.Windows.Forms;
using ConfigParser.ConfigurationUnits;
using ConfigParser.Types;

namespace ConfigGenerator.Forms
{
    public class BrowseDataBlockSource
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Sender { get; set; }
    }
    
    public partial class BrowseDataBlocks : Form
    {
        public List<DataBlockUnit> DataBlocksList { get; set; }
        
        public BrowseDataBlocks()
        {
            InitializeComponent();
        }

        public void Browse()
        {
            if (DataBlocksList != null)
            {
                List<BrowseDataBlockSource> dbSources = new List<BrowseDataBlockSource>();
                foreach (DataBlockUnit item in DataBlocksList)
                {
                    BrowseDataBlockSource bs = new BrowseDataBlockSource();
                    bs.Name = item.Name;
                    bs.Uid = item.Uid.ToString();
                    bs.Sender = item.SenderHost + ":" + item.SenderPort;

                    switch (item.Type)
                    {
                        case DataBlockType.OPC: bs.Type = "OPC"; break;
                        case DataBlockType.UDP: bs.Type = "UDP"; break;
                        case DataBlockType.TIMESET: bs.Type = "Timeset"; break;
                        case DataBlockType.TCP_CLIENT: bs.Type = "TCP-клиент"; break;
                        case DataBlockType.TCP_SERVER: bs.Type = "TCP-сервер"; break;
                    }
                    
                    dbSources.Add(bs);
                }

                dataGridView1.DataSource = dbSources;
                dataGridView1.Columns[0].HeaderText = "UID";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "Наименование";
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].HeaderText = "Тип связи";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Отправитель";
                dataGridView1.Columns[3].Width = 200;
                
                ShowDialog();
            }
        }
    }
}