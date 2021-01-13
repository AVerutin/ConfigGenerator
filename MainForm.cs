using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using ConfigParser;
using ConfigParser.ConfigurationUnits;
using ConfigParser.Data;
using ConfigGenerator.Forms;
using ConfigGenerator.Data;
using ConfigParser.Types;
using System.Collections.Generic;

namespace ConfigGenerator
{
    public partial class MainForm : Form
    {
        private string _cfgFileName;
        private readonly Logger _logger;
        private bool _modified;
        private Parser _configuration;
        private List<ProductionThread> _productionThreadsList;
        private int _threadNumber;

        public MainForm()
        {
            InitializeComponent();
            _logger = LogManager.GetCurrentClassLogger();
            _logger.Info("Запуск программы");
            
            _configuration = new Parser();            


            // Привязка событий к пунктам главного меню "Конфигурация"
            CreateConfig.Click += CreateConfiguration_Click;
            OpenConfig.Click += OpenConfiguration_Click;
            SaveConfig.Click += SaveConfiguration_Click;
            SaveAsConfig.Click += SaveAsConfiguration_Click;
            ExitConfig.Click += ExitConfig_Click;
            
            // Привязка событий к пунктам главного меню "Параметры"
            SetAggregate.Click += SetAggregate_Click;
            SetCommon.Click += SetCommon_Click;
            SetSubs.Click += SetSubs_Click;
            SetConnection.Click += SetConnection_Click;

            // Привязка событий к пунктам главного меню "Слежение"
            TrackDatablocks.Click += AddDataBlock_Click;
            TrackThread.Click += AddThread_Click;
            TrackSignal.Click += AddSignal_Click;
            TrackIngot.Click += AddIngotParam_Click;
            
            // Привязка обработчиков событий для нажатий на кнопки
            threadAdd.Click += AddThread_Click;
            dbAdd.Click += AddDataBlock_Click;
            dbEdit.Click += EditDataBlock_Click;
            dbDelete.Click += DeleteDataBlock_Click;
            signalAdd.Click += AddSignal_Click;
            signalEdit.Click += EditSignal_Click;
            signalDelete.Click += DeleteSignal_Click;

            // Привязка событий выбора элементов из списка
            threadsList.SelectedValueChanged += ThreadsList_SelectedValueChanged;
            rollgangList.SelectedValueChanged += RollgangList_SelectedValueChanged;
            labelList.SelectedValueChanged += LabelList_SelectedValueChanged;
            signalsList.SelectedValueChanged += SignalName_SelectedValueChanged;
            signalVirtual.CheckedChanged += SignalVirtual_CheckedChanged;
            dbNamesList.SelectedValueChanged += DataBlocksList_SelectedValueChanged;

            // Обновление компонентов на форме
            ResetForm();
            
            ShowStatusText("Готово.");
        }

        public bool Modified
        {
            get => _modified;
            set
            {
                Text = value
                    ? "[*] Конфигуратор системы слежения ООО «АЭМЗ»"
                    : "Конфигуратор системы слежения ООО «АЭМЗ»";

                _modified = value;
            }
        }

        private void ResetForm()
        {
            UpdateCommonParameters();
            UpdateThreadsList();
            UpdateLabelsView();
            UpdateRollgangsView();
            UpdateDataBlocksList();
            UpdateSignalsView();
        }

        /// <summary>
        /// Обновить данные на форме об общих параметрах конфигурации
        /// </summary>
        private void UpdateCommonParameters()
        {
            // Отображение данных об агрегате
            ShowAggregate();

            // Отображение данных о подписках
            ShowSubscription();
            
            // Отображение данных о строке подключения
            ShowConnection();
            
            // Отображение общих параметров стана
            ShowCommon();
        }


        #region Обновление элементов формы

        /// <summary>
        /// Обновление данных на форме об агрегате
        /// </summary>
        private void ShowAggregate()
        {
            if (_configuration.ListAggregateUnits.GetItemsCount() > 0)
            {
                AggregateUnit aggregate = _configuration.ListAggregateUnits[0] ?? new AggregateUnit();
                aggregateName.Text = aggregate.Name;
                aggregateUid.Text = aggregate.Uid.ToString();
                aggregateSignalWritePeriod.Text = aggregate.WriteSignalsPeriod.ToString();
            }
            else
            {
                aggregateName.Text = "";
                aggregateUid.Text = "";
                aggregateSignalWritePeriod.Text = "";
            }
        }

        /// <summary>
        /// Отображение данных о подписках
        /// </summary>
        private void ShowSubscription()
        {
            SubscriptionsUnit subs = _configuration.SubscriptionsUnit ?? new SubscriptionsUnit();
            SubsThreads.Text = subs.Threads.ToString();
            string TcpPort = "";
            foreach (ConfigurationUnit sub in subs.SubObjects)
            {
                foreach (var (key, value) in sub.Parameters)
                {
                    if (key == "Port")
                        TcpPort = value;
                }
                
                foreach (var (key, value) in sub.SubObjects.SelectMany(subItem => subItem.Parameters))
                {
                    if (key == "Port")
                        TcpPort = value;
                }
            }

            SubsTcp.Text = TcpPort;
        }

        /// <summary>
        /// Отображение параметров подключения
        /// </summary>
        private void ShowConnection()
        {
            if (_configuration.ListConnectionStringUnits.GetItemsCount() > 0)
            {
                ConnectionStringUnit conn = _configuration.ListConnectionStringUnits[0] ?? new ConnectionStringUnit();
                ConnHost.Text = conn.Host;
                ConnPort.Text = conn.Port.ToString();
                ConnDb.Text = conn.Database;
                ConnUser.Text = conn.UserName;
                ConnPassword.Text = conn.UserPassword;
                ConnSsl.Checked = conn.SslMode == "Prefer";
                ConnCert.Checked = conn.TrustServer;
            }
            else
            {
                ConnHost.Text = "";
                ConnPort.Text = "";
                ConnDb.Text = "";
                ConnUser.Text = "";
                ConnPassword.Text = "";
                ConnSsl.Checked = false;
                ConnCert.Checked = false;
            }
        }
        
        /// <summary>
        /// Отображение общих параметров стана
        /// </summary>
        private void ShowCommon()
        {
            MillConfigUnit common = _configuration.MillConfigUnit ?? new MillConfigUnit();
            CommonName.Text = common.Name;
            CommonComment.Text = common.Comment;
            
            CommonVisualIp.Text = common.VisualHost;
            CommonVisualPort.Text = common.VisualPort.ToString();
            CommonAccumulation.Text = common.PeriodAccumulation.ToString();
            CommonWrite.Text = common.PeriodRecording.ToString();
            CommonBufSize.Text = common.BufferSize.ToString();
            CommonBuffers.Text = common.MaxFileSize.ToString();

            CommonArchFile.Text = common.ArchiveFile;
            CommonArchIp.Text = common.ArchiveHost;
            CommonArchPort.Text = common.ArchivePort.ToString();

            CommonMaxSpeed.Text = common.MaxObjectSpeed.ToString("F1");
            CommonAccel.Text = common.ObjectAcceleration.ToString("F1");
            CommonCage.Text = common.CageNeighborhood.ToString("F1");
            CommonHead.Text = common.HeadNeighborhood.ToString("F1");
            CommonTail.Text = common.TailNeighborhood.ToString("F1");
            CommonMaxObjects.Text = common.MaxUnitsCount.ToString();
        }

        #endregion

        #region Обработка меню Конфигурация

        /// <summary>
        /// Обработка события закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Modified)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения внесенных изменений?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Modified = false;
                    _logger.Info("Завершение работы программы");
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Завершение работы программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitConfig_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Открыть существующую конфигурацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenConfiguration_Click(object sender, EventArgs e)
        {
            if (Modified)
            {
                DialogResult result = MessageBox.Show("Несохраненные данные будут утеряны!\nОткрыть конфигурацию без сохранения изменений в текущей?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Modified = false;
                    _logger.Info("Открытие конфигурации без сохранения изменений в текущей");
                }
            }

            if (!Modified)
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
                    _configuration.FillProductionThreads();
                    _productionThreadsList = _configuration.GetProductionThreads();

                    ResetForm();

                    int cnt = _configuration.GetElementsCount();
                    string msg = $"Открыта конфигурация из файла [{_cfgFileName}]. Найдено объектов: {cnt}";
                    ShowStatusText(msg);
                    _logger.Info(msg);
                    Modified = false;
                }
            }
        }

        /// <summary>
        /// Сохранить изменения в текущей конфигурации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveConfiguration_Click(object sender, EventArgs e)
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
                // Сохраняем конфигурацию в файл
                await SaveToFile();
                Modified = false;
                string msg = $"Текущая конфигурация сохранена в файле [{_cfgFileName}]";
                _logger.Info(msg);
                ShowStatusText(msg);

            }
        }

        /// <summary>
        /// Сохранить текущую конфигурацию в другой файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveAsConfiguration_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы конфигурации (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем конфигурацию в файл
                await SaveToFile();
                _cfgFileName = saveFileDialog.FileName;
                string msg = $"Текущая конфигурация сохранена в файле [{_cfgFileName}]";
                ShowStatusText(msg);
                Modified = false;
                _logger.Info(msg);
            }
        }

        /// <summary>
        /// Создать новую конфигурацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateConfiguration_Click(object sender, EventArgs e)
        {
            bool canCreate = false;
            // Создание нового экземпляра конфигурации
            if (!Modified)
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
                Modified = false;
                _configuration = new Parser();
                ConfigurationUnit tcpServer = new ConfigurationUnit();
                tcpServer.Parameters.Add("Port", "0");
                tcpServer.Name = "TcpServer";
                _configuration.SubscriptionsUnit.SubObjects.Add(tcpServer);
                _configuration.FillProductionThreads();
                _productionThreadsList = _configuration.GetProductionThreads();

                ResetForm(); // Устанавливаем все элементы формы в начальное состояние

                const string msg = "Создана новая конфигурация";
                ShowStatusText(msg);
                _logger.Info(msg);
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

                // Сохранение списка сигналов в файл
                foreach (SignalUnit signal in _configuration.ListSignalUnits)
                {
                    await wr.WriteLineAsync(signal.ToString());
                }

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

        #endregion

        #region Обработка меню Параметры

        /// <summary>
        /// Установить параметры агрегата
        /// </summary>
        private void SetAggregate_Click(object sender, EventArgs e)
        {
            EditAggregate editAggregate = new EditAggregate();
            AggregateUnit aggregate = new AggregateUnit();

            // Если имеется агрегат в списке, то используем его
            if (_configuration.ListAggregateUnits.GetItemsCount() > 0)
            {
                aggregate = _configuration.ListAggregateUnits[0];
            }

            editAggregate.Aggregate = aggregate;
            editAggregate.EditAggregateUnit();
            if(editAggregate.Result == DialogResult.OK)
            {
                if(_configuration.ListAggregateUnits.GetItemsCount() > 0)
                    _configuration.ListAggregateUnits[0] = editAggregate.Aggregate;
                else
                    _configuration.ListAggregateUnits.Add(editAggregate.Aggregate);

                Modified = true;
            }

            editAggregate.Dispose();
            ShowAggregate();
        }

        /// <summary>
        /// Установить общие параметры стана
        /// </summary>
        private void SetCommon_Click(object sender, EventArgs e)
        {
            EditMillConfig millConfig = new EditMillConfig();
            MillConfigUnit millConfigUnit = _configuration.MillConfigUnit;
            millConfig.MillConfig = millConfigUnit;
            millConfig.EditConfig();
            if (millConfig.Result == DialogResult.OK)
            {
                _configuration.MillConfigUnit = millConfig.MillConfig;
                Modified = true;
            }

            millConfig.Dispose();
            ShowCommon();
        }

        /// <summary>
        /// Установить параметры подписок
        /// </summary>
        private void SetSubs_Click(object sender, EventArgs e)
        {
            AddSubscriptions addSubscriptions = new AddSubscriptions();
            SubscriptionsUnit subsUnit = _configuration.SubscriptionsUnit;
            addSubscriptions.Subscription = subsUnit;
            addSubscriptions.EditSubscription();

            if(addSubscriptions.Result==DialogResult.OK)
            {
                _configuration.SubscriptionsUnit = addSubscriptions.Subscription;
                Modified = true;
            }

            addSubscriptions.Dispose();
            ShowSubscription();            
        }

        /// <summary>
        /// Установить параметры подключения к базе данных
        /// </summary>
        private void SetConnection_Click(object sender, EventArgs e)
        {
            EditConnection editConnection = new EditConnection();
            ConnectionStringUnit connUnit = new ConnectionStringUnit();

            // Если в списке имеется строка подключения, то используем ее
            if (_configuration.ListConnectionStringUnits.GetItemsCount() > 0)
                connUnit = new ConnectionStringUnit(_configuration.ListConnectionStringUnits[0]);

            editConnection.ConnectionString = connUnit;
            editConnection.EditConnectionString();

            if(editConnection.Result == DialogResult.OK)
            {
                if(_configuration.ListConnectionStringUnits.GetItemsCount() > 0)
                    _configuration.ListConnectionStringUnits[0] = editConnection.ConnectionString;
                else
                    _configuration.ListConnectionStringUnits.Add(editConnection.ConnectionString);
                Modified = true;
            }

            editConnection.Dispose();
            ShowConnection();            
        }

        #endregion

        #region Обработка меню Слежение

        /// <summary>
        /// Чтение списка линий производства из конфигурации
        /// </summary>
        private void UpdateThreadsList()
        {
            object selected = threadsList.SelectedItem;
            threadAdd.Enabled = true;

            threadsList.Items.Clear();

            foreach (ThreadUnit thread in _configuration.ListThreadUnits)
            {
                threadsList.Items.Add(thread.Name);
            }

            // В списке имеются нити
            if (threadsList.Items.Count > 0)
            {
                // Если есть сохраненная нить, позиционируемся на нее
                if (selected != null && threadsList.Items.Contains(selected))
                    threadsList.SelectedItem = selected;
                else
                    threadsList.SelectedIndex = 0;

                editSelected.Enabled = true;
                delSelected.Enabled = true;
            }
            else
            {
                // Список нитей пуст, очищаем элементы формы
                textThreadDirection.Text = "";
                textThreadNumber.Text = "";
                textThreadUid.Text = "";
                textThreadStart.Text = "";
                textThreadFinish.Text = "";
                checkThreadStopAtEnds.Checked = false;

                editSelected.Enabled = false;
                delSelected.Enabled = false;
            }
        }

        /// <summary>
        ///  Обновить список блоков данных на форме
        /// </summary>
        private void UpdateDataBlocksList()
        {
            // Сохраняем ранее выделенный объект
            object selected = dbNamesList.SelectedItem;
                
            dbNamesList.Items.Clear();
            foreach (DataBlockUnit dataBlock in _configuration.ListDataBlockUnits)
            {
                dbNamesList.Items.Add(dataBlock.Name);
            }

            dbAdd.Enabled = true;

            if (dbNamesList.Items.Count > 0)
            {
                // Восстанавливаем ранее выделенный объект
                if (selected != null && dbNamesList.Items.Contains(selected))
                    dbNamesList.SelectedItem = selected;
                else
                    dbNamesList.SelectedIndex = 0;
                
                dbEdit.Enabled = true;
                dbDelete.Enabled = true;
            }
            else
            {
                // Очищаем значения полей формы, т.к. список блоков данных пуст
                dbEdit.Enabled = false;
                dbDelete.Enabled = false;
                dbUid.Text = "";
                dbType.Text = "";
                dbSize.Text = "";
                dbReversal.Checked = false;
                dbServerName.Text = "";
                dbPort.Text = "";
                dbSrcName.Text = "";
                dbSrcPort.Text = "";
                dbHasHead.Checked = false;
                dbPath.Text = "";
            }
        }

        /// <summary>
        /// Обновление блока Метки на форме
        /// </summary>
        private void UpdateLabelsView()
        {
            labelList.Items.Clear();
            labelAdd.Enabled = threadsList.Items.Count>0;

            if (_threadNumber > 0)
            {
                // Получим список рольгангов на производственной нити
                foreach(ProductionThread thread in _productionThreadsList)
                {
                    if(thread.ThreadNumber == _threadNumber)
                    {
                        // Нашли выбранную нить. Выбираем рольганги на выбранной нити
                        foreach(LabelUnit label in thread.ListLabelUnits)
                        {
                            labelList.Items.Add(label.Text);
                        }
                        
                    }
                }

                if (labelList.Items.Count > 0)
                {
                    labelList.SelectedIndex = 0;
                    labelEdit.Enabled = true;
                    labelDelete.Enabled = true;
                }
                else
                {
                    labelPos.Text = "[0:0]";
                    labelThread.Text = "0";

                    labelEdit.Enabled = false;
                    labelDelete.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Обновление блока Сигналы на форме
        /// </summary>
        private void UpdateSignalsView()
        {
            // Сохраняем ранее выделенный объект
            object selected = signalsList.SelectedItem;
            
            if(!signalVirtual.Checked)
            {
                signalAdd.Enabled = dbNamesList.Items.Count > 0;
            }
            else
            {
                signalAdd.Enabled = true;
            }

            if(!signalVirtual.Checked)
            {
                // Отображаем реальные сигналы
                int dataBlockUid = 0;
                if (!string.IsNullOrEmpty(dbNamesList.Text))
                {
                    dataBlockUid = _configuration.FindDataBlock(dbNamesList.Text).Uid;
                }

                List<SignalUnit> signals = _configuration.GetSignals(dataBlockUid);
                signalsList.Items.Clear();
                foreach (SignalUnit signal in signals)
                {
                    signalsList.Items.Add(signal.Name);
                }
            }
            else
            {
                // Отображаем виртуальные сигналы
                List<SignalUnit> signals = _configuration.GetVirtualSignals();
                signalsList.Items.Clear();
                foreach (SignalUnit signal in signals)
                {
                    signalsList.Items.Add(signal.Name);
                }

            }
            
            if (signalsList.Items.Count > 0)
            {
                // Восстанавливаем ранее выделенный объект
                if (selected != null && signalsList.Items.Contains(selected))
                    signalsList.SelectedItem = selected;
                else
                    signalsList.SelectedIndex = 0;

                signalEdit.Enabled = true;
                signalDelete.Enabled = true;
            }
            else
            {
                // Очищаем поля на форме, т.к. список сигналов пуст
                signalUid.Text = "";
                signalType.Text = "";
                signalDataBlock.Text = "";
                signalTag.Text = "";
                signalByte.Text = "";
                signalVirtValue.Text = "";
                signalCompound.Text = "";
                signalReadOnly.Checked = false;
                signalEdit.Enabled = false;
                signalDelete.Enabled = false;
            }
        }
        
        /// <summary>
        /// Обновление списка рольгангов на нити
        /// </summary>
        private void UpdateRollgangsView()
        {
            rollgangList.Items.Clear();
            rollgangAdd.Enabled = threadsList.Items.Count>0;
            
            if (_threadNumber > 0)
            {
                // Получим список рольгангов на производственной нити
                foreach(ProductionThread thread in _productionThreadsList)
                {
                    if(thread.ThreadNumber == _threadNumber)
                    {
                        // Нашли выбранную нить. Выбираем рольганги на выбранной нити
                        foreach(RollgangUnit rollgang in thread.ListRollgangUnits)
                        {
                            rollgangList.Items.Add(rollgang.Name);
                        }
                    }
                }

                if (rollgangList.Items.Count > 0)
                {
                    rollgangList.SelectedIndex = 0;
                    rollgangEdit.Enabled = true;
                    rollgangDelete.Enabled = true;
                }
                else
                {
                    rollgangUid.Text = "0";
                    rollgangStart.Text = "[0:0]";
                    rollgangFinish.Text = "[0:0]";
                    rollgangSignalSpeed.Text = "0";
                    rollgangSpeedValue.Text = "0";

                    rollgangEdit.Enabled = false;
                    rollgangDelete.Enabled = false;
                }
            }
        }


        /// <summary>
        /// Редактирование параметров выбранной нити
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editSelected_Click(object sender, EventArgs e)
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
                string msg = $"Изменены параметры нити [{thread.Name}]";
                ShowStatusText(msg);
                _logger.Info(msg);
                Modified = true;
            }

            addThread.Dispose();
        }

        /// <summary>
        /// Удалить выбранную нить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delSelect_Click(object sender, EventArgs e)
        {
            _configuration.DeleteProductionThreadByName(threadsList.Text);
            UpdateThreadsList();
        }


        // /// <summary>
        // /// Обзор списка имеющихся производственных линий 
        // /// </summary>
        // /// <param name="sender"></param>
        // /// <param name="e"></param>
        //private void browseThreadToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    BrowseThreads browseThreads = new BrowseThreads();
        //    browseThreads.ThreadsList = _configuration.ListThreadUnits.GetItems();
        //    browseThreads.Browse();
        //    browseThreads.Dispose();
        //}
        
        /// <summary>
        /// Добавить новую нить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddThread_Click(object sender, EventArgs e)
        {
            AddThread addThread = new AddThread {Mode = FormMode.Add};
            addThread.ShowDialog();
            if (addThread.Result == DialogResult.OK)
            {
                ThreadUnit thread = addThread.Thread;
                _configuration.ListThreadUnits.Add(thread);
                _configuration.FillProductionThreads();
                _productionThreadsList = _configuration.GetProductionThreads();

                UpdateThreadsList();
                string msg = $"Добавлена новая нить [{thread.Name}]";
                ShowStatusText(msg);
                _logger.Info(msg);
                Modified = true;
            }

            addThread.Dispose();
        }
        
        /// <summary>
        /// Обработка события изменения индекса выбранной линии производства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreadsList_SelectedValueChanged(object sender, EventArgs e)
        {
            ThreadUnit thread = _configuration.FindThreadByName(threadsList.Text);
            textThreadUid.Text = thread.Uid.ToString();
            textThreadNumber.Text = thread.ThreadNumber.ToString();
            textThreadStart.Text = $"[{thread.StartPos.PosX}:{thread.StartPos.PosY}]";
            textThreadFinish.Text = $"[{thread.FinishPos.PosX}:{thread.FinishPos.PosY}]";
            textThreadDirection.Text = thread.Direction == ThreadDirection.Horizontal ? "Горизонтально" : "Вертикально";
            checkThreadStopAtEnds.Checked = thread.StopOnEnds;

            // _statusBarMessage = $"Выбрана линия производства: [{thread.Uid}] {thread.Name}";
            // StatusText.Text = _statusBarMessage;

            _threadNumber = thread.ThreadNumber;

            // UpdateSignalsList(thread.ThreadNumber);
            UpdateRollgangsView();
            UpdateLabelsView();
        }

        /// <summary>
        /// Обработка события изменения индекса выбранного рольганга
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollgangList_SelectedValueChanged(object sender, EventArgs e)
        {
            RollgangUnit rollgang = _configuration.FindRollgang(rollgangList.Text);
            rollgangUid.Text = rollgang.Uid.ToString();
            rollgangStart.Text = "[" + rollgang.StartPos.PosX + ":" + rollgang.StartPos.PosY + "]";
            rollgangFinish.Text = "[" + rollgang.FinishPos.PosX + ":" + rollgang.FinishPos.PosY + "]";
            rollgangSignalSpeed.Text = rollgang.SignalSpeed.ToString();
            rollgangSpeedValue.Text = rollgang.SpeedValue.ToString("F1");

            // _statusBarMessage = $"Выбран рольганг: [{rollgang.Uid}] {rollgang.Name}";
            // StatusText.Text = _statusBarMessage;
        }

        /// <summary>
        /// Обработка события выбора метки из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelList_SelectedValueChanged(object sender, EventArgs e)
        {
            LabelUnit label = _configuration.FindLabel(labelList.Text);
            labelThread.Text = label.ThreadNumber.ToString();
            labelPos.Text = $"[{label.Position.PosX}:{label.Position.PosY}]";

            // _statusBarMessage = $"Выбрана метка: [{label.Text}]";
            // StatusText.Text = _statusBarMessage;
        }

        /// <summary>
        /// Обработка события выбора сигнала из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignalName_SelectedValueChanged(object sender, EventArgs e)
        {
            SignalUnit signal = _configuration.FindSignal(signalsList.Text);
            signalUid.Text = signal.Uid.ToString();
            switch (signal.CompoundSignal)
            {
                case CompoundSignalType.SIMPLE_SIGNAL :
                    signalType.Text = signal.Type.ToString();
                    signalDataBlock.Text = _configuration.FindDataBlock(signal.DataBlockUid).Name;
                    signalTag.Text = signal.ServerName;
                    signalByte.Text = signal.Byte.ToString();
                    signalVirtValue.Text = "";
                    signalCompound.Text = "";
                    signalReadOnly.Checked = true;
                    break;
                case CompoundSignalType.VIRTUAL_SIGNAL :
                    signalType.Text = signal.Type == SignalType.NONE ?  "" : signal.Type.ToString();
                    signalDataBlock.Text = "";
                    signalTag.Text = "";
                    signalByte.Text = "";
                    signalVirtValue.Text = signal.VirtualValue.ToString("F1");
                    signalCompound.Text = signal.CompoundSignal.ToString();
                    signalReadOnly.Checked = !signal.UserWrite;
                    break;
            }

            // _statusBarMessage = $"Выбран сигнал: [{signal.Uid}] {signal.Name}";
            // StatusText.Text = _statusBarMessage;
        }

        /// <summary>
        /// Обработка события изменения выбранного значения блока данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataBlocksList_SelectedValueChanged(object sender, EventArgs e)
        {
            DataBlockUnit dataBlock = _configuration.FindDataBlock(dbNamesList.Text);
            dbUid.Text = dataBlock.Uid.ToString();
            dbType.Text = dataBlock.Type.ToString();
            dbSize.Text = dataBlock.DataBlockSize.ToString();
            dbServerName.Text = dataBlock.ServerName;
            dbPort.Text = dataBlock.Port.ToString();
            dbSrcName.Text = dataBlock.SenderHost;
            dbSrcPort.Text = dataBlock.SenderPort.ToString();
            dbReversal.Checked = dataBlock.Reversal;
            dbHasHead.Checked = dataBlock.HasHead;
            dbPath.Text = dataBlock.ServerPath;
            
            // _statusBarMessage = $"Выбран блок данных: [{dataBlock.Uid}] {dataBlock.Name}";
            // StatusText.Text = _statusBarMessage;
            
            UpdateSignalsView();
        }

        /// <summary>
        /// Изменение состояния переключателя между виритуальными и реальными сигналами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignalVirtual_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSignalsView();
        }

        /// <summary>
        /// Обработка события выбора пункта меню "Добавить блок данных"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDataBlock_Click(object sender, EventArgs e)
        {
            AddDataBlock addDataBlock = new AddDataBlock();
            addDataBlock.ShowDialog();
            if (addDataBlock.Result == DialogResult.OK)
            {
                DataBlockUnit dataBlock = addDataBlock.DataBlock;
                _configuration.ListDataBlockUnits.Add(dataBlock);
                
                UpdateDataBlocksList();
                string msg = $"Добавлен блок данных [{dataBlock.Name}]";
                ShowStatusText(msg);
                _logger.Info(msg);
                Modified = true;
            }

            addDataBlock.Dispose();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку Редактировать блок данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditDataBlock_Click(object sender, EventArgs e)
        {
            DataBlockUnit dBlock = _configuration.FindDataBlock(int.Parse(dbUid.Text));
            if (dBlock != null)
            {
                AddDataBlock editDataBlock = new AddDataBlock();
                editDataBlock.DataBlock = dBlock;
                editDataBlock.EditDataBlock();
                if (editDataBlock.Result == DialogResult.OK)
                {
                    Modified = true;
                    DataBlockUnit db = editDataBlock.DataBlock;
                    _configuration.ReplaceDataBlockUnit(db);

                    string msg = $"Изменены параметры блока данных [{dBlock.Uid}] {dBlock.Name}";
                    ShowStatusText(msg);
                    _logger.Info(msg);
                }
                
                editDataBlock.Dispose();
                UpdateDataBlocksList();
            }
        }
        
        /// <summary>
        /// Обработка события нажатия на кнопку Удалить блок данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteDataBlock_Click(object sender, EventArgs e)
        {
            DataBlockUnit dataBlock = _configuration.FindDataBlock(int.Parse(dbUid.Text));
            if (dataBlock != null)
            {
                DialogResult result = MessageBox.Show($"Блок данных [{dataBlock.Uid}] - {dataBlock.Name} будет удален!\nУверены?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int resDelete = _configuration.DeleteDataBlock(dataBlock.Uid);
                    string msg;
                    if (resDelete == 0)
                    {
                        msg = $"Удален блок данных [{dataBlock.Uid}] - {dataBlock.Name}";
                        _logger.Info(msg);
                        ShowStatusText(msg);
                        UpdateDataBlocksList();
                    }
                    else
                    {
                        if (resDelete == -1)
                        {
                            msg = $"Ошибка при удалении блока данных [{dataBlock.Name}] - Блок данных не найден";
                            _logger.Info(msg);
                            ShowStatusText(msg);
                        }
                        else
                        {
                            msg = $"Ошибка при удалении блока данных [{dataBlock.Name}] - Привязано сигналов: {resDelete}";
                            _logger.Info(msg);
                            ShowStatusText(msg);
                        }

                        MessageBox.Show(msg, "Ошибка!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Обработка события выбора пункта меню "Добавить сигнал"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSignal_Click(object sender, EventArgs e)
        {
            AddSignal addSignal = new AddSignal(signalVirtual.Checked, dbNamesList.Text, GetDataBlocksList());
            
            addSignal.ShowDialog();
            if (addSignal.Result == DialogResult.OK)
            {
                SignalUnit signal = addSignal.Signal;
                _configuration.ListSignalUnits.Add(signal);
                _configuration.FillProductionThreads();
                
                UpdateDataBlocksList();
                string msg = $"Добавлен сигнал [{signal.Name}]";
                ShowStatusText(msg);
                _logger.Info(msg);
                Modified = true;
            }

            addSignal.Dispose();
            Modified = true;
        }

        /// <summary>
        /// Обработка события нажатия кнопки Редактировать сигнал
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditSignal_Click(object sender, EventArgs e)
        {
            SignalUnit signal = _configuration.FindSignal(int.Parse(signalUid.Text));
            if (signal != null)
            {
                AddSignal editSignal = new AddSignal(signalVirtual.Checked, dbNamesList.Text, GetDataBlocksList());
                editSignal.EditSignal(signal);
                
                editSignal.Dispose();
                UpdateSignalsView();
            }
        }
        
        /// <summary>
        /// Удалить выделенный сигнал
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSignal_Click(object sender, EventArgs e)
        {
            SignalUnit signal = _configuration.FindSignal(int.Parse(signalUid.Text));
            if (signal != null)
            {
                DialogResult result = MessageBox.Show($"Сигнал [{signal.Uid}] - {signal.Name} будет удален!\nУверены?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (_configuration.DeleteSignal(signal.Uid))
                    {
                        string msg = $"Удален cигнал [{signal.Uid}] - {signal.Name}";
                        _logger.Info(msg);
                        ShowStatusText(msg);
                        UpdateSignalsView();
                    }
                    else
                    {
                        string msg = $"Ошибка при удалении cигнала [{signal.Uid}] - {signal.Name}";
                        _logger.Info(msg);
                        ShowStatusText(msg);
                    }
                }
            }
        }
        
        /// <summary>
        /// Получить список блоков данных
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> GetDataBlocksList()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (DataBlockUnit dataBlockUnit in _configuration.ListDataBlockUnits)
            {
                result.Add(dataBlockUnit.Uid, dataBlockUnit.Name);
            }

            return result;
        }

        // <summary>
        // Получить тип блока данных по его наименованию
        // </summary>
        // <param name="type"></param>
        // <returns></returns>
        // private DataBlockType GetDBType(string type)
        // {
        //     DataBlockType result;
        //     switch (type)
        //     {
        //         case "TIMESET" :
        //             result = DataBlockType.TIMESET;
        //             break;
        //         case "TCP_SERVER" :
        //             result = DataBlockType.TCP_SERVER;
        //             break;
        //         case "TCP_CLIENT" :
        //             result = DataBlockType.TCP_CLIENT;
        //             break;
        //         case "OPC" :
        //             result = DataBlockType.OPC;
        //             break;
        //         case "UDP" :
        //             result = DataBlockType.UDP;
        //             break;
        //         default: result = DataBlockType.TIMESET;
        //             break;
        //     }
        //
        //     return result;
        // }

        /// <summary>
        /// Обработка события выбора пункта меню "Добавить параметр ЕУ"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIngotParam_Click(object sender, EventArgs e)
        {

        }



        #endregion

        #region Обработка меню Визуализации

        /// <summary>
        /// Обработка нажатия на кнопку Редактировать выбранный рольганг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollgangEdit_Click(object sender, EventArgs e)
        {
            _logger.Info("Щелчек по кнопке Редактировать рольганг");
        }

        /// <summary>
        /// Обработка нажатия на кнопку Удалить выбранный рольганг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollgangDelete_Click(object sender, EventArgs e)
        {
            _logger.Info("Щелчек по кнопке Удалить рольганг");
        }
        
        #endregion

        /// <summary>
        /// Вывести сообщение в строке состояния
        /// </summary>
        /// <param name="message"></param>
        private void ShowStatusText(string message)
        {
            StatusText.Text = message;
        }
    }
}
