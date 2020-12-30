using System;
using System.Windows.Forms;
using ConfigGenerator.Data;
using ConfigParser.ConfigurationUnits;
using ConfigParser.Types;

namespace ConfigGenerator.Forms
{
    
    public partial class AddThread : Form
    {
        public ThreadUnit Thread { get; set; }
        public DialogResult Result { get; private set; }
        public FormMode Mode { get; set; }
        
        public AddThread()
        {
            InitializeComponent();
            Result = DialogResult.None;
            comboDirection.SelectedIndex = 0;
            textUid.Focus();
        }

        /// <summary>
        /// Редактировать параметры линии производства
        /// </summary>
        public void EditThread()
        {
            if (Mode == FormMode.Edit && Thread != null)
            {
                textName.Text = Thread.Name;
                textNumber.Text = Thread.ThreadNumber.ToString();
                textUid.Text = Thread.Uid.ToString();
                textPrev.Text = Thread.PrevThread.ToString();
                textNext.Text = Thread.NextThread.ToString();
                textStartX.Text = Thread.StartPos.PosX.ToString("F2");
                textStartY.Text = Thread.StartPos.PosY.ToString("F2");
                textFinishX.Text = Thread.FinishPos.PosX.ToString("F2");
                textFinishY.Text = Thread.FinishPos.PosY.ToString("F2");
                checkStopAtEnds.Checked = Thread.StopOnEnds;
                comboDirection.SelectedIndex = (int)Thread.Direction;

                textUid.Enabled = false;
                textUid.Focus();
                ShowDialog();
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = DialogResult.None;
            
            if (!String.IsNullOrEmpty(textName.Text))
            {
                Result = DialogResult.OK;
                Thread = new ThreadUnit();
                
                // Обработка введенных пользователем значений и заполнение полей объекта
                Thread.Name = textName.Text ?? "";
                Thread.Uid = string.IsNullOrEmpty(textUid.Text) ? 0 : int.Parse(textUid.Text);
                Thread.ThreadNumber = string.IsNullOrEmpty(textNumber.Text) ? 0 : int.Parse(textNumber.Text);
                Thread.PrevThread = string.IsNullOrEmpty(textPrev.Text) ? 0 : int.Parse(textPrev.Text);
                Thread.NextThread = string.IsNullOrEmpty(textNext.Text) ? 0 : int.Parse(textNext.Text);
                Thread.StopOnEnds = checkStopAtEnds.Checked;

                Thread.Direction = comboDirection.SelectedIndex == 0
                    ? ThreadDirection.Horizontal
                    : ThreadDirection.Vertical;

                double startX = string.IsNullOrEmpty(textStartX.Text)
                    ? 0
                    : double.Parse(textStartX.Text.Replace(".", ","));
                double startY = string.IsNullOrEmpty(textStartY.Text)
                    ? 0
                    : double.Parse(textStartY.Text.Replace(".", ","));
                double finishX = string.IsNullOrEmpty(textFinishX.Text)
                    ? 0
                    : double.Parse(textFinishX.Text.Replace(".", ","));
                double finishY = string.IsNullOrEmpty(textFinishY.Text)
                    ? 0
                    : double.Parse(textFinishY.Text.Replace(".", ","));
                Point startPos = new Point(startX, startY);
                Point finishPos = new Point(finishX, finishY);
                Thread.StartPos = startPos;
                Thread.FinishPos = finishPos;
            }
            
            // Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            Thread = null;
            // Close();
        }
    }
}