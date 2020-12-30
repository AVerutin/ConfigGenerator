using System.Windows.Forms;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigGenerator.Data;
using ConfigGenerator.Forms;
using ConfigParser;
using ConfigParser.ConfigurationUnits;
using ConfigParser.Data;
using ConfigParser.Types;
using NLog;

namespace ConfigGenerator
{
       
    public partial class Form1 : Form
    {
        private bool _modified;
        private string _cfgFileName;
        private Logger _logger;
        private string _statusBarMessage = "Готово.";

        private Parser _configuration;
        // private IConfigurationRoot _config;

        public Form1()
        {
            InitializeComponent();
            _logger = LogManager.GetCurrentClassLogger();
            statusBar1.Text = _statusBarMessage;
            _logger.Info("Запуск программы");
            _configuration = new Parser();
            ResetForm();

            // _config = new ConfigurationBuilder()
            //     .AddJsonFile("appsettings.json")
            //     .Build();
            //
            // string db_host = _config.GetSection("PGSQL:DBHost").Value;

        }

        /// <summary>
        /// Сбросить все элементы формы до значений по-умолчанию
        /// </summary>
        private void ResetForm()
        {
            UpdateThreadsList();
            UpdateDataBlockList();
            UpdateMillConfigView();
            UpdateSubscriptions();
            UpdateSignalsList();
        }

        /// <summary>
        /// Обновить список сигналов
        /// </summary>
        private void UpdateSignalsList()
        {
            List<SignalView> dataSource = new List<SignalView>();
            List<SignalUnit> signals = _configuration.ListSignalUnits.GetItems();
            foreach (SignalUnit signal in signals)
            {
                SignalView view = new SignalView();
                view.Uid = signal.Uid.ToString();
                view.Name = signal.Name;
                view.Type = signal.Type.ToString();
                DataBlockUnit dataBlock = _configuration.FindDataBlock(signal.DataBlockUid);
                string dbName = "";
                if (dataBlock != null)
                {
                    dbName = dataBlock.Name;
                }
                view.DataBlockName = dbName;
                view.Byte = signal.Byte.ToString();
                
                dataSource.Add(view);
            }

            dataThreadSignals.DataSource = dataSource;
            dataThreadSignals.Columns[0].HeaderText = "UID";
            dataThreadSignals.Columns[0].Width = 50;
            dataThreadSignals.Columns[1].HeaderText = "Наименование";
            dataThreadSignals.Columns[1].Width = 200;
            dataThreadSignals.Columns[2].HeaderText = "Тип";
            dataThreadSignals.Columns[2].Width = 50;
            dataThreadSignals.Columns[3].HeaderText = "Блок данных";
            dataThreadSignals.Columns[3].Width = 150;
            dataThreadSignals.Columns[4].HeaderText = "Байт";
            dataThreadSignals.Columns[4].Width = 50;
        }

        /// <summary>
        /// Обновить список линий производства
        /// </summary>
        private void UpdateThreadsList()
        {
            threadsList.Items.Clear();
            foreach (ThreadUnit thread in _configuration.ListThreadUnits)
            {
                threadsList.Items.Add(thread.Name);
            }

            if (threadsList.Items.Count > 0)
            {
                threadsList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обновить список подписок
        /// </summary>
        private void UpdateSubscriptions()
        {
            SubscriptionsUnit subs = _configuration.SubscriptionsUnit;
            List<SubscriptionView> rows = new List<SubscriptionView>();
            SubscriptionView row = new SubscriptionView();

            row.ParameterName = "Потоков";
            row.ParameterValue = subs.Threads.ToString();
            rows.Add(row);

            for (int i = 0; i < subs.SubObjects.Count; i++)
            {
                ConfigurationUnit item = subs.SubObjects[i];
                row = new SubscriptionView {ParameterName = "TCP-сервер", ParameterValue = item.Name};
                rows.Add(row);

                foreach (var (key, value) in item.Parameters)
                {
                    row = new SubscriptionView {ParameterName = key, ParameterValue = value};
                    rows.Add(row);
                }

                foreach (var (key, value) in item.SubObjects.SelectMany(subItem => subItem.Parameters))
                {
                    row = new SubscriptionView {ParameterName = key, ParameterValue = value};
                    rows.Add(row);
                }
            }

            dataSubsriptions.DataSource = rows;
            dataSubsriptions.Columns[0].HeaderText = "Параметр";
            dataSubsriptions.Columns[0].Width = 150;
            dataSubsriptions.Columns[1].HeaderText = "Значение";
            dataSubsriptions.Columns[1].Width = 150;
        }

        private void UpdateMillConfigView()
        {
            List<DataViews> dataViews = new List<DataViews>();
            MillConfigUnit item = _configuration.MillConfigUnit;

            DataViews dataView = new DataViews();
            dataView.ParameterName = "Наименование";
            dataView.ParameterValue = item.Name;
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Комментарий";
            dataView.ParameterValue = item.Comment;
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Файл архивов";
            dataView.ParameterValue = item.ArchiveFile;
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Адрес сервера архивов";
            dataView.ParameterValue = item.ArchiveHost;
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Порт сервера архивов";
            dataView.ParameterValue = item.ArchivePort.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Адрес севрера визуализации";
            dataView.ParameterValue = item.VisualHost;
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Порт сервера визуализации";
            dataView.ParameterValue = item.VisualPort.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Размер буффера";
            dataView.ParameterValue = item.BufferSize.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Максимальный размер файла";
            dataView.ParameterValue = item.MaxFileSize.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Окрестность за клетью";
            dataView.ParameterValue = item.CageNeighborhood.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Окресность датчика голова";
            dataView.ParameterValue = item.HeadNeighborhood.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Окрестность датчика хвост";
            dataView.ParameterValue = item.TailNeighborhood.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Максимальное количество единиц";
            dataView.ParameterValue = item.MaxUnitsCount.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Ускорение объекта";
            dataView.ParameterValue = item.ObjectAcceleration.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Максимальная скорость объекта";
            dataView.ParameterValue = item.MaxObjectSpeed.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Период накопления данных";
            dataView.ParameterValue = item.PeriodAccumulation.ToString();
            dataViews.Add(dataView);
            dataView = new DataViews();
            dataView.ParameterName = "Период записи данных";
            dataView.ParameterValue = item.PeriodRecording.ToString();
            dataViews.Add(dataView);

            dataMillConfig.DataSource = dataViews;
            dataMillConfig.Columns[0].HeaderText = "Параметр";
            dataMillConfig.Columns[0].Width = 150;
            dataMillConfig.Columns[1].HeaderText = "Значение";
            dataMillConfig.Columns[1].Width = 200;
        }

        private void UpdateDataBlockList()
        {
            dataBlocks.DataSource = null;
            List<DataBlockView> dataView = new List<DataBlockView>();
            foreach (DataBlockUnit item in _configuration.ListDataBlockUnits.GetItems())
            {
                DataBlockView dbv = new DataBlockView();
                dbv.Name = item.Name;
                dbv.Uid = item.Uid.ToString();
                dbv.Type = item.Type.ToString();
                dataView.Add(dbv);
            }

            dataBlocks.DataSource = dataView;
            dataBlocks.Columns[0].HeaderText = "UID";
            dataBlocks.Columns[0].Width = 50;
            dataBlocks.Columns[1].HeaderText = "Наименование";
            dataBlocks.Columns[1].Width = 150;
            dataBlocks.Columns[2].HeaderText = "Тип";
            dataBlocks.Columns[2].Width = 100;
        }

        /// <summary>
        /// Завершение работы программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработка события закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_modified)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения внесенных изменений?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _modified = false;
                    _logger.Info("Завершение работы программы");
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Открыть существующую конфигурацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openConfigurationMenuItem_Click(object sender, EventArgs e)
        {
            if (_modified)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения внесенных изменений?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _modified = false;
                    _logger.Info("Открытие конфигурации без сохранения изменений в текущей");
                }
            }

            if (!_modified)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы конфигурации (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _cfgFileName = openFileDialog.FileName;
                    _configuration = new Parser(_cfgFileName);
                    _configuration.Parse();
                    // Получение списка нитей
                    ResetForm();

                    int cnt = _configuration.GetElementsCount();
                    _statusBarMessage = String.Format("Открыта конфигурация из файла [{0}]. Найдено объектов: {1}",
                        _cfgFileName, cnt);
                    statusBar1.Text = _statusBarMessage;
                    _modified = false;
                    _logger.Info(_statusBarMessage);
                }
            }
        }

        /// <summary>
        /// Сохранить изменения в текущей конфигурации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void saveConfigurationMenuItem_Click(object sender, EventArgs e)
        {
            bool canSave = false;
            if (String.IsNullOrEmpty(_cfgFileName))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Файлы конфигурации (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.OverwritePrompt = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _cfgFileName = saveFileDialog.FileName;
                    canSave = true;
                }
            }
            else
            {
                canSave = true;
            }

            if (canSave)
            {
                _statusBarMessage = $"Текущая конфигурация сохранена в файле [{_cfgFileName}]";
                statusBar1.Text = _statusBarMessage;

                // Сохраняем конфигурацию в файл
                await SaveToFile();
                _modified = false;
                _logger.Info(_statusBarMessage);
            }
        }

        /// <summary>
        /// Сохранить текущую конфигурацию в другой файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void saveAsConfigurationMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы конфигурации (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _cfgFileName = saveFileDialog.FileName;
                _statusBarMessage = $"Текущая конфигурация сохранена в файле [{_cfgFileName}]";
                statusBar1.Text = _statusBarMessage;

                // Сохраняем конфигурацию в файл
                await SaveToFile();
                _modified = false;
                _logger.Info(_statusBarMessage);
            }
        }

        /// <summary>
        /// Сохранение объектов конфигурации в файл
        /// </summary>
        /// <returns></returns>
        private async Task SaveToFile()
        {
            if (!string.IsNullOrEmpty(_cfgFileName))
            {
                await using StreamWriter wr = File.CreateText(_cfgFileName);
                string mill = _configuration.MillConfigUnit.ToString();
                await wr.WriteLineAsync(mill);

                var subs = _configuration.SubscriptionsUnit.ToString();
                await wr.WriteLineAsync(subs);
                
                var agr = _configuration.ListAggregateUnits[0].ToString();
                await wr.WriteLineAsync(agr);

                var cage = _configuration.ListCagesUnits[0].ToString();
                await wr.WriteLineAsync(cage);

                var dbs = _configuration.ListDataBlockUnits[0].ToString();
                await wr.WriteLineAsync(dbs);

                var conn = _configuration.ListConnectionStringUnits[0].ToString();
                await wr.WriteLineAsync(conn);

                var deleter = _configuration.ListDeleterUnits[0].ToString();
                await wr.WriteLineAsync(deleter);

                var label = _configuration.ListLabelUnits[0].ToString();
                await wr.WriteLineAsync(label);

                var linear = _configuration.ListLinearDisplacementUnits[0].ToString();
                await wr.WriteLineAsync(linear);

                var rollgang = _configuration.ListRollgangUnits[0].ToString();
                await wr.WriteLineAsync(rollgang);

                var sensor = _configuration.ListSensorUnits[0].ToString();
                await wr.WriteLineAsync(sensor);

                var signal = _configuration.ListSignalUnits[0].ToString();
                await wr.WriteLineAsync(signal);

                var stopper = _configuration.ListStopperUnits[0].ToString();
                await wr.WriteLineAsync(stopper);

                var techUnit = _configuration.ListTechnicalUnits[0].ToString();
                await wr.WriteLineAsync(techUnit);

                var thread = _configuration.ListThreadUnits[0].ToString();
                await wr.WriteLineAsync(thread);

                _configuration.FillProductionThreads();
                var prodThreads = _configuration.GetProductionThreads();
                var prodThread = "// Линия производства\n" + prodThreads[2].ToString();
                await wr.WriteLineAsync(prodThread);
                
                wr.Close();
            }
        }

        /// <summary>
        /// Создать новую конфигурацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createConfigurationMenuItem_Click(object sender, EventArgs e)
        {
            bool canCreate = false;
            // Создание нового экземпляра конфигурации
            if (!_modified)
            {
                canCreate = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("Отменить все внесенные изменения в текущую конфигурацию?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    canCreate = true;
                }
            }

            if (canCreate)
            {
                _cfgFileName = "";
                _modified = false;
                _configuration = new Parser();
                ConfigurationUnit tcpServer = new ConfigurationUnit();
                tcpServer.Parameters.Add("Port", "0");
                tcpServer.Name = "TcpServer";
                _configuration.SubscriptionsUnit.SubObjects.Add(tcpServer);

                ResetForm(); // Устанавливаем все элементы формы в начальное состояние

                _statusBarMessage = "Создана новая конфигурация";
                statusBar1.Text = _statusBarMessage;
                _logger.Info(_statusBarMessage);
            }
        }

        /// <summary>
        /// Открыть форму для обзора конфигурации производства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseConfigurationMenuItem_Click(object sender, EventArgs e)
        {
            ConfigPreview configPreview = new ConfigPreview();
            configPreview.ViewConfig(_configuration);
            configPreview.ShowDialog();
            configPreview.Dispose();
        }

        /// <summary>
        /// Добавить новую нить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddThread addThread = new AddThread();
            addThread.Mode = FormMode.Add;
            addThread.ShowDialog();
            if (addThread.Result == DialogResult.OK)
            {
                ThreadUnit thread = addThread.Thread;
                _configuration.ListThreadUnits.Add(thread);

                UpdateThreadsList();
                _statusBarMessage = $"Добавлена новая нить [{thread.Name}]";
                statusBar1.Text = _statusBarMessage;
                _modified = true;
            }

            addThread.Dispose();
        }

        /// <summary>
        /// Обзор списка имеющихся производственных линий 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseThreads browseThreads = new BrowseThreads();
            browseThreads.ThreadsList = _configuration.ListThreadUnits.GetItems();
            browseThreads.Browse();
            browseThreads.Dispose();
        }

        /// <summary>
        /// Обработка события изменения индекса выбранной линии производства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void threadsList_SelectedValueChanged(object sender, EventArgs e)
        {
            ThreadUnit thread = _configuration.FindThreadByName(threadsList.Text);
            textThreadUid.Text = thread.Uid.ToString();
            textThreadNumber.Text = thread.ThreadNumber.ToString();
            textThreadName.Text = thread.Name;
            textThreadStart.Text = "[" + thread.StartPos.PosX + ":" + thread.StartPos.PosY + "]";
            textThreadFinish.Text = "[" + thread.FinishPos.PosX + ":" + thread.FinishPos.PosY + "]";
            textThreadDirection.Text = thread.Direction == ThreadDirection.Horizontal ? "Горизонтально" : "Вертикально";
            checkThreadStopAtEnds.Checked = thread.StopOnEnds;

            _statusBarMessage = $"Выбрана линия производства: [{thread.Uid}] {thread.Name}";
            statusBar1.Text = _statusBarMessage;
            
            // UpdateSignalsList(thread.ThreadNumber);
        }

        /// <summary>
        /// Изменить параметры линии производства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddThread addThread = new AddThread();
            ThreadUnit unit = _configuration.FindThreadByName(threadsList.Text);

            addThread.Mode = FormMode.Edit;
            addThread.Thread = unit;
            addThread.EditThread();
            if (addThread.Result == DialogResult.OK)
            {
                ThreadUnit thread = addThread.Thread;
                _configuration.ReplaceThreadUnit(thread);

                UpdateThreadsList();
                _statusBarMessage = $"Изменены параметры нити [{thread.Name}]";
                statusBar1.Text = _statusBarMessage;
                _modified = true;
            }

            addThread.Dispose();
        }

        /// <summary>
        /// Добавить новый блок данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDataBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataBlock addDataBlock = new AddDataBlock();

            addDataBlock.Mode = FormMode.Add;
            addDataBlock.ShowDialog();
            if (addDataBlock.Result == DialogResult.OK)
            {
                DataBlockUnit dataBlock = addDataBlock.DataBlock;
                _configuration.ListDataBlockUnits.Add(dataBlock);

                UpdateThreadsList();
                _statusBarMessage = $"Добавлен новый блок данных [{dataBlock.Name}]";
                statusBar1.Text = _statusBarMessage;
                _modified = true;
            }

            UpdateDataBlockList();
            addDataBlock.Dispose();
        }

        /// <summary>
        /// Редактировать выбранный блок данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editDataBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDataBlock addDataBlock = new AddDataBlock();
            int uid = 0;
            if (dataBlocks.CurrentRow != null)
            {
                uid = int.Parse(dataBlocks.CurrentRow.Cells[0].Value.ToString() ?? "0");
            }

            DataBlockUnit dataBlock = _configuration.FindDataBlock(uid);
            addDataBlock.Mode = FormMode.Edit;
            addDataBlock.DataBlock = dataBlock;
            

            addDataBlock.EditDataBlock();
            if (addDataBlock.Result == DialogResult.OK)
            {
                DataBlockUnit unit = addDataBlock.DataBlock;
                _configuration.ReplaceDataBlockUnit(unit);

                UpdateThreadsList();
                _statusBarMessage = $"Добавлена новая нить [{unit.Name}]";
                statusBar1.Text = _statusBarMessage;
                _modified = true;
            }
            
            UpdateDataBlockList();
            addDataBlock.Dispose();
        }

        /// <summary>
        /// Обзор списка блоков данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseDataBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseDataBlocks browseDataBlocks = new BrowseDataBlocks();
            browseDataBlocks.DataBlocksList = _configuration.ListDataBlockUnits.GetItems();
            browseDataBlocks.Browse();
            browseDataBlocks.Dispose();
        }

        private void millToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMillConfig millConfig = new EditMillConfig();
            millConfig.MillConfig = _configuration.MillConfigUnit;
            millConfig.EditConfig();
            if (millConfig.Result == DialogResult.OK)
            {
                _configuration.MillConfigUnit = millConfig.MillConfig;
                _modified = true;
            }

            UpdateMillConfigView();
            millConfig.Dispose();
        }

        private void subscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubscriptions addSubscriptions = new AddSubscriptions();
            addSubscriptions.Subscription = _configuration.SubscriptionsUnit;
            addSubscriptions.EditSubscription();
            if(addSubscriptions.Result==DialogResult.OK)
            {
                _configuration.SubscriptionsUnit = addSubscriptions.Subscription;
                _modified = true;
            }
            UpdateSubscriptions();
            addSubscriptions.Dispose();
        }
    }
}