using System;
using System.Drawing;
using System.Windows.Forms;
using ConfigParser;
using ConfigParser.ConfigurationUnits;
using Point = System.Drawing.Point;

namespace ConfigGenerator.Forms
{
    public partial class ConfigPreview : Form
    {
        private Graphics _canvas;
        private Parser _config;
        
        public ConfigPreview()
        {
            InitializeComponent();
            _canvas = pictureBox1.CreateGraphics();

            this.ResizeEnd += Form2_ResizeEnd;
            this.MaximumSizeChanged += Form2_ResizeEnd;
        }

        /// <summary>
        /// Просмотр конфигурации
        /// </summary>
        /// <param name="config">Конфигурация</param>
        public void ViewConfig(Parser config)
        {
            _config = config;
        }
        
        private void Form2_ResizeEnd(Object sender, EventArgs e)
        {
            string html = "<!DOCTYPE html> <html lang=\"en\"> <head> <meta charset=\"UTF-8\"> <title>АРМ Руководителя</title> " +
                "</head> <body> <h1>Заголовок</h1> </body> </html>";
            // string html = File.ReadAllText(@"c:\mts\index.html");
            // string uri = "http://aemz.ru/";
            // string uri = @"file://c:/mts/index.html";
            webBrowser1.DocumentText = html;
            // webBrowser1.Navigate(uri);

            if (webBrowser1.Document != null)
            {
                HtmlElement tableRow = null;
                HtmlElement headerElem = null;

                HtmlDocument doc = webBrowser1.Document;
                HtmlElement tableElem = doc.CreateElement("TABLE");
                

                HtmlElement tableHeader = doc.CreateElement("THEAD");
                tableElem.AppendChild(tableHeader);
                tableRow = doc.CreateElement("TR");
                tableHeader.AppendChild(tableRow);

                foreach (ThreadUnit col in _config.ListThreadUnits)
                {
                    headerElem = doc.CreateElement("TH");
                    headerElem.InnerText = col.Name;
                    tableRow.AppendChild(headerElem);
                }

                // Create table rows.
                HtmlElement tableBody = doc.CreateElement("TBODY");
                tableElem.AppendChild(tableBody);
                foreach (ThreadUnit thread in _config.ListThreadUnits)
                {
                    tableRow = doc.CreateElement("TR");
                    tableBody.AppendChild(tableRow);
                    foreach (SensorUnit sensor in _config.ListSensorUnits)
                    {
                        if(sensor.ThreadNumber == thread.ThreadNumber)
                        {
                            HtmlElement tableCell = doc.CreateElement("TD");
                            tableCell.InnerText = sensor.Name;
                            tableRow.AppendChild(tableCell);
                        }
                    }
                }
                doc.Body.AppendChild(tableElem);
            }
            // MessageBox.Show("You are in the Form.ResizeEnd event.");
        }
        
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            _canvas.FillRectangle(Brushes.Azure, 0, 0, pictureBox1.Width, pictureBox1.Height);
            for (int i = 20; i < pictureBox1.Width; i += 100)
            {
                _canvas.DrawLine(new Pen(Brushes.Aquamarine, 1), new Point(i,20), new Point(i,pictureBox1.Height));
            }
            for (int i = 20; i < pictureBox1.Height; i += 100)
            {
                _canvas.DrawLine(new Pen(Brushes.Aquamarine, 1), new Point(20,i), new Point(pictureBox1.Width,i));
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            _canvas.FillRectangle(Brushes.Azure, 0, 0, pictureBox1.Width, pictureBox1.Height);
            for (int i = 20; i < pictureBox1.Width; i += 100)
            {
                _canvas.DrawLine(new Pen(Brushes.Aquamarine, 1), new Point(i,20), new Point(i,pictureBox1.Height));
            }
            for (int i = 20; i < pictureBox1.Height; i += 100)
            {
                _canvas.DrawLine(new Pen(Brushes.Aquamarine, 1), new Point(20,i), new Point(pictureBox1.Width,i));
            }        }
    }
}