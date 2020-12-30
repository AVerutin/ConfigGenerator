using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConfigParser.ConfigurationUnits;

namespace ConfigGenerator.Forms
{
    public partial class AddSignal : Form
    {
        private SignalUnit _signal;
        public DialogResult Result = DialogResult.None;
        
        public AddSignal()
        {
            InitializeComponent();
            _signal = new SignalUnit();
        }

        /// <summary>
        /// Создать новый сигнал
        /// </summary>
        /// <param name="dataBlocks">Список блоков данных</param>
        /// <returns>Созданный сигнал</returns>
        public SignalUnit CreateSignal(Dictionary<int, string> dataBlocks)
        {
            
            ShowDialog();
            return _signal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signal">Сигнал для редактирования</param>
        /// <param name="dataBlocks">Список блоков данных</param>
        /// <returns>Отредактированный сигнал</returns>
        public SignalUnit EditSignal(SignalUnit signal, Dictionary<int, string> dataBlocks)
        {

            ShowDialog();
            return _signal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
        }
    }
}

// Uid	Идентификатор
// Name	Имя
// ServerName	ИмяСервер
// Type	Тип
// DataBlockUid	ИдентификаторБлокаДанных
// Byte	Байт
// Bit	Бит
// VirtualValue	ЗначениеВиртуальногоСигнала
// CompoundSignal	СоставнойСигнал
// UserWrite	ЗаписьКлиентами
// MinAnalogLevel	МинимальныйУровеньАналоговогоСигнала
