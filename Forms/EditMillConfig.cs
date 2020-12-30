using System;
using System.Windows.Forms;
using ConfigParser.ConfigurationUnits;

namespace ConfigGenerator.Forms
{
    public partial class EditMillConfig : Form
    {
        public DialogResult Result = DialogResult.None;
        public MillConfigUnit MillConfig;
        
        public EditMillConfig()
        {
            InitializeComponent();
            MillConfig = new MillConfigUnit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MillConfig.Name = textName.Text ?? "";
            MillConfig.Comment = textComment.Text ?? "";
            MillConfig.PeriodAccumulation = int.Parse(textPeriodAccumulation.Text ?? "0");
            MillConfig.PeriodRecording = int.Parse(textPeriodWriting.Text ?? "0");
            MillConfig.BufferSize = long.Parse(textFileSize.Text ?? "0");
            MillConfig.MaxFileSize = long.Parse(textBufferSize.Text ?? "0");
            MillConfig.VisualHost = textIPVisual.Text ?? "";
            MillConfig.VisualPort = int.Parse(textPortVisual.Text ?? "0");
            MillConfig.ArchiveFile = textArchiveFilePath.Text ?? "";
            MillConfig.ArchiveHost = textServerArchive.Text ?? "";
            MillConfig.ArchivePort = int.Parse(textPortArchive.Text ?? "0");
            MillConfig.MaxObjectSpeed = double.Parse(textMaxSpeed.Text.Replace(".", ",") ?? "0");
            MillConfig.ObjectAcceleration = double.Parse(textMaxAcceleration.Text.Replace(".", ",") ?? "0");
            MillConfig.CageNeighborhood = double.Parse(textAfterCage.Text.Replace(".", ",") ?? "0");
            MillConfig.HeadNeighborhood = double.Parse(textSensorHead.Text.Replace(".", ",") ?? "0");
            MillConfig.TailNeighborhood = double.Parse(textSensorTail.Text.Replace(".", ",") ?? "0");
            MillConfig.MaxUnitsCount = int.Parse(textMaxUnitsCount.Text.Replace(".", ",") ?? "0");
            Result = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MillConfig = null;
            Result = DialogResult.Cancel;
        }

        private void buttonSearchArchiveFile_Click(object sender, EventArgs e)
        {
            // Выбор файла архива
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "tag";
            openFileDialog.Filter = "Файл тегов архива (*.tag)|*.tag";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textArchiveFilePath.Text = openFileDialog.FileName;
            }
        }

        public void EditConfig()
        {
            if (MillConfig != null)
            {
                textName.Text = MillConfig.Name;
                textComment.Text = MillConfig.Comment;
                textPeriodAccumulation.Text = MillConfig.PeriodAccumulation.ToString();
                textPeriodWriting.Text = MillConfig.PeriodRecording.ToString();
                textFileSize.Text = MillConfig.BufferSize.ToString();
                textBufferSize.Text = MillConfig.MaxFileSize.ToString();
                textIPVisual.Text = MillConfig.VisualHost;
                textPortVisual.Text = MillConfig.VisualPort.ToString();
                textArchiveFilePath.Text = MillConfig.ArchiveFile;
                textServerArchive.Text = MillConfig.ArchiveHost;
                textPortArchive.Text = MillConfig.ArchivePort.ToString();
                textMaxSpeed.Text = MillConfig.MaxObjectSpeed.ToString("F2");
                textMaxAcceleration.Text = MillConfig.ObjectAcceleration.ToString("F2");
                textAfterCage.Text = MillConfig.CageNeighborhood.ToString("F2");
                textSensorHead.Text = MillConfig.HeadNeighborhood.ToString("F2");
                textSensorTail.Text = MillConfig.TailNeighborhood.ToString("F2");
                textMaxUnitsCount.Text = MillConfig.MaxUnitsCount.ToString();
            }
            ShowDialog();
        }
    }
}