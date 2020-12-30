using System.Windows.Forms;
using ConfigParser.ConfigurationUnits;


namespace ConfigGenerator.Forms
{
    public partial class EditAggregate : Form
    {
        public AggregateUnit Aggregate { get; set; }
        public DialogResult Result { get; private set; }

        public EditAggregate()
        {
            InitializeComponent();
            Aggregate = new AggregateUnit();
            Result = DialogResult.None;
        }

        public void EditAggregateUnit()
        {
            if(Aggregate != null)
            {
                aggId.Text = Aggregate.Uid.ToString();
                aggName.Text = Aggregate.Name;
                aggPeriod.Text = Aggregate.WriteSignalsPeriod.ToString();
                aggPrefix.Text = Aggregate.Prefix;
            }

            ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Aggregate.Name = aggName.Text;
            Aggregate.Prefix = aggPrefix.Text;
            Aggregate.Uid = int.Parse(aggId.Text);
            Aggregate.WriteSignalsPeriod = int.Parse(aggPeriod.Text);

            Result = DialogResult.OK;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Aggregate = new AggregateUnit();
            Result = DialogResult.Cancel;
        }
    }
}
