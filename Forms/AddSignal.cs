using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConfigParser.ConfigurationUnits;
using ConfigParser.Types;

namespace ConfigGenerator.Forms
{
    public partial class AddSignal : Form
    {
        public SignalUnit Signal;
        private readonly string _dataBlockName;
        private readonly Dictionary<int, string> _dataBlockList;
        private bool _virtualOnly;
        public DialogResult Result = DialogResult.None;
        
        public AddSignal(bool virtualOnly, string dbName, Dictionary<int,string> dbList)
        {
            InitializeComponent();
            checkVirtual.CheckedChanged += checkVirtual_CheckedChanged;
            Signal = new SignalUnit();
            
            _virtualOnly = virtualOnly;
            _dataBlockName = dbName;
            _dataBlockList = dbList;
            comboType.SelectedIndex = 0;

            Initialize();
        }

        /// <summary>
        /// Установка значений элементов формы
        /// </summary>
        private void Initialize()
        {
            checkVirtual.Checked = _virtualOnly;
            cbUserWrite.Enabled = false;
            textVirtualValue.Enabled = false;

            if (_dataBlockList != null)
            {
                List<string> dataBlocks = _dataBlockList.Values.ToList();
                comboDataBlock.Items.Clear();
                foreach (string item in dataBlocks)
                {
                    if(item == _dataBlockName)
                        comboDataBlock.Items.Add(item);
                }

                comboDataBlock.SelectedIndex = 0;
            }

            comboDataBlock.Enabled = false;
        }

        private void checkVirtual_CheckedChanged(object sender, EventArgs e)
        {
            _virtualOnly = checkVirtual.Checked;
            
            // Для виртуальных сигналов
            cbUserWrite.Enabled = !_virtualOnly;
            textVirtualValue.Enabled = !_virtualOnly;

            textByte.Enabled = _virtualOnly;
            textBit.Enabled = _virtualOnly;
            textAnalogLevel.Enabled = _virtualOnly;
            textServerName.Enabled = _virtualOnly;

            // Для реальных сигналов
            textByte.Enabled = !_virtualOnly;
            textBit.Enabled = !_virtualOnly;
            textAnalogLevel.Enabled = !_virtualOnly;
            textServerName.Enabled = !_virtualOnly;

            cbUserWrite.Enabled = _virtualOnly;
            textVirtualValue.Enabled = _virtualOnly;
        }

        /// <summary>
        /// Редактирование параметров сигнала
        /// </summary>
        /// <param name="signal">Сигнал</param>
        public void EditSignal(SignalUnit signal)
        {
            if (signal != null)
            {
                Signal = signal;
                
                // Вывод списка блоков данных
                if (_dataBlockList != null)
                {
                    List<string> dataBlocks = _dataBlockList.Values.ToList();
                    comboDataBlock.Items.Clear();
                    foreach (string item in dataBlocks)
                    {
                        if(item == _dataBlockName)
                            comboDataBlock.Items.Add(item);
                    }

                    comboDataBlock.SelectedIndex = 0;
                }

                comboDataBlock.Enabled = false;
                checkVirtual.Enabled = !_virtualOnly;

                comboType.Text = signal.Type.ToString();
                textUid.Text = signal.Uid.ToString();
                textName.Text = signal.Name;
                cbUserWrite.Checked = signal.UserWrite;
                textVirtualValue.Text = signal.VirtualValue.ToString("F1");
                textByte.Text = signal.Byte.ToString();
                textBit.Text = signal.Bit.ToString();
                textAnalogLevel.Text = signal.MinAnalogLevel.ToString();
                textServerName.Text = signal.ServerName;
            }

            ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Signal.Uid = int.Parse(textUid.Text == "" ? "0" : textUid.Text);
            Signal.Name = textName.Text ?? "";
            Signal.Type = GetDataType(comboType.Text);
            Signal.UserWrite = cbUserWrite.Checked;
            Signal.VirtualValue =
                double.Parse(textVirtualValue.Text == "" ? "0,0" : textVirtualValue.Text.Replace(".", ","));
            Signal.CompoundSignal =
                checkVirtual.Checked ? CompoundSignalType.VIRTUAL_SIGNAL : CompoundSignalType.SIMPLE_SIGNAL;
            Signal.DataBlockUid = GetDataBlockUid(comboDataBlock.Text);
            Signal.Byte = int.Parse(textByte.Text == "" ? "0" : textByte.Text);
            Signal.Bit = int.Parse(textBit.Text == "" ? "0" : textBit.Text);
            Signal.MinAnalogLevel = int.Parse(textAnalogLevel.Text == "" ? "0" : textAnalogLevel.Text);
            Signal.ServerName = textServerName.Text;
            
            Result = DialogResult.OK;
        }

        /// <summary>
        /// Обработка события нажатия на кнопку Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
        }

        /// <summary>
        /// Получить идентификатор блока данных по его имени
        /// </summary>
        /// <param name="dbName">Имя блока данных</param>
        /// <returns>Идентификатор блока данных</returns>
        private int GetDataBlockUid(string dbName)
        {
            int result = 0;
            if (_dataBlockList != null)
            {
                foreach (KeyValuePair<int,string> dBlock in _dataBlockList)
                {
                    if (dBlock.Value == dbName)
                    {
                        result = dBlock.Key;
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Получить тип данных по его наименованию
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private SignalType GetDataType(string type)
        {
            SignalType result;
            switch (type)
            {
                case "INT":
                    result = SignalType.INT;
                    break;
                 case "BINARY":
                     result = SignalType.BINARY;
                     break;
                 case "BOOL":
                     result = SignalType.BOOL;
                     break;
                 case "BYTE":
                     result = SignalType.BYTE;
                     break;
                 case "DINT":
                     result = SignalType.DINT;
                     break;
                 case "DWORD":
                     result = SignalType.DWORD;
                     break;
                 case "DWORDOM":
                     result = SignalType.DWORDOM;
                     break;
                case "REAL":
                    result = SignalType.REAL;
                    break;
                case "REALOM":
                    result = SignalType.REALOM;
                    break;
                case "WORD":
                    result = SignalType.WORD;
                    break;
                default:
                    result = SignalType.NONE;
                    break;
            }

            return result;
        }
    }
}

