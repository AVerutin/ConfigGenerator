using System.Collections.Generic;
using System.Windows.Forms;
using ConfigParser.ConfigurationUnits;
using ConfigParser.Types;

namespace ConfigGenerator.Forms
{
    public class BrowseThreadSource
    {
        public string Number { get; set; }
        public string Uid { get; set; }
        public string Name { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public string Direction { get; set; }
        public bool StopsAtEnds { get; set; }
        
    }
    
    public partial class BrowseThreads : Form
    {
        public List<ThreadUnit> ThreadsList { get; set; } 
        
        public BrowseThreads()
        {
            InitializeComponent();
            
        }

        public void Browse()
        {
            if (ThreadsList != null)
            {
                
                List<BrowseThreadSource> browseSource = new List<BrowseThreadSource>();
                foreach (ThreadUnit item in ThreadsList)
                {
                    BrowseThreadSource bs = new BrowseThreadSource();
                    bs.Number = item.ThreadNumber.ToString();
                    bs.Uid = item.Uid.ToString();
                    bs.Name = item.Name;
                    bs.Start = "[" + item.StartPos.PosX + ", " + item.StartPos.PosY + "]";
                    bs.Finish = "[" + item.FinishPos.PosX + ", " + item.FinishPos.PosY + "]";
                    bs.Direction = item.Direction == ThreadDirection.Horizontal ? "Горизонтально" : "Вертикально";
                    bs.StopsAtEnds = item.StopOnEnds;
                    browseSource.Add(bs);
                }
                
                dataGridView1.DataSource = browseSource;
                // dataGridView1.DataSource = ThreadsList;
                dataGridView1.Columns[0].HeaderText = "Номер";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "UID";
                dataGridView1.Columns[1].Width = 50;
                dataGridView1.Columns[2].HeaderText = "Наименование";
                dataGridView1.Columns[2].Width = 350;
                dataGridView1.Columns[3].HeaderText = "Начало";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Окончание";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Направление";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[6].HeaderText = "Останавливать";
                dataGridView1.Columns[6].Width = 100;
                ShowDialog();
            } 
        }
    }
}