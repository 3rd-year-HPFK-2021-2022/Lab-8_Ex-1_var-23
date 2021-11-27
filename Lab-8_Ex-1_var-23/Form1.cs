#nullable enable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Lab_8_Ex_1_var_23
{
    public class Values
    {
        private string _name;
        private double _rate;

        public Values(string name, double rate)
        {
            _name = name;
            _rate = rate;
        }
    }

    public partial class Form1 : Form
    {
        private Dictionary<string, Values> Exchange = new Dictionary<string, Values>();
        private bool isReadyToCalculate = false;
        public Form1()
        {
            InitializeComponent();
            const string UrlString = "https://bank.gov.ua/NBUStatService/v1/statdirectory/exchangenew";
            const string file = "exchanger.xml";
            

            var reader = new XmlTextReader(UrlString);
            if (reader.HasValue)
            {
                StreamWriter sw = new StreamWriter(file);
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            sw.Write("<" + reader.Name);
                            while (reader.MoveToNextAttribute())
                                sw.Write(" " + reader.Name + "='" + reader.Value + "-");
                            //sw.Write(">");
                            sw.Write(">");
                            break;
                        case XmlNodeType.Text:
                            sw.Write(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            sw.Write("</" + reader.Name);
                            sw.Write(">");
                            break;
                    }
                }

                sw.Close();
            }


            var xmlDocument = new XmlDocument();
            xmlDocument.Load(file);
            var xRoot = xmlDocument.DocumentElement;
            if (xRoot != null)
            {
                string cc = "null", txt = "null";
                double rate = 0;
                foreach (XmlElement xNode in xRoot)
                {
                    foreach (XmlNode childNode in xNode.ChildNodes)
                    {
                        if (childNode.Name == "cc") cc = childNode.InnerText;
                        else if (childNode.Name == "txt") txt = childNode.InnerText;
                        else if (childNode.Name == "rate") 
                            rate = double.Parse(childNode.InnerText, NumberStyles.Any, CultureInfo.InvariantCulture);
                    }
                    //MessageBox.Show($"cc: {cc} \ttxt: {txt} \trate: {rate}");
                    if (txt != null && cc != null) Exchange?.Add(cc, new Values(txt, rate));
                    var comboboxItem = cc/* + ' ' + txt*/;
                    ValueCC1.Items.Add(comboboxItem!);
                    ValueCC2.Items.Add(comboboxItem!);
                }
            }

            ValueCC1.Size = ValueCC2.Size = Value1_text.Size = Value2_text.Size = new Size(130, 40);
            Value1_text.Enabled = Value2_text.Enabled = ReplaceButton.Enabled = false;
        }
        
        private void KeyPress(object sender, KeyPressEventArgs e, Control textBox)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar is ',' or '.' || e.KeyChar == 8)
            {
                if (e.KeyChar == '.') e.KeyChar = ',';
                if ((textBox.Text.Length <= 0 && e.KeyChar == ',') || textBox.Text.Contains(",") && e.KeyChar == ',') e.Handled = true;
                 else e.Handled = false;
            }
            else e.Handled = true;
        }

        private void Value1_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(sender, e, Value1_text);
        }


        private void Value2_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(sender, e, Value2_text);
        }

        private void SelectedIndexChanged(ComboBox comboBox,TextBox textBox)
        {
            if (comboBox.SelectedIndex != -1) textBox.Enabled = true;
            if (Value2_text.Enabled && Value2_text.Enabled)
            {
                ReplaceButton.Enabled = isReadyToCalculate = true;
            }
        }
        private void ValueCC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(ValueCC1, Value1_text);
        }

        private void ValueCC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(ValueCC2, Value2_text);
        }
    }
}